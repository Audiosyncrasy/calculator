namespace calculator
{
    public partial class CalculatorForm : Form
    {
        private string _operatorClicked = "";
        private double _resultValue = 0;
        private bool _endOfCalcFlag = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            if (_endOfCalcFlag)
            {
                ClearAll();
                _endOfCalcFlag = false;
            }
            Button btn = (Button)sender;
            ClearZeroAndConcatIntExceptWhenDecimal(btn.Text);
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            if (_operatorClicked != "") return;
            Button button = (Button) sender;
            _operatorClicked = button.Text;

            _resultValue = double.Parse(resultBox.Text);
            resultTemp.Text = resultBox.Text;
            resultBox.Text = "0";
        }

        public double CalcSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double CalcDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double CalcQuotient(double num1, double num2)
        {
            return num1 / num2;
        }

        public double CalcProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public void ClearZeroAndConcatIntExceptWhenDecimal(string num)
        {
            if (returnResultBox().Text == "0" && num != ".")
            {
                resultBox.Clear();
            }

            returnResultBox().Text += num;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            _resultValue = 0;
            resultBox.Text = _resultValue.ToString();
            resultTemp.Text = "";
            _operatorClicked = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var num1 = _resultValue;
            var num2 = Double.Parse(resultBox.Text);
            resultTemp.Text += _operatorClicked + resultBox.Text + "=";

            switch (_operatorClicked)
            {
                case "+":
                    resultBox.Text = CalcSum(num1, num2).ToString();
                    break;
                case "-":
                    resultBox.Text = CalcDifference(num1, num2).ToString();
                    break;
                case "/":
                    resultBox.Text = CalcQuotient(num1, num2).ToString();
                    break;
                case "*":
                    resultBox.Text = CalcProduct(num1, num2).ToString();
                    break;
                default:
                    break;
            }

            _endOfCalcFlag = true;
        }
    }
}