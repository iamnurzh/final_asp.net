using final_asp.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Repositories
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAll();
    }
}
