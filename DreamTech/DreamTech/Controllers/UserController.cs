using DreamTech.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GetUser")]
        [HttpGet]
        public Employee GetUser()
        {   
            
            var user = new Employee()
            {   
                EmployeeCode="EMP-001",
                User=new User() 
                {
                    UserEmail="Channa@mail.com",
                    UserPassword="123456"
                }
            };
            return user;
        }

    }
}
