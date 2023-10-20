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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarModalidade01();
            while(r.Read())
            {
                comboBoxTurma.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string professor = txtProfessor.Text;
            string dia_semana = txtDSemana.Text;
            string hora = mkdHora.Text;
            string descricaoModalidade = comboBoxTurma.Text;

            Turma turma =  new Turma();
            if (string.IsNullOrEmpty(descricaoModalidade))
            {
                MessageBox.Show("Selecione uma Modalidade! :)");
                comboBoxTurma.Text = "";
                txtProfessor.Text = "";
                txtDSemana.Text = "";
                mkdHora.Text = "";
                txtNumMax.Text = "";
            }
            else
            {
                MessageBox.Show("ENTROU");
                int qtde_MaxAlunos = int.Parse(txtNumMax.Text);
                Turma turmaConsulta = new Turma();
                int modalidadeTurma = turmaConsulta.consultarIDModalidade(descricaoModalidade);
                MessageBox.Show("MANDANDO A DESCRICAO PARA O MÉTODOS");
                modalidadeTurma = turmaConsulta.consultarIDModalidade(txtNumMax.Text);
                Turma turmaCadastrar = new Turma(modalidadeTurma, dia_semana, hora, professor, qtde_MaxAlunos);
                if (turmaCadastrar.cadastrarTurma())
                {
                    MessageBox.Show("Cadastrado com Sucesso! :D");
                    comboBoxTurma.Text = "";
                    txtProfessor.Text = "";
                    txtDSemana.Text = "";
                    mkdHora.Text = "";
                    txtNumMax.Text = "";
                }
                else
                {
                    MessageBox.Show("Houve um erro :'(");
                }

            }


        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            comboBoxTurma.Text = row.Cells[0].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

