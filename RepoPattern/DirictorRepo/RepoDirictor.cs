using Microsoft.EntityFrameworkCore;
using MoviesProject.DTO;
using MoviesProject.Models;

namespace MoviesProject.RepoPattern.DirictorRepo
{
    public class RepoDirictor : IRepoDirictor
    {
        private readonly appDbContext _Context;
        public RepoDirictor(appDbContext context)
        {
            _Context = context;
        }
        public void AddDirictor(DirictorDto dto)
        {
            Dirictor dirictor = new Dirictor
            {
                DirictorContact = dto.DirictorContact,
                DirictorrEmail = dto.DirictorrEmail,
                DirictorName = dto.DirictorName,
                Nationality = new Nationality
                {
                    NationalityName = dto.Nationality.NationalityName,
                }
            };
            _Context.dirictors.Add(dirictor);
            _Context.SaveChanges();
        }

        public void UpdateAllData(UpdateAllDataDto dto , int id)
        {
            var res = _Context.dirictors
                .Include(x=>x.Movies)
                .ThenInclude(x=>x.Category)
                .Include(x=>x.Nationality)
                
                .FirstOrDefault(x => x.DirictorId == id);

                res.DirictorName = dto.DirictorName;
                res.DirictorContact = dto.DirictorContact;
                res.DirictorrEmail = dto.DirictorrEmail;
                res.Nationality = new Nationality
                {
                    NationalityName = dto.Nationality.NationalityName,
                };
                res.Movies = dto.Movies.Select(x => new Movie
                {
                    MovieTitle = x.MovieTitle,
                    MovieReleaserYeer = x.MovieReleaserYeer,
                    Category = new Category
                    {
                        CategoryName = dto.categoryDtos.CategoryName,
                    }
                }).ToList();
                
            _Context.dirictors.Update(res);
            _Context.SaveChanges();
        }

        public void DeleteDirictor(int id)
        {
            var res = _Context.dirictors.FirstOrDefault(x => x.DirictorId == id);
            if (res != null)
            {
                _Context.dirictors.Remove(res);
                _Context.SaveChanges();
            }
            else
                throw new Exception("Not Found");
        }
    }
}
