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
    public partial class Form13 : Form
    {
        int option;
        public Form13(int op)
        {
            InitializeComponent();
            option = op;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            AlunoTurma alT = new AlunoTurma();
            if (alT.verificaAluno(txtCPF.Text))
            {
                Turma t = new Turma();
            }
        }
    }
}
