using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    class Modalidade
    {

        private string descricao;
        private float preco;
        private int qtde_alunos, qtde_aulas;

        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidae (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + descricao + "','" + preco + "','" + qtde_alunos + "','" + qtde_aulas + "')", DAO_Conexao.con);
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

        public bool excluirModalidade(string descricao)
        {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidae set ativa " + "= 1 where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
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

        public bool atualizarModalidade(string descricao)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidae set descricaoModalidade = '" + descricao + "', precoModalidade = '" + preco + "', qtdeAlunos = '" + qtde_alunos + "', qtdeAulas = '" + qtde_aulas + "' where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
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

        public MySqlDataReader consultarModalidade01() //CONSULTA TODOS OS ATIVOS
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidae WHERE ativa = 0", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool consultarModalidade() //USADO NO MÉTODO EXCLUIR
        {

            bool existe = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidae " + "WHERE descricaoModalidade ='" + descricao + "'", DAO_Conexao.con);
                Console.WriteLine("SELECT * FROM Estudio_Modalidae " + "WHERE descricaoModalidade='" + descricao + "'");
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    existe = true;
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
            return existe;
        }

        public MySqlDataReader consultaTudo()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT descricaoModalidade FROM Estudio_Modalidae", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarModalidade02(string descricao)//CONSULTA A DESCRIÇÃO
        {

            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidae WHERE descricaoModalidade ='" + descricao + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool tornarAt()
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atv = new MySqlCommand("update Estudio_Modalidae set ativa = 0 where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
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

        public int consultarAtivas()
        {
            MySqlDataReader r = null;
            int retorno = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand command = new MySqlCommand("SELECT ativa FROM Estudio_Modalidae where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
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

        public MySqlDataReader consultarModalidade03()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidae WHERE descricaoModalidade ='" + descricao + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }
            
    }
}



