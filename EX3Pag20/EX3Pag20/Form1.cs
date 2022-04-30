using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3Pag20
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

        private void button2_Click(object sender, EventArgs e)
        {
            int A, B, resultado;

            //Entrada de dados:

            A = int.Parse(txtA.Text);
            B= int.Parse(txtB.Text);

           

            //Criando as condições:

            if (A == B)
            {
                resultado = (A + B);
                txtExibirResultado.Clear();
                txtExibirResultado.Text = resultado.ToString();
                
            }    

            else
            {
                resultado = (A*B);
                txtExibirResultado.Text = resultado.ToString();
                
            }
        }
    }
}
