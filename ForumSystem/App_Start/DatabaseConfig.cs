namespace ForumSystem.App_Start
{
    using System.Data.Entity;

    using ForumSystem.Data;
    using ForumSystem.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ForumSystemDbContext, Configuration>());
            ForumSystemDbContext.Create().Database.Initialize(true);
        }
    }
}