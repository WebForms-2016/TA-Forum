namespace ForumSystem.Data.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ForumSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ForumSystemDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            IList<Category> categories = new List<Category>()
            {
                new Category() {Name = "Games", Visibility = Visibility.Public },
                new Category() {Name = "Software", Visibility = Visibility.Public },
                new Category() {Name = "Hardware", Visibility = Visibility.Public },
                new Category() {Name = "Fun", Visibility = Visibility.Public },
                new Category() {Name = "Music", Visibility = Visibility.Public },
                new Category() {Name = "Movies", Visibility = Visibility.Public }
            };

            context.Categories.AddOrUpdate(categories.ToArray());
        }
    }
}
