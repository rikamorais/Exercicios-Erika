using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios2
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            string oper = "";
            double resultado;

            try
            {
                num1 = Convert.ToDouble(txtNumero.Text);
                //MessageBox.Show("Informe o segundo número");
                //txtNumero.Text = "";
                //txtNumero.Focus();
                num2 = Convert.ToDouble(txtNumero2.Text);
                oper = txtOperacao.Text;
                if (oper == "+")
                {
                    resultado = num1 + num2;
                    lblResultado.Text = Convert.ToString(resultado);
                }
                else if (oper == "-")
                {
                    resultado = num1 - num2;
                    lblResultado.Text = Convert.ToString(resultado);
                }
                else if (oper == "*")
                {
                    resultado = num1 * num2;
                    lblResultado.Text = Convert.ToString(resultado);
                }
                else if (oper == "/")
                {
                    resultado = num1 / num2;
                    lblResultado.Text = Convert.ToString(resultado);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Erro!");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
