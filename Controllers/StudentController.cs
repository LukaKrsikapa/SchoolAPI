using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Data;
using SchoolAPI.Data.Entities;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<StudentModel>> Get()
        {
            IEnumerable<Student> students;
            try
            {
                students = _studentRepository.AllStudents;

                if (students != null)
                {
                    List<StudentModel> result = _mapper.Map<List<StudentModel>>(students);
                    return Ok(result);
                }
                else
                {
                    return NotFound(new {Text = "Couldn't find any students"});
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}