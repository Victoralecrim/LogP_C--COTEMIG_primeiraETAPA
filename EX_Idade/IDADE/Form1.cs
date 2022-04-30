using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDADE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            idade = int.Parse(txtIdade.Text);

            if (idade >= 18)
            {
               MessageBox.Show("É maior de idade");
            }
            else
            {
                MessageBox.Show("É menor de idade");
            }
        }
    }
}
