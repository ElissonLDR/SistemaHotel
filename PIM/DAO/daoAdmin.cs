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
    class daoAdmin
    {
        Conexao bdAdmin;
        string comandoSql;
        public daoAdmin()
        {
            bdAdmin = new Conexao();    
        }

        public void Create(Admin admin)
        {

            comandoSql = "INSERT INTO [dbo].[Admin]([Nome],[CNPJ],[Cargo],[Senha])" +
                "VALUES (@NOME, @CNPJ, @CARGO, @SENHA)";

            SqlCommand comando = new SqlCommand(comandoSql, bdAdmin.Conn);

            comando.Parameters.Add("@NOME", SqlDbType.Char).Value = admin.Nome;
            comando.Parameters.Add("@CNPJ", SqlDbType.Char).Value = admin.CNPJ;
            comando.Parameters.Add("@CARGO", SqlDbType.Char).Value = admin.Cargo;
            comando.Parameters.Add("@SENHA", SqlDbType.Char).Value = admin.Senha;

            try
            {
                bdAdmin.Open();
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
                if (bdAdmin.Conn.State == ConnectionState.Open)
                {
                    bdAdmin.Close();
                }

            }
        }

        public Admin Read(Admin admin)
        {
            comandoSql = "SELECT * FROM Admin WHERE CNPJ = @CNPJ";

            SqlCommand comando = new SqlCommand(comandoSql, bdAdmin.Conn);

            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = admin.CNPJ;

            try
            {
                bdAdmin.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    admin.CNPJ = Convert.ToString(rd["CNPJ"]);
                    admin.Senha = Convert.ToString(rd["Senha"]);

                }
                else
                {                    
                    admin.CNPJ = "";
                    MessageBox.Show("Este cpf não está cadastrado.");
                    return null;
                }
                return admin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bdAdmin.Close();
            }

        }

        public void Update(Admin admin)
        {
            {
                comandoSql = "UPDATE Admin SET Nome = @NOME , Cargo = @CARGO ," +
                    " Senha = @SENHA WHERE CNPJ = @CNPJ";

                SqlCommand comando = new SqlCommand(comandoSql, bdAdmin.Conn);

                comando.Parameters.Add("@NOME", SqlDbType.Char).Value = admin.Nome;
                comando.Parameters.Add("@CNPJ", SqlDbType.Char).Value = admin.CNPJ;
                comando.Parameters.Add("@CARGO", SqlDbType.Char).Value = admin.Cargo;
                comando.Parameters.Add("@SENHA", SqlDbType.Char).Value = admin.Senha;

                try
                {
                    bdAdmin.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Salvo com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch 
                {
                    admin.CNPJ = "";
                    MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (bdAdmin.Conn.State == ConnectionState.Open)
                    {
                        bdAdmin.Close();
                    }

                }
            }
        }

        public void Delete(Admin admin)
        {
            comandoSql = "DELETE FROM Admin WHERE CNPJ = @CNPJ";

            SqlCommand comando = new SqlCommand(comandoSql, bdAdmin.Conn);

            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = admin.CNPJ;

            try
            {
                bdAdmin.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bdAdmin.Close();
            }
        }

        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                comandoSql = "SELECT * FROM Admin";

                bdAdmin.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bdAdmin.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdAdmin.Close();
            }
            return Dtt;

        }
    }
}
