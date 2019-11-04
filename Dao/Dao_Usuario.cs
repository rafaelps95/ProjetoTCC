using MySql.Data.MySqlClient;
using ProjetoTCC.Model;
using System;

namespace ProjetoTCC.Dao
{
    class Dao_Usuario
    {
        readonly MySqlConnection conexao;
        public Dao_Usuario()
        {
            conexao = new MySqlConnection(Dao.ConnectionString);
        }
        public bool Create(Usuario Usuario)
        {
            bool result = false;
            string comandoSql = "INSERT INTO usuarios (Username, Password, Tipo, Dica) VALUES (?USERNAME, ?SENHA, ?TIPO, ?DICA);";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?USERNAME", Usuario.Username);
            comando.Parameters.AddWithValue("?SENHA", Usuario.Senha);
            comando.Parameters.AddWithValue("?TIPO", Convert.ToInt16(Usuario.Tipo));
            comando.Parameters.AddWithValue("?DICA", Usuario.DicaSenha);

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
        public Usuario Read(Usuario Usuario)
        {
            Usuario temp = null;
            string comandoSql = "select * from usuarios where Username = ?USERNAME;";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?USERNAME", Usuario.Username);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    temp = new Usuario();
                    Usuario.Username = Convert.ToString(rd["Username"]);
                    Usuario.Senha = Convert.ToString(rd["Password"]);
                    Usuario.Tipo = Convert.ToInt16(rd["Tipo"]);
                    Usuario.DicaSenha = Convert.ToString(rd["Dica"]);

                    temp = Usuario;
                }
            }
            catch
            {
                temp = null;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return temp;
        }

        public bool Update(Usuario Usuario)
        {
            bool result = false;
            string comandoSql = "UPDATE usuarios SET Password = ?SENHA, Dica = ?DICA WHERE Username = ?USERNAME ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.Add("?SENHA", MySqlDbType.VarChar, 255).Value = Usuario.Senha;
            comando.Parameters.Add("?DICA", MySqlDbType.VarChar, 255).Value = Usuario.DicaSenha;
            comando.Parameters.Add("?USERNAME", MySqlDbType.VarChar, 255).Value = Usuario.Username;

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
        public bool Delete(Usuario Usuario)
        {
            bool result = false;
            string comandoSql = "DELETE FROM usuarios WHERE Username = @USERNAME ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@USERNAME", Usuario.Username);
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

        public bool Connect(Usuario Usuario)
        {
            bool result = false;

            string comandoSql = "select * from usuarios where Username = ?USERNAME ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?USERNAME", Usuario.Username);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    if (Convert.ToString(rd["Password"]) == Usuario.Senha)
                    {
                        Usuario.Tipo = Convert.ToInt16(rd["Tipo"]);
                        result = true;
                    }
                }
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
