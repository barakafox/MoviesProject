using System.ComponentModel.DataAnnotations;

namespace MoviesProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public ICollection<Movie> movies { get; set; }

    }
}
