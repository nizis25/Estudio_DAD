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
        int option, idTurma, idMod;
        public Form13(int op)
        {
            InitializeComponent();
            option = op;

            if (option == 1)
            {
                btnCadastrar.Text = "EXCLUIR";
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgvTurma.Rows.Clear();
                AlunoTurma alT = new AlunoTurma();

                if (alT.verificaAluno(txtCPF.Text))
                {
                    //COMEÇO CADASTRAR
                    if (option == 0)
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
                    //FIM CADASTRAR

                    //COMEÇO EXLUIR
                    if (option == 1)
                    {
                        AlunoTurma altr = new AlunoTurma();
                        MySqlDataReader r = altr.verificaAlunoMatriculado(txtCPF.Text);
                        while (r.Read())
                        {
                            int id = int.Parse(r["idTurma"].ToString());
                            int mod = int.Parse(r["idModalidade"].ToString());
                            string ds = r["diasemanaTurma"].ToString();
                            string hr = r["horaTurma"].ToString();
                            dgvTurma.Rows.Add(id, mod, ds, hr);
                        }
                        DAO_Conexao.con.Close();
                    }
                    //FIM EXCLUIR
                }
                else
                {
                    MessageBox.Show("ERRO! Aluno não cadastrado.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvTurma.CurrentRow.Index;
            idTurma = int.Parse(dgvTurma[0, linha].Value.ToString());
            idMod = int.Parse(dgvTurma[1, linha].Value.ToString());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AlunoTurma altr = new AlunoTurma(txtCPF.Text, idTurma);

            if (option == 0)
            {
                Modalidade modal = new Modalidade();
                int maxAl = modal.buscaMaxAlModal(idMod);

                Turma turma = new Turma();
                int qtdeAl = turma.buscaMaxAl(idMod);

                if (maxAl > qtdeAl)
                {
                    if (altr.cadastrarAlunoTurma())
                    {
                        MessageBox.Show("Aluno cadastrado na Turma :D", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("NÃO FOI POSSÍVEL o cadastro na Turma '-'", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Quantidade máxima ATINGIDA ;(", "CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else

            if (option == 1)
            {
                DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    altr.excluirAlunoTurma();
                    MessageBox.Show("Aluno excluído da Turma :D", "EXCLUÍDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Aluno NÃO FOI excluído da Turma '-'", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}



