using System.ComponentModel.DataAnnotations;

namespace DZ13.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Display(Name = "Student")]
        public int StudentId { get; set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public decimal? Grade { get; set; }

        public string Status { get; set; } = "Active";

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}