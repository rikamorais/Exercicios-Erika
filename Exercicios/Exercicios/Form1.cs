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
    public partial class mediaNotas : Form
    {
        public mediaNotas()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media, soma;

            soma = Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt3.Text)
                + Convert.ToDouble(txt4.Text);
            media = soma / 4;

            MessageBox.Show(Convert.ToString(media));
        }
    }
}
