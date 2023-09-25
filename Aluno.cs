﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;

    public Aluno(string cpf,string nome,string rua,string numero,string bairro,string complemento,string cep,string cidade,string estado,string telefone,string email)
    {
        setCPF(cpf);
        setNome(nome);
        setRua(rua);
        setNumero(numero);
        setBairro(bairro);
        setComplemento(complemento);
        setCEP(cep);
        setCidade(cidade);
        setEstado(estado);
        setTelefone(telefone);
        setEmail(email);
    }

        public Aluno()
        {

        }

        public Aluno(string cpf)
        {
            setCPF(cpf);
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }

        public string getBairro()
        {
            return this.Bairro;
        }

        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }

        public string getNumero()
        {
            return this.Numero;
        }

        public void setRua(string Rua)
        {
            this.Rua = Rua;
        }

        public string getRua()
        {
            return this.Rua;
        }

        public void setComplemento(string Complemento)
        {
            this.Complemento = Complemento;
        }

        public string getComplemento()
        {
            return this.Complemento;
        }

        public void setCEP(string CEP)
        {
            this.CEP = CEP;
        }

        public string getCEP()
        {
            return this.CEP;
        }

        public void setCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }

        public string getCidade()
        {
            return this.Cidade;
        }

        public void setEstado(string Estado)
        {
            this.Estado = Estado;
        }

        public string getEstado()
        {
            return this.Estado;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public void setFoto(byte[] Foto)
        {
            this.Foto = Foto;
        }

        public byte[] getFoto()
        {
            return this.Foto;
        }

        public bool cadastrarAluno()
        {
            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + CPF+"','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        } 

        public bool consultarAluno() //usado no método excluir
        {

            bool existe = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno='" + CPF + "'", DAO_Conexao.con);
                Console.WriteLine("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno='" + CPF + "'");
                MySqlDataReader resultado = consulta.ExecuteReader();

                if(resultado.Read())
                {
                    existe = true;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public MySqlDataReader consultarAluno01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno='" + CPF + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool excluirAluno()
        {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo " + "= 1 where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
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

        public bool atualizarAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                //Console.WriteLine("update Estudio_Aluno set nomeAluno = '" + Nome + "', ruaAluno = '" + Rua + "', numeroAluno = '" + Numero + "', bairroAluno = '" + Bairro + "' complementoAluno ='" + Complemento + "',CEPAluno='" + CEP + "', cidadeAluno='" + Cidade + "', estadoAluno='" + Estado + "', telefoneAluno = '" + Telefone + "', emailAluno = '" + Email + "' where CPFAluno = '" + CPF + "'");
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Aluno set nomeAluno = '" + Nome + "', ruaAluno = '" + Rua + "', numeroAluno = '" + Numero + "', bairroAluno = '" + Bairro + "', complementoAluno ='" + Complemento + "',CEPAluno='" + CEP + "', cidadeAluno='" + Cidade + "', estadoAluno='" + Estado + "', telefoneAluno = '" + Telefone + "', emailAluno = '" + Email + "' where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
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
    }

}
