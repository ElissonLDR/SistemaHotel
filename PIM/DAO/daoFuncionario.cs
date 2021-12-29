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
    class daoFuncionario
    {
        Conexao bdFuncionario;
        string comandoSql;
        public daoFuncionario()
        {
            bdFuncionario = new Conexao();
        }
        public void Create(Funcionario funcionario)
        {

            comandoSql = "INSERT INTO [dbo].[Funcionario]([Nome],[CPF],[RG],[Nasc],[Celular],[DtAdmissao],[Cargo]," +
                "[CEP],[Rua],[Bairro],[Cidade],[Estado],[Salario],[Senha])" +
                "VALUES (@Nome, @CPF, @RG, @Nasc, @Celular, @DtAdmissao, @Cargo," +
                " @CEP, @Rua, @Bairro, @Cidade , @Estado , @Salario , @Senha)";

            SqlCommand comando = new SqlCommand(comandoSql, bdFuncionario.Conn);

            comando.Parameters.Add("@Nome", SqlDbType.Char).Value = funcionario.Nome;
            comando.Parameters.Add("@CPF", SqlDbType.Char).Value = funcionario.CPF;
            comando.Parameters.Add("@RG", SqlDbType.Char).Value = funcionario.RG;
            comando.Parameters.Add("@Nasc", SqlDbType.Char).Value = funcionario.Nasc;
            comando.Parameters.Add("@Celular", SqlDbType.Char).Value = funcionario.Cel;
            comando.Parameters.Add("@DtAdmissao", SqlDbType.Char).Value = funcionario.DtAdmissao;
            comando.Parameters.Add("@Cargo", SqlDbType.Char).Value = funcionario.Cargo;
            comando.Parameters.Add("@CEP", SqlDbType.Char).Value = funcionario.CEP;
            comando.Parameters.Add("@Rua", SqlDbType.Char).Value = funcionario.Rua;
            comando.Parameters.Add("@Bairro", SqlDbType.Char).Value = funcionario.Bairro;
            comando.Parameters.Add("@Cidade", SqlDbType.Char).Value = funcionario.Cidade;
            comando.Parameters.Add("@Estado", SqlDbType.Char).Value = funcionario.Estado;
            comando.Parameters.Add("@Salario", SqlDbType.Char).Value = funcionario.Salario;
            comando.Parameters.Add("@Senha", SqlDbType.Char).Value = funcionario.SenhaFuncionario;

            try
            {
                bdFuncionario.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                funcionario.CPF = "";
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (bdFuncionario.Conn.State == ConnectionState.Open)
                {
                    bdFuncionario.Close();
                }

            }
        }
        public Funcionario Read(Funcionario funcionario)
        {
            comandoSql = "SELECT * from Funcionario Where CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bdFuncionario.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionario.CPF;

            try
            {
                bdFuncionario.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    funcionario.Nome = Convert.ToString(rd["Nome"]);
                    funcionario.CPF = Convert.ToString(rd["CPF"]);
                    funcionario.RG = Convert.ToString(rd["RG"]);
                    funcionario.Nasc = Convert.ToString(rd["Nasc"]);
                    funcionario.Cel = Convert.ToString(rd["Celular"]);
                    funcionario.DtAdmissao = Convert.ToString(rd["DtAdmissao"]);
                    funcionario.Cargo = Convert.ToString(rd["Cargo"]);
                    funcionario.CEP = Convert.ToString(rd["CEP"]);
                    funcionario.Rua = Convert.ToString(rd["Rua"]);
                    funcionario.Bairro = Convert.ToString(rd["Bairro"]);
                    funcionario.Cidade = Convert.ToString(rd["Cidade"]);
                    funcionario.Estado = Convert.ToString(rd["Estado"]);
                    funcionario.Salario = Convert.ToString(rd["Salario"]);
                    funcionario.SenhaFuncionario = Convert.ToString(rd["Senha"]);

                }
                else
                {
                    funcionario.CPF = "";
                    MessageBox.Show("Este cpf não está cadastrado.");
                    return null;
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bdFuncionario.Close();
            }
            
        }
        public void Update(Funcionario funcionario)
        {
            {

                comandoSql = "UPDATE Funcionario SET Nome = @Nome , CPF = @CPF , RG = @RG , Nasc = @Nasc , Celular = @Celular " +
                    ", DtAdmissao = @DtAdmissao , Cargo = @Cargo , CEP = @CEP , Rua = @Rua , Bairro = @Bairro , Cidade = @Cidade , Estado = @Estado , Salario = @Salario , Senha = @Senha " +
                    "WHERE CPF = @CPF";

                SqlCommand comando = new SqlCommand(comandoSql, bdFuncionario.Conn);

                comando.Parameters.Add("@Nome", SqlDbType.Char).Value = funcionario.Nome;
                comando.Parameters.Add("@CPF", SqlDbType.Char).Value = funcionario.CPF;
                comando.Parameters.Add("@RG", SqlDbType.Char).Value = funcionario.RG;
                comando.Parameters.Add("@Nasc", SqlDbType.Char).Value = funcionario.Nasc;
                comando.Parameters.Add("@Celular", SqlDbType.Char).Value = funcionario.Cel;
                comando.Parameters.Add("@DtAdmissao", SqlDbType.Char).Value = funcionario.DtAdmissao;
                comando.Parameters.Add("@Cargo", SqlDbType.Char).Value = funcionario.Cargo;
                comando.Parameters.Add("@CEP", SqlDbType.Char).Value = funcionario.CEP;
                comando.Parameters.Add("@Rua", SqlDbType.Char).Value = funcionario.Rua;
                comando.Parameters.Add("@Bairro", SqlDbType.Char).Value = funcionario.Bairro;
                comando.Parameters.Add("@Cidade", SqlDbType.Char).Value = funcionario.Cidade;
                comando.Parameters.Add("@Estado", SqlDbType.Char).Value = funcionario.Estado;
                comando.Parameters.Add("@Salario", SqlDbType.Char).Value = funcionario.Salario;
                comando.Parameters.Add("@Senha", SqlDbType.Char).Value = funcionario.SenhaFuncionario;

                try
                {
                    bdFuncionario.Open();
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
                    if (bdFuncionario.Conn.State == ConnectionState.Open)
                    {
                        bdFuncionario.Close();
                    }

                }
            }
        }
        public void Delete(Funcionario funcionario)
        {
            comandoSql = "DELETE FROM Funcionario WHERE CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bdFuncionario.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionario.CPF;

            try
            {
                bdFuncionario.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bdFuncionario.Close();
            }
        }

        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                string comandoSql = "SELECT * FROM Funcionario";

                bdFuncionario.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bdFuncionario.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdFuncionario.Close();
            }
            return Dtt;

        }
    }
}
