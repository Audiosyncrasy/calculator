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
            ClearZeroAndConcatIntExceptWhenDecimal(btn.Text);
        }

        public int CalcSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public void ClearZeroAndConcatIntExceptWhenDecimal(string num)
        {
            if (returnResultBox().Text == "0" && num != ".")
            {
                resultBox.Clear();
            }

            returnResultBox().Text += num;
        }
    }
}