using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Salário de até 300, reajuste de 50%;
             Salários maiores que 300, reajuste de 30%.*/

            double salario = Convert.ToDouble(txtSalario.Text);
            double salarioAjustado = 0;

            if (salario <= 300)
            {
                salarioAjustado = salario * 1.5;
                MessageBox.Show(Convert.ToString(salarioAjustado));
            }
            else
            {
                salarioAjustado = salario * 1,3;
                MessageBox.Show(Convert.ToString(salarioAjustado));
            }
        }
    }
}
