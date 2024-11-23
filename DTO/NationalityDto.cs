using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO
{
    public class NationalityDto
    {
        [Required]
        public string NationalityName { get; set; }
    }
}
