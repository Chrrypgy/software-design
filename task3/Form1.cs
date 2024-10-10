
namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Fibonacci(int n) => (n <= 1) ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFibonacciInput.Text, out int n))
                lblFibonacciResult.Text = $"Fibonacci({n}) = {Fibonacci(n)}";
        }
        private int Power(int x, int n) => (n == 0) ? 1 : x * Power(x, n - 1);

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBase.Text, out int x) && int.TryParse(txtExponent.Text, out int n))
                lblPowerResult.Text = $"{x}^{n} = {Power(x, n)}";
        }
    }
}
