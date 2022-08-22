using AutoMapper;
using Contracts.Interfaces;
using Contracts.Service;
using DataModel.Models.DTOs.Distribute;
using DataModel.Models.DTOs.Requests;
using DataModel.Models.DTOs.Stores;
using DataModel.Models.Entities;
using DataModel.Parameters;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api")]
    [ApiController]
    public class RequestItemsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public RequestItemsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet("requestheaders/{headerid}/items")]
        public async Task<IActionResult> GetRequestItemsForRequestHeader(int headerid, [FromQuery] RequestItemParameters requestItemParameters)
        {


            var requestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(headerid, trackChanges: false);
            if (requestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {headerid} doesn't exist in the database.");
                return NotFound();
            }

            var requestItemsFromDb = await _repository.RequestItem.GetRequestItemsAsync(headerid, requestItemParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(requestItemsFromDb.MetaData));
            var requestItemsDto = _mapper.Map<IEnumerable<RequestItemDto>>(requestItemsFromDb);
            return Ok(requestItemsDto);
        }

        [HttpGet("requestheaders/{headerid}/items/{id}", Name = "GetRequestItemForRequestHeader")]
        public async Task<IActionResult> GetRequestItemForRequestHeader(int headerid, int id)
        {
            var requestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(headerid, trackChanges: false);
            if (requestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {headerid} doesn't exist in the database.");
                return NotFound();
            }

            var requestItemDb = await _repository.RequestItem.GetRequestItemAsync(headerid, id, trackChanges: false);
            if (requestItemDb == null)
            {
                _logger.LogInfo($"RequestItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var requestItem = _mapper.Map<RequestItemDto>(requestItemDb);

            return Ok(requestItem);
        }
        [HttpPost("requestheaders/{headerid}/items")]
        public async Task<IActionResult> CreateRequestItemForRequestHeader(int headerid, [FromBody] RequestItemForCreationDto requestItem)
        {
            if (requestItem == null)
            {
                _logger.LogError("RequestItemForCreationDto object sent from client is null.");
                return BadRequest("RequestItemForCreationDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the RequestItemForCreationDto object");
                return UnprocessableEntity(ModelState);
            }
            var requestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(headerid, trackChanges: false);
            if (requestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {headerid} doesn't exist in the database.");
                return NotFound();
            }
            //check in store
            var storeItems = await _repository.StoreItem.GetAllStoreItems( trackChanges: false);
            var groupstoreItems = _mapper.Map<IEnumerable<StoreItemDto>>(storeItems)
                                .GroupBy(m => m.model)
                               .Select(g => new
                               {
                                   ItemType = g.Select(x => x.type).FirstOrDefault(),
                                   model = g.Key,
                                   availablequantity = g.Sum(x => x.availableQuantity),
                                   approvedequantity = g.Sum(x => x.approvedQuantity)
                               }).ToList();
            foreach (var item in groupstoreItems)
            {
                if(item.model == requestItem.model)
                {
                    if (item.availablequantity >= requestItem.requestedQuantity)
                    {
                        var requestItemEntity = _mapper.Map<RequestItem>(requestItem);
                        _repository.RequestItem.CreateRequestItemForRequestHeader(headerid, requestItemEntity);
                        await _repository.SaveAsync();
                        var requestItemToReturn = _mapper.Map<RequestItemDto>(requestItemEntity);
                        return CreatedAtRoute("GetRequestItemForRequestHeader", new { headerid, id = requestItemToReturn.id }, requestItemToReturn);
                    }
                    else
                    {
                        _logger.LogInfo("Requested Quantity is not Available in Store");
                        return NotFound("Requested Quantity is not Available in Store");
                    }
                }
            }
            _logger.LogInfo("Requested Model is not Available in Store");
            return NotFound("Requested Model is not Available in Store");
        }

        [HttpPut("requestheaders/{headerid}/items/{id}")]
        public async Task<IActionResult> UpdateRequestItemForRequestHeader(int headerid, int id, [FromBody] RequestItemForUpdateDto requestItem)
        {
            if (requestItem == null)
            {
                _logger.LogError("RequestItemForUpdateDto object sent from client is null.");
                return BadRequest("RequestItemForUpdateDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the RequestItemForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }

            var requestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(headerid, trackChanges: false);
            if (requestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {headerid} doesn't exist in the database.");
                return NotFound();
            }
            var requestItemEntity = await _repository.RequestItem.GetRequestItemAsync(headerid, id, trackChanges: true);
            if (requestItemEntity == null)
            {
                _logger.LogInfo($"RequestItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(requestItem, requestItemEntity);
            await _repository.SaveAsync();

            return NoContent();

        }

        [HttpDelete("requestheaders/{headerid}/items/{id}")]
        public async Task<IActionResult> DeleteRequestHeader(int headerid, int id)
        {
            var requestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(headerid, trackChanges: false);
            if (requestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {headerid} doesn't exist in the database.");
                return NotFound();
            }

            var requestItemForRequestHeader = await _repository.RequestItem.GetRequestItemAsync(headerid, id, trackChanges: false);
            if (requestItemForRequestHeader == null)
            {
                _logger.LogInfo($"RequestItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.RequestItem.DeleteRequestItem(requestItemForRequestHeader);
            await _repository.SaveAsync();

            return NoContent();
        }
        [HttpPatch("requestitems/{id}")]
        public async Task<IActionResult> PartiallyUpdateRequestItemForRequestHeader(int id, [FromBody] JsonPatchDocument<RequestItemForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }
            var requestItemEntity = await _repository.RequestItem.GetRequestAsync(id, trackChanges: true);
            if (requestItemEntity == null)
            {
                _logger.LogInfo($"RequestItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var requestItemToPatch = _mapper.Map<RequestItemForUpdateDto>(requestItemEntity);

            patchDoc.ApplyTo(requestItemToPatch, ModelState);

            TryValidateModel(requestItemToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(requestItemToPatch, requestItemEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost]
        [Route("requestapprove/{id}")]
        public async Task<IActionResult> RequestApproval(int id, int qty, string status, string? attachments)
        {
            var requestItemEntity = await _repository.RequestItem.GetRequestAsync(id, trackChanges: true);
            if (status == "Reject" | qty <= 0)
            {
                var requestDto = new RequestItemStatus()
                {
                    status = "Reject",
                    attachments = attachments
                };
                _mapper.Map(requestDto, requestItemEntity);
                _logger.LogInfo($"StatusMessage : Request with {id} has been Rejected");
            }
            else if (status == "Distribute")
            {
                //find by quantity
                var result = await _repository.StoreItem.GetStoreByQtyAsync(false);
                if (result != null)
                {
                    var sum = 0;
                    var remainToStore = 0;
                    List<int> itemsId = new List<int>();
                    foreach (var item in result)
                    {
                        itemsId.Add(item.id);
                        sum += item.availableQuantity;
                        if (sum >= qty)
                        {
                            remainToStore = sum - qty;
                            break;
                        }
                    }
                    int[] items = itemsId.ToArray();
                    var last = items.LastOrDefault();
                    foreach (var item in items)
                    {
                        var storeItem = await _repository.StoreItem.GetStoreByIdAsync(item, trackChanges: true);
                        var storeDto = new StoreItemAvailableQuantity();
                        var distributeDto = new DistributeForCreationDto();
                        if (item.Equals(last))
                        {
                            distributeDto = new DistributeForCreationDto()
                            {
                                approvedQuantity = storeItem.availableQuantity - remainToStore,
                                storeItemId = storeItem.id,
                                requestId = id
                            };
                            //update store status
                            storeDto = new StoreItemAvailableQuantity()
                            {
                                availableQuantity = remainToStore,
                                availability = remainToStore == 0 ? false : true
                            };
                        }
                        else
                        {
                            distributeDto = new DistributeForCreationDto()
                            {
                                approvedQuantity = storeItem.availableQuantity,
                                storeItemId = storeItem.id,
                                requestId = id
                            };
                            //update store status
                            storeDto = new StoreItemAvailableQuantity()
                            {
                                availableQuantity = 0,
                                availability = false
                            };
                        }
                        var distributeItem = _mapper.Map<Distribute>(distributeDto);
                        _repository.Distribute.CreateDistribute(distributeItem);

                        _mapper.Map(storeDto, storeItem);

                    }
                    //update request item status & distributed Quantity
                    var requestDto = new RequestItemStatus()
                    {
                        status = "Distribute",
                        approvedQuantity = qty,
                        attachments = attachments
                    };
                    _mapper.Map(requestDto, requestItemEntity);
                    _logger.LogInfo($"StatusMessage : {id} has been Distributed");
                }
            }
            await _repository.SaveAsync();
            return Ok();
        }
        /*[HttpPost]
       [Route("requestdistribute/{id}")]
       public async Task<IActionResult> RequestApproval(int id, int qty, string status, string? attachments)
       {
           var requestItemEntity = await _repository.RequestItem.GetRequestAsync(id, trackChanges: true);
           if (status == "Reject" | qty <= 0)
           {
               var requestDto = new RequestItemStatus()
               {
                   status = "Reject",
                   attachments = attachments
               };
               _mapper.Map(requestDto, requestItemEntity);
               _logger.LogInfo($"StatusMessage : Request with {id} has been Rejected");
           }
           else if (status == "Distribute")
           {
               //find by quantity
               var result = await _repository.StoreItem.GetStoreByQtyAsync(false);
               if (result != null)
               {
                   var sum = 0;
                   var remainToStore = 0;
                   List<int> itemsId = new List<int>();
                   foreach (var item in result)
                   {
                       itemsId.Add(item.id);
                       sum += item.availableQuantity;
                       if (sum >= qty)
                       {
                           remainToStore = sum - qty;
                           break;
                       }
                   }
                   int[] items = itemsId.ToArray();
                   var last = items.LastOrDefault();
                   foreach (var item in items)
                   {
                       var storeItem = await _repository.StoreItem.GetStoreByIdAsync(item, trackChanges: true);
                       var storeDto = new StoreItemAvailableQuantity();
                       var distributeDto = new DistributeForCreationDto();
                       if (item.Equals(last))
                       {
                           distributeDto = new DistributeForCreationDto()
                           {
                               approvedQuantity = storeItem.availableQuantity - remainToStore,
                               storeItemId = storeItem.id,
                               requestId = id
                           };
                           //update store status
                           storeDto = new StoreItemAvailableQuantity()
                           {
                               availableQuantity = remainToStore,
                               availability = remainToStore == 0 ? false : true
                           };
                       }
                       else
                       {
                           distributeDto = new DistributeForCreationDto()
                           {
                               approvedQuantity = storeItem.availableQuantity,
                               storeItemId = storeItem.id,
                               requestId = id
                           };
                           //update store status
                           storeDto = new StoreItemAvailableQuantity()
                           {
                               availableQuantity = 0,
                               availability = false
                           };
                       }
                       var distributeItem = _mapper.Map<Distribute>(distributeDto);
                       _repository.Distribute.CreateDistribute(distributeItem);

                       _mapper.Map(storeDto, storeItem);

                   }
                   //update request item status & distributed Quantity
                   var requestDto = new RequestItemStatus()
                   {
                       status = "Distribute",
                       approvedQuantity = qty,
                       attachments = attachments
                   };
                   _mapper.Map(requestDto, requestItemEntity);
                   _logger.LogInfo($"StatusMessage : {id} has been Distributed");
               }
           }
           await _repository.SaveAsync();
           return Ok();
       }*/
    }
}
