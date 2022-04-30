using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class calcularmedia
        {
            public double CalcMedia(double N1, double N2)
            {
                return (N1 + N2) / 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração de variaveis
            double N1, N2, MEDIA;

            //Entrada de dados:
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);

            //Processamento

            calcularmedia obj = new calcularmedia();

            MEDIA = obj.CalcMedia(N1,N2);

            txtExibirResult.Text = obj.CalcMedia(N1,N2).ToString();



            if (MEDIA >= 7)
            {
                MessageBox.Show("Aprovado");
            }

            else
            {
                MessageBox.Show("Reprovado");
            }

        }
    }
}
