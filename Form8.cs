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

        public Form8()
        {
            InitializeComponent();
            Modalidade combo = new Modalidade();
            MySqlDataReader ler = combo.consultarModalidade01();

            while (ler.Read())
            {
                comboBox1.Items.Add(ler["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Modalidade modal = new Modalidade();
            modal.consultarModalidade();
            txtPrecoAtu.Enabled = false;
            txtQtdeAlunosAtu.Enabled = false;
            txtQtdeAulasAtu.Enabled = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(txtPrecoAtu.Text);
            int qtdeAluno = int.Parse(txtQtdeAlunosAtu.Text);
            int qtdeAulas = int.Parse(txtQtdeAulasAtu.Text);
            Modalidade modal = new Modalidade(comboBox1.Text, preco, qtdeAluno, qtdeAulas);
            if(modal.atualizarModalidade())
            {
                MessageBox.Show("Atualizado com Sucesso!");
            }
            else
            {
                MessageBox.Show("ERRO! Não foi possível atualizar");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(op == 1)
            {
                btnAtualizar.Enabled = false;
                btnReativar.Enabled = false;

            }
            if(op == 2)
            {
                Modalidade modal = new Modalidade(comboBox1.Text.ToString());
                MySqlDataReader res = modal.consultarModalidade01();

                while(res.Read())
                {
                    txtPrecoAtu.Text = res["precoModalidade"].ToString();
                    txtQtdeAlunosAtu.Text = res["qtdeAlunos"].ToString();
                    txtQtdeAulasAtu.Text = res["qtdeAulas"].ToString();
                    atual = comboBox1.Text;
                }
                DAO_Conexao.con.Close();
            }
        }

        private void btnReativar_Click(object sender, EventArgs e)
        {
            try
            {
                float preco = float.Parse(txtPrecoAtu.Text);
                int qtdeAluno = int.Parse(txtQtdeAlunosAtu.Text);
                int qtdeAulas = int.Parse(txtQtdeAulasAtu.Text);
                Modalidade modal = new Modalidade(comboBox1.Text, preco, qtdeAluno, qtdeAulas);
                if (modal.tornarAt())
                {
                    MessageBox.Show("Reativo!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!");
            }
            

        }
    }
}
