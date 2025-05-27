using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DZ15
{
    public partial class Form1 : Form
    {
        // Dictionary to store data about banks and their loan types
        private Dictionary<string, Dictionary<string, LoanInfo>> bankData;

        public Form1()
        {
            InitializeComponent();

            // Load bank data when form is created
            try
            {
                bankData = BankData.GetBankData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka o bankama: " + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate the banks dropdown
                foreach (string bank in bankData.Keys)
                {
                    cmbBanks.Items.Add(bank);
                }

                // Select first bank by default
                if (cmbBanks.Items.Count > 0)
                    cmbBanks.SelectedIndex = 0;

                // Add period types to dropdown
                cmbPeriodType.Items.Add("Godina");
                cmbPeriodType.Items.Add("Meseci");
                cmbPeriodType.SelectedIndex = 0; // Default to years
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Greška prilikom učitavanja forme: " + ex.Message);
                MessageBox.Show("Greška prilikom inicijalizacije: " + ex.Message);
            }
        }

        private void cmbBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // When bank changes, update loan types
                UpdateLoanTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri promeni banke: " + ex.Message);
            }
        }

        private void UpdateLoanTypes()
        {
            // Clear previous loan types
            cmbLoanTypes.Items.Clear();

            if (cmbBanks.SelectedIndex != -1)
            {
                string selectedBank = cmbBanks.SelectedItem.ToString();

                // Add loan types for selected bank
                foreach (string loanType in bankData[selectedBank].Keys)
                {
                    cmbLoanTypes.Items.Add(loanType);
                }

                // Select first loan type by default
                if (cmbLoanTypes.Items.Count > 0)
                    cmbLoanTypes.SelectedIndex = 0;
            }
        }

        private void cmbLoanTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // When loan type changes, update displayed interest rate
                UpdateInterestRateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri promeni tipa kredita: " + ex.Message);
            }
        }

        private void UpdateInterestRateDisplay()
        {
            if (cmbBanks.SelectedIndex != -1 && cmbLoanTypes.SelectedIndex != -1)
            {
                string selectedBank = cmbBanks.SelectedItem.ToString();
                string selectedLoanType = cmbLoanTypes.SelectedItem.ToString();

                // Get and display interest rate
                LoanInfo loanInfo = bankData[selectedBank][selectedLoanType];
                lblInterestRate.Text = $"{loanInfo.InterestRate}%";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!ValidateInputs())
                    return;

                // Get selected bank and loan type
                string selectedBank = cmbBanks.SelectedItem.ToString();
                string selectedLoanType = cmbLoanTypes.SelectedItem.ToString();
                LoanInfo loanInfo = bankData[selectedBank][selectedLoanType];

                // Parse input values
                decimal amount = decimal.Parse(txtAmount.Text);
                int period = int.Parse(txtPeriod.Text);

                // Convert period to months if needed
                int periodInMonths = period;
                if (cmbPeriodType.SelectedIndex == 0) // Years
                    periodInMonths = period * 12;

                // Get interest rate
                double interestRate = loanInfo.InterestRate;

                // Convert annual interest rate to monthly
                double monthlyRate = interestRate / 100 / 12;

                // Calculate monthly payment
                double monthlyPayment = CalculateMonthlyPayment(amount, monthlyRate, periodInMonths);

                // Calculate totals
                double totalPayment = monthlyPayment * periodInMonths;
                double totalInterest = totalPayment - (double)amount;

                // Get effective rate (EKS)
                double effectiveRate = loanInfo.EffectiveRate;

                // Display results
                lblMonthlyPayment.Text = $"{monthlyPayment:N2} RSD";
                lblTotalPayment.Text = $"{totalPayment:N2} RSD";
                lblTotalInterest.Text = $"{totalInterest:N2} RSD";
                lblEKS.Text = $"{effectiveRate:F2}%";

                // Enable payment plan button
                btnShowPlan.Enabled = true;

                // For debugging - these values can be examined
                Debug.WriteLine($"Iznos kredita: {amount}");
                Debug.WriteLine($"Mesečna rata: {monthlyPayment}");
                Debug.WriteLine($"Ukupna kamata: {totalInterest}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Molimo unesite ispravne brojeve za iznos i period.",
                    "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Unete vrednosti su prevelike.",
                    "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log exception for debugging
                Debug.WriteLine($"Exception: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        private double CalculateMonthlyPayment(decimal principal, double monthlyRate, int periodInMonths)
        {
            try
            {
                double principalAmount = (double)principal;

                // Formula for monthly payment: P = (Pv*r*(1+r)^n)/((1+r)^n-1)
                double numerator = principalAmount * monthlyRate * Math.Pow(1 + monthlyRate, periodInMonths);
                double denominator = Math.Pow(1 + monthlyRate, periodInMonths) - 1;

                return numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                // This would happen if monthlyRate is 0
                Debug.WriteLine("Greška pri deljenju: " + ex.Message);
                throw new Exception("Greška pri računanju mesečne rate: deljenje nulom.");
            }
        }

        private bool ValidateInputs()
        {
            // Check if bank and loan type are selected
            if (cmbBanks.SelectedIndex == -1 || cmbLoanTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo izaberite banku i tip kredita.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if amount is entered and valid
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Molimo unesite iznos kredita.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            // Check if period is entered and valid
            if (string.IsNullOrWhiteSpace(txtPeriod.Text))
            {
                MessageBox.Show("Molimo unesite period otplate.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeriod.Focus();
                return false;
            }

            // Try to parse amount
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Iznos kredita mora biti pozitivan broj.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            // Try to parse period
            if (!int.TryParse(txtPeriod.Text, out int period) || period <= 0)
            {
                MessageBox.Show("Period otplate mora biti pozitivan broj.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeriod.Focus();
                return false;
            }

            // Check if period exceeds maximum allowed
            string selectedBank = cmbBanks.SelectedItem.ToString();
            string selectedLoanType = cmbLoanTypes.SelectedItem.ToString();
            LoanInfo loanInfo = bankData[selectedBank][selectedLoanType];

            // If period type is years, check against max years
            if (cmbPeriodType.SelectedIndex == 0 && period > loanInfo.MaxYears)
            {
                MessageBox.Show($"Maksimalni period za {selectedLoanType} u {selectedBank} je {loanInfo.MaxYears} godina.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeriod.Focus();
                return false;
            }

            // If period type is months, convert to years and check
            if (cmbPeriodType.SelectedIndex == 1 && period > loanInfo.MaxYears * 12)
            {
                MessageBox.Show($"Maksimalni period za {selectedLoanType} u {selectedBank} je {loanInfo.MaxYears * 12} meseci.",
                    "Validacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeriod.Focus();
                return false;
            }

            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset input fields
            txtAmount.Clear();
            txtPeriod.Clear();

            // Reset result labels
            lblMonthlyPayment.Text = "0.00 RSD";
            lblTotalPayment.Text = "0.00 RSD";
            lblTotalInterest.Text = "0.00 RSD";
            lblEKS.Text = "0.00%";

            // Disable payment plan button
            btnShowPlan.Enabled = false;

            // Set focus to amount text box
            txtAmount.Focus();
        }

        private void btnShowPlan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs again (just to be safe)
                if (!ValidateInputs())
                    return;

                // Get loan details
                string selectedBank = cmbBanks.SelectedItem.ToString();
                string selectedLoanType = cmbLoanTypes.SelectedItem.ToString();
                LoanInfo loanInfo = bankData[selectedBank][selectedLoanType];

                decimal amount = decimal.Parse(txtAmount.Text);
                int period = int.Parse(txtPeriod.Text);

                // Convert period to months if needed
                int periodInMonths = period;
                if (cmbPeriodType.SelectedIndex == 0) // Years
                    periodInMonths = period * 12;

                // Get interest rate
                double interestRate = loanInfo.InterestRate;

                double monthlyRate = interestRate / 100 / 12;

                // Calculate monthly payment
                double monthlyPayment = CalculateMonthlyPayment(amount, monthlyRate, periodInMonths);

                // Show payment plan form
                ShowPaymentPlan(amount, monthlyRate, periodInMonths, monthlyPayment, selectedBank, selectedLoanType);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri prikazu plana otplate: {ex.Message}",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPaymentPlan(decimal principal, double monthlyRate, int periodInMonths,
            double monthlyPayment, string bankName, string loanType)
        {
            // Create a new form for payment plan
            Form paymentPlanForm = new Form
            {
                Text = $"Plan otplate kredita - {bankName} - {loanType}",
                Size = new Size(1200, 900),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.Sizable,  
                MaximizeBox = true 
            };

            // Create list view for payment schedule
            ListView listView = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Location = new Point(10, 10),
                Size = new Size(1200, 900),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // Add columns to list view
            listView.Columns.Add("Mesec", 70);
            listView.Columns.Add("Rata", 200);
            listView.Columns.Add("Glavnica", 200);
            listView.Columns.Add("Kamata", 200);
            listView.Columns.Add("Preostali dug", 200);

            // Calculate and populate payment schedule
            double balance = (double)principal;
            for (int month = 1; month <= periodInMonths; month++)
            {
                double interestPayment = balance * monthlyRate;
                double principalPayment = monthlyPayment - interestPayment;
                balance -= principalPayment;

                if (balance < 0.01) balance = 0;

                ListViewItem item = new ListViewItem(month.ToString());
                item.SubItems.Add($"{monthlyPayment:N2} RSD");
                item.SubItems.Add($"{principalPayment:N2} RSD");
                item.SubItems.Add($"{interestPayment:N2} RSD");
                item.SubItems.Add($"{balance:N2} RSD");

                listView.Items.Add(item);
            }

            // Add button to close the form
            Button closeButton = new Button
            {
                Text = "Zatvori",
                Location = new Point(500, 930),
                Size = new Size(100, 30),
                Anchor = AnchorStyles.Bottom
            };
            closeButton.Click += (s, e) => paymentPlanForm.Close();

            // Add controls to form
            paymentPlanForm.Controls.Add(listView);
            paymentPlanForm.Controls.Add(closeButton);

            // Show form
            paymentPlanForm.ShowDialog();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, decimal point and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace (no decimal for period)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}