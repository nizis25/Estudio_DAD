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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    public partial class Form11 : Form
    {
        String atual = "";

        public Form11()
        {
            InitializeComponent();
            Modalidade modalidade = new Modalidade();
            MySqlDataReader r = modalidade.consultarModalidade01();
            while(r.Read())
            {
                cbbModalidade.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void cbbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDiaSemana.Items.Clear();
            cbbHora.Items.Clear();


            Turma turma = new Turma();
            int modalidade = turma.consultarIDModalidade01(cbbModalidade.Text);

            Turma tur = new Turma();
            MySqlDataReader read = tur.consultaModalidadeNaTurma(modalidade);
            while (read.Read())
            {
                cbbDiaSemana.Items.Add(read["diasemanaTurma"].ToString());
            }
                
            DAO_Conexao.con.Close();

            if (cbbDiaSemana.Items.Count == 0)
            {
                MessageBox.Show("Essa Turma NÃO existe!Por favor, escolha outra! :)");
                cbbDiaSemana.Enabled = false;
                cbbHora.Enabled = false;
                
            }
            else
            {
                cbbDiaSemana.Enabled = true;
                cbbHora.Enabled = true;
            }
        }



        private void Form11_Load(object sender, EventArgs e)
        {
            cbbDiaSemana.Enabled = false;
            txtProfessor.Enabled = false;
            txtMaxAlunos.Enabled = false;
            cbbDiaSemana.Enabled = false;
            cbbHora.Enabled = false;
        }

        private void cbbDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            MySqlDataReader read = turma.consultaDia(cbbDiaSemana.Text);
            while (read.Read())
            {
                cbbHora.Items.Add(read["horaTurma"].ToString());
            }
                    
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int m = turma.consultarIDModalidade(cbbModalidade.Text);

            Turma turma3 = new Turma();
            int c = turma3.consultarIDTurma(m, cbbHora.Text, cbbDiaSemana.Text);

            Turma turma2 = new Turma();
            MySqlDataReader read = turma2.consultaTurmaAtualizar(c);
            if (read.Read())
            {
                txtProfessor.Text = read["professorTurma"].ToString();
                txtMaxAlunos.Text = read["nalunosmatriculadosTurma"].ToString();
                txtProfessor.Enabled = false;
                txtMaxAlunos.Enabled = false;

            }
            else
            {
                MessageBox.Show("Turma não cadastrada!");
            }
            DAO_Conexao.con.Close();
        }
    }
}
