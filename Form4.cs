﻿using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    DialogResult res = MessageBox.Show("Deseja mesmo excluir?", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        aluno.excluirAluno();
                        MessageBox.Show("Aluno Excluído com sucesso!", "EXCLUÍDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            DAO_Conexao.con.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form4_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}



