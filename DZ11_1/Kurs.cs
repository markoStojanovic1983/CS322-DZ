namespace DZ11_1
{
    public class Kurs : IComparable<Kurs>
    {
        public string ImeKursa { get; set; }
        public int FondCasova { get; set; }
        public int MaksimalnoPrijava { get; set; }

        // Constructor
        public Kurs(string imeKursa, int fondCasova, int maksimalnoPrijava)
        {
            this.ImeKursa = imeKursa;
            this.FondCasova = fondCasova;
            this.MaksimalnoPrijava = maksimalnoPrijava;
        }

        // Implementation of CompareTo method to compare by MaksimalnoPrijava
        public int CompareTo(Kurs courseToCompare)
        {
            if (courseToCompare == null) return 1;
            return courseToCompare.MaksimalnoPrijava.CompareTo(this.MaksimalnoPrijava);
        }

        // Override ToString for better output formatting
        public override string ToString()
        {
            return $"Course: {ImeKursa}, Class Hours: {FondCasova}, Max Registrations: {MaksimalnoPrijava}";
        }
    }
}
