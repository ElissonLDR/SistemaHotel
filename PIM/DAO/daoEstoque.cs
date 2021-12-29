using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.CTR;
using PIM.Model;
using PIM.View;

namespace PIM.DAO
{
    class daoEstoque
    {
        Conexao bd;
        string comandoSql;
        public daoEstoque()
        {
            bd = new Conexao();
        }       
        public void Create(Estoque estoque)
        {

            comandoSql = "INSERT INTO Estoque ([Nome],[Qtd],[Tipo])" +
                "VALUES (@NOME, @QTD, @TIPO)";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@NOME", SqlDbType.Char).Value = estoque.Nome;
            comando.Parameters.Add("@QTD", SqlDbType.Char).Value = estoque.Quantidade;
            comando.Parameters.Add("@TIPO", SqlDbType.Char).Value = estoque.Tipo;

            try
            {
                bd.Open();
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
                if (bd.Conn.State == ConnectionState.Open)
                {
                    bd.Close();
                }

            }

        }
        public void Update(Estoque estoque)
        {
            {

                comandoSql = "UPDATE Estoque SET Nome = @NOME , Qtd = @QTD , Tipo = @TIPO WHERE COD = @COD";

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                comando.Parameters.Add("@COD", SqlDbType.Char).Value = estoque.Cod;
                comando.Parameters.Add("@NOME", SqlDbType.Char).Value = estoque.Nome;
                comando.Parameters.Add("@QTD", SqlDbType.Char).Value = estoque.Quantidade;
                comando.Parameters.Add("@TIPO", SqlDbType.Char).Value = estoque.Tipo;

                try
                {
                    bd.Open();
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
                    if (bd.Conn.State == ConnectionState.Open)
                    {
                        bd.Close();
                    }

                }
            }
        }
        public void Delete(Estoque estoque)
        {
            comandoSql = "DELETE FROM Estoque WHERE COD = @COD";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@COD", SqlDbType.VarChar).Value = estoque.Cod;

            try
            {
                bd.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bd.Close();
            }
        }

        public DataTable DataGridAlimentos()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                string comandoSql = "SELECT * FROM Estoque WHERE Tipo = 'Alimentos'";

                bd.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Close();
            }
            return Dtt;
        }
        public DataTable DataGridEquipamentos()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                string comandoSql = "SELECT * FROM Estoque WHERE Tipo = 'Equipamentos'";

                bd.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Close();
            }
            return Dtt;
        }
        public DataTable DataGridLavanderia()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                string comandoSql = "SELECT * FROM Estoque WHERE Tipo = 'Lavanderia'";

                bd.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Close();
            }
            return Dtt;
        }
        public DataTable DataGridDiveros()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                string comandoSql = "SELECT * FROM Estoque";

                bd.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Close();
            }
            return Dtt;
        }
    }
}
