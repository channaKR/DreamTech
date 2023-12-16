
using DreamTech.Data;
using DreamTech.Interface;
using DreamTech.Model;
using DreamTech.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        [Route("GetUsers")]
        public ICollection<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }





    }
}
