namespace ForumSystem.Services.Data.Contracts
{
    using System.Linq;

    using ForumSystem.Models;

    public interface IUserService
    {
        IQueryable<User> GetAll();
    }
}
