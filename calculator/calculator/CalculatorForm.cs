namespace calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {

        }

        public int CalcSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}