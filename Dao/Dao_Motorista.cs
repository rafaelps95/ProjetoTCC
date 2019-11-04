using MySql.Data.MySqlClient;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;

namespace ProjetoTCC.Dao
{
    class Dao_Motorista
    {
        readonly MySqlConnection conexao;
        public Dao_Motorista()
        {
            conexao = new MySqlConnection(Dao.ConnectionString);
        }
        public bool Create(Motorista Motorista)
        {
            bool result = false;
            string comandoSql = "INSERT INTO motoristas (Nome,CPF,CNH,CatCNH,ValCNH) VALUES (?NOME,?CPF,?CNH,?CATCNH,?VALCNH)";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?NOME", Motorista.Nome);
            comando.Parameters.AddWithValue("?CPF", Motorista.CPF);
            comando.Parameters.AddWithValue("?CNH", Motorista.CNH);
            comando.Parameters.AddWithValue("?CATCNH", Motorista.CategoriaCNH);
            comando.Parameters.AddWithValue("?VALCNH", Motorista.ValidadeCNH.ToString("dd/MM/yyyy"));

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
        public Motorista Read(Motorista Motorista)
        {
            string comandoSql = "SELECT * FROM motoristas WHERE ID = ?ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?ID", Convert.ToInt16(Motorista.ID));
            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Motorista.Nome = Convert.ToString(rd["Nome"]);
                    Motorista.CPF = Convert.ToString(rd["CPF"]);
                    Motorista.CNH = Convert.ToString(rd["CNH"]);
                    Motorista.CategoriaCNH = Convert.ToString(rd["CatCNH"]);
                    Motorista.ValidadeCNH = DateTime.Parse(Convert.ToString(rd["ValCNH"]));
                    Motorista.ID = Convert.ToInt16(rd["ID"]);
                }
            }
            catch
            {
                Motorista = null;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return Motorista;
        }

        public List<Motorista> GetMotoristas()
        {
            List<Motorista> list = new List<Motorista>();
            Motorista Motorista;
            string comandoSql = "SELECT * FROM motoristas ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Motorista = new Motorista
                    {
                        Nome = Convert.ToString(rd["Nome"]),
                        CPF = Convert.ToString(rd["CPF"]),
                        CNH = Convert.ToString(rd["CNH"]),
                        CategoriaCNH = Convert.ToString(rd["CatCNH"]),
                        ValidadeCNH = DateTime.Parse(Convert.ToString(rd["ValCNH"])),
                        ID = Convert.ToInt16(rd["ID"])
                    };

                    list.Add(Motorista);
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


        public bool Update(Motorista Motorista)
        {
            bool result = false;
            string comandoSql = "UPDATE motoristas SET Nome = ?NOME, CPF = ?CPF, CNH = ?CNH, CatCNH = ?CATCNH, ValCNH = ?VALCNH WHERE ID = ?ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?NOME", Motorista.Nome);
            comando.Parameters.AddWithValue("?CPF", Motorista.CPF);
            comando.Parameters.AddWithValue("?CNH", Motorista.CNH);
            comando.Parameters.AddWithValue("?CATCNH", Motorista.CategoriaCNH);
            comando.Parameters.AddWithValue("?VALCNH", Motorista.ValidadeCNH.ToString("dd/MM/yyyy"));
            comando.Parameters.AddWithValue("?ID", Convert.ToInt16(Motorista.ID));

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
        public bool Delete(Motorista Motorista)
        {
            bool result = false;
            string comandoSql = "DELETE FROM motoristas WHERE ID = ?ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("?ID", Convert.ToInt16(Motorista.ID));

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
