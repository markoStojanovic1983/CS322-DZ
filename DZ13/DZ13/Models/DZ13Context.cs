using Microsoft.EntityFrameworkCore;

namespace DZ13.Models
{
    public class DZ13Context : DbContext
    {
        public DZ13Context(DbContextOptions<DZ13Context> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Enrollment)
                .WithMany()
                .HasForeignKey(g => g.EnrollmentId);
        }
    }
}