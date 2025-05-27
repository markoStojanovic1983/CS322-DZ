using System.ComponentModel.DataAnnotations;

namespace DZ13.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int EnrollmentId { get; set; }

        [Required]
        [Display(Name = "Assignment Name")]
        public string AssignmentName { get; set; }

        public decimal Points { get; set; }

        [Display(Name = "Max Points")]
        public decimal MaxPoints { get; set; }

        [Display(Name = "Date Graded")]
        [DataType(DataType.Date)]
        public DateTime DateGraded { get; set; }

        public string Comments { get; set; }

        public virtual Enrollment Enrollment { get; set; }
    }
}