namespace ForumSystem.Services.Data
{
    using System.Linq;

    using Models;
    using ForumSystem.Services.Data.Contracts;
    using ForumSystem.Data;
    public class UserService : IUserService
    {
        private readonly IRepository<User> users;

        public UserService(IRepository<User> usersRepo)
        {
            this.users = usersRepo;
        }

        public IQueryable<User> GetAll()
        {
            return this.users.All();
        }
    }
}
