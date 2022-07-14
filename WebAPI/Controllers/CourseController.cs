using AutoMapper;
using Business.Abstract;
using Core.Enums;
using Core.Utilities.Attributes;
using Entities.Concrete;
using Entities.Dtos.CourseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [CustomAuthorize(Roles.admin)]
        [HttpPost("add")]
        public IActionResult Add(CreateCourseDto course)
        {
            var newCourse =_mapper.Map<Course>(course);
            _courseService.Add(newCourse);
            return Ok();
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result =_courseService.GetList();
            return Ok(result);
     
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _courseService.Get(x=>x.Id==id);
            return Ok(result);
        }
    }
}
