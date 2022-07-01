using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos.StudentCourseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentCourseService;
        private readonly IMapper _mapper;

        public StudentCourseController(IStudentCourseService studentCourseService, IMapper mapper)
        {
            _studentCourseService = studentCourseService;
            _mapper = mapper;
        }

        [HttpPost("addStudentToCourse")]
        public IActionResult AddStudentToCourse(CreateStudentCourseDto createStudentCourse)
        {
            var studentCourse=_mapper.Map<StudentCourse>(createStudentCourse);
            _studentCourseService.AddStudentToCourse(studentCourse);
            return Ok();
        }
    }
}
