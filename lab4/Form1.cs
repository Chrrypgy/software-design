using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4
{
    [TestClass]
    public class BookTests
    {
        public class Book
        {
            public string Title { get; set; } = string.Empty;
            public string Author { get; set; } = string.Empty;

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public int FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Ebook, {FileSizeMB}MB)";
            }
        }

        [TestMethod]
        public void Book_GetInfo_ReturnsCorrectFormat()
        {
            var book = new Book { Title = "Test Title", Author = "Test Author" };

            var result = book.GetInfo();

            Assert.AreEqual("Test Title by Test Author", result);
        }

        [TestMethod]
        public void Book_TitleProperty_SetsAndGetsCorrectly()
        {
            var book = new Book { Title = "New Title", Author = "Default Author" };

            Assert.AreEqual("New Title", book.Title);
        }

        [TestMethod]
        public void Book_AuthorProperty_SetsAndGetsCorrectly()
        {
            var book = new Book { Title = "Default Title", Author = "New Author" };

            Assert.AreEqual("New Author", book.Author);
        }

        [TestClass]
        public class PolymorphismTests
        {
            [TestMethod]
            public void TestPolymorphism_GetInfo_Method()
            {
               
                Book[] books =
                {
                    new Book { Title = "Generic Book", Author = "John Smith" },
                    new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                    new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 }
                };

               
                Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
                Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
                Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
            }
        }
    }
}
