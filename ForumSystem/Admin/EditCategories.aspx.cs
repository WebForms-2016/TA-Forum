namespace ForumSystem.Admin
{
    using System;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Ninject;

    using ErrorHandlerControl;
    using Models.Categories;
    using Services.Data.Contracts;
    using System.Collections.Generic;
    public partial class EditCategories : System.Web.UI.Page
    {
        [Inject]
        public ICategoriesService categories { get; set; }
        

        public IList<EditCategoriesResponseModel> GridViewCategories_GetData()
        {
            return categories.GetAll()
                .ProjectTo<EditCategoriesResponseModel>()
                .ToList();
        }

        protected void LinkButtonEdit_Click(object sender, EventArgs e)
        {
            this.PanelEdit.Visible = true;
            this.PanelDelete.Visible = false;
            this.PanelCreate.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = false;
        }

        protected void LinkButtonEditSave_Click(object sender, EventArgs e)
        {
            this.PanelEdit.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
            ErrorNotifier.AddSuccessMessage("Category modified.");
        }

        protected void LinkButtonCancelEdit_Click(object sender, EventArgs e)
        {
            this.PanelEdit.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
        }

        protected void LinkButtonDelete_Click(object sender, EventArgs e)
        {
            this.PanelDelete.Visible = true;
            this.PanelEdit.Visible = false;
            this.PanelCreate.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = false;
        }

        protected void LinkButtonConfirmDelete_Click(object sender, EventArgs e)
        {
            this.PanelDelete.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
            ErrorNotifier.AddSuccessMessage("Category deleted.");
        }

        protected void LinkButtonCancelDelete_Click(object sender, EventArgs e)
        {
            this.PanelDelete.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
        }

        protected void LinkButtonShowCreatePanel_Click(object sender, EventArgs e)
        {
            this.LinkButtonShowCreatePanel.Visible = false;
            this.PanelCreate.Visible = true;
            this.PanelEdit.Visible = false;
            this.PanelDelete.Visible = false;
        }

        protected void LinkButtonCreate_Click(object sender, EventArgs e)
        {
            this.PanelCreate.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
            if (this.TextBoxCategoryCreate.Text != "")
            {
                ErrorNotifier.AddSuccessMessage("Category created.");
            }
            else
            {
                ErrorNotifier.AddErrorMessage("Category name cannot be empty.");
            }
        }

        protected void LinkButtonCancelCreate_Click(object sender, EventArgs e)
        {
            this.PanelCreate.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
        }
    }
}