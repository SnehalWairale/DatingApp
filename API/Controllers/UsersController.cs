using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.Interface;
using API.DTOs;
using AutoMapper;

namespace API.Controllers
{
    [Authorize]
    public class UsersController :BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private  readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository=userRepository;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();
             return Ok(users);
            
        }
        
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
             
          return   await _userRepository.GetMemberAsync(username);
     
            // var user= await _userRepository.GetUserByUsernameAsync(username.ToLower());
            // return _mapper.Map<MemberDto>(user);
            
        }
        
    }
}