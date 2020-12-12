using final_asp.net.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace final_asp.net.Models
{
    public class Instructor
    {
        public Instructor()
        {
        }

        public Instructor(int ID, string LastName, string FirstMidName)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstMidName = FirstMidName;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.LastName))
                errors.Add(new ValidationResult("Lastname is empty"));

            if (string.IsNullOrWhiteSpace(this.FirstMidName))
                errors.Add(new ValidationResult("Firstname is empty"));

            return errors;
        }
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
        [Display(Name = "Hire Date")]

        [CustomDate(ErrorMessage = "Please be careful!")]
        public DateTime HireDate { get; set; }

        /*public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }*/
    }
}
