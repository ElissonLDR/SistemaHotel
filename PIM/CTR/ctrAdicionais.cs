using PIM.DAO;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.CTR
{
    class ctrAdicionais
    {
        daoAdicionais daoAdicionais;
        public ctrAdicionais()
        {
            daoAdicionais = new daoAdicionais();
        }
        public void Create(Adicionais adicionais)
        {
            daoAdicionais.Create(adicionais);
        }
        public void Update(Adicionais adicionais)
        {
            daoAdicionais.Update(adicionais);
        }
        public void Delete(Adicionais adicionais)
        {
            daoAdicionais.Delete(adicionais);
        }
    }
}
