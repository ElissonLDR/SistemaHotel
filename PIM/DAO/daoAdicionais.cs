using PIM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.DAO
{
    class daoAdicionais
    {
        Conexao bdAdicionais;
        string comandoSql;
        public daoAdicionais()
        {
            bdAdicionais = new Conexao();
        }
        public void Create(Adicionais adicionais)
        {

            comandoSql = "INSERT INTO Adicionais ([Nome],[Preco])" +
                "VALUES (@NOME, @PRECO)";

            SqlCommand comando = new SqlCommand(comandoSql, bdAdicionais.Conn);

            comando.Parameters.Add("@NOME", SqlDbType.Char).Value = adicionais.Nome;
            comando.Parameters.Add("@PRECO", SqlDbType.Char).Value = adicionais.Preco;

            try
            {
                bdAdicionais.Open();
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
                if (bdAdicionais.Conn.State == ConnectionState.Open)
                {
                    bdAdicionais.Close();
                }

            }

        }
        public void Update(Adicionais adicionais)
        {
            {

                comandoSql = "UPDATE Adicionais SET Nome = @NOME , Preco = @PRECO WHERE COD = @COD";

                SqlCommand comando = new SqlCommand(comandoSql, bdAdicionais.Conn);

                comando.Parameters.Add("@NOME", SqlDbType.Char).Value = adicionais.Nome;
                comando.Parameters.Add("@PRECO", SqlDbType.Char).Value = adicionais.Preco;
                comando.Parameters.Add("@COD", SqlDbType.Char).Value = adicionais.Cod;

                try
                {
                    bdAdicionais.Open();
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
                    if (bdAdicionais.Conn.State == ConnectionState.Open)
                    {
                        bdAdicionais.Close();
                    }

                }
            }
        }
        public void Delete(Adicionais adicionais)
        {
            comandoSql = "DELETE FROM Adicionais WHERE COD = @COD";

            SqlCommand comando = new SqlCommand(comandoSql, bdAdicionais.Conn);

            comando.Parameters.Add("@COD", SqlDbType.VarChar).Value = adicionais.Cod;

            try
            {
                bdAdicionais.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bdAdicionais.Close();
            }
        }

        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                string comandoSql = "SELECT * FROM Adicionais";

                bdAdicionais.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bdAdicionais.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdAdicionais.Close();
            }
            return Dtt;
        }
    }
}
