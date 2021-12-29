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
    class daoReserva
    {
        Conexao bd;
        string comandoSql;
        public daoReserva()
        {
            bd = new Conexao();
        }
        public void Create(Reserva reserva)
        {
            comandoSql = "INSERT INTO [dbo].[Reserva]([CPF],[Quarto],[ValorDiaria],[Checkin],[Checkout],[Diarias],[ValorTotal],[Entrada],[ValorFinal],[SituacaoCheckin],[SituacaoCheckout])" +
                "VALUES(@CPF, @QUARTO, @VALORDIARIA, @CHECKIN, @CHECKOUT, @DIARIAS, @VALORTOTAL, @ENTRADA, @VALORFINAL, @SITUACAOCHECKIN , @SITUACAOCHECKOUT)";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.Char).Value = reserva.CPF;
            comando.Parameters.Add("@QUARTO", SqlDbType.Char).Value = reserva.Quarto;
            comando.Parameters.Add("@VALORDIARIA", SqlDbType.Char).Value = reserva.ValorDiaria;
            comando.Parameters.Add("@CHECKIN", SqlDbType.Char).Value = reserva.Checkin;
            comando.Parameters.Add("@CHECKOUT", SqlDbType.Char).Value = reserva.Checkout;
            comando.Parameters.Add("@DIARIAS", SqlDbType.Char).Value = reserva.Diarias;
            comando.Parameters.Add("@VALORTOTAL", SqlDbType.Char).Value = reserva.ValorTotal;
            comando.Parameters.Add("@ENTRADA", SqlDbType.Char).Value = reserva.Entrada;
            comando.Parameters.Add("@VALORFINAL", SqlDbType.Char).Value = reserva.ValorFinal;
            comando.Parameters.Add("@SITUACAOCHECKIN", SqlDbType.Char).Value = reserva.situacaoCheckin;
            comando.Parameters.Add("@SITUACAOCHECKOUT", SqlDbType.Char).Value = reserva.situacaoCheckout;

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

        public Reserva ReadCPF(Reserva reserva)
        {

            comandoSql = "SELECT* from Hospede Where CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = reserva.CPF;

            try
            {
                bd.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    reserva.Nome = Convert.ToString(rd["Nome"]);
                    reserva.CPFHospede = Convert.ToString(rd["CPF"]);
                    reserva.Nascimento = Convert.ToString(rd["Nascimento"]);
                    reserva.Email = Convert.ToString(rd["Email"]);
                    reserva.Celular = Convert.ToString(rd["Celular"]);
                    reserva.CEP = Convert.ToString(rd["CEP"]);
                    reserva.Rua = Convert.ToString(rd["Rua"]);
                    reserva.Bairro = Convert.ToString(rd["Bairro"]);
                    reserva.Cidade = Convert.ToString(rd["Cidade"]);
                    reserva.Estado = Convert.ToString(rd["Estado"]);
                }
                else
                {
                    reserva.CPFHospede = "";
                    MessageBox.Show("Este cpf não está cadastrado.");
                    return null;
                }
                return reserva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bd.Close();
            }
        }
        
        public Reserva ReadReserva(Reserva reserva)
        {

            comandoSql = "SELECT * from Reserva Where CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = reserva.CPF;

            try
            {
                bd.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    reserva.CPF = Convert.ToString(rd["CPF"]);
                    reserva.Quarto = Convert.ToString(rd["Quarto"]);
                    reserva.ValorDiaria = Convert.ToString(rd["ValorDiaria"]);
                    reserva.Checkin = Convert.ToString(rd["Checkin"]);
                    reserva.Checkout = Convert.ToString(rd["Checkout"]);
                    reserva.Diarias = Convert.ToString(rd["Diarias"]);
                    reserva.ValorTotal = Convert.ToString(rd["ValorTotal"]);
                    reserva.Entrada = Convert.ToString(rd["Entrada"]);
                    reserva.ValorFinal = Convert.ToString(rd["ValorFinal"]);
                    reserva.situacaoCheckin = Convert.ToString(rd["SituacaoCheckin"]);
                    reserva.situacaoCheckout = Convert.ToString(rd["SituacaoCheckout"]);
                }
                else
                {
                    reserva.CPF = "";

                }
                return reserva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bd.Close();
            }
        }
        
        public Reserva ReadDisp(Reserva reserva)
        {

            comandoSql = "SELECT * from Reserva Where Quarto = @QUARTO";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@QUARTO", SqlDbType.VarChar).Value = reserva.Quarto;

            try
            {
                bd.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    reserva.Quarto = Convert.ToString(rd["Quarto"]);
                    reserva.Checkin = Convert.ToString(rd["Checkin"]);
                    reserva.Checkout = Convert.ToString(rd["Checkout"]);
                }
                else
                {
                    reserva.Quarto = "";

                }
                return reserva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bd.Close();
            }
        }
        public void Update(Reserva reserva)
        {
            comandoSql = "UPDATE Reserva SET CPF = @CPF, Quarto = @QUARTO, ValorDiaria = @VALORDIARIA, Checkin = @CHECKIN, Checkout = @CHECKOUT," +
                " Diarias = @DIARIAS, ValorTotal = @VALORTOTAL, Entrada = @ENTRADA," +
                "ValorFinal = @VALORFINAL, SituacaoCheckin = @situacaoCheckin, SituacaoCheckout = @situacaoCheckout" +
                " WHERE CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.Char).Value = reserva.CPF;
            comando.Parameters.Add("@QUARTO", SqlDbType.Char).Value = reserva.Quarto;
            comando.Parameters.Add("@VALORDIARIA", SqlDbType.Char).Value = reserva.ValorDiaria;
            comando.Parameters.Add("@CHECKIN", SqlDbType.Char).Value = reserva.Checkin;
            comando.Parameters.Add("@CHECKOUT", SqlDbType.Char).Value = reserva.Checkout;
            comando.Parameters.Add("@DIARIAS", SqlDbType.Char).Value = reserva.Diarias;
            comando.Parameters.Add("@VALORTOTAL", SqlDbType.Char).Value = reserva.ValorTotal;
            comando.Parameters.Add("@ENTRADA", SqlDbType.Char).Value = reserva.Entrada;
            comando.Parameters.Add("@VALORFINAL", SqlDbType.Char).Value = reserva.ValorFinal;
            comando.Parameters.Add("@situacaoCheckin", SqlDbType.Char).Value = reserva.situacaoCheckin;
            comando.Parameters.Add("@situacaoCheckout", SqlDbType.Char).Value = reserva.situacaoCheckout;
            try
            {
                bd.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Alteração salva com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void Delete(Reserva reserva)
        {
            comandoSql = "DELETE FROM Reserva WHERE CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = reserva.CPF;

            try
            {
                bd.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Reserva cancelada!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                comandoSql = "SELECT * FROM Reserva";

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
        public DataTable dtQuartos(Reserva reserva)
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                comandoSql = "SELECT Checkin, Checkout, SituacaoCheckin, SituacaoCheckout FROM Reserva WHERE Quarto = @COD";

                bd.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                comando.Parameters.Add("@COD", SqlDbType.VarChar).Value = reserva.Quarto;

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

        public DataTable Quartos()
        {
            DataTable dtQuarto;
            try
            {
                dtQuarto = new DataTable();

                comandoSql = "SELECT* FROM Quartos order by Codigo asc";

                bd.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(dtQuarto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Close();
            }
            return dtQuarto;
        }

        public Reserva ReadQuarto(Reserva reserva)
        {

            comandoSql = "SELECT* from Quartos Where Codigo = @CODIGO";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = reserva.Quarto;

            try
            {
                bd.Open();
                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    reserva.Numero = Convert.ToString(rd["Num"]);
                    reserva.Diaria = Convert.ToString(rd["Diaria"]);
                    reserva.Andar = Convert.ToString(rd["Andar"]);
                    reserva.Predio = Convert.ToString(rd["Predio"]);
                    reserva.Tipo = Convert.ToString(rd["Tipo"]);
                    reserva.Situacao = Convert.ToString(rd["Situacao"]);
                    reserva.Descricao = Convert.ToString(rd["Descricao"]);
                    reserva.Img1 = (byte[])(rd["Img1"]);
                }
                else
                {
                    reserva.Quarto = "";
                }
                return reserva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bd.Close();
            }
        }


        public void UpdateQuarto(Reserva reserva)
        {
            comandoSql = "UPDATE Quartos SET Situacao = @SITUACAO WHERE Codigo = @QUARTO";

            SqlCommand comando = new SqlCommand(comandoSql, bd.Conn);

            comando.Parameters.Add("@QUARTO", SqlDbType.Char).Value = reserva.Quarto;
            comando.Parameters.Add("@SITUACAO", SqlDbType.VarChar).Value = reserva.Situacao;

            try
            {
                bd.Open();
                comando.ExecuteNonQuery();

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
}
