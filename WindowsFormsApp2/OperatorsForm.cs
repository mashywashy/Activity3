using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OperatorsForm : Form
    {
        public OperatorsForm()
        {
            InitializeComponent();
            PopulateOperators();
        }

        private void PopulateOperators()
        {
            operators.Items.Add("Addition");
            operators.Items.Add("Subtraction");
            operators.Items.Add("Multiplication");
            operators.Items.Add("Division");
            operators.Items.Add("Modulo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(firstNum.Text, out double num1) || !double.TryParse(secondNum.Text, out double num2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            double output = 0;

            switch (operators.SelectedIndex)
            {
                case 0: // Addition
                    output = num1 + num2;
                    break;
                case 1: // Subtraction
                    output = num1 - num2;
                    break;
                case 2: // Multiplication
                    output = num1 * num2;
                    break;
                case 3: // Division
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    output = num1 / num2;
                    break;
                case 4: // Modulo
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    output = num1 % num2;
                    break;
                default:
                    MessageBox.Show("Please select an operator.");
                    return;
            }

            result.Text = output.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsAlphanumeric(firstWord.Text) && IsAlphanumeric(secondWord.Text))
            {
                finalWord.Text = firstWord.Text.Trim() + " " + secondWord.Text.Trim();
            }
            else
            {
                MessageBox.Show("Please enter only alphanumeric characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsAlphanumeric(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }
    }
}
