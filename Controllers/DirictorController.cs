using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.RepoPattern.DirictorRepo;
using MoviesProject.RepoPattern.MovieRepo;

namespace MoviesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirictorController : ControllerBase
    {
        private readonly IRepoDirictor _repo;
        public DirictorController(IRepoDirictor repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult AddDirictor(DirictorDto dto)
        {
            _repo.AddDirictor(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDirictor(UpdateAllDataDto dto , int id)
        {
            _repo.UpdateAllData(dto, id);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDirictor(int id)
        {
            _repo.DeleteDirictor(id);
            return NoContent();
        }
    }
}
