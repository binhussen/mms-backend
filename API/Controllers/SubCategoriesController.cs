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
    [Route("api/categories/{categoryid}/models")]
    [ApiController]
    public class SubCategoriesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public SubCategoriesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetSubCategoriesForCategory(int categoryid, [FromQuery] SubCategoryParameters subcategoryParameters)
        {

            var category = await _repository.Category.GetCategoryAsync(categoryid, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"Category with id: {categoryid} doesn't exist in the database.");
                return NotFound();
            }

            var subCategoriesFromDb = await _repository.SubCategory.GetSubCategoriesAsync(categoryid, subcategoryParameters, trackChanges: false);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(subCategoriesFromDb.MetaData));

            var subCategoryDto = _mapper.Map<IEnumerable<SubCategoryDto>>(subCategoriesFromDb);
            return Ok(subCategoryDto);

        }

        [HttpGet("{id}", Name = "GetSubCategoryForCategory")]
        public async Task<IActionResult> GetSubCategoryForCategory(int categoryid, int id)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryid, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"Category with id: {categoryid} doesn't exist in the database.");
                return NotFound();
            }

            var subCategoryDb = await _repository.SubCategory.GetSubCategoryAsync(categoryid, id, trackChanges: false);
            if (subCategoryDb == null)
            {
                _logger.LogInfo($"SubCategory with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var subCategory = _mapper.Map<SubCategoryDto>(subCategoryDb);

            return Ok(subCategory);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubCategoryForCategory(int categoryid, [FromBody] SubCategoryForCreationDto subCategory)
        {
            if (subCategory == null)
            {
                _logger.LogError("SubCategoryForCreationDto object sent from client is null.");
                return BadRequest("SubCategoryForCreationDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the SubCategoryForCreationDto object");
                return UnprocessableEntity(ModelState);
            }
            var category = await _repository.Category.GetCategoryAsync(categoryid, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"Category with id: {categoryid} doesn't exist in the database.");
                return NotFound();
            }

            var subCategoryEntity = _mapper.Map<SubCategory>(subCategory);

            _repository.SubCategory.CreateSubCategoryForCategory(categoryid, subCategoryEntity);
            await _repository.SaveAsync();
            var subCategoryToReturn = _mapper.Map<SubCategoryDto>(subCategoryEntity);
            return CreatedAtRoute("GetSubCategoryForCategory", new { categoryid, id = subCategoryToReturn.id }, subCategoryToReturn);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubCategoryForCategory(int categoryid, int id, [FromBody] SubCategoryForUpdateDto subCategory)
        {
            if (subCategory == null)
            {
                _logger.LogError("SubCategoryForUpdateDto object sent from client is null.");
                return BadRequest("SubCategoryForUpdateDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the SubCategoryForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }

            var category = await _repository.Category.GetCategoryAsync(categoryid, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"Category with id: {categoryid} doesn't exist in the database.");
                return NotFound();
            }
            var subCategoryEntity = await _repository.SubCategory.GetSubCategoryAsync(categoryid, id, trackChanges: true);
            if (subCategoryEntity == null)
            {
                _logger.LogInfo($"SubCategory with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(subCategory, subCategoryEntity);
            await _repository.SaveAsync();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int categoryid, int id)
        {
            var category = await _repository.Category.GetCategoryAsync(categoryid, trackChanges: false);
            if (category == null)
            {
                _logger.LogInfo($"NotifyHeader with id: {categoryid} doesn't exist in the database.");
                return NotFound();
            }

            var subCategoryForCategory = await _repository.SubCategory.GetSubCategoryAsync(categoryid, id, trackChanges: false);
            if (subCategoryForCategory == null)
            {
                _logger.LogInfo($"SubCategory with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.SubCategory.DeleteSubCategory(subCategoryForCategory);
            await _repository.SaveAsync();

            return NoContent();
        }

    }
}
