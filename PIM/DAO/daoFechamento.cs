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
    class daoFechamento
    {
        Conexao bdFechamento;
        string comandoSql;
        public daoFechamento()
        {
            bdFechamento = new Conexao();
        }

        public Fechamento ReadAdicional(Fechamento fechamento)
        {

            comandoSql = "SELECT* from Adicionais Where Nome = @NOME";

            SqlCommand comando = new SqlCommand(comandoSql, bdFechamento.Conn);

            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = fechamento.Nome;

            try
            {
                bdFechamento.Open();
                SqlDataReader rd = comando.ExecuteReader();

                if (rd.HasRows == true)
                {
                    rd.Read();
                    fechamento.Nome = Convert.ToString(rd["Nome"]);
                    fechamento.Preco = Convert.ToString(rd["Preco"]);
                }
                else
                {
                    fechamento.Nome = "";
                }
                return fechamento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                bdFechamento.Close();
            }
        }
        public DataTable Adicionais()
        {
            DataTable dtAdicionais;
            try
            {
                dtAdicionais = new DataTable();

                comandoSql = "SELECT* FROM Adicionais order by Nome asc";

                bdFechamento.Open();

                SqlCommand comando = new SqlCommand(comandoSql, bdFechamento.Conn);

                SqlDataAdapter sd = new SqlDataAdapter(comando);

                sd.Fill(dtAdicionais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bdFechamento.Close();
            }
            return dtAdicionais;
        }
    }
}
