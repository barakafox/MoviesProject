using MoviesProject.DTO;

namespace MoviesProject.RepoPattern.CategoryRepo
{
    public interface IRepoCategory
    {
        public void AddCategory(CategoryDto dto);
        public void UpdateCategory(CategoryDto dto , int id);
    }
}
