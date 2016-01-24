namespace ForumSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Models;

    public interface IForumSystemDbContext
    {
        IDbSet<Category> Categories { get; set; }

        IDbSet<Thread> Threads { get; set; }

        IDbSet<Rating> Ratings { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
