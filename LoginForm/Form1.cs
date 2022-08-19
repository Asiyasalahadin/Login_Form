using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "Asiya" && textBox2.Text !="admin")
            {
                MessageBox.Show("INCORRECT USERNAME OR PASSWORD");
            }
            else
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
        }
    }
}
