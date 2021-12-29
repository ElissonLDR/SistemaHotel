using PIM.DAO;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.CTR
{
    class ctrHospedes
    {
        daoHospedes daoHospedes;
        DataTable dtGrid;
        public ctrHospedes()
        {
            daoHospedes = new daoHospedes();
        }
        public void Create(Hospedes hospedes)
        {
            daoHospedes.Create(hospedes);
        }
        public Hospedes Read(Hospedes hospedes)
        {
            return daoHospedes.Read(hospedes);
        }
        public Hospedes ReadCPF(Hospedes hospedes)
        {
            return daoHospedes.ReadCPF(hospedes);
        }
        public void Update(Hospedes hospedes)
        {
            daoHospedes.Update(hospedes);
        }
        public void Delete(Hospedes hospedes)
        {
            daoHospedes.Delete(hospedes);
        }

        public DataTable DataGrid()
        {
            dtGrid = new DataTable();
            dtGrid = daoHospedes.DataGrid();
            return dtGrid;
        }
    }
    
}
