using AutoMapper;
using Contracts.Interfaces;
using Contracts.Service;
using DataModel.Models.DTOs.Distribute;
using DataModel.Models.DTOs.Requests;
using DataModel.Models.DTOs.Stores;
using DataModel.Models.Entities;
using DataModel.Parameters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api")]
    [ApiController]
    public class DistributesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public DistributesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet("distributes", Name = "GetAllDistributes")]
        public async Task<IActionResult> GetAllDistributes([FromQuery] DistributeParameters distributeParameters)
        {
            var distributes = await _repository.Distribute.GetAllDistributesAsync(distributeParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(distributes.MetaData));

            var distributeDtos = _mapper.Map<IEnumerable<DistributeDto>>(distributes);
            return Ok(distributeDtos);
        }
        [HttpGet("distribute/{id}", Name = "DistributeById")]
        public async Task<IActionResult> GetDistributeById(int id)
        {
            var distribute = await _repository.Distribute.GetDistributeByIdAsync(id, trackChanges: false);
            if (distribute == null)
            {
                _logger.LogInfo($"Customer with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var distributeDto = _mapper.Map<DistributeDto>(distribute);
                return Ok(distributeDto);
            }
        }
        [HttpGet("distributes/{requestid}", Name = "GetDistributeForRequest")]
        public async Task<IActionResult> GetDistributesForRequest(int requestid, [FromQuery] DistributeParameters distributeParameters)
        {
            var request = await _repository.RequestItem.GetRequestAsync(requestid, trackChanges: false);
            if (request == null)
            {
                _logger.LogInfo($"RequestItem with id: {requestid} doesn't exist in the database.");
                return NotFound();
            }

            var distributesFromDb = await _repository.Distribute.GetAllDistributesAsync(requestid, distributeParameters, trackChanges: false);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(distributesFromDb.MetaData));

            var distributesDto = _mapper.Map<IEnumerable<DistributeDto>>(distributesFromDb);
            return Ok(distributesDto);
        }

        [HttpPost]
        [Route("distribute/{requestid}")]
        public async Task<IActionResult> RequestApproval(int requestid, int qty)
        {
            var requestItemEntity = await _repository.RequestItem.GetRequestAsync(requestid, trackChanges: true);
            if(qty <= 0)
            {

                _logger.LogInfo($"StatusMessage : Request 0 {requestid} can't be distribute");
                return BadRequest($"Request 0 {requestid} can't be distribute");
            }
            else
            {
                //find by model
                var result = await _repository.StoreItem.GetStoreByModelAsync(requestItemEntity.model, false);
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
                                requestId = requestid
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
                                requestId = requestid
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
                    };
                    _mapper.Map(requestDto, requestItemEntity);
                    _logger.LogInfo($"StatusMessage : {requestid} has been Distributed");
                }
            }
            await _repository.SaveAsync();
            return Ok();
        }
    }
}
