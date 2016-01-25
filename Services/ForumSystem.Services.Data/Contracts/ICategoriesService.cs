namespace ForumSystem.Services.Data.Contracts
{
    using System.Linq;

    using ForumSystem.Models;

    public interface ICategoriesService
    {
        int Add(string title, Visibility visibility);

        int Add(Category newCategory);

        void Update();

        IQueryable<Category> GetAll();

        IQueryable<Category> GetById(int id);

        void Delete(int id);
    }
}
