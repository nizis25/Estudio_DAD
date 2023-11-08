using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    public partial class Form3 : Form
    {
        int option;
        public Form3(int op)
        {
            InitializeComponent();
            option = op;

            if (option == 0)
            {
                button3.Visible = false;
                txtNome.Enabled = false;
                txtEnd.Enabled = false;
                txtNum.Enabled = false;
                txtBairro.Enabled = false;
                txtComple.Enabled = false;
                mkdCEP.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
                mkdTel.Enabled = false;
                txtEmail.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }

            if (option == 1)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                txtNome.Enabled = false;
                txtEnd.Enabled = false;
                txtNum.Enabled = false;
                txtBairro.Enabled = false;
                txtComple.Enabled = false;
                mkdCEP.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
                mkdTel.Enabled = false;
                txtEmail.Enabled = false;
            }

            if (option == 2)
            {
                button1.Visible = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mkdCPF.Text, txtNome.Text, txtEnd.Text, txtNum.Text, txtBairro.Text, txtComple.Text, mkdCEP.Text, txtCidade.Text, txtEstado.Text, mkdTel.Text, txtEmail.Text, foto);

            if (aluno.verificaCPF())
            {
                if (aluno.consultarAluno() == false)
                {
                    if (aluno.cadastrarAluno())
                    {
                        mkdCPF.Text = "";
                        txtNome.Text = "";
                        txtEnd.Text = "";
                        txtNum.Text = "";
                        txtBairro.Text = "";
                        txtComple.Text = "";
                        mkdCEP.Text = "";
                        txtCidade.Text = "";
                        txtEstado.Text = "";
                        mkdTel.Text = "";
                        txtEmail.Text = "";
                        pictureBox1.Image = null;
                        MessageBox.Show("Cadastrado com Sucesso! :D", "CADASTRADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro :'(", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado: Aluno já cadastrado.", "Lamentamos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O CPF não é valido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Aluno aluno01 = new Aluno(mkdCPF.Text);

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                Aluno aluno = new Aluno(mkdCPF.Text);

                //COMEÇO CADASTRAR
                if (option == 0)
                {
                    if (aluno.consultarAluno())
                    {
                        txtNome.Enabled = false;
                        txtEnd.Enabled = false;
                        txtNum.Enabled = false;
                        txtBairro.Enabled = false;
                        txtComple.Enabled = false;
                        mkdCEP.Enabled = false;
                        txtCidade.Enabled = false;
                        txtEstado.Enabled = false;
                        mkdTel.Enabled = false;
                        txtEmail.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        MessageBox.Show("ERRO! Esse CPF já existe! Por favor, digite outro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtNome.Enabled = true;
                        txtEnd.Enabled = true;
                        txtNum.Enabled = true;
                        txtBairro.Enabled = true;
                        txtComple.Enabled = true;
                        mkdCEP.Enabled = true;
                        txtCidade.Enabled = true;
                        txtEstado.Enabled = true;
                        mkdTel.Enabled = true;
                        txtEmail.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                    }
                }
                //FIM CADASTRAR

                //COMEÇO BUSCAR
                if (option == 1)
                {
                    if (aluno.consultarAluno())
                    {
                        MySqlDataReader r = aluno.consultarAluno01();
                        while (r.Read())
                        {
                            txtNome.Text = r["nomeAluno"].ToString();
                            txtEnd.Text = r["ruaAluno"].ToString();
                            txtNum.Text = r["numeroAluno"].ToString();
                            txtBairro.Text = r["bairroAluno"].ToString();
                            txtComple.Text = r["complementoAluno"].ToString();
                            mkdCEP.Text = r["CEPAluno"].ToString();
                            txtCidade.Text = r["cidadeAluno"].ToString();
                            txtEstado.Text = r["estadoAluno"].ToString();
                            mkdTel.Text = r["telefoneAluno"].ToString();
                            txtEmail.Text = r["emailAluno"].ToString();
                            try
                            {
                                string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                                byte[] bimage = (byte[])r["fotoAluno"];
                                FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                                fs.Write(bimage, 0, bimage.Length - 1);
                                fs.Close();
                                pictureBox1.Image = Image.FromFile(imagem);
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao carregar a foto", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aluno não cadastrado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                //FIM BUSCAR

                //COMEÇO ATUALIZAR
                if (option == 2)
                {
                    if (aluno.consultarAluno())
                    {
                        MySqlDataReader r = aluno.consultarAluno01();
                        while (r.Read())
                        {
                            txtNome.Text = r["nomeAluno"].ToString();
                            txtEnd.Text = r["ruaAluno"].ToString();
                            txtNum.Text = r["numeroAluno"].ToString();
                            txtBairro.Text = r["bairroAluno"].ToString();
                            txtComple.Text = r["complementoAluno"].ToString();
                            mkdCEP.Text = r["CEPAluno"].ToString();
                            txtCidade.Text = r["cidadeAluno"].ToString();
                            txtEstado.Text = r["estadoAluno"].ToString();
                            mkdTel.Text = r["telefoneAluno"].ToString();
                            txtEmail.Text = r["emailAluno"].ToString();
                        }

                        try
                        {
                            string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                            byte[] bimage = (byte[])r["fotoAluno"];
                            FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                            fs.Write(bimage, 0, bimage.Length - 1);
                            fs.Close();
                            pictureBox1.Image = Image.FromFile(imagem);
                            r.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao carregar a foto", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        DAO_Conexao.con.Close();
                        txtNome.Enabled = true;
                        txtEnd.Enabled = true;
                        txtNum.Enabled = true;
                        txtBairro.Enabled = true;
                        txtComple.Enabled = true;
                        mkdCEP.Enabled = true;
                        txtCidade.Enabled = true;
                        txtEstado.Enabled = true;
                        mkdTel.Enabled = true;
                        txtEmail.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }

                    else
                    {

                        MessageBox.Show("ERRO! Aluno não cadastrado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mkdCPF.Text = "";
                        txtNome.Text = "";
                        txtEnd.Text = "";
                        txtNum.Text = "";
                        txtBairro.Text = "";
                        txtComple.Text = "";
                        mkdCEP.Text = "";
                        txtCidade.Text = "";
                        txtEstado.Text = "";
                        mkdTel.Text = "";
                        txtEmail.Text = "";
                        pictureBox1.Image = null;

                        button2.Enabled = false;
                        button3.Enabled = false;
                        txtNome.Enabled = false;
                        txtEnd.Enabled = false;
                        txtNum.Enabled = false;
                        txtBairro.Enabled = false;
                        txtComple.Enabled = false;
                        mkdCEP.Enabled = false;
                        txtCidade.Enabled = false;
                        txtEstado.Enabled = false;
                        mkdTel.Enabled = false;
                        txtEmail.Enabled = false;

                    }
                }
                //FIM ATUALIZAR

                DAO_Conexao.con.Close();
            }

            //DAO_Conexao.con.Close(); //somente fecha depois de retorna

        }


        private void button3_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mkdCPF.Text, txtNome.Text, txtEnd.Text, txtNum.Text, txtBairro.Text, txtComple.Text, mkdCEP.Text, mkdTel.Text, txtCidade.Text, txtEstado.Text, txtEmail.Text, foto);
            if (aluno.atualizarAluno())
            {
                MessageBox.Show("Dados atualizados com sucesso!", "ATUALIZADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Não é possível atualizar os dados desse aluno", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }//catch
            }//if
            dialog.Dispose();
        }

        //MÉTODO CRIADO PARA A CONVERSÃO DA IMAGEM PARA INTEGRÁ-LA NO BANCO
        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //deslocamento de bytes em relação ao parâmetro original
                //redefine a posição do fluxo para a gravação
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                //lê um bloco de bytes e grava os dados em um buffer (stream)
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }
    }
}



