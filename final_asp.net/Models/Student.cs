using final_asp.net.CustomValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int ID, string LastName, string FirstMidName, DateTime EnrollmentDate)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstMidName = FirstMidName;
            this.EnrollmentDate = EnrollmentDate;
        }

        [Remote(action: "ValidateStudentId", controller: "Students")]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }

        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]

        [CustomDate(ErrorMessage = "Please be careful!")]
        public DateTime EnrollmentDate { get; set; }


        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
