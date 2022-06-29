using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos.ExamDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public ExamController(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }

        [HttpGet("getAllExamByStudentId")]
        public IActionResult GetAllExamByStudentId(int id)
        {

            var result = _examService.GetAllExamByStudentId(id);
            return Ok(result);
        }

        [HttpGet("getExamByStudentIdAndCourseId")]
        public IActionResult GetExamByStudentIdAndCourseId(int studentId,int courseId)
        {

            var result = _examService.GetExamByStudentIdAndCourseId(studentId,courseId);
            return Ok(result);
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {

            var result = _examService.GetList();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CreateExamDto exam)
        {
            var createExam =_mapper.Map<Exam>(exam);
            _examService.Add(createExam);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(UpdateExamDto exam)
        {
            var createExam =_mapper.Map<Exam>(exam);
            _examService.Update(createExam);
            return Ok();
        }
    }
}
