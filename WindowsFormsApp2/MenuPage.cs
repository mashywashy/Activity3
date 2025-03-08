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
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OperatorsForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ArraysForm().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ConditionalsForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logged out", "success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new LoginForm().Show();
            this.Close();
        }
    }
}
