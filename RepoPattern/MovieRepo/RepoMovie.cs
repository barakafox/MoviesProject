using Microsoft.EntityFrameworkCore;
using MoviesProject.DTO;
using MoviesProject.Models;

namespace MoviesProject.RepoPattern.MovieRepo
{
    public class RepoMovie : IRepoMovie
    {
        private readonly appDbContext _Context;
        public RepoMovie(appDbContext context)
        {
            _Context = context;
        }
        public void AddMovieWithReletdData(AddMovieWithReletadData dto)
        {
            var cat = _Context.Categories.FirstOrDefault(x=>x.CategoryName == dto.category.CategoryName);
            if (cat != null)
            {
                throw new Exception("Category Allready Added");
            }
            Movie movie = new Movie
            {
                MovieTitle = dto.MovieTitle,
                MovieReleaserYeer = dto.MovieReleaserYeer,
                Dirictors = dto.dirictors.Select(x=> new Dirictor
                {
                    DirictorName = x.DirictorName,
                    DirictorContact = x.DirictorContact,
                    DirictorrEmail = x.DirictorrEmail,
                    Nationality = new Nationality
                    {
                        NationalityName = x.Nationality.NationalityName,
                    }
                }).ToList(),
                Category = new Category
                {
                    CategoryName = dto.category.CategoryName,
                }
            };
            _Context.Movies.Add(movie);
            _Context.SaveChanges();
        }

        public List<AddMovieWithReletadData> GetAllData()
        {
            var res = _Context.Movies
                .Include(x=> x.Dirictors)
                .ThenInclude(x=>x.Nationality)
                .Include(x=> x.Category)
                .Select(x=> new AddMovieWithReletadData
                {
                    MovieTitle = x.MovieTitle,
                    MovieReleaserYeer = x.MovieReleaserYeer,
                    dirictors = x.Dirictors.Select(x=> new DirictorDto
                    {
                        DirictorName =x.DirictorName,
                        DirictorrEmail = x.DirictorrEmail,
                        DirictorContact = x.DirictorContact,
                        Nationality = new NationalityDto
                        {
                            NationalityName = x.Nationality.NationalityName,
                        }
                    }).ToList(),
                    category = new CategoryDto
                    {
                        CategoryName = x.Category.CategoryName,
                    }
                }).ToList();
            return res;
        }
        public AddMovieWithReletadData GetData(int id)
        {
            var res = _Context.Movies
                .Include(x => x.Dirictors)
                .ThenInclude(x => x.Nationality)
                .Include(x => x.Category).FirstOrDefault(x => x.MovieId == id);
            return new AddMovieWithReletadData
            {
                MovieTitle = res.MovieTitle,
                MovieReleaserYeer = res.MovieReleaserYeer,
                dirictors = res.Dirictors.Select(x=>new DirictorDto
                {
                    DirictorContact = x.DirictorContact,
                    DirictorrEmail = x.DirictorrEmail,
                    DirictorName = x.DirictorName,
                    Nationality = new NationalityDto
                    {
                        NationalityName = x.Nationality.NationalityName,
                    }
                }).ToList(),
                category = new CategoryDto
                {
                    CategoryName = res.Category.CategoryName,
                }
            };
        }
    }
}
