using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex10Pag09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração de variaveis

            int anoNasc,anoAtual, ano, meses, dias, semanas;

            //Entrada de dados

            anoNasc = int.Parse(txtanoNasc.Text);
            anoAtual = int.Parse(txtanoAtual.Text);

            ano = (anoAtual - anoNasc);
            meses = (ano * 12);
            dias = (ano * 365);
            semanas = (dias * 7);


                        



        }
    }
}
