using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ConditionalsForm : Form
    {
        public ConditionalsForm()
        {
            InitializeComponent();
        }

        private float DetermineEquivalentGrade(int num)
        {
            // Check if number is within valid range
            if (num >= 0 && num <= 100)
            {
                if (num < 50)
                {
                    return 5.00f;
                }
                else if (num < 55.49)
                {
                    return 3.00f;
                }
                else if (num < 60.99)
                {
                    return 2.75f;
                }
                else if (num < 65.49)
                {
                    return 2.50f;
                }
                else if (num < 71.99)
                {
                    return 2.25f;
                }
                else if (num < 77.49)
                {
                    return 2.00f;
                }
                else if (num < 82.99)
                {
                    return 1.75f;
                }
                else if (num < 88.49)
                {
                    return 1.50f;
                }
                else if (num < 93.99)
                {
                    return 1.25f;
                }
                else
                {
                    return 1.00f;
                }
            }
            else
            {
                return 0.0f;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input before processing
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a grade value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            try
            {
                int grade = int.Parse(textBox1.Text);

                // Additional validation
                if (grade < 0 || grade > 100)
                {
                    MessageBox.Show("Grade must be between 0 and 100.", "Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                float res = DetermineEquivalentGrade(grade);
                result.Text = grade.ToString() + " is equivalent to " + res.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuPage().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate input before processing
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a day number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            try
            {
                int day = int.Parse(textBox2.Text);
                string res = day + " is " + DetermineWeekName(day);

                // Check if the result indicates invalid input
                if (res.StartsWith("Invalid"))
                {
                    MessageBox.Show(res, "Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }

                weekResult.Text = res;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DetermineWeekName(int day)
        {
            // Check if day is within valid range (1-7)
            if (day > 0 && day < 8)
            {
                switch (day)
                {
                    case 1:
                        return "Monday";
                    case 2:
                        return "Tuesday";
                    case 3:
                        return "Wednesday";
                    case 4:
                        return "Thursday";
                    case 5:
                        return "Friday";
                    case 6:
                        return "Saturday";
                    case 7:
                        return "Sunday";
                }
            }
            return "Invalid day. Please enter a number between 1 and 7.";
        }
    }
}