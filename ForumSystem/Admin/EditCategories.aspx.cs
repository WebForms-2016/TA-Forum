namespace ForumSystem.Admin
{
    using System;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Ninject;

    using ErrorHandlerControl;
    using Services.Data.Contracts;
    using Models;

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

        //protected void LinkButtonEditSave_Click(object sender, EventArgs e)
        //{
        //    this.PanelEdit.Visible = false;
        //    this.LinkButtonShowCreatePanel.Visible = true;
        //    ErrorNotifier.AddSuccessMessage("Category modified.");
        //}

        //protected void LinkButtonCancelEdit_Click(object sender, EventArgs e)
        //{
        //    this.PanelEdit.Visible = false;
        //    this.LinkButtonShowCreatePanel.Visible = true;
        //}

        //protected void LinkButtonDelete_Click(object sender, EventArgs e)
        //{
        //    this.PanelDelete.Visible = true;
        //    this.PanelEdit.Visible = false;
        //    this.PanelCreate.Visible = false;
        //    this.LinkButtonShowCreatePanel.Visible = false;
        //}

        //protected void LinkButtonConfirmDelete_Click(object sender, EventArgs e)
        //{
        //    this.PanelDelete.Visible = false;
        //    this.LinkButtonShowCreatePanel.Visible = true;
        //    ErrorNotifier.AddSuccessMessage("Category deleted.");
        //}

        //protected void LinkButtonCancelDelete_Click(object sender, EventArgs e)
        //{
        //    this.PanelDelete.Visible = false;
        //    this.LinkButtonShowCreatePanel.Visible = true;
        //}

        //protected void LinkButtonShowCreatePanel_Click(object sender, EventArgs e)
        //{
        //    this.LinkButtonShowCreatePanel.Visible = false;
        //    this.PanelCreate.Visible = true;
        //    this.PanelEdit.Visible = false;
        //    this.PanelDelete.Visible = false;
        //}

        //protected void LinkButtonCreate_Click(object sender, EventArgs e)
        //{
        //    this.PanelCreate.Visible = false;
        //    this.LinkButtonShowCreatePanel.Visible = true;
        //    if (this.TextBoxCategoryCreate.Text != "")
        //    {
        //        ErrorNotifier.AddSuccessMessage("Category created.");
        //    }
        //    else
        //    {
        //        ErrorNotifier.AddErrorMessage("Category name cannot be empty.");
        //    }
        //}
    }
}