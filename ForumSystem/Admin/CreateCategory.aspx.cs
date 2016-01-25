namespace ForumSystem.Admin
{
    using System;
    using System.Collections;
    using System.Web.UI;
    using Ninject;

    using ErrorHandlerControl;
    using ForumSystem.Models;
    using ForumSystem.Services.Data.Contracts;

    public partial class CreateCategory : System.Web.UI.Page
    {
        [Inject]
        public ICategoriesService Categories { get; set; }

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
            if (string.IsNullOrWhiteSpace(this.TextBoxCategoryTitle.Text))
            {
                Notifier.AddErrorMessage("Category title is required!");
                return;
            }

            var visibility = this.DropDownVisibilities.SelectedIndex;
            var newCategory = new Category()
            {
                Title = this.TextBoxCategoryTitle.Text,
                Visibility = (Visibility)visibility
            };

            var id = this.Categories.Add(newCategory);

            if (id != 0)
            {
                Notifier.AddSuccessMessage("Category was successfully created!");
                Response.Redirect("~/Admin/EditCategories.aspx");
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