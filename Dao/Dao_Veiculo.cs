using MySql.Data.MySqlClient;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;

namespace ProjetoTCC.Dao
{
    class Dao_Veiculo
    {
        readonly MySqlConnection conexao;
        public Dao_Veiculo()
        {
            conexao = new MySqlConnection(Dao.ConnectionString);
        }
        public bool Create(Veiculo Veiculo)
        {
            bool result = false;
            string comandoSql = "INSERT INTO veiculos (Marca,Modelo,Ano,Placa,Tipo,QtdAssentos,ValorDia) VALUES (@MARCA,@MODELO,@ANO,@PLACA,@TIPO,@QTDASSENTOS,@VALORDIA)";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@MARCA", Veiculo.Marca);
            comando.Parameters.AddWithValue("@MODELO", Veiculo.Modelo);
            comando.Parameters.AddWithValue("@ANO", Convert.ToInt16(Veiculo.Ano));
            comando.Parameters.AddWithValue("@PLACA", Veiculo.Placa);
            comando.Parameters.AddWithValue("@TIPO", Convert.ToInt16(Veiculo.Tipo));
            comando.Parameters.AddWithValue("@QTDASSENTOS", Convert.ToString(Veiculo.QtdAssentos));
            comando.Parameters.AddWithValue("@VALORDIA", Convert.ToDecimal(Veiculo.ValorDia));

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
        public Veiculo Read(Veiculo Veiculo)
        {
            string comandoSql = "select * from veiculos where Placa = @PLACA ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@PLACA", Veiculo.Placa);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Veiculo.ID = Convert.ToInt16(rd["ID"]);
                    Veiculo.Marca = Convert.ToString(rd["Marca"]);
                    Veiculo.Modelo = Convert.ToString(rd["Modelo"]);
                    Veiculo.Ano = Convert.ToInt16(rd["Ano"]);
                    Veiculo.Placa = Convert.ToString(rd["Placa"]);
                    Veiculo.Tipo = Convert.ToInt16(rd["Tipo"]);
                    Veiculo.QtdAssentos = Convert.ToInt16(rd["QtdAssentos"]);
                    Veiculo.ValorDia = Convert.ToDouble(rd["ValorDia"]);
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

            return Veiculo;
        }

        public List<Veiculo> GetVeiculos()
        {
            List<Veiculo> list = new List<Veiculo>();
            Veiculo Veiculo;
            string comandoSql = "SELECT * FROM veiculos ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Veiculo = new Veiculo
                    {
                        ID = Convert.ToInt16(rd["ID"]),
                        Marca = Convert.ToString(rd["Marca"]),
                        Modelo = Convert.ToString(rd["Modelo"]),
                        Ano = Convert.ToInt16(rd["Ano"]),
                        Placa = Convert.ToString(rd["Placa"]),
                        Tipo = Convert.ToInt16(rd["Tipo"]),
                        QtdAssentos = Convert.ToInt16(rd["QtdAssentos"]),
                        ValorDia = Convert.ToDouble(rd["ValorDia"])
                    };

                    list.Add(Veiculo);
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

        public bool Update(Veiculo Veiculo)
        {
            bool result = false;
            string comandoSql = "UPDATE veiculos SET Marca = @MARCA, Modelo = @MODELO, Ano = @ANO, Placa = @PLACA, Tipo = @TIPO, QtdAssentos = @QTDASSENTOS, ValorDia = @VALORDIA WHERE ID = @ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@MARCA", Veiculo.Marca);
            comando.Parameters.AddWithValue("@MODELO", Veiculo.Modelo);
            comando.Parameters.AddWithValue("@ANO", Convert.ToInt16(Veiculo.Ano));
            comando.Parameters.AddWithValue("@PLACA", Veiculo.Placa);
            comando.Parameters.AddWithValue("@TIPO", Convert.ToInt16(Veiculo.Tipo));
            comando.Parameters.AddWithValue("@QTDASSENTOS", Convert.ToString(Veiculo.QtdAssentos));
            comando.Parameters.AddWithValue("@VALORDIA", Convert.ToDecimal(Veiculo.ValorDia));
            comando.Parameters.AddWithValue("@ID", Convert.ToInt16(Veiculo.ID));

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
        public bool Delete(Veiculo Veiculo)
        {
            bool result = false;
            string comandoSql = "DELETE FROM veiculos WHERE ID = @ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@ID", Veiculo.ID);

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
