namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralShort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] shortNumbers = ProceduralShort(numbers);
            listBoxResults.DataSource = shortNumbers;
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
