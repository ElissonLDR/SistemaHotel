using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PIM.Model;
using System.Windows.Forms;
using System.Data;
using PIM.View;


namespace PIM.DAO
{
    class daoQuartos
    {
        Conexao bdQuartos;
        string comandoSql;
        public daoQuartos()
        {
            bdQuartos = new Conexao();
        }
        public void Create(Quartos quartos)
        {
            comandoSql = "INSERT INTO [dbo].[Quartos]([Codigo],[Num],[Diaria],[Andar],[Predio],[Tipo],[Situacao],[Descricao],[Img1])" +
                "VALUES(@CODIGO, @NUMERO, @DIARIA, @ANDAR, @PREDIO, @TIPO, @SITUACAO, @DESCRICAO, @IMAGEM1)";

            SqlCommand comando = new SqlCommand(comandoSql, bdQuartos.Conn);

            comando.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = quartos.Codigo;
            comando.Parameters.Add("@NUMERO", SqlDbType.VarChar).Value = quartos.Numero;
            comando.Parameters.Add("@DIARIA", SqlDbType.VarChar).Value = quartos.Diaria;
            comando.Parameters.Add("@ANDAR", SqlDbType.VarChar).Value = quartos.Andar;
            comando.Parameters.Add("@PREDIO", SqlDbType.VarChar).Value = quartos.Predio;
            comando.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = quartos.Tipo;
            comando.Parameters.Add("@SITUACAO", SqlDbType.VarChar).Value = quartos.Situacao;
            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = quartos.Descricao;
            comando.Parameters.Add("@IMAGEM1", SqlDbType.Binary).Value = quartos.Img1;

            try
            {
                bdQuartos.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (bdQuartos.Conn.State == ConnectionState.Open)
                {
                    bdQuartos.Close();
                }

            }
        }

        public Quartos Read(Quartos quartos)
        {

            comandoSql = "SELECT* from Quartos Where Codigo = @BUSCAR";

            SqlCommand comando = new SqlCommand(comandoSql, bdQuartos.Conn);

            comando.Parameters.Add("@BUSCAR", SqlDbType.VarChar).Value = quartos.Buscar;

            try
            {
                bdQuartos.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    quartos.Codigo = Convert.ToString(rd["Codigo"]);
                    quartos.Numero = Convert.ToString(rd["Num"]);
                    quartos.Diaria = Convert.ToString(rd["Diaria"]);
                    quartos.Andar = Convert.ToString(rd["Andar"]);
                    quartos.Predio = Convert.ToString(rd["Predio"]);
                    quartos.Tipo = Convert.ToString(rd["Tipo"]);
                    quartos.Situacao = Convert.ToString(rd["Situacao"]);
                    quartos.Descricao = Convert.ToString(rd["Descricao"]);
                    quartos.Img1 = (byte[])(rd["Img1"]);
                }
                else
                {
                    quartos.Codigo = ""; 
                    MessageBox.Show("Este Codigo não está cadastrado.");
                    return null;
                }
                return quartos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bdQuartos.Close();
            }
        }
        public Quartos ReadCodigo(Quartos quartos)
        {

            comandoSql = "SELECT* from Quartos Where Codigo = @BUSCAR";

            SqlCommand comando = new SqlCommand(comandoSql, bdQuartos.Conn);

            comando.Parameters.Add("@BUSCAR", SqlDbType.VarChar).Value = quartos.Buscar;

            try
            {
                bdQuartos.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    quartos.Codigo = Convert.ToString(rd["Codigo"]);
                }
                else
                {
                    quartos.Codigo = "";
                }
                return quartos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bdQuartos.Close();
            }
        }
        public void Update(Quartos quartos)
        {
            comandoSql = "UPDATE Quartos SET Diaria = @DIARIA, Tipo = @TIPO, Situacao = @SITUACAO, Descricao = @DESCRICAO," +
                "Img1 = @IMAGEM1 WHERE Codigo = @BUSCAR";

            SqlCommand comando = new SqlCommand(comandoSql, bdQuartos.Conn);

            comando.Parameters.Add("@BUSCAR", SqlDbType.Char).Value = quartos.Buscar;
            comando.Parameters.Add("@DIARIA", SqlDbType.VarChar).Value = quartos.Diaria;
            comando.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = quartos.Tipo;
            comando.Parameters.Add("@SITUACAO", SqlDbType.VarChar).Value = quartos.Situacao;
            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = quartos.Descricao;
            comando.Parameters.Add("@IMAGEM1", SqlDbType.Binary).Value = quartos.Img1;
            try
            {
                bdQuartos.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Alteração salvo com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (bdQuartos.Conn.State == ConnectionState.Open)
                {
                    bdQuartos.Close();
                }

            }
        }
        public void Delete (Quartos quartos)
        {
            comandoSql = "DELETE FROM Quartos WHERE Codigo = @CODIGO";

            SqlCommand comando = new SqlCommand(comandoSql, bdQuartos.Conn);

            comando.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = quartos.Codigo;

            try
            {
                bdQuartos.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bdQuartos.Close();
            }
        }

        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                comandoSql = "SELECT * FROM Quartos ";

                bdQuartos.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bdQuartos.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdQuartos.Close();
            }
            return Dtt;
        }
    }
}
