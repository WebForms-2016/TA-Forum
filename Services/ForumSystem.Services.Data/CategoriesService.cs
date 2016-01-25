namespace ForumSystem.Services.Data
{
    using System;
    using System.Linq;

    using ForumSystem.Data;
    using ForumSystem.Models;
    using ForumSystem.Services.Common;
    using ForumSystem.Services.Data.Contracts;

    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> categories;

        public CategoriesService(IRepository<Category> categoriesRepository)
        {
            this.categories = categoriesRepository;
        }
        
        public int Add(string title, Visibility visibility)
        {
            var newCategory = new Category
            {
                Title = title,
                Visibility = visibility
            };

            this.categories.Add(newCategory);
            this.categories.SaveChanges();

            return newCategory.Id;
        }

        public int Add(Category newCategory)
        {
            this.categories.Add(newCategory);
            this.categories.SaveChanges();

            return newCategory.Id;
        }

        public void Update()
        {
            this.categories.SaveChanges();
        }

        public IQueryable<Category> GetAll()
        {
            var query = this.categories.All();
            
            return query
                .OrderBy(c => c.Id);
                //.Skip((request.Page - 1) * request.PageSize)
                //.Take(request.PageSize);
        }

        public IQueryable<Category> GetById(int id)
        {
            return this.categories
                .All()
                .Where(c => c.Id == id);
        }

        public void Delete(int id)
        {
            var categoryToBeDelete = this.GetById(id);
            this.categories.Delete(categoryToBeDelete);
            this.categories.SaveChanges();
        }
    }
}
