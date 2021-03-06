﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Models
{
    public class Course
    {
        public Course()
        {
        }

        public Course(int CourseID, string Title, int Credits)
        {
            this.CourseID = CourseID;
            this.Title = Title;
            this.Credits = Credits;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]

        [Remote(action: "ValidateCourseId", controller: "Courses")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        /*public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }*/
    }
}
