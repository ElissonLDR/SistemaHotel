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
    class ctrFuncionario
    {
        daoFuncionario daoFuncionario;
        DataTable dtGrid;
        public ctrFuncionario()
        {
            daoFuncionario = new daoFuncionario();
        }
        public void Create(Funcionario funcionario)
        {
            daoFuncionario.Create(funcionario);
        }
        public Funcionario Read(Funcionario funcionario)
        {
            return daoFuncionario.Read(funcionario);
        }
        public void Update(Funcionario funcionario)
        {
            daoFuncionario.Update(funcionario);
        }
        public void Delete(Funcionario funcionario)
        {
            daoFuncionario.Delete(funcionario);
        }

        public DataTable DataGrid()
        {
            dtGrid = new DataTable();
            dtGrid = daoFuncionario.DataGrid();
            return dtGrid;
        }
    }
}
