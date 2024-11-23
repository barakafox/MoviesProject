using MoviesProject.DTO;
using MoviesProject.Models;

namespace MoviesProject.RepoPattern.NationalityRepo
{
    public class RepoNationality:IRepoNationality
    {
        private readonly appDbContext _Context;
        public RepoNationality(appDbContext context)
        {
            _Context = context;
        }
        public void AddNationality(NationalityDto dto)
        {
            Nationality nationality = new Nationality
            {
                NationalityName = dto.NationalityName,
            };
            _Context.Nationality.Add(nationality);
            _Context.SaveChanges();
        }
        public void DeleteNationality(int id)
        {
            var res = _Context.Nationality.FirstOrDefault(x => x.NationalityId == id);
            if (res != null)
            {
                _Context.Nationality.Remove(res);
                _Context.SaveChanges();
            }
            else
                throw new Exception("Not Found");

        }
    }
}
