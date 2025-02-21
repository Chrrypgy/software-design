using System.Threading.Tasks;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
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
                return $"{Title} by {IssueNumber}";
            }


        }

        public class Ebook : Book
        {
            public string FileFormat { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Ebook in {FileFormat}) by {Author}";
            }
        }

        private List<Book> books = new List<Book>
        {
            new Book { Title = "C# Basics", Author = "John Smith" },
            new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 45 },
            new Ebook { Title = "Learn C#", Author = "Alice Brown", FileFormat = "PDF" }
        };


        private void btnshowInfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Book book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                string info = "";

                foreach (Book book in books)
                {
                    if (selectedText == book.GetInfo())
                    {
                        if (book is Magazine)
                        {
                            info = "Selected item is a Magazine: " + book.GetInfo();
                        }
                        else if (book is Ebook)
                        {
                            info = "Selected item is an Ebook: " + book.GetInfo();
                        }
                        else
                        {
                            info = "Selected item is a Book: " + book.GetInfo();
                        }
                        break;
                    }
                }
                MessageBox.Show(info);
            }
            else
            {
                MessageBox.Show("Please select a book from the list.");
            }
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            Lab3task3.Form1 form3 = new Lab3task3.Form1();
            form3.Show();
            this.Hide();
        }
    }
}
