using final_asp.net.Models;
using final_asp.net.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepo;

        public StudentService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _studentRepo.GetAll();
        }
    }
}
