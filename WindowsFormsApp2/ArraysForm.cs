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
    public partial class ArraysForm : Form
    {
        private List<int> numsArr= new List<int>();
        private List<string> wordsArr = new List<string>();
        public ArraysForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(num.Text, out int parsedNum)) // Ensure valid integer input
            {
                numsArr.Add(parsedNum); // Add parsed integer to list
                MessageBox.Show($"Number {parsedNum} added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Locate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Locate is clicked!");
            if (int.TryParse(numToLocate.Text, out int parsedNum)) // Ensure valid integer input
            {
                containsResult.Text = numsArr.Contains(parsedNum)
                    ? $"Number {parsedNum} is an element of the array."
                    : $"Number {parsedNum} is not an element.";

                largestResult.Text = $"The largest number is {GetLargest()}";
                smallestResult.Text = $"The smallest number is {GetSmallest()}";
                sumResult.Text = $"The sum of the array is {GetSum()}";
                meanResult.Text = $"The mean of the array is {GetMean()}";

                containsResult.Refresh();
                largestResult.Refresh();
                smallestResult.Refresh();
                sumResult.Refresh();
                meanResult.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetLargest()
        {
            return numsArr.Count > 0 ? numsArr.Max() : 0;
        }

        private int GetSmallest()
        {
            return numsArr.Count > 0 ? numsArr.Min() : 0;
        }

        private int GetSum()
        {
            return numsArr.Sum();
        }

        private double GetMean()
        {
            return numsArr.Count > 0 ? numsArr.Average() : 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuPage().Show();
            this.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string word = textBox4.Text.Trim();

            if (!string.IsNullOrEmpty(word))
            {
                wordsArr.Add(word); // Add word to list
                MessageBox.Show($"Word '{word}' added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid word.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wordToLocate = textBox3.Text.Trim();

            if (!string.IsNullOrEmpty(wordToLocate))
            {
                label9.Text = wordsArr.Contains(wordToLocate)
                    ? $"'{wordToLocate}' is an element of the array."
                    : $"'{wordToLocate}' is not an element of the array.";

                label10.Text = $"There are {wordsArr.Count} words in the array";

                label9.Refresh();
                label10.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter a valid word to locate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
