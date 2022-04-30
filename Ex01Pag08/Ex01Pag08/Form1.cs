using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01Pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int N1, N2, N3, soma;
            double mediaTotal, porcentagemN1, porcentagemN2, porcentagemN3;

            N1 = int.Parse(txtN1.Text);
            N2 = int.Parse(txtN2.Text);
            N3 = int.Parse(txtN3.Text); 

            soma = N1 + N3;
            mediaTotal = (N1 + N2 + N3)/3;
            porcentagemN1 = (N1 * 100) / mediaTotal;
            porcentagemN2 = (N2 * 100) / mediaTotal;
            porcentagemN3 = (N3 * 100) / mediaTotal;





        }
    }
}
