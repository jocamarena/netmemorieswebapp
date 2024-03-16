using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repository.IRepository;

namespace WebApplication1.Controllers
{
    public class MemoryController : Controller
    {
        //private readonly ApplicationDBContext _context;
        private IMemoryRepository Repository;

        public MemoryController(IMemoryRepository Repository)
        {
            this.Repository = Repository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var memories = Repository.GetAll().ToList();
            return View(memories);
        }
        
        public IActionResult Create(Memory inputMemory)
        {
/*            Repository.Add(inputMemory);
            Repository.Save();
            return View(inputMemory);*/
            return View();
        }

        [HttpPut]
        public IActionResult UpdateMemory(Memory inputMemory)
        {
            var memory = Repository.GetFirstOrDefault(m => m.ID == inputMemory.ID);
            if (memory == null)
            {
                return NotFound();
            } else
            {
                Repository.Update(inputMemory);
                Repository.Save();
            }
            return View(memory);
        }
    }
}
