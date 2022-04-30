using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX17Pag09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class program 
        {
            public double CalcDesconto(double total, double desconto)
            {
                return (total - desconto);
            }
        }
       
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            program obj = new program();

            int quantidade;
            double preco, total, desconto;

            //Entrada de dados:

            quantidade = int.Parse(txtQuantProd.Text);
            preco = double.Parse(txtValorProd.Text);

            //Processamento:
            total = quantidade * preco;

            if  (total > 200)
            {
                desconto = total * 15 / 100;
                total = obj.CalcDesconto(total, desconto);
            }

            txtExibirResultado.Text = total.ToString("C");

        }
    }
}
