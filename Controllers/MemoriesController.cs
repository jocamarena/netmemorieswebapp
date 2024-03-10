using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Repository.IRepository;

namespace WebApplication1.Controllers
{
    public class MemoriesController : Controller
    {
        //private readonly ApplicationDBContext _context;
        private IMemoryRepository Repository;
        public MemoriesController(IMemoryRepository Repository)
        {
            this.Repository = Repository;
        }
        /*public MemoriesController(ApplicationDBContext context)
        {
            _context = context;
        }*/
        public IActionResult Memory()
        {
            //var memories = _context.Memories.ToList();
            var memories = Repository.GetAll().ToList();
            return View(memories);
        }
    }
}
