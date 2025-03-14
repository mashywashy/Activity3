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


        private float determineEquivalentGrade(int num)
        {
            if (num >= 0 || num <= 100)
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
                else {
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
            string grade = textBox1.Text;
            float res = determineEquivalentGrade(int.Parse(textBox1.Text));
            result.Text = grade + " is equivalent to " + res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuPage().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox2.Text);
            string res = DetermineWeekName(day);
            weekResult.Text = res;

        }

        private string DetermineWeekName(int day)
        {
            if (day > 0 || day < 8)
            {
                switch (day)
                {
                    case 1:
                        return "Monday";
                        break;
                    case 2:
                        return "Tuesday";
                        break;
                    case 3:
                        return "Wednesday";
                        break;
                    case 4:
                        return "Thursday";
                        break;
                    case 5:
                        return "Friday";
                        break;
                    case 6:
                        return "Saturday";
                        break;
                    case 7:
                        return "Sunday";
                        break;
                    default:
                        return "Invalid day";
                        break;
                }
            }

            return "Invalid day";
        }
    }
}
