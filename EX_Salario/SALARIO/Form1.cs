using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarãção de variaveis

            double Salario, SalarioR;
            string profissao;

            //Entrada de dados

            Salario = double.Parse(txtSalario.Text);
            profissao = comboProfissao.Text;

            //Processamento

            if (profissao == "Tecnico")
            {
                SalarioR = (1.5 * Salario);
            }

            else if (profissao == "Gerente")
            {
                SalarioR = (1.3 * Salario);
            }

            else
            {
                SalarioR = (1.1 * Salario);
            }

            lblexibirSal.Text = SalarioR.ToString();
        }

        private void comboProfissao_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
