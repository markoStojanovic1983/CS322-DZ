namespace DZ07
{
    partial class AddNewBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxTitle = new TextBox();
            textBoxGenre = new TextBox();
            textBoxISBN = new TextBox();
            comboBoxAuthor = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 3;
            label4.Text = "ISBN:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(133, 19);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(364, 39);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(133, 116);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(364, 39);
            textBoxGenre.TabIndex = 5;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(133, 164);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(364, 39);
            textBoxISBN.TabIndex = 6;
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(133, 66);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(364, 40);
            comboBoxAuthor.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(309, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddNewBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 308);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboBoxAuthor);
            Controls.Add(textBoxISBN);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewBookForm";
            Text = "AddNewBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxTitle;
        private TextBox textBoxGenre;
        private TextBox textBoxISBN;
        private ComboBox comboBoxAuthor;
        private Button btnCancel;
        private Button btnSave;
    }
}