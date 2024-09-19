using Microsoft.AspNetCore.Mvc;
using PrimaryConstructor.Models;
using PrimaryConstructor.Repository;

namespace PrimaryConstructor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserRepository _repository) : ControllerBase
    {
        [HttpGet(Name = "GetUser")]
        public User Get()
        {
            var model = new User("Bora", "Kasmer", new DateTime(1978, 6, 3));
            //var model = new User("Bora", "Kasmer");
            model.UserInfo();
            return model;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return _repository.GetUsers().ToList();
        }
        [HttpGet]
        [Route("GetUserByName")]
        public User? GetUserByName(string name)
        {
            return _repository.GetUserByName(name);
        }
    }
}
