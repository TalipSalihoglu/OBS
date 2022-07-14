﻿using AutoMapper;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Enums;
using Core.Utilities.Attributes;
using Entities.Dtos.LoginDtos;
using Entities.Dtos.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("userAdd")]
        public IActionResult Add(CreateUserDto createUserDto) 
        {
           var user= _mapper.Map<User>(createUserDto);
           _userService.Add(user);
           return Ok();
        }

        [HttpGet("getUserByUserName")]
        public IActionResult getUserByUserName(string userName)
        {
            var user = _userService.Get(x => x.UserName.Equals(userName));
            return Ok(user);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var token = _userService.Login(loginDto);
            return Ok(new {token = token});
        }
    }
}
