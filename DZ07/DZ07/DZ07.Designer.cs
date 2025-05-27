namespace DZ07
{
    partial class DZ07
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
            tabControl1 = new TabControl();
            Authors = new TabPage();
            btnDeleteAuthor = new Button();
            btnUpdateAuthor = new Button();
            btnAddAuthor = new Button();
            dataGridViewAuthors = new DataGridView();
            Books = new TabPage();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnAddBook = new Button();
            dataGridViewBooks = new DataGridView();
            tabControl1.SuspendLayout();
            Authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).BeginInit();
            Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Authors);
            tabControl1.Controls.Add(Books);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 505);
            tabControl1.TabIndex = 0;
            // 
            // Authors
            // 
            Authors.Controls.Add(btnDeleteAuthor);
            Authors.Controls.Add(btnUpdateAuthor);
            Authors.Controls.Add(btnAddAuthor);
            Authors.Controls.Add(dataGridViewAuthors);
            Authors.Location = new Point(8, 46);
            Authors.Name = "Authors";
            Authors.Padding = new Padding(3);
            Authors.Size = new Size(934, 451);
            Authors.TabIndex = 0;
            Authors.Text = "Authors";
            Authors.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(695, 387);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(233, 46);
            btnDeleteAuthor.TabIndex = 3;
            btnDeleteAuthor.Text = "Delete Author";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnUpdateAuthor
            // 
            btnUpdateAuthor.Location = new Point(348, 387);
            btnUpdateAuthor.Name = "btnUpdateAuthor";
            btnUpdateAuthor.Size = new Size(233, 46);
            btnUpdateAuthor.TabIndex = 2;
            btnUpdateAuthor.Text = "Update Author";
            btnUpdateAuthor.UseVisualStyleBackColor = true;
            btnUpdateAuthor.Click += btnUpdateAuthor_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(6, 387);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(233, 46);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Add New Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // dataGridViewAuthors
            // 
            dataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthors.Location = new Point(6, 6);
            dataGridViewAuthors.Name = "dataGridViewAuthors";
            dataGridViewAuthors.RowHeadersWidth = 82;
            dataGridViewAuthors.Size = new Size(922, 350);
            dataGridViewAuthors.TabIndex = 0;
            // 
            // Books
            // 
            Books.Controls.Add(btnDeleteBook);
            Books.Controls.Add(btnUpdateBook);
            Books.Controls.Add(btnAddBook);
            Books.Controls.Add(dataGridViewBooks);
            Books.Location = new Point(8, 46);
            Books.Name = "Books";
            Books.Padding = new Padding(3);
            Books.Size = new Size(934, 451);
            Books.TabIndex = 1;
            Books.Text = "Books";
            Books.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(695, 387);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(233, 46);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(348, 387);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(233, 46);
            btnUpdateBook.TabIndex = 5;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(6, 387);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(233, 46);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add New Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(6, 6);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(922, 350);
            dataGridViewBooks.TabIndex = 0;
            // 
            // DZ07
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 529);
            Controls.Add(tabControl1);
            Name = "DZ07";
            Text = "DZ07";
            tabControl1.ResumeLayout(false);
            Authors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).EndInit();
            Books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Authors;
        private TabPage Books;
        private Button btnDeleteAuthor;
        private Button btnUpdateAuthor;
        private Button btnAddAuthor;
        private DataGridView dataGridViewAuthors;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private DataGridView dataGridViewBooks;
    }
}
