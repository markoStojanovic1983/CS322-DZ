namespace DZ11_2
{
    public abstract class AcademicPerson : IAcademicMember
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int EnrollmentYear { get; set; }

        public AcademicPerson(string firstName, string lastName, int enrollmentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            EnrollmentYear = enrollmentYear;
        }

        // Abstract method that must be implemented by derived classes
        public abstract string GetAcademicStatus();

        // Virtual method that can be overridden by derived classes
        public virtual void DisplayInformation()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}");
            Console.WriteLine($"Enrollment year: {EnrollmentYear}");
        }

        // Protected method accessible only to derived classes
        protected string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
