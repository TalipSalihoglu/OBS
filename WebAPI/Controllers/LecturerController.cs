using AutoMapper;
using Business.Abstract;
using Core.Enums;
using Core.Utilities.Attributes;
using Entities.Concrete;
using Entities.Dtos.LecturerDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturerController : ControllerBase
    {
        private readonly ILecturerService _lecturerService;
        private readonly IMapper _mapper;

        public LecturerController(ILecturerService lecturerService, IMapper mapper)
        {
            _lecturerService = lecturerService;
            _mapper = mapper;
        }

        [CustomAuthorize(Roles.admin)]
        [HttpPost("add")]
        public IActionResult Add(CreateLecturerDto lecturer)
        {
            Lecturer newLecturer = _mapper.Map<Lecturer>(lecturer);
            _lecturerService.Add(newLecturer);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(UpdateLecturerDto lecturer)
        {
            Lecturer updateLecturer = _mapper.Map<Lecturer>(lecturer);
            _lecturerService.Update(updateLecturer);
            return Ok();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _lecturerService.GetList();
            return Ok(result);
        }

        [HttpGet("getbyUserId")]
        public IActionResult getbyUserId(int userid)
        {
            var result = _lecturerService.Get(x => x.UserId == userid);
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _lecturerService.Get(x=>x.Id==id);
            return Ok(result);
        }
    }
}
