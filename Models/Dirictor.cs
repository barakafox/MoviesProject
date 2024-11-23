using System.ComponentModel.DataAnnotations;

namespace MoviesProject.Models
{
    public class Dirictor
    {
        public int DirictorId { get; set; }
        [Required]
        public string DirictorName { get; set; }
        [Phone]
        public string DirictorContact { get; set; }
        [EmailAddress]
        public string DirictorrEmail { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
    }
}
