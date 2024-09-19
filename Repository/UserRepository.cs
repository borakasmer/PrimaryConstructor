using PrimaryConstructor.Models;

namespace PrimaryConstructor.Repository
{
    public class UserRepository() : IUserRepository
    {
        private static readonly List<User> _users = new List<User> {
            new User("John", "Doe", new DateTime(1990, 1, 1)),
            new User("Jane", "Doe", new DateTime(1995, 1, 1)),
            new User("Alice", "Smith", new DateTime(2000, 1, 1)),
            new User("Bob", "Smith", new DateTime(2005, 1, 1)),
            new User("Charlie", "Brown", new DateTime(2010, 1, 1)),
            new User("Daisy", "Brown", new DateTime(2015, 1, 1))
        };
        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User? GetUserByName(string name)
        {
            return _users.FirstOrDefault(u => u.Name.ToUpper().Contains(name.ToUpper()) || u.Surname.ToUpper().Contains(name.ToUpper()));
        }
    }
}
