using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using zacars.Data;
using zacars.Models;

namespace zacars.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private VehiclesProjectDbContext _dbContext;
        public CategoriesController(VehiclesProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Categories);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category categoryModel)
        {
            var category = new Category()
            {
                Type = categoryModel.Type,
            };
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }

}
