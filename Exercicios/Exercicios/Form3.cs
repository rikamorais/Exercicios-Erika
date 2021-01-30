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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);

            if (idade >= 18)
            {
                MessageBox("Idade maior que 18.");
            }
            else
            {
                MessageBox("Idade menor que 18.");
            }
        }
    }
}
