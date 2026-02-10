using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {

            if ((textBox_Result.Text == "0") || isOperationPerformed)
                textBox_Result.Clear();
            isOperationPerformed = false;

            string buttonText = ((Button)sender).Text;
            string decimalSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (buttonText == ".")
            {
                if (!textBox_Result.Text.Contains(decimalSep))
                    textBox_Result.Text = textBox_Result.Text + decimalSep;
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + buttonText;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string newOperation = button.Text;

            if (resultValue != 0 && !isOperationPerformed)
            {
                button19.PerformClick();
            }
            else
            {
                resultValue = double.Parse(textBox_Result.Text);
            }

            //operationPerformed = button.Text;
            //labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            //isOperationPerformed = true;

            operationPerformed = newOperation; // "+" or "-" or "*" or "÷" or "xʸ"
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "÷":
                    double divisor = double.Parse(textBox_Result.Text);
                    if (divisor == 0)
                    {
                        MessageBox.Show("Division par zéro impossible", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Result.Text = "0";
                        return;
                    }
                    textBox_Result.Text = (resultValue / divisor).ToString();
                    break;
                case "xʸ":
                    //textBox_Result.Text = (Math.Pow(resultValue, double.Parse(textBox_Result.Text))).ToString();
                    //break;
                    double exponent = double.Parse(textBox_Result.Text);
                    textBox_Result.Text = Math.Pow(resultValue, exponent).ToString();
                    break;


                default:
                    break;
            }
            //reinitialize values
            resultValue = double.Parse(textBox_Result.Text);
            operationPerformed = "";
            labelCurrentOperation.Text = "";
            isOperationPerformed = false;

        }

        private void parentheses_click(object sender, EventArgs e)
        {

            textBox_Result.Text = textBox_Result.Text + ((Button)sender).Text;
        }

        private void sqr_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);

            if (value < 0)
            {
                MessageBox.Show("Racine carrée impossible pour un nombre négatif",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox_Result.Text = Math.Sqrt(value).ToString();
            isOperationPerformed = true;
        }

        private void square_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);
            textBox_Result.Text = Math.Pow(value, 2).ToString();
            isOperationPerformed = true;
        }

        private void cube_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);
            textBox_Result.Text = Math.Pow(value, 3).ToString();
            isOperationPerformed = true;
        }

        private void sin_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);

            // conversion degrés → radians
            double radians = value * Math.PI / 180;

            double result = Math.Sin(radians);
            textBox_Result.Text = result.ToString();

            isOperationPerformed = true;
        }

        private void cos_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);

            double radians = value * Math.PI / 180;

            double result = Math.Cos(radians);
            textBox_Result.Text = result.ToString();

            isOperationPerformed = true;
        }

        private void ln_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);

            if (value <= 0)
            {
                MessageBox.Show("ln(x) est défini seulement pour x > 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox_Result.Text = Math.Log(value).ToString();
            isOperationPerformed = true;
        }

        private void tan_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);

            if (value == 90)
            {
                MessageBox.Show("tan(90°) n'est pas défini",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double radians = value * Math.PI / 180;

            double result = Math.Tan(radians);
            textBox_Result.Text = result.ToString();

            isOperationPerformed = true;
        }

        private void cubeRoot_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);
            textBox_Result.Text = Math.Cbrt(value).ToString();
            isOperationPerformed = true;

        }

        private void factorial_click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox_Result.Text);

            if (value < 0 || value != Math.Floor(value))
            {
                MessageBox.Show("Factorielle définie seulement pour les entiers ≥ 0",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = 1;
            for (int i = 1; i <= (int)value; i++)
                result *= i;

            textBox_Result.Text = result.ToString();
            isOperationPerformed = true;
        }

        private void e_click(object sender, EventArgs e)
        {
            textBox_Result.Text = Math.E.ToString();
            isOperationPerformed = true;
        }

        private void percent_click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(textBox_Result.Text);

            switch (operationPerformed)
            {
                case "+":
                case "-":
                case "*":
                case "÷":
                case "xʸ": // pour xʸ si tu veux
                          // Calcul relatif à resultValue
                    currentValue = resultValue * currentValue / 100;
                    break;
                default:
                    // Si aucune opération, juste diviser par 100
                    currentValue = currentValue / 100;
                    break;
            }

            textBox_Result.Text = currentValue.ToString();
            isOperationPerformed = true;
        }
    }
}