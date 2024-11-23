using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO
{
    public class MovieDto
    {
        [Required]
        public string MovieTitle { get; set; }
        public DateTime MovieReleaserYeer { get; set; }
    }
}
