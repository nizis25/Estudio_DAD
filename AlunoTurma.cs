using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    class AlunoTurma
    {
        public AlunoTurma()
        {

        }

        public AlunoTurma(int idEstudio_TurmaAluno, string cpfAluno, int idTurma)
        {
            this.idEstudio_TurmaAluno = idEstudio_TurmaAluno;
            this.cpfAluno = cpfAluno;
            this.idTurma = idTurma;
        }

        private int idEstudio_TurmaAluno;
        private string cpfAluno;
        private int idTurma;

        public int IdEstudio_TurmaAluns { get => idEstudio_TurmaAluno; set => idEstudio_TurmaAluno = value; }
        public string CpfAluno { get => cpfAluno; set => cpfAluno = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }

        public bool cadastrarAlunoTurma()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cadastra = new MySqlCommand("insert into Estudio_TurmaAluno (cpfAluno, idTurma) values ('" + cpfAluno + "','" + idTurma + "')", DAO_Conexao.con);
                cadastra.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cad;

        }

        public bool verificaAluno(string cpf)
        {
            bool ex = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand vEx = new MySqlCommand("select * from Estudio_Aluno where CPFAluno = '" + cpf + "'", DAO_Conexao.con);
                MySqlDataReader r = vEx.ExecuteReader();
                while(r.Read())
                {
                    ex = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return ex;
        }

        /*public MySqlDataReader verificaAlunoMatriculado()
        {
            MySqlDataReader r = null;
            try
            {
                DAO_Conexao.con.Open();

            }
            catch (Exception ex)
            {

            }
        }*/
    }
}
