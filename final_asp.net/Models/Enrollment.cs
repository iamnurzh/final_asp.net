using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public Enrollment(int EnrollmentID, int CourseID, int StudentID)
        {
            this.EnrollmentID = EnrollmentID;
            this.CourseID = CourseID;
            this.StudentID = StudentID;
        }
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        /*public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }*/
    }
}
