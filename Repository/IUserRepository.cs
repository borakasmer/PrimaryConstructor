using PrimaryConstructor.Models;

namespace PrimaryConstructor.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User? GetUserByName(string name);
    }
}
