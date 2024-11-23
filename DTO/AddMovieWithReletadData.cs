using MoviesProject.Models;
using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO
{
    public class AddMovieWithReletadData
    {
        [Required]
        public string MovieTitle { get; set; }
        public DateTime MovieReleaserYeer { get; set; }
        public ICollection<DirictorDto> dirictors { get; set; }
        public CategoryDto category { get; set; }
    }
}
