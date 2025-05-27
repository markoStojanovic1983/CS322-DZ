using System;
using System.IO;
using System.Windows.Forms;

namespace DZ12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select a text file to open"
            };

            // Show the dialog and check if user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Clear the rich text box
                    richTextBox1.Clear();

                    // Using statement for automatic resource cleanup of StreamReader
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        // Read file line by line
                        while ((line = reader.ReadLine()) != null)
                        {
                            richTextBox1.AppendText(line + Environment.NewLine);
                        }
                    } // StreamReader is automatically disposed here

                    // Ask user to save the file
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                        Title = "Save the text file"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Using statement for automatic resource cleanup of StreamWriter
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Get all text from the rich text box
                            string[] lines = richTextBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                            // Write each line to the file
                            foreach (string textLine in lines)
                            {
                                // Don't write empty lines at the end that might be added by RichTextBox
                                if (!(textLine == "" && Array.IndexOf(lines, textLine) == lines.Length - 1))
                                {
                                    writer.WriteLine(textLine);
                                }
                            }
                        } // StreamWriter is automatically disposed here

                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}