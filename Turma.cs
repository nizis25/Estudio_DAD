using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;
        private int qtde_MaxAlunos;

        public Turma ()
        {

        }

        public Turma(int modalidade, string dia_semana)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, string professor, string dia_semana, string hora, int qtde_MaxAlunos)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.qtde_MaxAlunos = qtde_MaxAlunos;
        }

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; } 
        public int Qtde_MaxAlunos { get => qtde_MaxAlunos; set => qtde_MaxAlunos = value; }

        public bool cadastrarTurma()
        {
            bool cad = false;
            MessageBox.Show("ENTROU TRY");

            try
            {
                DAO_Conexao.con.Open();
                MessageBox.Show("ABRIU");
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values ('" + modalidade + "'," + professor + ",'" + dia_semana + "','" + hora + "'," + qtde_MaxAlunos + ")", DAO_Conexao.con);
                MessageBox.Show("...");
                insere.ExecuteNonQuery();
                MessageBox.Show("CADASTROU");
                cad = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ENTROU CATCH");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            MessageBox.Show("SAIU TRY");
            return cad;

        }

        public int consultarIDModalidade(string modalidade)
        {
            MySqlDataReader resultado = null;
            int id = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retorno = new MySqlCommand("SELECT idEstudio_Modalidade FROM Estudio_Modalidae " + "WHERE descricaoModalidade = '" + modalidade + "' and ativa = 0", DAO_Conexao.con);
                resultado = retorno.ExecuteReader();
                if (resultado.Read())
                {
                    id = int.Parse(resultado["idEstudio_Modalidade"].ToString());
                    Console.WriteLine("ConsultarIDModalidade" + id);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return id;

        }

    }

}
