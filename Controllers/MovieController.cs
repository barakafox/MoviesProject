using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.RepoPattern.MovieRepo;

namespace MoviesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IRepoMovie _repo;
        public MovieController(IRepoMovie repo)
        {
            _repo = repo;
        }
        [HttpPost("AddMoiveWithReletedData")]
        public IActionResult AddMoiveWithReletedData(AddMovieWithReletadData dto)
        {
            try
            {
                _repo.AddMovieWithReletdData(dto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllData")]
        public IActionResult GetAllData()
        {
            var res = _repo.GetAllData();
            return Ok(res);
        }

        [HttpGet("GetAllDataById")]
        public IActionResult GetAllDataById(int id)
        {
            var res = _repo.GetData(id);
            return Ok(res);
        }
    }
}
