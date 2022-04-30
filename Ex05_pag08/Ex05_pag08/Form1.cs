using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05_pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            int BaseR, alturaR, Area;

             alturaR = int.Parse(txtaltura.Text);
             BaseR = int.Parse(txtBase.Text);
            Area = BaseR * alturaR;

            txtExibirArea.Text = Area.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int AlturaR, BaseR, Perimetro;
            
            AlturaR = int.Parse(txtaltura.Text);
            BaseR = int.Parse(txtBase.Text);
            Perimetro = int.Parse(txtExibirArea.Text);
            Perimetro = 2 * (BaseR + AlturaR);
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
