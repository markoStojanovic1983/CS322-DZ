namespace DZ11_2
{
    public class Student : AcademicPerson
    {
        public string StudentID { get; private set; }
        public double GradeAverage { get; private set; }

        public Student(string firstName, string lastName, int enrollmentYear, string studentId, double gradeAverage)
            : base(firstName, lastName, enrollmentYear)
        {
            StudentID = studentId;
            GradeAverage = gradeAverage;
        }

        public override string GetAcademicStatus()
        {
            return "Student";
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Grade average: {GradeAverage:F2}");
        }
    }
}
