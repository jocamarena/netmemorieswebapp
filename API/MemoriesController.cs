using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository.IRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemoriesController : ControllerBase
    {
        private readonly IMemoryRepository memoryRepository;
        public MemoriesController(IMemoryRepository memoryRepository)
        {
            this.memoryRepository = memoryRepository;
        }
        // GET: api/<MemoriesController>
        [HttpGet]
        public IEnumerable<Memory> Get()
        {
            var memories = memoryRepository.GetAll();
            return memories;
        }

        // GET api/<MemoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MemoriesController>
        [HttpPost]
        public void Post([FromBody] Memory memory)
        {
            if (memory.ID == 0)
            {
                memoryRepository.Add(memory);
            }
            else
            {
                memoryRepository.Update(memory);
            }
            memoryRepository.Save();
        }
    }
}
