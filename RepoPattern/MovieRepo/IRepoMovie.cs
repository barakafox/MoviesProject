using MoviesProject.DTO;

namespace MoviesProject.RepoPattern.MovieRepo
{
    public interface IRepoMovie
    {
        public void AddMovieWithReletdData(AddMovieWithReletadData dto);
        public List<AddMovieWithReletadData> GetAllData();
        public AddMovieWithReletadData GetData(int id);
    }
}
