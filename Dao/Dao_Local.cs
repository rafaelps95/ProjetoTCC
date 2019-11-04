using MySql.Data.MySqlClient;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;

namespace ProjetoTCC.Dao
{
    class Dao_Local
    {
        readonly MySqlConnection conexao;
        public Dao_Local()
        {
            conexao = new MySqlConnection(Dao.ConnectionString);
        }
        public bool Create(Local Local)
        {
            bool result = false;
            string comandoSql = "INSERT INTO locais (Bairro,Cidade, Estado, Nome) VALUES (?BAIRRO,?CIDADE,?ESTADO,?NOME)";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?NOME", Local.Nome);
            comando.Parameters.AddWithValue("?BAIRRO", Local.Bairro);
            comando.Parameters.AddWithValue("?CIDADE", Local.Cidade);
            comando.Parameters.AddWithValue("?ESTADO", Local.Estado);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return result;
        }
        public Local Read(Local Local)
        {
            string comandoSql = "SELECT * FROM locais WHERE ID = ?ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?ID", Convert.ToInt16(Local.ID));
            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Local.Nome = Convert.ToString(rd["Nome"]);
                    Local.Bairro = Convert.ToString(rd["Bairro"]);
                    Local.Cidade = Convert.ToString(rd["Cidade"]);
                    Local.Estado = Convert.ToString(rd["Estado"]);
                    Local.ID = Convert.ToInt16(rd["ID"]);
                }
            }
            catch
            {
                Local = null;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return Local;
        }

        public List<Local> GetLocais()
        {
            List<Local> list = new List<Local>();
            Local Local;
            string comandoSql = "SELECT * FROM locais ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Local = new Local
                    {
                        Nome = Convert.ToString(rd["Nome"]),
                        Bairro = Convert.ToString(rd["Bairro"]),
                        Cidade = Convert.ToString(rd["Cidade"]),
                        Estado = Convert.ToString(rd["Estado"]),
                        ID = Convert.ToInt16(rd["ID"])
                    };

                    list.Add(Local);
                }
            }
            catch
            {

            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return list;
        }

        public bool Update(Local Local)
        {
            bool result = false;
            string comandoSql = "UPDATE locais SET Nome = ?NOME, Bairro = ?BAIRRO, Cidade = ?CIDADE, Estado = ?ESTADO WHERE ID = ?ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?NOME", Local.Nome);
            //comando.Parameters.Add("?NUMERO", MySqlType.Integer).Value =
            //Convert.ToInt16(Local.Numero);
            comando.Parameters.AddWithValue("?BAIRRO", Local.Bairro);
            comando.Parameters.AddWithValue("?CIDADE", Local.Cidade);
            comando.Parameters.AddWithValue("?ESTADO", Local.Estado);
            //comando.Parameters.Add("?CEP", MySqlType.VarChar, 10).Value = Local.CEP;
            comando.Parameters.AddWithValue("?ID", Convert.ToInt16(Local.ID));

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return result;
        }
        public bool Delete(Local Local)
        {
            bool result = false;
            string comandoSql = "DELETE FROM locais WHERE ID = ?ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?ID", Convert.ToInt16(Local.ID));

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return result;
        }
    }
}
