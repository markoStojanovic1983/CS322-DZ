namespace DZ15
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            cmbLoanTypes = new ComboBox();
            cmbBanks = new ComboBox();
            groupBox2 = new GroupBox();
            lblInterestRate = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbPeriodType = new ComboBox();
            txtPeriod = new TextBox();
            txtAmount = new TextBox();
            groupBox3 = new GroupBox();
            lblEKS = new Label();
            lblTotalInterest = new Label();
            lblTotalPayment = new Label();
            lblMonthlyPayment = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnReset = new Button();
            btnCalculate = new Button();
            btnShowPlan = new Button();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbLoanTypes);
            groupBox1.Controls.Add(cmbBanks);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Izbor Banke";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 55);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 3;
            label2.Text = "Tip kredita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 2;
            label1.Text = "Banka:";
            // 
            // cmbLoanTypes
            // 
            cmbLoanTypes.FormattingEnabled = true;
            cmbLoanTypes.Location = new Point(300, 92);
            cmbLoanTypes.Name = "cmbLoanTypes";
            cmbLoanTypes.Size = new Size(254, 40);
            cmbLoanTypes.TabIndex = 1;
            cmbLoanTypes.SelectedIndexChanged += cmbLoanTypes_SelectedIndexChanged;
            // 
            // cmbBanks
            // 
            cmbBanks.FormattingEnabled = true;
            cmbBanks.Location = new Point(6, 92);
            cmbBanks.Name = "cmbBanks";
            cmbBanks.Size = new Size(254, 40);
            cmbBanks.TabIndex = 0;
            cmbBanks.SelectedIndexChanged += cmbBanks_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblInterestRate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbPeriodType);
            groupBox2.Controls.Add(txtPeriod);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Location = new Point(20, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 252);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalji kredita";
            // 
            // lblInterestRate
            // 
            lblInterestRate.AutoSize = true;
            lblInterestRate.Location = new Point(476, 206);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(78, 32);
            lblInterestRate.TabIndex = 8;
            lblInterestRate.Text = "0.00%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 146);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 6;
            label5.Text = "Godine/Meseci:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 5;
            label4.Text = "Period otplate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 55);
            label3.Name = "label3";
            label3.Size = new Size(219, 32);
            label3.TabIndex = 4;
            label3.Text = "Iznos kredita (RSD):";
            // 
            // cmbPeriodType
            // 
            cmbPeriodType.FormattingEnabled = true;
            cmbPeriodType.Location = new Point(300, 138);
            cmbPeriodType.Name = "cmbPeriodType";
            cmbPeriodType.Size = new Size(254, 40);
            cmbPeriodType.TabIndex = 2;
            // 
            // txtPeriod
            // 
            txtPeriod.Location = new Point(300, 93);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(254, 39);
            txtPeriod.TabIndex = 1;
            txtPeriod.KeyPress += txtPeriod_KeyPress;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(300, 48);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(254, 39);
            txtAmount.TabIndex = 0;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEKS);
            groupBox3.Controls.Add(lblTotalInterest);
            groupBox3.Controls.Add(lblTotalPayment);
            groupBox3.Controls.Add(lblMonthlyPayment);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(20, 514);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(554, 237);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kalkulator kredita";
            // 
            // lblEKS
            // 
            lblEKS.AutoSize = true;
            lblEKS.Location = new Point(315, 188);
            lblEKS.Name = "lblEKS";
            lblEKS.Size = new Size(85, 32);
            lblEKS.TabIndex = 14;
            lblEKS.Text = "0.00 %";
            // 
            // lblTotalInterest
            // 
            lblTotalInterest.AutoSize = true;
            lblTotalInterest.Location = new Point(315, 141);
            lblTotalInterest.Name = "lblTotalInterest";
            lblTotalInterest.Size = new Size(109, 32);
            lblTotalInterest.TabIndex = 13;
            lblTotalInterest.Text = "0.00 RSD";
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.AutoSize = true;
            lblTotalPayment.Location = new Point(315, 95);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(109, 32);
            lblTotalPayment.TabIndex = 12;
            lblTotalPayment.Text = "0.00 RSD";
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.AutoSize = true;
            lblMonthlyPayment.Location = new Point(315, 50);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(109, 32);
            lblMonthlyPayment.TabIndex = 11;
            lblMonthlyPayment.Text = "0.00 RSD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 188);
            label9.Name = "label9";
            label9.Size = new Size(58, 32);
            label9.TabIndex = 10;
            label9.Text = "EKS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 141);
            label6.Name = "label6";
            label6.Size = new Size(185, 32);
            label6.TabIndex = 9;
            label6.Text = "Ukupna kamata:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 95);
            label7.Name = "label7";
            label7.Size = new Size(182, 32);
            label7.TabIndex = 8;
            label7.Text = "Ukupna otplata:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 50);
            label8.Name = "label8";
            label8.Size = new Size(161, 32);
            label8.TabIndex = 7;
            label8.Text = "Mesečna rata:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(181, 780);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 3;
            btnReset.Text = "Poništi";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(25, 780);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Izračunaj";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnShowPlan
            // 
            btnShowPlan.Enabled = false;
            btnShowPlan.Location = new Point(335, 780);
            btnShowPlan.Name = "btnShowPlan";
            btnShowPlan.Size = new Size(239, 46);
            btnShowPlan.TabIndex = 5;
            btnShowPlan.Text = "Prikaži plan otplate";
            btnShowPlan.UseVisualStyleBackColor = true;
            btnShowPlan.Click += btnShowPlan_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 206);
            label10.Name = "label10";
            label10.Size = new Size(184, 32);
            label10.TabIndex = 9;
            label10.Text = "Kamatna stopa: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 866);
            Controls.Add(btnShowPlan);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "DZ15";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbBanks;
        private Label label2;
        private Label label1;
        private ComboBox cmbLoanTypes;
        private GroupBox groupBox2;
        private ComboBox cmbPeriodType;
        private TextBox txtPeriod;
        private TextBox txtAmount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblInterestRate;
        private GroupBox groupBox3;
        private Label lblEKS;
        private Label lblTotalInterest;
        private Label lblTotalPayment;
        private Label lblMonthlyPayment;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnReset;
        private Button btnCalculate;
        private Button btnShowPlan;
        private Label label10;
    }
}
