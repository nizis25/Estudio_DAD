using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if(e.KeyChar == 13)
            {
                dgvTurma.Rows.Clear();
                AlunoTurma alT = new AlunoTurma();
                if (option == 0)
                {
                    if (alT.verificaAluno(txtCPF.Text))
                    {
                        Turma t = new Turma();
                        MySqlDataReader r = t.todas();
                        while (r.Read())
                        {
                            int id = int.Parse(r["idEstudio_Turma"].ToString());
                            int mod = int.Parse(r["idModalidade"].ToString());
                            string ds = r["diasemanaTurma"].ToString();
                            string hr = r["horaTurma"].ToString();
                            dgvTurma.Rows.Add(id, mod, ds, hr);
                        }
                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro na busca: aluno não cadastrado.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (option == 1)
                {
                }
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            
        }
    }
}
