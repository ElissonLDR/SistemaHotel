using PIM.DAO;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.CTR
{
    class ctrFechamento
    {
        daoFechamento daoFechamento;
        public ctrFechamento()
        {
            daoFechamento = new daoFechamento();
        }
        public Fechamento ReadAdicional(Fechamento fechamento)
        {
            return daoFechamento.ReadAdicional(fechamento);
        }
    }
}
