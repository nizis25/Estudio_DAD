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

        public Modalidade (string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade (string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade ()
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

        public bool excluirModalidade()
        {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidae set ativo " + "= 1 where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
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

        public bool atualizarModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                //Console.WriteLine("update Estudio_Aluno set nomeAluno = '" + Nome + "', ruaAluno = '" + Rua + "', numeroAluno = '" + Numero + "', bairroAluno = '" + Bairro + "' complementoAluno ='" + Complemento + "',CEPAluno='" + CEP + "', cidadeAluno='" + Cidade + "', estadoAluno='" + Estado + "', telefoneAluno = '" + Telefone + "', emailAluno = '" + Email + "' where CPFAluno = '" + CPF + "'");
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

        public MySqlDataReader consultarModalidade01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidae " + "WHERE descricaoModalidade='" + descricao + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool consultarAluno() //usado no método excluir
        {

            bool existe = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidae " + "WHERE descricaoModalidade='" + descricao + "'", DAO_Conexao.con);
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

    }
}
