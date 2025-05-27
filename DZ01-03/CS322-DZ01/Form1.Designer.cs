namespace CS322_DZ01
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
            nameTextInput = new TextBox();
            nameLabel = new Label();
            surnameLabel = new Label();
            surnnameTextInput = new TextBox();
            addressLabel = new Label();
            addressTextInput = new TextBox();
            confirmButton = new Button();
            maleRadioButton = new RadioButton();
            genderLabel = new Label();
            femaleRadioButton = new RadioButton();
            aboutYouTextSection = new RichTextBox();
            aboutLabel = new Label();
            educationListBox = new ListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            profilePictureBox = new PictureBox();
            uploadPictureButton = new Button();
            profilePictureLabel = new Label();
            educationLabel = new Label();
            otherLabel = new Label();
            otherListBox = new CheckedListBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // nameTextInput
            // 
            nameTextInput.Location = new Point(155, 48);
            nameTextInput.Name = "nameTextInput";
            nameTextInput.Size = new Size(281, 27);
            nameTextInput.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(110, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(34, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Ime";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(88, 102);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(62, 20);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Prezime";
            // 
            // surnnameTextInput
            // 
            surnnameTextInput.Location = new Point(155, 99);
            surnnameTextInput.Name = "surnnameTextInput";
            surnnameTextInput.Size = new Size(281, 27);
            surnnameTextInput.TabIndex = 3;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(95, 152);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(55, 20);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Adresa";
            // 
            // addressTextInput
            // 
            addressTextInput.Location = new Point(155, 149);
            addressTextInput.Name = "addressTextInput";
            addressTextInput.Size = new Size(281, 27);
            addressTextInput.TabIndex = 5;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(342, 927);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(94, 29);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Unesi";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(155, 198);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(68, 24);
            maleRadioButton.TabIndex = 8;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Muški";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(115, 200);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(29, 20);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Pol";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(155, 228);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(72, 24);
            femaleRadioButton.TabIndex = 11;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Ženski";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
            // 
            // aboutYouTextSection
            // 
            aboutYouTextSection.Location = new Point(155, 581);
            aboutYouTextSection.Name = "aboutYouTextSection";
            aboutYouTextSection.Size = new Size(281, 98);
            aboutYouTextSection.TabIndex = 12;
            aboutYouTextSection.Text = "";
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new Point(59, 581);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(91, 20);
            aboutLabel.TabIndex = 13;
            aboutLabel.Text = "Nešto o tebi";
            // 
            // educationListBox
            // 
            educationListBox.FormattingEnabled = true;
            educationListBox.Location = new Point(155, 270);
            educationListBox.Name = "educationListBox";
            educationListBox.Size = new Size(281, 144);
            educationListBox.TabIndex = 14;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(577, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(45, 24);
            fileToolStripMenuItem.Text = "Fajl";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(157, 26);
            openToolStripMenuItem.Text = "Otvori";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(157, 26);
            saveToolStripMenuItem.Text = "Snimi";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(157, 26);
            saveAsToolStripMenuItem.Text = "Snimi kao";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(157, 26);
            exitToolStripMenuItem.Text = "Izađi";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(71, 24);
            editToolStripMenuItem.Text = "Izmena";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(68, 24);
            helpToolStripMenuItem.Text = "Pomoć";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(144, 26);
            aboutUsToolStripMenuItem.Text = "O nama";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(155, 750);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(281, 156);
            profilePictureBox.TabIndex = 16;
            profilePictureBox.TabStop = false;
            // 
            // uploadPictureButton
            // 
            uploadPictureButton.Location = new Point(155, 702);
            uploadPictureButton.Name = "uploadPictureButton";
            uploadPictureButton.Size = new Size(281, 29);
            uploadPictureButton.TabIndex = 17;
            uploadPictureButton.Text = "Učitaj sliku";
            uploadPictureButton.UseVisualStyleBackColor = true;
            uploadPictureButton.Click += uploadPictureButton_Click;
            // 
            // profilePictureLabel
            // 
            profilePictureLabel.AutoSize = true;
            profilePictureLabel.Location = new Point(51, 706);
            profilePictureLabel.Name = "profilePictureLabel";
            profilePictureLabel.Size = new Size(93, 20);
            profilePictureLabel.TabIndex = 18;
            profilePictureLabel.Text = "Profilna slika";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new Point(51, 270);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new Size(93, 20);
            educationLabel.TabIndex = 19;
            educationLabel.Text = "Obrazovanje";
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Location = new Point(76, 439);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(68, 20);
            otherLabel.TabIndex = 20;
            otherLabel.Text = "Dodatno";
            // 
            // otherListBox
            // 
            otherListBox.FormattingEnabled = true;
            otherListBox.Location = new Point(155, 439);
            otherListBox.Name = "otherListBox";
            otherListBox.Size = new Size(281, 114);
            otherListBox.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 968);
            Controls.Add(otherListBox);
            Controls.Add(otherLabel);
            Controls.Add(educationLabel);
            Controls.Add(profilePictureLabel);
            Controls.Add(uploadPictureButton);
            Controls.Add(profilePictureBox);
            Controls.Add(educationListBox);
            Controls.Add(aboutLabel);
            Controls.Add(aboutYouTextSection);
            Controls.Add(femaleRadioButton);
            Controls.Add(genderLabel);
            Controls.Add(maleRadioButton);
            Controls.Add(confirmButton);
            Controls.Add(addressLabel);
            Controls.Add(addressTextInput);
            Controls.Add(surnameLabel);
            Controls.Add(surnnameTextInput);
            Controls.Add(nameLabel);
            Controls.Add(nameTextInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextInput;
        private Label nameLabel;
        private Label surnameLabel;
        private TextBox surnnameTextInput;
        private Label addressLabel;
        private TextBox addressTextInput;
        private Button confirmButton;
        private RadioButton maleRadioButton;
        private Label genderLabel;
        private RadioButton femaleRadioButton;
        private RichTextBox aboutYouTextSection;
        private Label aboutLabel;
        private ListBox educationListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private PictureBox profilePictureBox;
        private Button uploadPictureButton;
        private Label profilePictureLabel;
        private Label educationLabel;
        private Label otherLabel;
        private CheckedListBox otherListBox;
    }
}
