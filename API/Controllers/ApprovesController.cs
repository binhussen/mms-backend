using AutoMapper;
using Contracts.Interfaces;
using Contracts.Service;
using DataModel.Models.DTOs.Distribute;
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
    }
}
