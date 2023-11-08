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
    public partial class Form8 : Form
    {
        int op = 0;
        String atual = "";

        public Form8(int p)
        {
            InitializeComponent();
            Modalidade combo = new Modalidade();
            MySqlDataReader ler = null;
            label5.Visible = false;
            txtNova.Visible = false;

            if (p == 2) //consultar
            {
                op = 1;
                ler = combo.consultarModalidade01();
                btnAtualizar.Visible = false;
                btnReativar.Visible = false;
            }
            else op = 2;

            if (p == 1)
            {
                ler = combo.consultaTudo();
                label5.Visible = true;
                txtNova.Visible = true;
            }

            while (ler.Read())
            {
                comboBox1.Items.Add(ler["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (op == 1)
            {
                txtPrecoAtu.Enabled = false;
                txtQtdeAlunosAtu.Enabled = false;
                txtQtdeAulasAtu.Enabled = false;
            }

            else
            {
                txtPrecoAtu.Enabled = true;
                txtQtdeAlunosAtu.Enabled = true;
                txtQtdeAulasAtu.Enabled = true;
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                float preco = float.Parse(txtPrecoAtu.Text);
                int qtdeAluno = int.Parse(txtQtdeAlunosAtu.Text);
                int qtdeAulas = int.Parse(txtQtdeAulasAtu.Text);
                string descricao = comboBox1.Text;
                Modalidade modal = new Modalidade(descricao, preco, qtdeAluno, qtdeAulas);
                if (modal.consultarAtivas() == 0)
                {
                    if (modal.atualizarModalidade(descricao))
                    {
                        MessageBox.Show("Atualizado com Sucesso!", "ATUALIZADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox1.Text = "";
                        txtPrecoAtu.Text = "";
                        txtQtdeAlunosAtu.Text = "";
                        txtQtdeAulasAtu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("ERRO! Não foi possível atualizar", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReativar_Click(object sender, EventArgs e)
        {

            float preco = float.Parse(txtPrecoAtu.Text);
            int qtdeAluno = int.Parse(txtQtdeAlunosAtu.Text);
            int qtdeAulas = int.Parse(txtQtdeAulasAtu.Text);
            Modalidade modal = new Modalidade(comboBox1.Text, preco, qtdeAluno, qtdeAulas);
            MySqlDataReader r = modal.consultarModalidade03();
            if (r.Read())
            {
                DAO_Conexao.con.Close();

                if (modal.tornarAt())
                {
                    MessageBox.Show("Reativo!", "REATIVADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro:(", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Modalidade não encontrada", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (op == 1) //consultar
            {
                Modalidade modal = new Modalidade(comboBox1.Text.ToString());
                MySqlDataReader res = modal.consultarModalidade02(comboBox1.Text);

                while (res.Read())
                {
                    txtPrecoAtu.Text = res["precoModalidade"].ToString();
                    txtQtdeAlunosAtu.Text = res["qtdeAlunos"].ToString();
                    txtQtdeAulasAtu.Text = res["qtdeAulas"].ToString();

                    atual = comboBox1.Text;
                }
                DAO_Conexao.con.Close();

            }
            if (op == 2)//atualizar
            {
                btnAtualizar.Visible = true;
                string mod = comboBox1.Text;
                Modalidade modal = new Modalidade(mod.ToString());
                MySqlDataReader res = modal.consultarModalidade02(mod);

                while (res.Read())
                {

                    txtPrecoAtu.Text = res["precoModalidade"].ToString();
                    txtQtdeAlunosAtu.Text = res["qtdeAlunos"].ToString();
                    txtQtdeAulasAtu.Text = res["qtdeAulas"].ToString();

                    atual = comboBox1.Text;
                }
                DAO_Conexao.con.Close();
                Console.WriteLine(modal.consultarAtivas());
                if (modal.consultarAtivas() == 1)
                {
                    btnReativar.Enabled = true;
                }
                txtNova.Text = comboBox1.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}



