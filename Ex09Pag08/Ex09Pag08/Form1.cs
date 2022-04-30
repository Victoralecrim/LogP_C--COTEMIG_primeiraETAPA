using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex09Pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double qntd_moeda1cent, qntd_moeda5cent, qntd_moeda10cent, qntd_moeda25cent, qntd_moeda50cent, qntd_moeda1R, total;
            qntd_moeda1cent = double.Parse(txtmoeda1cent.Text);
            qntd_moeda1cent = qntd_moeda1cent * (0.01);
            qntd_moeda5cent = double.Parse(txtmoeda5cent.Text);
            qntd_moeda5cent = qntd_moeda5cent * (0.05);
            qntd_moeda10cent = double.Parse(txtmoeda10cent.Text);
            qntd_moeda10cent = qntd_moeda10cent * (0.10);
            qntd_moeda25cent = double.Parse(txtmoeda25cent.Text);
            qntd_moeda25cent = qntd_moeda25cent * (0.25);
            qntd_moeda50cent = double.Parse(txtmoeda50cent.Text);
            qntd_moeda50cent = qntd_moeda50cent * (0.50);
            qntd_moeda1R = double.Parse(txtmoeda1R.Text);
            qntd_moeda1R = qntd_moeda1R * (1.00);
            total = qntd_moeda1cent + qntd_moeda5cent + qntd_moeda10cent + qntd_moeda25cent + qntd_moeda50cent + qntd_moeda1R;

            txttotal.Text = total.ToString("C");




        }
    }
}
