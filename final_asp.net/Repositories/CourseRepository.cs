using final_asp.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_asp.net.Data;
using Microsoft.EntityFrameworkCore;

namespace final_asp.net.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        readonly final_aspnetContext _context;

        public CourseRepository(final_aspnetContext context)
        {
            _context = context;
        }

               public Task<List<Course>> GetAll()
        {
            return _context.Course.ToListAsync();
        }
    }
}
