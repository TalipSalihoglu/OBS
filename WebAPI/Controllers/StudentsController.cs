using AutoMapper;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Enums;
using Core.Utilities.Attributes;
using Entities.Concrete;
using Entities.Dtos.StudentDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentsController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpPost("add")]
        public IActionResult Add(CreateStudentDto student)
        {
            Student s = _mapper.Map<Student>(student);
            _studentService.Add(s);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(UpdateStudentDto student)
        {
            Student s = _mapper.Map<Student>(student);
            _studentService.Update(s);
            return Ok();
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _studentService.Get(x => x.Id == id);
            return Ok(result);
        }

        [CustomAuthorize(Roles.student)]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _studentService.GetList();
            return Ok(result);
        }
    }
}
