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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mkdCPF.Text, txtNome.Text, txtEnd.Text, txtNum.Text, txtBairro.Text, txtComple.Text, mkdCEP.Text, txtCidade.Text, txtEstado.Text, mkdTel.Text, txtEmail.Text, foto);


            if(aluno.cadastrarAluno())
            {
                MessageBox.Show("Cadastrado com Sucesso! :D");
            }
            else
            {
                MessageBox.Show("Houve um erro :'(");
            }
            Aluno aluno01 = new Aluno(mkdCPF.Text);

           
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                Aluno aluno = new Aluno(mkdCPF.Text);
                MySqlDataReader r = aluno.consultarAluno01();
                if(r.Read())
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
                else
                {
                    MessageBox.Show("Aluno não cadastrado!");
                }
                DAO_Conexao.con.Close();
            }

            //DAO_Conexao.con.Close(); //somente fecha depois de retorna
            
        }


        private void button3_Click(object sender, EventArgs e)
        {

            Aluno aluno = new Aluno(mkdCPF.Text, txtNome.Text, txtEnd.Text, txtNum.Text, txtBairro.Text, txtComple.Text, mkdCEP.Text, mkdTel.Text, txtCidade.Text, txtEstado.Text, txtEmail.Text);
            if (aluno.atualizarAluno())
            {
                MessageBox.Show("Dados atualizados com sucesso!");

            }
            else
            {
            MessageBox.Show("Não é possível atualizar os dados desse aluno");
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
            using(var stream = new System.IO.MemoryStream())
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

