using MySql.Data.MySqlClient;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoTCC.Dao
{
    class Dao_Reserva
    {
        readonly MySqlConnection conexao;
        public Dao_Reserva()
        {
            conexao = new MySqlConnection(Dao.ConnectionString);
        }
        public bool Create(Reserva Reserva)
        {
            bool result;
            string comandoSql = "insert into reservas (ID_Cliente,ID_LocalSaida,ID_LocalDestino,ID_Veiculo,ID_MOTORISTA,ID_Usuario,DT_Saida,DT_Retorno,Valor) values (@ID_Cliente,@ID_LocalSaida,@ID_LocalDestino,@ID_Veiculo,@ID_MOTORISTA,@ID_Usuario,@DT_Saida,@DT_Retorno,@Valor)";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@ID_Cliente", Convert.ToInt16(Reserva.Cliente.ID));
            comando.Parameters.AddWithValue("@ID_LocalSaida", Convert.ToInt16(Reserva.LocalPartida.ID));
            comando.Parameters.AddWithValue("@ID_LocalDestino", Convert.ToInt16(Reserva.LocalDestino.ID));
            comando.Parameters.AddWithValue("@ID_Veiculo", Convert.ToInt16(Reserva.Veiculo.ID));
            comando.Parameters.AddWithValue("@ID_MOTORISTA", Convert.ToInt16(Reserva.Motorista.ID));
            comando.Parameters.AddWithValue("@ID_Usuario", Reserva.Usuario.Username);
            comando.Parameters.AddWithValue("@DT_Saida", Reserva.DataHoraInicial.ToString());
            comando.Parameters.AddWithValue("@DT_Retorno", Reserva.DataHoraFinal.ToString());
            comando.Parameters.AddWithValue("@Valor", Convert.ToDecimal(Reserva.Valor));

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
        public Reserva Read(Reserva Reserva)
        {
            string comandoSql = "select c.ID as cID, c.Nome as cNome, c.Tipo as cTipo, c.CPF as cCPF, c.CNPJ as cCNPJ, lp.ID as lpID, lp.Nome as lpNome, lp.Bairro as lpBairro, lp.Cidade as lpCidade, lp.Estado as lpEstado, ld.ID as ldID, ld.Nome as ldNome, ld.Bairro as ldBairro, ld.Cidade as ldCidade, ld.Estado as ldEstado, v.ID as vID, v.Marca as vMarca, v.Modelo as vModelo, v.Ano as vAno, v.QtdAssentos as vQtdAssentos, v.ValorDia as vValorDia, m.ID as mID, m.Nome as mNome, r.ID as rID, r.DT_Saida as rDTSaida, r.DT_Retorno as rDTRetorno, r.Valor as rValor from reservas r inner join clientes c on c.ID = r.ID_Cliente inner join locais lp on lp.ID= r.ID_LocalSaida inner join locais ld on ld.ID = r.ID_LocalDestino inner join motoristas m on m.ID = r.ID_Motorista inner join veiculos v on v.ID = r.ID_Veiculo where r.ID = @RID;";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@RID", Convert.ToInt16(Reserva.ID));
            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Reserva.Cliente = new Cliente()
                    {
                        ID = Convert.ToInt16(rd["cID"]),
                        Nome = Convert.ToString(rd["cNome"]),
                    };
                    Reserva.LocalPartida = new Local()
                    {
                        ID = Convert.ToInt16(rd["lpID"]),
                        Nome = Convert.ToString(rd["lpNome"]),
                        Bairro = Convert.ToString(rd["lpBairro"]),
                        Cidade = Convert.ToString(rd["lpCidade"]),
                        Estado = Convert.ToString(rd["lpEstado"]),
                    };
                    Reserva.LocalDestino = new Local()
                    {
                        ID = Convert.ToInt16(rd["ldID"]),
                        Nome = Convert.ToString(rd["ldNome"]),
                        Bairro = Convert.ToString(rd["ldBairro"]),
                        Cidade = Convert.ToString(rd["ldCidade"]),
                        Estado = Convert.ToString(rd["ldEstado"]),
                    };
                    Reserva.Veiculo = new Veiculo()
                    {
                        ID = Convert.ToInt16(rd["vID"]),
                        Marca = Convert.ToString(rd["vMarca"]),
                        Modelo = Convert.ToString(rd["vModelo"]),
                        Ano = Convert.ToInt16(rd["vAno"]),
                        QtdAssentos = Convert.ToInt16(rd["vQtdAssentos"]),
                        ValorDia = Convert.ToDouble(rd["vValorDia"]),
                    };
                    Reserva.Motorista = new Motorista()
                    {
                        ID = Convert.ToInt16(rd["mID"]),
                        Nome = Convert.ToString(rd["mNome"]),

                    };

                    Reserva.ID = Convert.ToInt16(rd["rID"]);
                    Reserva.DataHoraInicial = DateTime.Parse(Convert.ToString(rd["rDTSaida"]));
                    Reserva.DataHoraFinal = DateTime.Parse(Convert.ToString(rd["rDTRetorno"]));
                    Reserva.Valor = Convert.ToDouble(rd["rValor"]);
                }
            }
            catch
            {
                Reserva = null;
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return Reserva;
        }

        public List<Reserva> GetReservas()
        {
            List<Reserva> list = new List<Reserva>();
            Reserva Reserva;
            string comandoSql = "select c.ID as cID, c.Nome as cNome, c.Tipo as cTipo, c.CPF as cCPF, c.CNPJ as cCNPJ, lp.ID as lpID, lp.Nome as lpNome, lp.Bairro as lpBairro, lp.Cidade as lpCidade, lp.Estado as lpEstado, ld.ID as ldID, ld.Nome as ldNome, ld.Bairro as ldBairro, ld.Cidade as ldCidade, ld.Estado as ldEstado, v.ID as vID, v.Marca as vMarca, v.Modelo as vModelo, v.Ano as vAno, v.QtdAssentos as vQtdAssentos, v.ValorDia as vValorDia, m.ID as mID, m.Nome as mNome, r.ID as rID, r.DT_Saida as rDTSaida, r.DT_Retorno as rDTRetorno, r.Valor as rValor from reservas r inner join clientes c on c.ID = r.ID_Cliente inner join locais lp on lp.ID= r.ID_LocalSaida inner join locais ld on ld.ID = r.ID_LocalDestino inner join motoristas m on m.ID = r.ID_Motorista inner join veiculos v on v.ID = r.ID_Veiculo;";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);

            try
            {
                conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                while (rd.Read())
                {
                    Reserva = new Reserva();
                    Reserva.Cliente = new Cliente()
                    {
                        ID = Convert.ToInt16(rd["cID"]),
                        Nome = Convert.ToString(rd["cNome"]),
                    };
                    Reserva.LocalPartida = new Local()
                    {
                        ID = Convert.ToInt16(rd["lpID"]),
                        Nome = Convert.ToString(rd["lpNome"]),
                        Bairro = Convert.ToString(rd["lpBairro"]),
                        Cidade = Convert.ToString(rd["lpCidade"]),
                        Estado = Convert.ToString(rd["lpEstado"]),
                    };
                    Reserva.LocalDestino = new Local()
                    {
                        ID = Convert.ToInt16(rd["ldID"]),
                        Nome = Convert.ToString(rd["ldNome"]),
                        Bairro = Convert.ToString(rd["ldBairro"]),
                        Cidade = Convert.ToString(rd["ldCidade"]),
                        Estado = Convert.ToString(rd["ldEstado"]),
                    };
                    Reserva.Veiculo = new Veiculo()
                    {
                        ID = Convert.ToInt16(rd["vID"]),
                        Marca = Convert.ToString(rd["vMarca"]),
                        Modelo = Convert.ToString(rd["vModelo"]),
                        Ano = Convert.ToInt16(rd["vAno"]),
                        QtdAssentos = Convert.ToInt16(rd["vQtdAssentos"]),
                        ValorDia = Convert.ToDouble(rd["vValorDia"]),
                    };
                    Reserva.Motorista = new Motorista()
                    {
                        ID = Convert.ToInt16(rd["mID"]),
                        Nome = Convert.ToString(rd["mNome"]),

                    };

                    Reserva.ID = Convert.ToInt16(rd["rID"]);
                    Reserva.DataHoraInicial = DateTime.Parse(Convert.ToString(rd["rDTSaida"]));
                    Reserva.DataHoraFinal = DateTime.Parse(Convert.ToString(rd["rDTRetorno"]));
                    Reserva.Valor = Convert.ToDouble(rd["rValor"]);

                    list.Add(Reserva);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }

            return list;
        }

        public bool Update(Reserva Reserva)
        {
            bool result;
            string comandoSql = "UPDATE reservas SET ID_Cliente = @ID_Cliente, ID_LocalSaida = @ID_LocalSaida, ID_LocalDestino = ID_LocalDestino, ID_Veiculo = @ID_Veiculo, ID_Motorista = @ID_MOTORISTA, ID_Usuario = @ID_Usuario, DT_Saida = @DT_Saida, DT_Retorno = @DT_Retorno, Valor = @Valor WHERE ID = @ID;";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@ID_Cliente", Convert.ToInt16(Reserva.Cliente.ID));
            comando.Parameters.AddWithValue("@ID_LocalSaida", Convert.ToInt16(Reserva.LocalPartida.ID));
            comando.Parameters.AddWithValue("@ID_LocalDestino", Convert.ToInt16(Reserva.LocalDestino.ID));
            comando.Parameters.AddWithValue("@ID_Veiculo", Convert.ToInt16(Reserva.Veiculo.ID));
            comando.Parameters.AddWithValue("@ID_MOTORISTA", Convert.ToInt16(Reserva.Motorista.ID));
            comando.Parameters.AddWithValue("@ID_Usuario", Reserva.Usuario.Username);
            comando.Parameters.AddWithValue("@DT_Saida", Reserva.DataHoraInicial.ToString());
            comando.Parameters.AddWithValue("@DT_Retorno", Reserva.DataHoraFinal.ToString());
            comando.Parameters.AddWithValue("@Valor", Convert.ToDecimal(Reserva.Valor));
            comando.Parameters.AddWithValue("@ID", Convert.ToInt16(Reserva.ID));

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
        public bool Delete(Reserva Reserva)
        {
            bool result;
            string comandoSql = "DELETE FROM reservas WHERE ID = @ID ";
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@ID", Convert.ToInt16(Reserva.ID));

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
