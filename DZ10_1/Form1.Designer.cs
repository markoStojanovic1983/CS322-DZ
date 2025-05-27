namespace DZ10_1
{
    partial class Form1
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
            listBoxNumbers = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnStack = new Button();
            btnQueue = new Button();
            SuspendLayout();
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.Location = new Point(12, 15);
            listBoxNumbers.Margin = new Padding(3, 4, 3, 4);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(200, 524);
            listBoxNumbers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(228, 15);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 44);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 66);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnStack
            // 
            btnStack.Location = new Point(228, 118);
            btnStack.Margin = new Padding(3, 4, 3, 4);
            btnStack.Name = "btnStack";
            btnStack.Size = new Size(144, 44);
            btnStack.TabIndex = 3;
            btnStack.Text = "Stack Pop";
            btnStack.UseVisualStyleBackColor = true;
            btnStack.Click += btnStack_Click;
            // 
            // btnQueue
            // 
            btnQueue.Location = new Point(228, 169);
            btnQueue.Margin = new Padding(3, 4, 3, 4);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(144, 44);
            btnQueue.TabIndex = 4;
            btnQueue.Text = "Queue Dequeue";
            btnQueue.UseVisualStyleBackColor = true;
            btnQueue.Click += btnQueue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 566);
            Controls.Add(btnQueue);
            Controls.Add(btnStack);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(listBoxNumbers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "DZ10_1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnQueue;
    }
}