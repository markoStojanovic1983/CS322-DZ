using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ07
{
    public partial class AddNewBookForm : Form
    {
        public string NewBookTitle { get; set; }
        public int NewBookAuthorId { get; set; }
        public string NewBookGenre { get; set; }
        public string NewBookISBN { get; set; }

        private List<Author> originalAuthors; 

        // Constructor to initialize the form with a list of authors
        public AddNewBookForm(List<Author> authors)
        {
            InitializeComponent();

            // Store the original authors list
            originalAuthors = authors;

            // Create a display list with names - Second Approach
            var authorDisplay = authors.Select(a => new
            {
                AuthorID = a.AuthorID,
                DisplayName = $"{a.FirstName} {a.LastName}"
            }).ToList();

            comboBoxAuthor.DataSource = authorDisplay;
            comboBoxAuthor.DisplayMember = "DisplayName";
            comboBoxAuthor.ValueMember = "AuthorID";
        }

        // Method to set existing values for updating
        public void SetExistingValues(string title, int authorId, string genre, string isbn)
        {
            textBoxTitle.Text = title;
            textBoxGenre.Text = genre;
            textBoxISBN.Text = isbn;
            comboBoxAuthor.SelectedValue = authorId;
        }

        // Event handler for saving the new or updated book details
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                comboBoxAuthor.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxGenre.Text) ||
                string.IsNullOrWhiteSpace(textBoxISBN.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewBookTitle = textBoxTitle.Text;
            NewBookAuthorId = (int)comboBoxAuthor.SelectedValue;
            NewBookGenre = textBoxGenre.Text;
            NewBookISBN = textBoxISBN.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Event handler for canceling the operation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}