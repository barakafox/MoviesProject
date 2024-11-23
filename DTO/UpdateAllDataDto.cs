using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO
{
    public class UpdateAllDataDto
    {
        [Required]
        public string DirictorName { get; set; }
        [Phone]
        public string DirictorContact { get; set; }
        [EmailAddress]
        public string DirictorrEmail { get; set; }
        public NationalityDto Nationality { get; set; }
        public List<MovieDto> Movies { get; set; }
        public CategoryDto categoryDtos { get; set; }

    }
}
