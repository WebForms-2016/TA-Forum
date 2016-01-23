namespace ForumSystem.Data
{
    using System.Data.Entity;
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

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Thread> Threads { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Rating> Ratings { get; set; }

    }
}
