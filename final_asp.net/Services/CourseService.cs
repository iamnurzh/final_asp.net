using final_asp.net.Models;
using final_asp.net.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Services
{
    public class CourseService
    {
        private readonly ICourseRepository _courseRepo;

        public CourseService(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public async Task<List<Course>> GetCourses()
        {
            return await _courseRepo.GetAll();
        }

    }
}
