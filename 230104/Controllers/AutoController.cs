using _230104.Models;
using _230104.Models.DTOs;
using _230104.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _230104.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly AutoInterface autoInterface;

        public AutoController(AutoInterface autoInterface)
        {
            this.autoInterface = autoInterface;
        }

        [HttpPost]
        public async Task<ActionResult<Auto>> Post(CreatedAutoDTO createDTO)
        {

            return StatusCode(201, await autoInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<Auto>> Get()
        {

            return await autoInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<Auto> Get(Guid id)
        {

            return await autoInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<Auto> Put(Guid id, UpdateAutoDTO updateDTO)
        {

            return await autoInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<Auto> Delete(Guid id)
        {
            return await autoInterface.DeleteById(id);
        }

        [HttpGet("/byUser/{id}")]
        public async Task<IEnumerable<Auto>> GetUserPosts(Guid id)
        {
            return await autoInterface.GetUserPosts(id);
        }
    }
}
