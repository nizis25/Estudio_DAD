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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            Turma cad = new Turma();
            MySqlDataReader r = cad.todas();
            while (r.Read())
            {
                //????
            }
            DAO_Conexao.con.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            txtNome.Enabled = false;    
        }
    }
}
