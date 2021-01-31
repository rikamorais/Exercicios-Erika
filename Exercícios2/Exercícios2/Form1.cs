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
    public partial class frmItema : Form
    {
        class Aluno
        {
            //Atributos
            public string Nome;
            public int Documento;
            public int RegistroMatricula;
            public string Turma;


            //Métodos
            public void nota()
            {
               
            }
            public void AssistirAula()
            {
             
            }
            public double media()
            {
                return 0;
            }

        }
        public frmItema()
        {
            InitializeComponent();
        }

        private void frmItema_Load(object sender, EventArgs e)
        {
        
        }
    }
}
