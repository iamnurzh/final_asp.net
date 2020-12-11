using final_asp.net.Data;
using final_asp.net.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        readonly final_aspnetContext _context;

        public DepartmentRepository(final_aspnetContext context)
        {
            _context = context;
        }

        public Task<List<Department>> GetAll()
        {
            return _context.Department.ToListAsync();
        }
    }
}
