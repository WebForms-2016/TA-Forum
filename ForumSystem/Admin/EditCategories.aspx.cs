namespace ForumSystem.Admin
{
    using System;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Ninject;

    using ErrorHandlerControl;
    using Services.Data.Contracts;
    using Models;
    using System.Collections;
    using System.Web.UI.WebControls;
    public partial class EditCategories : System.Web.UI.Page
    {
        [Inject]
        public ICategoriesService Categories { get; set; }
                
        public IQueryable<Category> GridViewCategories_GetData()
        {
            return Categories.GetAll();
        }

        public void GridViewCategories_DeleteItem(int Id)
        {
            this.Categories.Delete(Id);
            Notifier.AddSuccessMessage("Category was successfully deleted!");
        }

        public void GridViewCategories_UpdateItem(int Id)
        {
            var categoryToBeUpdate = this.Categories.GetById(Id)
                .FirstOrDefault();

            if (categoryToBeUpdate == null)
            {
                ModelState.AddModelError("", string.Format("Category with id {0} was not found", Id));
            }

            TryUpdateModel(categoryToBeUpdate);
            if (ModelState.IsValid)
            {
                this.Categories.Update();
                Notifier.AddSuccessMessage("Category was successfully modified!");
            }
        }
    }
}