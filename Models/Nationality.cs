using System.ComponentModel.DataAnnotations;

namespace MoviesProject.Models
{
    public class Nationality
    {
        public int NationalityId { get; set; }
        [Required]
        public string NationalityName { get;set; }
        public Dirictor Dirictor { get; set; }
    }
}
