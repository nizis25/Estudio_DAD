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

        public Turma()
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

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values ('" + modalidade + "','" + professor + "','" + dia_semana + "','" + hora + "','" + qtde_MaxAlunos + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
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

        public int consultarIDModalidade01(string modalidade)
        {
            MySqlDataReader resultado = null;
            int id = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retorno = new MySqlCommand("SELECT idEstudio_Modalidade FROM Estudio_Modalidae WHERE descricaoModalidade = '"
                    + modalidade + "' and ativa = 0", DAO_Conexao.con);
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

        public int consultarIDModalidade(string modalidade)
        {
            MySqlDataReader resultado = null;
            int id = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retorno = new MySqlCommand("SELECT DISTINCT * FROM Estudio_Modalidae INNER JOIN Estudio_Turma ON " +
                    "Estudio_Turma.idModalidade = Estudio_Modalidae.idEstudio_Modalidade AND Estudio_Turma.ativa = 0 " +
                    "AND Estudio_Modalidae.descricaoModalidade = '" + modalidade + "'", DAO_Conexao.con);
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

        public MySqlDataReader consultarTurmaModalidade02(int modalidade)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta02 = new MySqlCommand("SELECT DISTINCT diasemanaTurma FROM Estudio_Turma where idModalidade = " + modalidade + "", DAO_Conexao.con);
                resultado = consulta02.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public int consultarIDModalidade03(string modalidade)
        {
            MySqlDataReader resultado = null;
            int id = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retorno = new MySqlCommand("SELECT idEstudio_Modalidade FROM Estudio_Modalidae WHERE descricaoModalidade =" +
                    " '" + modalidade + "'", DAO_Conexao.con);
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

        public int consultarIDTurma(int modalidade, string hora, string dia_semana)//USADA NO BUSCAR
        {
            MySqlDataReader resultado = null;
            int id = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaTurma = new MySqlCommand("SELECT idEstudio_Turma FROM Estudio_Turma WHERE idModalidade = "
                    + modalidade + " AND horaTurma = '" + hora
                    + "' AND diasemanaTurma = '" + dia_semana + "'", DAO_Conexao.con);
                resultado = consultaTurma.ExecuteReader();

                if (resultado.Read())
                {
                    id = int.Parse(resultado["idEstudio_Turma"].ToString());
                    Console.WriteLine("ConsultarIDTurma" + id);
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

        public MySqlDataReader consultarTodas()
        {
            MySqlDataReader r = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT DISTINCT descricaoModalidade FROM Estudio_Modalidae inner join Estudio_Turma where Estudio_Turma.idModalidade = Estudio_Modalidae.idEstudio_Modalidade AND Estudio_Turma.ativa = 0", DAO_Conexao.con);
                r = consulta.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return r;
        }

        public MySqlDataReader todas()
        {
            MySqlDataReader busca = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand todas = new MySqlCommand("SELECT * FROM Estudio_Turma where ativa = 0", DAO_Conexao.con);
                busca = todas.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return busca;
        }

        public bool excluirTurma()
        {
            bool excluido = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand("update Estudio_Turma set ativa = 1 where idModalidade = " + modalidade + "", DAO_Conexao.con);
                excluir.ExecuteNonQuery();
                excluido = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluido;

        }

        public MySqlDataReader consultaDia(string diaSemana)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaDia = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE diasemanaTurma = '" + diaSemana + "' AND ativa = 0", DAO_Conexao.con);
                resultado = consultaDia.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            /*finally
            {
                DAO_Conexao.con.Close();
            }*/

            return resultado;

        }

        public MySqlDataReader consultaDia01(string diaSemana, string desc)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaDia = new MySqlCommand("SELECT horaTurma FROM Estudio_Turma inner join Estudio_Modalidae on Estudio_Turma.idModalidade = Estudio_Modalidae.idEstudio_Modalidade AND Estudio_Turma.diasemanaTurma = '" + diaSemana + "' AND Estudio_Modalidae.descricaoModalidade = '" + desc + "' AND Estudio_Turma.ativa = 0", DAO_Conexao.con);
                resultado = consultaDia.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;

        }

        public MySqlDataReader consultaDia02(string diaSemana, int modalidade)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaDia = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE diasemanaTurma = '" + diaSemana +
                    "' AND idModalidade = " + modalidade + "", DAO_Conexao.con);
                resultado = consultaDia.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultaHora(string hora)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaHora = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE horaTurma = '" + hora + "' AND ativa = 0", DAO_Conexao.con);
                resultado = consultaHora.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            /*finally
            {
                DAO_Conexao.con.Close();
            }*/

            return resultado;

        }

        public MySqlDataReader consultaModalidadeNaTurma(int modalidade)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaModalidade = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade = " + modalidade + " AND ativa = 0", DAO_Conexao.con);
                resultado = consultaModalidade.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultaModalidadeNaTurma01(int modalidade)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaModalidade = new MySqlCommand("SELECT DISTINCT diasemanaTurma FROM Estudio_Turma WHERE idModalidade = " + modalidade + "", DAO_Conexao.con);
                resultado = consultaModalidade.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultaTurmaAtualizar(int idTurma)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select Estudio_Turma.nalunosmatriculadosTurma, Estudio_Turma.professorTurma, " +
                    "Estudio_Turma.diasemanaTurma, Estudio_Turma.horaTurma from Estudio_Turma inner join Estudio_Modalidae on " +
                    "Estudio_Modalidae.idEstudio_Modalidade = Estudio_Turma.idModalidade and " +
                    "Estudio_Turma.ativa = 0 and Estudio_Turma.idEstudio_Turma = " + idTurma + "", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultaTurmaAtualizar01(int idTurma)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select Estudio_Turma.nalunosmatriculadosTurma, Estudio_Turma.professorTurma, " +
                    "Estudio_Turma.diasemanaTurma, Estudio_Turma.horaTurma from Estudio_Turma inner join Estudio_Modalidae on " +
                    "Estudio_Modalidae.idEstudio_Modalidade = Estudio_Turma.idModalidade and " +
                    "Estudio_Turma.idEstudio_Turma = " + idTurma, DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public bool tornarAt(int id)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atv = new MySqlCommand("update Estudio_Turma set ativa = 0 where idEstudio_Turma = " + id + "", DAO_Conexao.con);
                atv.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public int consultarAtivas(int id)
        {
            MySqlDataReader r = null;
            int retorno = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand command = new MySqlCommand("SELECT ativa FROM Estudio_Turma where idEstudio_Turma = " + id, DAO_Conexao.con);
                r = command.ExecuteReader();
                if (r.Read())
                {
                    retorno = int.Parse(r["ativa"].ToString());
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
            return retorno;
        }

        public bool atualizarTurma(int modalidade)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Turma set professorTurma = '" + professor
                    + "', diasemanaTurma = '" + dia_semana + "', horaTurma = '" + hora
                    + "', nalunosmatriculadosTurma = '" + qtde_MaxAlunos + "' where idEstudio_Turma = " + modalidade + "", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                exc = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                DAO_Conexao.con.Close();
            }

            return exc;
        }

        public int buscaMaxAl(int idModal)
        {
            int al = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand buscamax = new MySqlCommand("select nalunosmatriculadosTurma from Estudio_Turma where idModalidade = " + idModal, DAO_Conexao.con);
                MySqlDataReader r = buscamax.ExecuteReader();
                while (r.Read())
                {
                    al += int.Parse(r["nalunosmatriculadosTurma"].ToString());
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

            return al;
        }
    }

}



