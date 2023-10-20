using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            if(opcao == 1)
            {
                if(aluno.cadastrarAluno())
                {
                    Messa
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
