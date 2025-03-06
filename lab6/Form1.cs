using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; // ✅ Ensure you only use EF Core

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task AddBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                // Check if author already exists
                var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                    await context.SaveChangesAsync(); // Save new author first
                }

                // Add the book linked to the author
                var book = new Book { Title = bookTitle, AuthorID = author.AuthorID };
                context.Books.Add(book);
                await context.SaveChangesAsync(); // Save new book
            }
        }

        // 🔹 Event handler for the Add Book button
        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookTitle = txtBookTitle.Text.Trim();
            string authorName = txtAuthorName.Text.Trim();

            if (string.IsNullOrWhiteSpace(bookTitle) || string.IsNullOrWhiteSpace(authorName))
            {
                MessageBox.Show("Please enter both book title and author name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnAddBook.Enabled = false; // Disable button while saving
            try
            {
                await AddBookAsync(bookTitle, authorName);
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after saving
                txtBookTitle.Clear();
                txtAuthorName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAddBook.Enabled = true; // Re-enable button
            }
        }

        private async Task UpdateBookAsync(int bookId, string newTitle, string newAuthor)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);
                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update author if changed
                if (!string.IsNullOrEmpty(newAuthor) && book.Author.Name != newAuthor)
                {
                    var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == newAuthor);
                    if (author == null)
                    {
                        author = new Author { Name = newAuthor };
                        context.Authors.Add(author);
                        await context.SaveChangesAsync(); // Save new author
                    }
                    book.AuthorID = author.AuthorID;
                }

                book.Title = newTitle;
                await context.SaveChangesAsync(); // Save updated book details
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUpdateBookID.Text, out int bookId) && !string.IsNullOrWhiteSpace(txtUpdateBookTitle.Text))
            {
                btnUpdateBook.Enabled = false;
                await UpdateBookAsync(bookId, txtUpdateBookTitle.Text.Trim(), txtUpdateAuthorName.Text.Trim());
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdateBook.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid input. Ensure Book ID and Title are entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ✅ Entity Framework DbContext
        public class BookstoreContext : DbContext
        {
            public DbSet<Book> Books { get; set; } = null!;
            public DbSet<Author> Authors { get; set; } = null!;

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Your_Connection_String_Here"); // 🔹 Update with actual connection string
            }
        }

        // ✅ Book Entity
        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; } = string.Empty; // 🔹 Prevents null errors
            public int AuthorID { get; set; } // Foreign key
            public Author Author { get; set; } = null!;
        }

        // ✅ Author Entity
        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; } = string.Empty;
            public List<Book> Books { get; set; } = new List<Book>(); // Prevents null errors
        }
        private async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeleteBookID.Text, out int bookId))
            {
                btnDeleteBook.Enabled = false;
                await DeleteBookAsync(bookId);
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDeleteBook.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<List<string>> SearchBooksAsync(string title, IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress?.Report(50); // Simulate some progress
                await Task.Delay(500); // Simulated delay

                var books = await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(title))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                progress?.Report(100); // Completion
                return books;
            }
        }
        private async void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearchBookTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTitle))
            {
                MessageBox.Show("Enter a book title to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSearchBook.Enabled = false;
            progressBar.Value = 0;

            var progress = new Progress<int>(value => progressBar.Value = value);
            var books = await SearchBooksAsync(searchTitle, progress);

            listBoxBooks.Items.Clear();
            if (books.Count > 0)
            {
                listBoxBooks.Items.AddRange(books.ToArray());
            }
            else
            {
                listBoxBooks.Items.Add("No books found.");
            }

            btnSearchBook.Enabled = true;
        }
    }
}