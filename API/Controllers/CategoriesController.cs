using AutoMapper;
using Contracts.Interfaces;
using Contracts.Service;
using DataModel.Models.DTOs.Categories;
using DataModel.Models.Entities;
using DataModel.Parameters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CategoriesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet(Name = "GetCategories")]
        public async Task<IActionResult> GetCategories([FromQuery] CategoryParameters categoryParameters)
        {
            var categories = await _repository.Category.GetAllCategoriesAsync(categoryParameters, trackChanges: false);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(categories.MetaData));

            var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            return Ok(categoryDtos);
        }
        [HttpGet("{id}", Name = "CategoryById")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _repository.Category.GetCategoryAsync(id, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"Category with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var categoryDto = _mapper.Map<CategoryDto>(category);
                return Ok(categoryDto);
            }
        }
        [HttpPost(Name = "CreateCategory")]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto category)
        {
            if (category == null)
            {
                _logger.LogError("CategoryForCreationDto object sent from client is null.");
                return BadRequest("CategoryForCreationDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CategoryForCreationDto object");
                return UnprocessableEntity(ModelState);
            }

            var categoryEntity = _mapper.Map<Category>(category);

            _repository.Category.CreateCategory(categoryEntity);
            await _repository.SaveAsync();

            var categoryToReturn = _mapper.Map<CategoryDto>(categoryEntity);

            // Disable BCC4002
            return CreatedAtRoute("categoryById", new { id = categoryToReturn.id }, categoryToReturn);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryForUpdateDto category)
        {
            if (category == null)
            {
                _logger.LogError("CategoryForUpdateDto object sent from client is null.");
                return BadRequest("CategoryForUpdateDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CategoryForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var categoryEntity = await _repository.Category.GetCategoryAsync(id, trackChanges: true);
            if (categoryEntity == null)
            {
                _logger.LogInfo($"Category with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(category, categoryEntity);
            await _repository.SaveAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _repository.Category.GetCategoryAsync(id, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"Category with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.Category.DeleteCategory(category);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
