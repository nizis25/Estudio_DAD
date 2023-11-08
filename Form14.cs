using MySql.Data.MySqlClient;
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
    public partial class Form14 : Form
    {
        string cpf, nome;



        public Form14()
        {
            InitializeComponent();
            AlunoTurma at = new AlunoTurma();
            MySqlDataReader r = at.consultaTurmaMatricula();
            while (r.Read())
            {
                int id = int.Parse(r["idTurma"].ToString());
                int modalidade = int.Parse(r["idModalidade"].ToString());
                string diasemana = r["diasemanaTurma"].ToString();
                string hora = r["horaTurma"].ToString();

                dgvAlunoTurma.Rows.Add(id, modalidade, diasemana, hora);
            }
            DAO_Conexao.con.Close();
        }

        private void dgvAlunoTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAluno.Rows.Clear();
            int line = dgvAlunoTurma.CurrentRow.Index;
            int id = int.Parse(dgvAlunoTurma[0, line].Value.ToString());
            AlunoTurma at = new AlunoTurma();
            MySqlDataReader r = at.buscaAlunoTurma(id);
            while(r.Read())
            {
                string cpf = r["CPFAluno"].ToString();
                string nome = r["nomeAluno"].ToString();
                dgvAluno.Rows.Add(cpf, nome);
            }
            DAO_Conexao.con.Close();
        }
    }
}



