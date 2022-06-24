using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos.StudentDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //[HttpGet]
        //public Task<IActionResult> GetAll()
        //{

        //}
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("add")]
        public IActionResult Add(CreateStudentDto student)
        {
            Student s = new Student() {
                FirstName=student.FirstName,
                LastName=student.LastName,
                DepartmentId=student.DepartmentId,
                CityId = student.CityId,
                FullAddress = student.FullAddress,
                Email = student.Email,
            };
            
            _studentService.Add(s);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(UpdateStudentDto student)
        {
            Student s = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                DepartmentId = student.DepartmentId,
                CityId = student.CityId,
                FullAddress = student.FullAddress,
                Email = student.Email,
            };

            _studentService.Update(s);
            return Ok();
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {       
            var result = _studentService.GetDetail(x=>x.Id==id);
            return Ok(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _studentService.GetList();
            return Ok(result);
        }
    }
}
