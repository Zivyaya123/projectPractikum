using Microsoft.AspNetCore.Mvc;
using Project;
using Sevices.Interfaces;
//using Sevices.ServiceClasses;
using Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sevices.DTOs;
using Repository.Entities;
using UI.Models;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        IUserServices _service;
        public UserController(IUserServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            return await _service.GetAllAsync();
        }

        [HttpPost]
        public async Task<UserDTO> AddUser([FromBody] UserDTO user)
        {
            UserDTO UM = new UserDTO();
            UM.FirstName = user.FirstName;
            UM.LastName = user.LastName;
            UM.IdentityNumber = user.IdentityNumber;
            UM.DateOfBirth = user.DateOfBirth;
            UM.Gender = user.Gender;
            UM.HMO = user.HMO;
            UM.Children = user.Children;
            await _service.AddAsync(UM);
            return UM;
           
        }
    }
  
}
