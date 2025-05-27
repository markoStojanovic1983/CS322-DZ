using System;
using System.Windows.Forms;

namespace DZ09_4_5
{
    public partial class Form1 : Form
    {
        private int[] array;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArraySize.Text, out int size) && size > 0)
            {
                // Create and populate array with random numbers (1-100)
                array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = random.Next(1, 101); // Random numbers between 1 and 100
                }

                // Display numbers in ListBox
                lstNumbers.Items.Clear();
                foreach (int num in array)
                {
                    lstNumbers.Items.Add(num);
                }

                btnCalculate.Enabled = true;
                lblResults.Text = "Array created with random numbers. Select task from dropdown and click Calculate to see results.";
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for array size.");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (array != null && array.Length > 0)
            {
                if (cmbTask.SelectedIndex == 0) // Task 4
                {
                    // Calculate sum and average
                    double sum = 0;
                    foreach (int num in array)
                    {
                        sum += num;
                    }
                    double average = sum / array.Length;

                    // Display results
                    lblResults.Text = $"Task 4 Results:\n" +
                                    $"Sum: {sum}\n" +
                                    $"Average: {average:F2}";
                }
                else // Task 5
                {
                    // Find minimum and maximum
                    int min = array[0];
                    int max = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] < min) min = array[i];
                        if (array[i] > max) max = array[i];
                    }

                    // Display results
                    lblResults.Text = $"Task 5 Results:\n" +
                                    $"Minimum: {min}\n" +
                                    $"Maximum: {max}";
                }
            }
        }
    }
}