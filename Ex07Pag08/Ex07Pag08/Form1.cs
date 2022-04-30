using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07Pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculartotal_Click(object sender, EventArgs e)
        {
            int TotalCamisaP, TotalCamisaM, TotalCamisaG;
            double total;

            TotalCamisaP = int.Parse(txtCamisaP.Text);
            TotalCamisaM = int.Parse(txtCamisaM.Text);
            TotalCamisaG = int.Parse(txtCamisaG.Text);

            CalclTotalDecamisas objcalcula = new CalclTotalDecamisas();

            total = objcalcula.CalculaTotal(TotalCamisaP, TotalCamisaM, TotalCamisaG);

            txttotalCamisas.Text = total.ToString("C");


        }

       
    }
}
