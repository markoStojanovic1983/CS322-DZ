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
    public partial class AddNewAuthorForm : Form
    {
        public string NewAuthorFirstName { get; set; }
        public string NewAuthorLastName { get; set; }

        // Constructor to initialize the form
        public AddNewAuthorForm()
        {
            InitializeComponent();
        }

        // Method to set existing values for updating an author
        public void SetExistingValues(string firstName, string lastName)
        {
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
        }

        // Event handler for saving the new or updated author details
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewAuthorFirstName = textBoxFirstName.Text;
            NewAuthorLastName = textBoxLastName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        // Event handler for canceling the operation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}