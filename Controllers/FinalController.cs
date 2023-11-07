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
        private readonly IMapper _mapper;
        private readonly IFinalRepository _finalRepository;

        public FinalController(IMapper mapper, IFinalRepository finalRepository)
        {
            _mapper = mapper;
            _finalRepository = finalRepository;
        }

        [HttpGet]
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

        [HttpGet("id")]
        public ActionResult<FinalModel> Get(int studentId, int id)
        {
            try
            {
                FinalModel? result = null;

                Final? finalDM = _finalRepository.GetFinalById(id);

                if (finalDM != null && finalDM.StudentId == studentId)
                {
                    result = _mapper.Map<FinalModel>(finalDM);
                }
                
                return Ok(result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
