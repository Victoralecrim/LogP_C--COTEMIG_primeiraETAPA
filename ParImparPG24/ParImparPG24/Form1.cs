using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParImparPG24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n; 

            n = int.Parse(textBox1.Text);


            if (n % 2 == 0)
            {
              txtresposta.Text = n + " é par";
              
            }
            else
            {
                txtresposta.Text = n + " é ímpar";
            }
        }
    }
}
