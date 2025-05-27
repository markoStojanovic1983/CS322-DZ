namespace DZ09_4_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtArraySize = new TextBox();
            lblArraySize = new Label();
            btnCreateArray = new Button();
            lstNumbers = new ListBox();
            btnCalculate = new Button();
            lblResults = new Label();
            cmbTask = new ComboBox();
            lblTask = new Label();
            SuspendLayout();
            // 
            // txtArraySize
            // 
            txtArraySize.Location = new Point(249, 23);
            txtArraySize.Name = "txtArraySize";
            txtArraySize.Size = new Size(177, 39);
            txtArraySize.TabIndex = 3;
            // 
            // lblArraySize
            // 
            lblArraySize.Location = new Point(20, 26);
            lblArraySize.Name = "lblArraySize";
            lblArraySize.Size = new Size(223, 39);
            lblArraySize.TabIndex = 2;
            lblArraySize.Text = "Enter array size (n):";
            // 
            // btnCreateArray
            // 
            btnCreateArray.Location = new Point(20, 87);
            btnCreateArray.Name = "btnCreateArray";
            btnCreateArray.Size = new Size(409, 46);
            btnCreateArray.TabIndex = 4;
            btnCreateArray.Text = "Create Array";
            btnCreateArray.Click += btnCreateArray_Click;
            // 
            // lstNumbers
            // 
            lstNumbers.Location = new Point(20, 148);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(409, 164);
            lstNumbers.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Enabled = false;
            btnCalculate.Location = new Point(20, 376);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(409, 45);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResults
            // 
            lblResults.Location = new Point(20, 446);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(406, 145);
            lblResults.TabIndex = 7;
            lblResults.Text = "Results will appear here";
            // 
            // cmbTask
            // 
            cmbTask.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTask.Items.AddRange(new object[] { "Task 4", "Task 5" });
            cmbTask.Location = new Point(169, 323);
            cmbTask.Name = "cmbTask";
            cmbTask.Size = new Size(260, 40);
            cmbTask.TabIndex = 1;
            // 
            // lblTask
            // 
            lblTask.Location = new Point(20, 326);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(143, 37);
            lblTask.TabIndex = 0;
            lblTask.Text = "Select Task:";
            // 
            // Form1
            // 
            ClientSize = new Size(446, 617);
            Controls.Add(lblTask);
            Controls.Add(cmbTask);
            Controls.Add(lblArraySize);
            Controls.Add(txtArraySize);
            Controls.Add(btnCreateArray);
            Controls.Add(lstNumbers);
            Controls.Add(btnCalculate);
            Controls.Add(lblResults);
            Name = "Form1";
            Text = "DZ09";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtArraySize;
        private Label lblArraySize;
        private Button btnCreateArray;
        private ListBox lstNumbers;
        private Button btnCalculate;
        private Label lblResults;
        private ComboBox cmbTask;
        private Label lblTask;
    }
}