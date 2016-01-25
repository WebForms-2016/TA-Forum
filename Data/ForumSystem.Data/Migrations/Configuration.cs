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
                new Category() {Title = "Games", Visibility = Visibility.Public },
                new Category() {Title = "Software", Visibility = Visibility.Public },
                new Category() {Title = "Hardware", Visibility = Visibility.Public },
                new Category() {Title = "Fun", Visibility = Visibility.Public },
                new Category() {Title = "Music", Visibility = Visibility.Public },
                new Category() {Title = "Movies", Visibility = Visibility.Public }
            };

            context.Categories.AddOrUpdate(categories.ToArray());
        }
    }
}
