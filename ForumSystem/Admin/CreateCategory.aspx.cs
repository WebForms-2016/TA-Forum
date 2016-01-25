using ErrorHandlerControl;
using ForumSystem.Models;
using ForumSystem.Services.Data.Contracts;
using ForumSystem.Services.Data.Enumerations;
using Ninject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForumSystem.Admin
{
    public partial class CreateCategory : System.Web.UI.Page
    {
        [Inject]
        public ICategoriesService Categories { get; set; }

        public Enumeration visibilities = new Enumeration();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var ht = this.GetEnumForBind(typeof(Visibility));

                this.DropDownVisibilities.DataSource = ht;
                this.DropDownVisibilities.DataBind();
            }
        }

        protected void LinkButtonCreate_Click(object sender, EventArgs e)
        {
            var category = new Category();

            TryUpdateModel(category);
            if (ModelState.IsValid)
            {
                this.Categories.Add(category);
                Notifier.AddSuccessMessage("Category created.");
            }            
        }

        protected void LinkButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxCategoryTitle.Text = string.Empty;
        }

        private Hashtable GetEnumForBind(Type enumeration)
        {
            string[] names = Enum.GetNames(enumeration);
            Array values = Enum.GetValues(enumeration);
            Hashtable ht = new Hashtable();

            for (int i = 0; i < names.Length; i++)
            {
                ht.Add(Convert.ToInt32(values.GetValue(i)).ToString(), names[i]);
            }

            return ht;
        }
    }
}