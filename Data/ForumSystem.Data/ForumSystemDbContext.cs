namespace ForumSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;

    using Models;

    public class ForumSystemDbContext : IdentityDbContext<User>
    {
        public ForumSystemDbContext()
            : base("ForumSystemConnection", throwIfV1Schema: false)
        {
        }

        public static ForumSystemDbContext Create()
        {
            return new ForumSystemDbContext();
        }
    }
}
