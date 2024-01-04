using _230104.Models;
using _230104.Models.DTOs;
using _230104.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace _230104.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserInterface UserInterface;

        public UserController(UserInterface UserInterface)
        {
            this.UserInterface = UserInterface;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(CreatedUserDTO createDTO)
        {

            return StatusCode(201, await UserInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {

            return await UserInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<User> Get(Guid id)
        {

            return await UserInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<User> Put(Guid id, UpdateUserDTO updateDTO)
        {

            return await UserInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<User> Delete(Guid id)
        {
            return await UserInterface.DeleteById(id);
        }
    }
}
