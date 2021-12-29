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
    class ctrQuartos
    {
        daoQuartos daoQuarto;
        public ctrQuartos()
        {
            daoQuarto = new daoQuartos();
        }
        public void Create(Quartos quartos)
        {
            daoQuarto.Create(quartos);
        }
        public Quartos Read(Quartos quartos)
        {
            return daoQuarto.Read(quartos);
        }
        public void Update(Quartos quartos)
        {
            daoQuarto.Update(quartos);
        }
        public void Delete(Quartos quartos)
        {
            daoQuarto.Delete(quartos);
        }
        public Quartos ReadCodigo(Quartos quartos)
        {
            return daoQuarto.ReadCodigo(quartos);
        }
    }
}
