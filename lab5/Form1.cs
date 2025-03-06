using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public class Author
    {
        public int AuthorID { get; set; }
        public required string Name { get; set; }
        public virtual List<Book> Books { get; set; } = new(); // ? Collection initialization simplified
    }

    public class Book
    {
        public int BookID { get; set; }
        public required string Title { get; set; }
        public int AuthorID { get; set; }
        public virtual required Author Author { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) { }

        public static void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using var context = new BookstoreContext();
            var author = new Author { Name = authorName };
            var book = new Book { Title = bookTitle, Author = author };

            context.Authors.Add(author);
            context.Books.Add(book);
            context.SaveChanges();
        }

        public static List<string> GetBooksWithAuthors()
        {
            using var context = new BookstoreContext();
            return context.Books
                .Include(b => b.Author)
                .Select(b => $"{b.Title} by {b.Author.Name}")
                .ToList();
        }

        private void BtnAddBook_Click(object sender, EventArgs e) { }

        private void BtnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully");
        }

        private void BtnSearchBooks_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            var books = SearchBooksByAuthor(authorName);
            listBoxBooks.DataSource = books;
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            DeleteBook(bookId);
        }

        public static void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using var context = new BookstoreContext();
            var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
            if (book != null)
            {
                book.Title = newTitle;
                book.Author.Name = newAuthorName;
                context.SaveChanges();
            }
        }

        public static List<string> SearchBooksByAuthorByName(string authorName)

        {
            using var context = new BookstoreContext();
            return context.Books
                .Include(b => b.Author)
                .Where(b => b.Author.Name.Contains(authorName))
                .Select(b => $"{b.Title} by {b.Author.Name}")
                .ToList();
        }

        public static void DeleteBook(int bookId)
        {
            using var context = new BookstoreContext();
            var book = context.Books.Find(bookId);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }
    }
}
