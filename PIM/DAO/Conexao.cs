using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.DAO
{
    class Conexao
    {
        public SqlConnection Conn = new SqlConnection(@"");

        public void Open()
        {
            Conn.Open();
        }

        public void Close()
        {
            Conn.Close();
        }
    }
}
