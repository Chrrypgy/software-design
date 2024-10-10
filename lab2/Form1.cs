using System.Threading.Tasks;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);

        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtinput.Text);
            int result = RecursiveFactorial(number);
            lblresult.Text = $"Factorial: {result}";
        }

        public int RecursiveSum (int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);

        }

        private void clcsum_Click(object sender, EventArgs e)
        {
            int[] numbers = sum.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            resultsum.Text = $"Sum: {result}";
        }

        private void task3_Click(object sender, EventArgs e)
        {
            task3.Form1 form3 = new task3.Form1();
            form3.Show();
            this.Hide();
        }

       
    }
}
