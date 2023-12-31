﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String descricao = txtDescricao.Text;
            float preco = float.Parse(txtPreco.Text);
            int qtdeAlunos = int.Parse(txtQtdeAlunos.Text);
            int qtdeAulas = int.Parse(txtQtdeAulas.Text);


            Modalidade modalidade = new Modalidade(descricao, preco, qtdeAlunos, qtdeAulas);

            if (Modalidade.consultaModal(descricao) == false)
            {
                if (modalidade.cadastrarModalidade())
                {
                    MessageBox.Show("Cadastrado com Sucesso! :D", "CADASTRADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricao.Text = "";
                    txtPreco.Text = "";
                    txtQtdeAlunos.Text = "";
                    txtQtdeAulas.Text = "";
                }
                else
                {
                    MessageBox.Show("Houve um erro :'(", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Já existe uma modalidade cadastrada com esta descrição. Por favor, escolha outro.", "CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Modalidade modalidade01 = new Modalidade(txtDescricao.Text);
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



