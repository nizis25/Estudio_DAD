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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202203", "cl202203", "cl*25042007"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CADASTRAR ALUNO
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SAIR
            Application.Exit();
        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);

            if (tipo == 0)
            {
                MessageBox.Show("Usuário/Senha Inválidos! :( ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM >:D ", "BEM-VINDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }

            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito :O ", "BEM-VINDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                //ALUNO - TODOS

                //MODALIDADE - APENAS O CONSULTAR ATIVO
                cadastrarModalidadeToolStripMenuItem.Visible = false;
                excluirModalidadeToolStripMenuItem.Visible = false;
                atualizarModalidadeToolStripMenuItem.Visible = false;

                //TURMA - APENAS O CONSULTAR ATIVO
                cadastrarTurmaToolStripMenuItem1.Visible = false;
                excluirTurmaToolStripMenuItem1.Visible = false;
                atualizarTurmaToolStripMenuItem.Visible = false;
            }

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /*private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CADASTRAR LOGIN
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXCLUIR ALUNO
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void cadastroModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CADASTRO MODALIDADE
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXCLUIR MODALIDADE
            Form7 f7 = new Form7();
            f7.MdiParent = this;
            f7.Show();
        }

        private void atualizarBuscarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ATUALIZAR MODALIDADE
            Form8 f8 = new Form8(1);
            f8.MdiParent = this;
            f8.Show();
        }

        private void buscarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BUSCAR MODALIDADE
            Form8 f8 = new Form8(2);
            f8.MdiParent = this;
            f8.Show();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CADASTRAR TURMA
            Form9 f9 = new Form9();
            f9.MdiParent = this;
            f9.Show();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXCLUIR TURMA
            Form10 f10 = new Form10();
            f10.MdiParent = this;
            f10.Show();
        }*/

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //SAIR
            Application.Exit();
        }

        private void cadastrarLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //CADASTRAR LOGIN
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //CADASTRAR ALUNO
            Form3 f3 = new Form3(0);
            f3.MdiParent = this;
            f3.Show();
        }

        private void excluirAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //EXCLUIR ALUNO
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CADASTRAR MODALIDADE
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //EXCLUIR MODALIDADE
            Form7 f7 = new Form7();
            f7.MdiParent = this;
            f7.Show();
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ATUALIZAR MODALIDADE
            Form8 f8 = new Form8(1);
            f8.MdiParent = this;
            f8.Show();
        }

        private void buscarModalidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //BUSCAR MODALIDADE
            Form8 f8 = new Form8(2);
            f8.MdiParent = this;
            f8.Show();
        }

        private void cadastrarTurmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CADASTRAR TURMA
            Form9 f9 = new Form9();
            f9.MdiParent = this;
            f9.Show();
        }

        private void excluirTurmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //EXCLUIR TURMA
            Form10 f10 = new Form10();
            f10.MdiParent = this;
            f10.Show();
        }

        private void consultarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //consultar turma
            Form11 f11 = new Form11();
            f11.MdiParent = this;
            f11.Show();
        }

        private void atualizarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Atualizar turma 
            Form12 f12 = new Form12();
            f12.MdiParent = this;
            f12.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SAIR ALUNO NA TURMA
            Application.Exit();
        }

        private void cadastrarAlunoNaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CADASTRAR ALUNO NA TURMA
            Form13 f13 = new Form13(0);
            f13.MdiParent = this;
            f13.Show();
        }
        private void buscarConsultarAlunoNaTurnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BUSCAR/CONSULTAR ALUNO NA TURMA
            Form14 f14 = new Form14();
            f14.MdiParent = this;
            f14.Show();
        }

        private void excluirAlunoNaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXCLUIR ALUNO NA TURMA
            Form13 f13 = new Form13(1);
            f13.MdiParent = this;
            f13.Show();
        }

        /*private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void atualizarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/

        private void buscarAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //BUSCAR ALUNO
            Form3 f3 = new Form3(1);
            f3.MdiParent = this;
            f3.Show();
        }

        private void atualizarAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //ATUALIZAR ALUNO
            Form3 f3 = new Form3(2);
            f3.MdiParent = this;
            f3.Show();
        }
    }
}



