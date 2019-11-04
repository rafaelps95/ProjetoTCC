using SistemaPim4.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPim4.Dao
{
    class Dao_Destino
    {
        OleDbConnection conexao;
        public Dao_Destino(string banco)
        {
            conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + banco + "; Extended Properties='Excel 12.0 Xml; HDR = YES';");
            //conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + banco + "; Extended Properties = 'Excel 8.0; HDR=YES;ReadOnly=False'");
        }
        public bool Create(Destino Destino)
        {
            string comandoSql = "INSERT INTO [Cartas$] ([COD],[NOME],[VALOR],[FRENTE],[COSTA]) VALUES (@COD,@NOME,@VALOR,@FRENTE,@COSTA)";
            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);
            //comando.Parameters.Add("@COD", OleDbType.Integer).Value =
            //Convert.ToInt16(carta.cod);
            //comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value =
            //carta.nome;
            //comando.Parameters.Add("@VALOR", OleDbType.Integer).Value =
            //Convert.ToInt16(carta.valor);
            //comando.Parameters.Add("@FRENTE", OleDbType.VarChar, 255).Value =
            //carta.frente;
            //comando.Parameters.Add("@COSTA", OleDbType.VarChar, 255).Value =
            //carta.costa;
            //try
            //{
            //    conexao.Open();
            //    comando.ExecuteNonQuery();
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            return true;
        }
        public Destino Read(Destino Destino)
        {
            string comandoSql = "select * from [Cartas$] where [COD] = @COD ";
            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);
            //comando.Parameters.Add("@COD", OleDbType.Integer).Value =
            //Convert.ToInt16(Destino.cod);

            //try
            //{
            //    conexao.Open();
            //    OleDbDataReader rd = comando.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        carta.cod = Convert.ToInt16(rd["COD"]);
            //        carta.nome = Convert.ToString(rd["NOME"]);
            //        carta.valor = Convert.ToInt16(rd["VALOR"]);
            //        carta.frente = Convert.ToString(rd["FRENTE"]);
            //        carta.costa = Convert.ToString(rd["COSTA"]);
            //    }
            //    return carta;
            //}
            //catch
            //{
            //    return null;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            return new Destino();
        }
        public bool Update(Destino Destino)
        {
            string comandoSql = "UPDATE [Cartas$] SET [NOME] = @NOME, [VALOR] = @VALOR, [FRENTE] = @FRENTE, [COSTA] = @COSTA WHERE [COD] = @COD ";
            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);
            //comando.Parameters.Add("@NOME", OleDbType.VarChar, 255).Value =
            //Destino.Nome;
            //comando.Parameters.Add("@VALOR", OleDbType.Integer).Value =
            //Convert.ToInt16(Destino.valor);
            //comando.Parameters.Add("@FRENTE", OleDbType.VarChar, 255).Value =
            //Destino.frente;
            //comando.Parameters.Add("@COSTA", OleDbType.VarChar, 255).Value =
            //Destino.costa;
            //comando.Parameters.Add("@COD", OleDbType.Integer).Value =
            //Convert.ToInt16(Destino.cod);
            //try
            //{
            //    conexao.Open();
            //    comando.ExecuteNonQuery();
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            return true;
        }
        public bool Delete(Destino Destino)
        {
            string comandoSql = "DELETE FROM [Cartas$] WHERE [COD] = @COD ";
            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);
            //comando.Parameters.Add("@COD", OleDbType.Integer).Value =
            //Convert.ToInt16(Destino.cod);
            //try
            //{
            //    conexao.Open();
            //    comando.ExecuteNonQuery();
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            return true;
        }
    }
}
