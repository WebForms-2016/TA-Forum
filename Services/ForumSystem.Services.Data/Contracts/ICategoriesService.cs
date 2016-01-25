namespace ForumSystem.Services.Data.Contracts
{
    using System.Linq;

    using ForumSystem.Models;
    using ForumSystem.Services.Common;

    public interface ICategoriesService
    {
        int Add(string name, Visibility visibility);

        bool Update(int id);

        IQueryable<Category> GetAll(CategoryRequest request = null);

        IQueryable<Category> GetById(int id);

        void Delete(int id);
    }
}
