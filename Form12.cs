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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            Modalidade modal = new Modalidade();
            MySqlDataReader r = modal.consultarModalidade01();
            while (r.Read())
            {
                cbbModalidade.Items.Add(r["descricaoModalidade"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void cbbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHora.Items.Clear();
            cbbDiaSemana.Items.Clear();
            Turma turma = new Turma();
            int modalidade = turma.consultarIDModalidade01(cbbModalidade.Text);
            //DAO_Conexao.con.Close();

            Turma tr = new Turma();
            MySqlDataReader b = tr.consultarTurmaModalidade02(modalidade);
            while (b.Read())
            {
                cbbDiaSemana.Items.Add(b["diasemanaTurma"].ToString());
            }
                
            DAO_Conexao.con.Close();

            if (cbbDiaSemana.Items.Count == 0)
            {
                cbbDiaSemana.Enabled = false;
                cbbHora.Enabled = false;
                txtProfessor.Enabled = false;
                txtQtdMax.Enabled = false;
                MessageBox.Show("Turma inexistente. Selecione uma modalidade com turma.");
            }
            else
            {
                cbbDiaSemana.Enabled = true;
                cbbHora.Enabled = true;
            }
        }

        private void cbbDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int id = turma.consultarIDModalidade03(cbbModalidade.Text);
            MySqlDataReader b = turma.consultaDia02(cbbDiaSemana.Text, id);
            while(b.Read())
            {
                cbbHora.Items.Add(b["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cbbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int m = turma.consultarIDModalidade03(cbbModalidade.Text);
            int c = turma.consultarIDTurma(m, cbbHora.Text, cbbDiaSemana.Text);
            MySqlDataReader r = turma.consultaTurmaAtualizar01(c);
            if (r.Read())
            {
                txtProfessor.Text = r["professorTurma"].ToString();
                txtQtdMax.Text = r["nalunosmatriculadosTurma"].ToString();
                txtProfessor.Enabled = true;
                txtQtdMax.Enabled = true;
            }
            DAO_Conexao.con.Close();

            if (turma.consultarAtivas(c) == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbbHora.Items.Clear();
            cbbDiaSemana.Items.Clear();
            Turma turma = new Turma();
            int m = turma.consultarIDModalidade01(cbbModalidade.Text);
            int c = turma.consultarIDTurma(m, cbbHora.Text, cbbDiaSemana.Text);

            if (turma.tornarAt(c))
            {
                MessageBox.Show("Modalidade ativa com Sucesso");
                button2.Enabled = false;
                txtProfessor.Enabled = true;
                txtQtdMax.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro ao ativar");
            }
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int consulta = turma.consultarIDModalidade(cbbModalidade.Text);
            int qtde = int.Parse(txtQtdMax.Text);
            string professor = txtProfessor.Text;
            Turma t;
             t = new Turma(consulta, professor, cbbDiaSemana.Text, cbbHora.Text, qtde);
            int mod = turma.consultarIDTurma(consulta, cbbHora.Text, cbbDiaSemana.Text);
            if (t.atualizarTurma(mod))
            {
                MessageBox.Show("Dados atualizados com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar");
            }
        }
    }
}
