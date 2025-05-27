namespace DZ12_2
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadFile = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(235, 44);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(316, 46);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(83, 133);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(630, 783);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 974);
            Controls.Add(richTextBox1);
            Controls.Add(btnLoadFile);
            Name = "Form1";
            Text = "DZ12_2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcessFile;
        private RichTextBox richTextBox1;
        private Button btnLoadFile;
    }
}
