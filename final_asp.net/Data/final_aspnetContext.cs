using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using final_asp.net.Models;

namespace final_asp.net.Data
{
    public class final_aspnetContext : DbContext
    {
        public final_aspnetContext (DbContextOptions<final_aspnetContext> options)
            : base(options)
        {
        }

        public DbSet<final_asp.net.Models.Course> Course { get; set; }

        public DbSet<final_asp.net.Models.Department> Department { get; set; }

        public DbSet<final_asp.net.Models.Instructor> Instructor { get; set; }

        public DbSet<final_asp.net.Models.Student> Student { get; set; }
    }
}
