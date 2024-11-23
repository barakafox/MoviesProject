using MoviesProject.DTO;
using MoviesProject.Models;

namespace MoviesProject.RepoPattern.CategoryRepo
{
    public class RepoCategory:IRepoCategory
    {
        private readonly appDbContext _Context;
        public RepoCategory(appDbContext context)
        {
            _Context = context;
        }
        public void AddCategory(CategoryDto dto)
        {
            var cat = _Context.Categories.FirstOrDefault(x => x.CategoryName == dto.CategoryName);
            if (cat != null)
            {
                throw new Exception("Category Allready Added");
            }
            Category category = new Category
            {
                CategoryName = dto.CategoryName,
            };
            _Context.Categories.Add(category);
            _Context.SaveChanges();
        }
        public void UpdateCategory(CategoryDto dto, int id)
        {
            var cat = _Context.Categories.FirstOrDefault(x => x.CategoryName == dto.CategoryName);
            if(cat != null)
            {
                throw new Exception("Category Allready Added");
            }
                var res = _Context.Categories.FirstOrDefault(x => x.CategoryId == id);
                if (res != null)
                {
                    res.CategoryName = dto.CategoryName;
                }
                _Context.Categories.Update(res);
                _Context.SaveChanges();
        }
    }
}
