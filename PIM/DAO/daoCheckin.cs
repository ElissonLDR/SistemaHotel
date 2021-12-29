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
    class daoCheckin
    {
        Conexao bdCheckin;
        string comandoSql;
        DateTime Hoje = DateTime.Today.Date;
        public daoCheckin()
        {
            bdCheckin = new Conexao();
        }
        public DataTable DataGrid()
        {
            DataTable Dtt;
            try
            {
                Dtt = new DataTable();

                comandoSql = "SELECT CPF, Checkin, Checkout, SituacaoCheckin, SituacaoCheckout " +
                    "FROM Reserva WHERE Checkin = @HOJE";

                bdCheckin.Open();
                
                SqlCommand comando = new SqlCommand(comandoSql, bdCheckin.Conn);

                var dtHoje = Hoje.ToShortDateString();

                comando.Parameters.Add("@HOJE", SqlDbType.VarChar).Value = dtHoje;

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdCheckin.Close();
            }
            return Dtt;
        }

        public void UpdateCheckin(Checkin checkin)
        {
            comandoSql = "UPDATE Reserva SET SituacaoCheckin = @situacaoCheckin WHERE CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bdCheckin.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.Char).Value = checkin.CPF;
            comando.Parameters.Add("@situacaoCheckin", SqlDbType.VarChar).Value = checkin.situacaoCheckin;

            try
            {
                bdCheckin.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Checkin realizado!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (bdCheckin.Conn.State == ConnectionState.Open)
                {
                    bdCheckin.Close();
                }

            }
        }
        
        public void UpdateCheckout(Checkin checkin)
        {
            comandoSql = "UPDATE Reserva SET SituacaoCheckout = @situacaoCheckout WHERE CPF = @CPF";

            SqlCommand comando = new SqlCommand(comandoSql, bdCheckin.Conn);

            comando.Parameters.Add("@CPF", SqlDbType.Char).Value = checkin.CPF;
            comando.Parameters.Add("@situacaoCheckout", SqlDbType.VarChar).Value = checkin.situacaoCheckout;

            try
            {
                bdCheckin.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Checkout realizado!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Opa, houve um problema com os dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (bdCheckin.Conn.State == ConnectionState.Open)
                {
                    bdCheckin.Close();
                }

            }
        }
    }
}
