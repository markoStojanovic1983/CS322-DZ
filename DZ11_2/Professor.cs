namespace DZ11_2
{
    public class Professor : AcademicPerson
    {
        public string Title { get; private set; }
        public string[] Subjects { get; private set; }

        public Professor(string firstName, string lastName, int enrollmentYear, string title, string[] subjects)
            : base(firstName, lastName, enrollmentYear)
        {
            Title = title;
            Subjects = subjects;
        }

        public override string GetAcademicStatus()
        {
            return $"Professor - {Title}";
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine("Subjects:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine($"- {subject}");
            }
        }
    }
}
