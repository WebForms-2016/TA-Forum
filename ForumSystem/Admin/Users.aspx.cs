namespace ForumSystem.Admin
{
    using System;
    using System.Linq;

    using Models;
    using Ninject;
    using Services.Data.Contracts;
    
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Inject]
        public IUserService usersData { get; set; }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<User> GridViewBooks_GetData()
        {
            return this.usersData.GetAll();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_UpdateItem(int id)
        {
            ForumSystem.Models.User item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();

            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_DeleteItem(int id)
        {

        }
    }
}