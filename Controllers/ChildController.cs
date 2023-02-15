using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository;
using Sevices.Interfaces;
//using Sevices.Models;
using Sevices.DTOs;
using UI.Models;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChildController : ControllerBase
    {
        IChildServices _service;
        public ChildController(IChildServices service)
        {
            _service = service;
        }

         [HttpGet]
        public async Task<IEnumerable<ChildDTO>> GetChildren()
        {
            return await _service.GetAllAsync();
        }
        [HttpPost]
        public async Task<ChildDTO> AddChild([FromBody] ChildModel child)
        {
            ChildDTO CM = new ChildDTO();
            CM.Name = child.Name;
            CM.DateOfBirth = child.DateOfBirth;
            CM.IdentityNumber = child.IdentityNumber;
            await _service.AddAsync(CM);
            return CM;
        }


    }

}
