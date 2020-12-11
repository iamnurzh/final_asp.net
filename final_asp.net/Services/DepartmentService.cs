using final_asp.net.Models;
using final_asp.net.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Services
{
    public class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepo;

        public DepartmentService(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _departmentRepo.GetAll();
        }

    }
}
