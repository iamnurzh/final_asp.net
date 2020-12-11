using final_asp.net.Models;
using final_asp.net.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Services
{
    public class InstructorService
    {
        private readonly IInstructorRepository _instructorRepo;

        public InstructorService(IInstructorRepository instructorRepo)
        {
            _instructorRepo = instructorRepo;
        }

        public async Task<List<Instructor>> GetInstructors()
        {
            return await _instructorRepo.GetAll();
        }
    }
}
