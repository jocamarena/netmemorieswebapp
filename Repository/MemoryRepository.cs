﻿using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repository.IRepository;

namespace WebApplication1.Repository
{
    public class MemoryRepository : Repository<Memory>, IMemoryRepository
    {
        private readonly ApplicationDBContext _context;
        public MemoryRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Update(Memory memory)
        {
            _context.Update(memory);
        }
    }
}
