using MySql.Data.MySqlClient;
using ProjetoTCC.Model;
using System;
using System.Windows.Forms;

namespace ProjetoTCC.Dao
{
    class Dao_Cliente
    {
        readonly MySqlConnection conexao;
        public Dao_Cliente()
        {
            conexao = new MySqlConnection(Dao.ConnectionString);
        }
        public bool Create (Cliente Cliente)
        {
            bool result;
            string comandoSql;
            
            if (Cliente.Tipo == 0)
            {
                comandoSql = "INSERT INTO clientes (Nome,Tipo,DTNascimento,CPF,Email,Telefone,Username) VALUES (?NOME, ?TIPO, ?DATANASC, ?CPF, ?EMAIL, ?TELEFONE, ?USERNAME);";
            }
            else
            {
                comandoSql = "INSERT INTO clientes (Nome,Tipo,CNPJ,Email,Telefone,Username) VALUES (?NOME, ?TIPO, ?CNPJ, ?EMAIL, ?TELEFONE, ?USERNAME);";
            }
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?NOME", Cliente.Nome);
            comando.Parameters.AddWithValue("?TIPO", Convert.ToInt16(Cliente.Tipo));

            if (Cliente.Tipo == 0)
            {
                comando.Parameters.AddWithValue("?DATANASC", Cliente.DataNasc.ToString("dd/MM/yyyy"));
                comando.Parameters.AddWithValue("?CPF", Cliente.CPF);
            }
            else
            {
                comando.Parameters.AddWithValue("?CNPJ", Cliente.CNPJ);
            }

            comando.Parameters.AddWithValue("?EMAIL", Cliente.Email);
            comando.Parameters.AddWithValue("?TELEFONE", Cliente.Telefone);
            comando.Parameters.AddWithValue("?USERNAME", Cliente.Usuario.Username);

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
        public Cliente Read(Cliente Cliente)
        {
            string comandoSql = "SELECT * FROM clientes WHERE CPF = ?CPF or CNPJ = ?CNPJ or Username = ?USERNAME ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("?USERNAME", Cliente.Usuario.Username);
            comando.Parameters.AddWithValue("?CPF", Cliente.CPF);
            comando.Parameters.AddWithValue("?CNPJ", Cliente.CNPJ);

            Cliente = null;

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Cliente = new Cliente
                    {
                        ID = Convert.ToInt16(rd["ID"]),
                        Nome = Convert.ToString(rd["Nome"]),
                        Tipo = Convert.ToInt16(rd["Tipo"])
                    };

                    if (Cliente.Tipo == 0)
                    {
                        Cliente.CPF = Convert.ToString(rd["CPF"]);
                        Cliente.DataNasc = DateTime.Parse(Convert.ToString(rd["DTNascimento"]));
                    }
                    else
                    {
                        Cliente.CNPJ = Convert.ToString(rd["CNPJ"]);
                    }

                    Cliente.Email = Convert.ToString(rd["Email"]);
                    Cliente.Telefone = Convert.ToString(rd["Telefone"]);
                    Cliente.Usuario.Username = Convert.ToString(rd["Username"]);
                }
            }
            catch (Exception ex)
            {
                Cliente = null;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return Cliente;
        }
        public bool Update(Cliente Cliente)
        {
            bool result;
            string comandoSql;

            if (Cliente.Tipo == 0)
            {
                comandoSql = "UPDATE clientes SET Nome = ?NOME, DTNascimento = ?DATANASC, Email = ?EMAIL, Telefone = ?TELEFONE WHERE CPF = ?CPF OR Username = ?USERNAME;";
            }
            else
            {
                comandoSql = "UPDATE clientes SET Nome = ?NOME, Email = ?EMAIL, Telefone = ?TELEFONE, Username = ?USERNAME WHERE CNPJ = ?CNPJ OR Username = ?USERNAME;";

            }

            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?NOME", Cliente.Nome);

            comando.Parameters.AddWithValue("?TIPO", Convert.ToInt16(Cliente.Tipo));

            if (Cliente.Tipo == 0)
            {
                comando.Parameters.AddWithValue("?DATANASC", Cliente.DataNasc.ToString("dd/MM/yyyy"));
                comando.Parameters.AddWithValue("?CPF", Cliente.CPF);
            }
            else
            {
                comando.Parameters.AddWithValue("?CNPJ", Cliente.CNPJ);
            }

            comando.Parameters.AddWithValue("?EMAIL", Cliente.Email);
            comando.Parameters.AddWithValue("?TELEFONE", Cliente.Telefone);
            comando.Parameters.AddWithValue("?USERNAME", Cliente.Usuario.Username);

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
        public bool Delete(Cliente Cliente)
        {
            bool result;
            string comandoSql = "DELETE FROM clientes WHERE ID = @ID;";

            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@ID", Convert.ToInt16(Cliente.ID));

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show(ex.Message);
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
