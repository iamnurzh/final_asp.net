using final_asp.net.Data;
using final_asp.net.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        readonly final_aspnetContext _context;

        public StudentRepository(final_aspnetContext context)
        {
            _context = context;
        }

        public Task<List<Student>> GetAll()
        {
            return _context.Student.ToListAsync();
        }
    }
}
