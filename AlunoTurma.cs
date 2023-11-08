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

        private string cpfAluno;
        private int idTurma;

        public AlunoTurma()
        {

        }

        public AlunoTurma(string cpfAluno, int idTurma)
        {
            this.cpfAluno = cpfAluno;
            this.idTurma = idTurma;
        }


        public string CpfAluno { get => cpfAluno; set => cpfAluno = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }

        public bool cadastrarAlunoTurma()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cadastra = new MySqlCommand("insert into Estudio_TurmaAluno (cpfAluno, idTurma) values " +
                    "('" + cpfAluno + "'," + idTurma + ")", DAO_Conexao.con);
                cadastra.ExecuteNonQuery();
                DAO_Conexao.con.Close();
                DAO_Conexao.con.Open();
                MySqlCommand aumentaNAlunos = new MySqlCommand("update Estudio_Turma set nalunosmatriculadosTurma = nalunosmatriculadosTurma + 1 where idEstudio_Turma = " + idTurma, DAO_Conexao.con);
                aumentaNAlunos.ExecuteNonQuery();
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
                while (r.Read())
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

        public MySqlDataReader verificaAlunoMatriculado(string cpf)
        {
            MySqlDataReader r = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand verifica = new MySqlCommand("select idTurma, idModalidade, diasemanaTurma, horaTurma from Estudio_TurmaAluno inner join Estudio_Turma on Estudio_TurmaAluno.idTurma = Estudio_Turma.idEstudio_Turma and " +
                    "Estudio_TurmaAluno.cpfAluno = '" + cpf + "'", DAO_Conexao.con);
                r = verifica.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return r;
        }

        public bool excluirAlunoTurma()
        {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("delete from Estudio_TurmaAluno where cpfAluno = '" + cpfAluno + "' and idTurma = " + idTurma, DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                DAO_Conexao.con.Close();
                DAO_Conexao.con.Open();
                MySqlCommand diminui = new MySqlCommand("update Estudio_Turma set nalunosmatriculadosTurma = nalunosmatriculadosTurma - 1 where idEstudio_Turma = " + idTurma, DAO_Conexao.con);
                diminui.ExecuteNonQuery();
                exc = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return exc;
        }

        public MySqlDataReader consultaTurmaMatricula()
        {
            MySqlDataReader r = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select distinct Estudio_TurmaAluno.idTurma, Estudio_Turma.idModalidade, Estudio_Turma.diasemanaTurma, Estudio_Turma.horaTurma from Estudio_TurmaAluno inner join Estudio_Turma on Estudio_TurmaAluno.idTurma = Estudio_Turma.idEstudio_Turma", DAO_Conexao.con);
                r = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return r;
        }

        public MySqlDataReader buscaAlunoTurma(int id)
        {
            MySqlDataReader r = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand busca = new MySqlCommand("select Estudio_Aluno.CPFAluno, nomeAluno from Estudio_Aluno inner join Estudio_TurmaAluno on Estudio_Aluno.CPFAluno = Estudio_TurmaAluno.cpfAluno and Estudio_TurmaAluno.idTurma = " + id, DAO_Conexao.con);
                r = busca.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return r;
        }

    }
}



