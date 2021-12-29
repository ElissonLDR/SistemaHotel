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
    class daoHospedes
    {
        Conexao bdHospede;
        string comandoSql;
        public daoHospedes()
        {
            bdHospede = new Conexao();
        }
        public void Create(Hospedes hospede)
        {
            comandoSql = "INSERT INTO [dbo].[Hospede]([Nome],[CPF],[Nascimento],[Email]," +
                "[Celular],[CEP],[Rua],[Bairro],[Cidade],[Estado])" +
                "VALUES(@NOME, @CPF, @NASC, @EMAIL, @CELULAR, @CEP, @RUA, @BAIRRO, @CIDADE, @ESTADO)";

            SqlCommand comando = new SqlCommand(comandoSql, bdHospede.Conn);

            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = hospede.Nome;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = hospede.CPF;
            comando.Parameters.Add("@NASC", SqlDbType.VarChar).Value = hospede.Nascimento;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = hospede.Email;
            comando.Parameters.Add("@CELULAR", SqlDbType.VarChar).Value = hospede.Celular;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = hospede.CEP;
            comando.Parameters.Add("@RUA", SqlDbType.VarChar).Value = hospede.Rua;
            comando.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = hospede.Bairro;
            comando.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = hospede.Cidade;
            comando.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = hospede.Estado;

            try
            {
                bdHospede.Open();
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
                if (bdHospede.Conn.State == ConnectionState.Open)
                {
                    bdHospede.Close();
                }

            }
        }
        public Hospedes Read(Hospedes hospede)
        {
            
            comandoSql = "SELECT* from Hospede Where CPF = @Buscar";

            SqlCommand comando = new SqlCommand(comandoSql, bdHospede.Conn);

            comando.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = hospede.Buscar;
            try
            {
                bdHospede.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    hospede.Nome = Convert.ToString(rd["Nome"]);
                    hospede.CPF = Convert.ToString(rd["CPF"]);
                    hospede.Nascimento = Convert.ToString(rd["Nascimento"]);
                    hospede.Email = Convert.ToString(rd["Email"]);
                    hospede.Celular = Convert.ToString(rd["Celular"]);
                    hospede.CEP = Convert.ToString(rd["CEP"]);
                    hospede.Rua = Convert.ToString(rd["Rua"]);
                    hospede.Bairro = Convert.ToString(rd["Bairro"]);
                    hospede.Cidade = Convert.ToString(rd["Cidade"]);
                    hospede.Estado = Convert.ToString(rd["Estado"]);
                }
                else
                {     
                    MessageBox.Show("Este CPF não está cadastrado.");
                    return null;
                }                
                return hospede;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                bdHospede.Close();
            }
        } 
        public Hospedes ReadCPF(Hospedes hospede)
        {
            
            comandoSql = "SELECT* from Hospede Where CPF = @Buscar";

            SqlCommand comando = new SqlCommand(comandoSql, bdHospede.Conn);

            comando.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = hospede.Buscar;
            try
            {
                bdHospede.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();hospede.CPF = Convert.ToString(rd["CPF"]);
                }
                else
                {
                    hospede.CPF = "";
                    return null;
                }                
                return hospede;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                bdHospede.Close();
            }
        }
        public void Update(Hospedes hospede)
        {
            comandoSql = "UPDATE Hospede SET Nome = @NOME, CPF = @CPF, Nascimento = @NASC, " +
                "Email = @EMAIL, Celular = @CELULAR, CEP = @CEP, Rua = @RUA, " +
                "Bairro = @BAIRRO, Cidade = @CIDADE, Estado = @ESTADO WHERE CPF = @Buscar";

            SqlCommand comando = new SqlCommand(comandoSql, bdHospede.Conn);

            comando.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = hospede.Buscar;
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = hospede.Nome;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = hospede.CPF;
            comando.Parameters.Add("@NASC", SqlDbType.VarChar).Value = hospede.Nascimento;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = hospede.Email;
            comando.Parameters.Add("@CELULAR", SqlDbType.VarChar).Value = hospede.Celular;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = hospede.CEP;
            comando.Parameters.Add("@RUA", SqlDbType.VarChar).Value = hospede.Rua;
            comando.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = hospede.Bairro;
            comando.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = hospede.Cidade;
            comando.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = hospede.Estado;

            try
            {
                bdHospede.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bdHospede.Close();
            }
        }
        public void Delete(Hospedes hospede)
        {
            comandoSql = "DELETE FROM Hospede WHERE CPF = @Buscar";

            SqlCommand comando = new SqlCommand(comandoSql, bdHospede.Conn);

            comando.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = hospede.Buscar;

            try
            {
                bdHospede.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bdHospede.Close();
            }
        }


        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();                
                
                string comandoSql = "SELECT * FROM Hospede";
               
                bdHospede.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bdHospede.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);
                              
                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdHospede.Close();
            }
            return Dtt;
        }



    }
}

