using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using final_asp.net.CustomValidation;

namespace final_asp.net.Models
{
    public class Department
    {
        public Department()
        {
        }

        public Department(int DepartmentID, string Name, DateTime StartDate)
        {
            this.DepartmentID = DepartmentID;
            this.Name = Name;
            this.StartDate = StartDate;
        }
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }



        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]

        [CustomDate(ErrorMessage = "Please be careful!")]
        public DateTime StartDate { get; set; }


        public int? InstructorID { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        /*public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }*/
    }
}

