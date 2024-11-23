using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.RepoPattern.MovieRepo;
using MoviesProject.RepoPattern.NationalityRepo;

namespace MoviesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly IRepoNationality _repo;
        public NationalityController(IRepoNationality repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult AddNationality(NationalityDto dto)
        {
            try
            {
                _repo.AddNationality(dto); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteNationality(int id)
        {
            try
            {
                _repo.DeleteNationality(id);
            }
            catch (Exception ex)
            {
                return NotFound("Not Found Nationality");
            }
            return Ok();


        }
    }
}
