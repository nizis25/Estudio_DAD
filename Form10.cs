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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Turma t = new Turma();
            MySqlDataReader p = t.consultarTodas();
            while (p.Read())
            {
                cbbModalidade.Items.Add(p["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            int modalidadeTurma = turma.consultarIDModalidade(cbbModalidade.Text);

            Turma turmaConsultaTodas = new Turma(modalidadeTurma);
            turmaConsultaTodas.todas();

            DAO_Conexao.con.Close();

            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                turmaConsultaTodas.excluirTurma();
                MessageBox.Show("Turma excluída com sucesso! :)", "EXCLUÍDA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("ERRO ao excluir! :(", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            string hora = cbbDia.Text;
            MySqlDataReader hr = turma.consultaHora(hora);
            DAO_Conexao.con.Close();
        }

        private void cbbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHora.Items.Clear();
            cbbHora.Text = "";
            Turma turma = new Turma();
            string mod = cbbModalidade.Text;
            string diaSemana = cbbDia.Text;
            MySqlDataReader dia = turma.consultaDia01(diaSemana, mod);
            while (dia.Read())
            {
                cbbHora.Items.Add(dia["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cbbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHora.Items.Clear();
            cbbHora.Text = "";
            cbbDia.Items.Clear();
            cbbDia.Text = "";

            Turma turma = new Turma();
            int modalidade = turma.consultarIDModalidade(cbbModalidade.Text);
            MySqlDataReader modal = turma.consultaModalidadeNaTurma01(modalidade);
            while (modal.Read())
            {
                cbbDia.Items.Add(modal["diasemanaTurma"].ToString());
            }
            DAO_Conexao.con.Close();

            if (cbbDia.Items.Count == 0)
            {
                MessageBox.Show("Turma INEXISTENTE! Selecione outra :)");
                cbbDia.Enabled = false;
                cbbHora.Enabled = false;
            }
            else
            {
                cbbDia.Enabled = true;
                cbbHora.Enabled = true;
            }
        }

    }
}



