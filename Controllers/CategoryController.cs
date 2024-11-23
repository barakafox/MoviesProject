using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.RepoPattern.CategoryRepo;
using MoviesProject.RepoPattern.MovieRepo;

namespace MoviesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepoCategory _repo;
        public CategoryController(IRepoCategory repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryDto dto)
        {
            _repo.AddCategory(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult EditCategory(CategoryDto dto , int id)
        {
            _repo.UpdateCategory(dto , id);
            return Ok();
        }
    }
}
