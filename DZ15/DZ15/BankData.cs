using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ15
{
    // This class stores information about different bank loan types
    public class BankData
    {
        // Dictionary to store bank information
        public static Dictionary<string, Dictionary<string, LoanInfo>> GetBankData()
        {
            // Main dictionary - bank name is the key
            var banks = new Dictionary<string, Dictionary<string, LoanInfo>>();

            // OTP banka loans
            var otpLoans = new Dictionary<string, LoanInfo>();
            otpLoans.Add("Stambeni kredit", new LoanInfo(2.99, 3.50, 30));
            otpLoans.Add("Keš kredit", new LoanInfo(8.50, 9.80, 7));
            otpLoans.Add("Auto kredit", new LoanInfo(5.99, 7.20, 8));
            banks.Add("OTP banka", otpLoans);

            // Banca Intesa loans
            var intesaLoans = new Dictionary<string, LoanInfo>();
            intesaLoans.Add("Stambeni kredit", new LoanInfo(3.10, 3.65, 25));
            intesaLoans.Add("Keš kredit", new LoanInfo(8.20, 9.50, 8));
            intesaLoans.Add("Auto kredit", new LoanInfo(6.20, 7.40, 7));
            banks.Add("Banca Intesa", intesaLoans);

            // AIK banka loans
            var aikLoans = new Dictionary<string, LoanInfo>();
            aikLoans.Add("Stambeni kredit", new LoanInfo(3.25, 3.85, 25));
            aikLoans.Add("Keš kredit", new LoanInfo(8.30, 9.70, 7));
            aikLoans.Add("Auto kredit", new LoanInfo(6.30, 7.50, 7));
            banks.Add("AIK banka", aikLoans);

            return banks;
        }
    }

    // Simple class to store loan information
    public class LoanInfo
    {
        public double InterestRate { get; set; }      // Kamatna stopa
        public double EffectiveRate { get; set; }     // Efektivna kamatna stopa (EKS)
        public int MaxYears { get; set; }             // Maksimalni period otplate u godinama

        public LoanInfo(double interestRate, double effectiveRate, int maxYears)
        {
            InterestRate = interestRate;
            EffectiveRate = effectiveRate;
            MaxYears = maxYears;
        }
    }
}