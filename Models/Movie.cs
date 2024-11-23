using System.ComponentModel.DataAnnotations;

namespace MoviesProject.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        public DateTime MovieReleaserYeer { get; set; }
        public ICollection<Dirictor> Dirictors { get; set; }
        public Category Category { get; set; }
    }
}
