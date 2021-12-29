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
    class ctrEstoque
    {
        daoEstoque daoEstoque;
        public ctrEstoque()
        {
            daoEstoque = new daoEstoque();
        }
        public void Create(Estoque estoque)
        {
            daoEstoque.Create(estoque);
        }
        public void Update(Estoque estoque)
        {
            daoEstoque.Update(estoque);
        }
        public void Delete(Estoque estoque)
        {
            daoEstoque.Delete(estoque);
        }

    }
}
