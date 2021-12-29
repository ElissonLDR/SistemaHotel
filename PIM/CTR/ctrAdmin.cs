using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIM.DAO;
using PIM.Model;

namespace PIM.CTR
{
    class ctrAdmin
    {
        daoAdmin daoAdmin;
        DataTable dtGrid;
        public ctrAdmin()
        {
            daoAdmin = new daoAdmin();
        }
        public void Create(Admin admin)
        {
            daoAdmin.Create(admin);
        }
        public Admin Read(Admin admin)
        {
            return daoAdmin.Read(admin);
        }
        public void Update(Admin admin)
        {
            daoAdmin.Update(admin);
        }
        public void Delete(Admin admin)
        {
            daoAdmin.Delete(admin);
        }
        public DataTable DataGrid()
        {
            dtGrid = new DataTable();
            dtGrid = daoAdmin.DataGrid();
            return dtGrid;
        }
    }
}
