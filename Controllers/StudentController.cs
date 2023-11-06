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
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentController(IDepartmentRepository departmentRepository, IStudentRepository studentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<StudentModel>> GetByDepartmentId(int? departmentId)
        {
            IEnumerable<Student> students;
            try
            {
                if(departmentId == null)
                {
                    students = _studentRepository.AllStudents;
                }
                else
                {
                    students = _studentRepository.AllStudents.Where(s => s.DepartmentId == departmentId);
                }

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

        [HttpGet("StudentById")]
        public ActionResult<StudentModel> GetById(int? id)
        {
            IEnumerable<Student> students;
            try
            {
                if(id == null)
                {
                    return BadRequest("Parameter \"id\" is required");
                }
                Student student = _studentRepository.GetStudentById(id);
                if(student != null)
                {
                    StudentModel result = _mapper.Map<StudentModel>(student);
                    return Ok(result);
                }
                else
                {
                    return NotFound("Student not found");
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public ActionResult<StudentModel> Post(StudentModel newStudent)
        {
            try
            {
                Student? studentToAdd = _mapper.Map<Student>(newStudent);
                studentToAdd = _studentRepository.AddStudent(studentToAdd);
                StudentModel result = _mapper.Map<StudentModel>(studentToAdd);
                result.DepartmentName = _departmentRepository.GetDepartmentById(newStudent.DepartmentId).Name;
                return Created($"api/student/{result.Id}", result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public ActionResult<StudentModel> Put(StudentModel updatedStudent)
        {
            try
            {
                StudentModel result;
                Student? updatedStudentDM = _mapper.Map<Student>(updatedStudent);
                updatedStudentDM = _studentRepository.UpdateStudent(updatedStudentDM);
                if(updatedStudentDM != null)
                {
                    result = _mapper.Map<StudentModel>(updatedStudentDM);
                    return Ok(result);
                }
                else
                {
                    return NotFound("Student not found");
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}