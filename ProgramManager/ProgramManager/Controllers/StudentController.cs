using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramManager.DTO;
using ProgramManager.Model;

namespace ProgramManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ICollection<StudnetModel> studnetModels = new List<StudnetModel>()
        {
            new StudnetModel()
            {
                Id=1,
                Name = "Chamara",
                Address ="Kegalle",
                Course = "Science",
                UniversityName ="ICBT"


            },
             new StudnetModel()
            {
                Id=2,
                Name = "Chaidu",
                Address ="Colombo",
                Course = "IT",
                UniversityName ="IIT"


            }, 
            new StudnetModel()
            {
                Id=4,
                Name = "Darshavi",
                Address ="Dehiowita",
                Course = "Bio",
                UniversityName ="SLIIT"


            },
             new StudnetModel()
            {
                Id=3,
                Name = "Dilshan",
                Address ="Kegalle",
                Course = "HNDA",
                UniversityName ="SLIATE"


            }
        };
        public ICollection<CourseName> courseNames = new List<CourseName>()
        {
            new CourseName
            {
                
                Course="Game Development",
                Location="Kandy",
                LecName="Darshavi"

            },
             new CourseName
            {

                Course="Account",
                Location="Colombo",
                LecName="Channa"

            },
              new CourseName
            {

                Course="Asp .net core",
                Location="Kurunegala",
                LecName="Kalinnga"

            }
        };

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/Student")]
        public IActionResult Student()
        {
            var studentdetails = studnetModels.Select(st=> _mapper.Map<StudnetDto>(st));
            return Ok(studentdetails);
        }

        [HttpGet]
        [Route("/Course")]
        public IActionResult Course()
        {
            var coursenamelist = courseNames.Select(co => _mapper.Map<CourseNameDto>(co));
            return Ok(coursenamelist);
        }

        [HttpPost]
        [Route("/Insert")]
        public IActionResult Student(StudnetDto studentModel)
        {
            var student= _mapper.Map<StudnetModel>(studentModel);
            studnetModels.Add(student);
            return Ok(studnetModels.Select(st => _mapper.Map<StudnetDto>(st)));
        }
    }
}
