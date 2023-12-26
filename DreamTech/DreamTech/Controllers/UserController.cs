
using DreamTech.Data;
using DreamTech.Interface;
using DreamTech.Model;
using DreamTech.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamTech.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        [Route("/Getusers")]
        [ProducesResponseType(200, Type = typeof(ICollection<User>))]
        [ProducesResponseType(typeof(ICollection<User>), 400)]
        public IActionResult GetUsers()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_userRepository.GetUsers());
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(404, Type = typeof(User))]
        [Route("/SingleUser/{id}")]
        public IActionResult SingleUser(int id)
        {

            if (!ModelState.IsValid)
            {
                return NotFound("User Not Found");
            }
            return Ok(_userRepository.GetUser(id));
        
        }




    }
}
