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
            ConcatIntExceptWhenZero(btn.Text);
        }

        public int CalcSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public void ConcatIntExceptWhenZero(string num)
        {
            if (returnResultBox().Text != "0")
            {
                resultBox.Text += num;
            }
            else
            {
                resultBox.Text = num;
            }
        }
    }
}