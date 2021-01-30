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
    public partial class parImpar : Form
    {
        public parImpar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);

            if (numero % 2 == 0)
            {
                MessageBox.Show("Número par");
            }
            else
            {
                MessageBox.Show("Número ímpar");
            }
        }
    }
}
