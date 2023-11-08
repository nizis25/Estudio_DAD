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
    public partial class Form7 : Form
    {
        public Form7()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade model = new Modalidade(comboBox1.Text);
            model.consultarModalidade();
            DAO_Conexao.con.Close();

            DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                model.excluirModalidade(comboBox1.Text);
                MessageBox.Show("Modalidade excluída com sucesso!", "EXCLUÍDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERRO ao excluir!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



