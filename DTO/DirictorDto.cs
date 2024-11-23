using MoviesProject.Models;
using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO
{
    public class DirictorDto
    {
        [Required]
        public string DirictorName { get; set; }
        [Phone]
        public string DirictorContact { get; set; }
        [EmailAddress]
        public string DirictorrEmail { get; set; }
        public NationalityDto Nationality { get; set; }
    }
}
