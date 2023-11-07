using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Data;
using SchoolAPI.Data.Entities;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [Route("api/students/{studentId}/[controller]")]
    [ApiController]
    public class FinalController : ControllerBase
    {
        private readonly Mapper _mapper;
        private readonly IFinalRepository _finalRepository;

        public FinalController(Mapper mapper, IFinalRepository finalRepository)
        {
            _mapper = mapper;
            _finalRepository = finalRepository;
        }

        [HttpGet("StudentFinals")]
        public ActionResult<List<FinalModel>> Get(int studentId)
        {
            try
            {
                List<Final> finals = _finalRepository.GetFinalsByStudentId(studentId).ToList();
                List<FinalModel> result = _mapper.Map<List<FinalModel>>(finals);
                return Ok(result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
