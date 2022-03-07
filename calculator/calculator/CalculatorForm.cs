namespace calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            resultBox.Text += btn.Text;
        }

        public int CalcSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}