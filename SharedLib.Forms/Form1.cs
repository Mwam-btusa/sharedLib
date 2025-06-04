using Shared.Lib.Services;

namespace SharedLib.Forms
{
    public partial class Form1 : Form
    {

        SharedCalculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new SharedCalculator();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            var num1 = double.Parse(txtNum1.Text);
            var num2 = double.Parse(txtNum2.Text);
            lblResultado.Text = calculator.Add(num1, num2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

        }
    }
}
