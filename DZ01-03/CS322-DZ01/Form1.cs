using System;
using System.IO;
using System.Windows.Forms;

namespace CS322_DZ01
{
    public partial class Form1 : Form
    {
        private string name = string.Empty;
        private string surname = string.Empty;
        private string address = string.Empty;
        private string gender = string.Empty;
        private string education = string.Empty;
        private string other = string.Empty;
        private string aboutYou = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Prepopulate educationListBox items
            educationListBox.Items.Add("Osnovna škola");
            educationListBox.Items.Add("Srednja škola");
            educationListBox.Items.Add("Osnovne stukovne studije");
            educationListBox.Items.Add("Osnovne akademske studije");
            educationListBox.Items.Add("Master studije");
            educationListBox.Items.Add("Doktorske studije");
            // Style educationListBox items
            educationListBox.Font = new Font("Arial", 9, FontStyle.Bold);
            educationListBox.ForeColor = Color.DarkBlue;

            // Prepopulate otherCheckedListBox
            otherListBox.Items.Add("Vozačka dozvola");
            otherListBox.Items.Add("Rad na računaru");
            otherListBox.Items.Add("Poznavanje stranih jezika");
            // Style otherCheckedListBox
            otherListBox.Font = new Font("Arial", 9, FontStyle.Bold);
            otherListBox.ForeColor = Color.DarkBlue;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            name = nameTextInput.Text.Trim(); // Variable that stores value from ime textbox and uses trim to avoid unnecessary space values
            surname = surnnameTextInput.Text.Trim(); // Variable that stores value from prezime textbox and uses trim to avoid unnecessary space values
            address = addressTextInput.Text.Trim(); // Variable that stores value from adresa textbox and uses trim to avoid unnecessary space values
            aboutYou = aboutYouTextSection.Text.Trim(); // Variable that stores the content of aboutYouTextSection

            // Validation for name input
            if (name.Split(' ').Length > 1 || name != "")
            {
                MessageBox.Show("Ime treba da se sastoji od jedne reči!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation for adress input
            if (address.Split(' ').Length <= 1)
            {
                MessageBox.Show("Adresa treba da se sastoji od više reči!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation for gender
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Molimo odaberite pol!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected education level
            if (educationListBox.SelectedItem != null)
            {
                education = educationListBox.SelectedItem.ToString() ?? string.Empty;
            }
            else
            {
                MessageBox.Show("Please select an education level!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Get the selected items from otherListBox
            var otherSelectedItems = otherListBox.CheckedItems.Cast<string>().ToList();

            other = string.Join(", ", otherSelectedItems);




            // Display data
            MessageBox.Show($"Ime: {name}\nPrezime: {surname}\nAdresa: {address}\nPol: {gender}\nObrazovanje: {education}\nDodatno: {other}\n" +
                $"O vama: {aboutYou}"
                , "Podaci", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Save data to a file
            try
            {
                using (StreamWriter writer = new StreamWriter("UnetiPodaci.txt", true)) // 'true' appends data to the file if it exists
                {
                    writer.WriteLine($"Ime: {name}");
                    writer.WriteLine($"Prezime: {surname}");
                    writer.WriteLine($"Adresa: {address}");
                    writer.WriteLine($"Pol: {gender}");
                    writer.WriteLine($"Nivo obrazovanja: {education}");
                    writer.WriteLine($"Dodatno: {other}");
                    writer.WriteLine($"O vama: {aboutYou}");
                    writer.WriteLine($"Vreme unosa: {DateTime.Now}");
                    writer.WriteLine(new string('-', 40));
                }

                MessageBox.Show("Podaci su uspešno upisani u fajl!", "Snimanje podataka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške pri upisu u fajl: {ex.Message}", "Snimanje podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = maleRadioButton.Text;
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = femaleRadioButton.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija za unos podataka o osobi", "O nama", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uploadPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    fileDialog.Title = "Odaberite sliku";

                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Bitmap profilePicture = new Bitmap(fileDialog.FileName))
                        {
                            profilePictureBox.Image = resizeImage(profilePicture, profilePictureBox.Width, profilePictureBox.Height);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom učitavanja slike: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image resizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
    }
}
