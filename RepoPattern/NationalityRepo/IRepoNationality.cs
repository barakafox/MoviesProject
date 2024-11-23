using MoviesProject.DTO;

namespace MoviesProject.RepoPattern.NationalityRepo
{
    public interface IRepoNationality
    {
        public void AddNationality(NationalityDto dto);
        public void DeleteNationality(int id);
    }
}
