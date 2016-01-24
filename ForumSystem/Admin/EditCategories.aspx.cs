using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForumSystem.Admin
{
    public partial class EditCategories : System.Web.UI.Page
    {
        /*
        public IQueryable<Category> GridViewCategories_GetData()
        {
            return StaticData.Categories.AsQueryable<Category>();
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
            ErrorSuccessNotifier.AddSuccessMessage("Category modified.");
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
            ErrorSuccessNotifier.AddSuccessMessage("Category deleted.");
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
                ErrorSuccessNotifier.AddSuccessMessage("Category created.");
            }
            else
            {
                ErrorSuccessNotifier.AddErrorMessage("Category name cannot be empty.");
            }
        }

        protected void LinkButtonCancelCreate_Click(object sender, EventArgs e)
        {
            this.PanelCreate.Visible = false;
            this.LinkButtonShowCreatePanel.Visible = true;
        }
        */
    }
}