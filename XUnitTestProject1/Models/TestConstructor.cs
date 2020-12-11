using final_asp.net.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.Models
{
    class TestConstructor
    {
        Course c = new Course(1, "dotNet", 3);
        Department d = new Department(1, "FIT", 1000000, new DateTime(2020,12,12));
        Enrollment e = new Enrollment(1, 1, 1);
        Instructor i = new Instructor(1, "Sariyev", "Kairat");
        OfficeAssignment o = new OfficeAssignment(1, "Manas st.");
        Student s = new Student(1, "Nauryzbayev", "Nurzhan", new DateTime(2017, 9, 1));
    }
} 
