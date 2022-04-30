using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag25Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n=int.Parse(textBox1.Text);

            if (n > 0)
            {
                label2.Text = "Positivo";
            }

            else if (n < 0)
            {
                label2.Text = "Negativo";
            }
            else
            {
                label2.Text = "Zero";
            }
        }
    }
}
