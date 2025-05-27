using Microsoft.EntityFrameworkCore;

namespace DZ07
{
    public partial class DZ07 : Form
    {
        private DZ07Context context;
        private List<Author> authors;
        private List<Book> books;

        public DZ07()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }

        // Method to initialize the database context
        private void InitializeDatabase()
        {
            try
            {
                context = new DZ07Context();
                context.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load authors and books data into DataGridViews
        private void LoadData()
        {
            try
            {
                // Load authors
                authors = context.Authors.ToList();
                dataGridViewAuthors.DataSource = authors;

                // Hide ID column for authors
                if (dataGridViewAuthors.Columns.Contains("AuthorID"))
                    dataGridViewAuthors.Columns["AuthorID"].Visible = false;

                // Load books with author information
                books = context.Books.Include(b => b.Author).ToList();

                // Create display list for books
                var booksDisplay = books.Select(b => new
                {
                    BookID = b.BookID,
                    Title = b.Title,
                    AuthorName = b.Author != null ? $"{b.Author.FirstName} {b.Author.LastName}" : "Unknown Author",
                    Genre = b.Genre,
                    ISBN = b.ISBN
                }).ToList();

                dataGridViewBooks.DataSource = booksDisplay;

                // Hide BookID column
                if (dataGridViewBooks.Columns.Contains("BookID"))
                    dataGridViewBooks.Columns["BookID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for adding a new author
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            using (AddNewAuthorForm form = new AddNewAuthorForm())
            {
                form.Text = "Add New Author"; // Set title
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Author newAuthor = new Author
                        {
                            FirstName = form.NewAuthorFirstName,
                            LastName = form.NewAuthorLastName
                        };

                        context.Authors.Add(newAuthor);
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Author added!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
            }
        }

        //Event handler for updating an existing author
        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an author first!", "Warning");
                return;
            }

            Author selectedAuthor = (Author)dataGridViewAuthors.SelectedRows[0].DataBoundItem;

            using (AddNewAuthorForm form = new AddNewAuthorForm())
            {
                form.Text = "Update Author"; // Set title
                // Pre-fill with existing values
                form.SetExistingValues(selectedAuthor.FirstName, selectedAuthor.LastName);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedAuthor.FirstName = form.NewAuthorFirstName;
                        selectedAuthor.LastName = form.NewAuthorLastName;
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Author updated!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
            }
        }

        // Event handler for deleting an author
        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an author first!", "Warning");
                return;
            }

            Author selectedAuthor = (Author)dataGridViewAuthors.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Delete {selectedAuthor.FirstName} {selectedAuthor.LastName}?",
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Authors.Remove(selectedAuthor);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Author deleted!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

        // Event handler for adding a new book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (authors.Count == 0)
            {
                MessageBox.Show("Add authors first!", "Warning");
                return;
            }

            using (AddNewBookForm form = new AddNewBookForm(authors))
            {
                form.Text = "Add New Book"; // Set title
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Book newBook = new Book
                        {
                            Title = form.NewBookTitle,
                            AuthorID = form.NewBookAuthorId,
                            Genre = form.NewBookGenre,
                            ISBN = form.NewBookISBN
                        };

                        context.Books.Add(newBook);
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Book added!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
            }
        }

        // Event handler for updating an existing book
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book first!", "Warning");
                return;
            }

            // Get the selected row index to find the corresponding book
            int selectedIndex = dataGridViewBooks.SelectedRows[0].Index;
            Book selectedBook = books[selectedIndex]; 

            using (AddNewBookForm form = new AddNewBookForm(authors))
            {
                form.Text = "Update Book"; // Set title
                // Pre-fill with existing values
                form.SetExistingValues(selectedBook.Title, selectedBook.AuthorID,
                                     selectedBook.Genre, selectedBook.ISBN);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedBook.Title = form.NewBookTitle;
                        selectedBook.AuthorID = form.NewBookAuthorId;
                        selectedBook.Genre = form.NewBookGenre;
                        selectedBook.ISBN = form.NewBookISBN;
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Book updated!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
            }
        }

        // Event handler for deleting a book
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book first!", "Warning");
                return;
            }

            // Get the selected row index to find the corresponding book
            int selectedIndex = dataGridViewBooks.SelectedRows[0].Index;
            Book selectedBook = books[selectedIndex];

            if (MessageBox.Show($"Delete '{selectedBook.Title}'?",
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.Books.Remove(selectedBook);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Book deleted!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

       
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}