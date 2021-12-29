using PIM.DAO;
using PIM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.CTR
{
    class ctrReserva
    {
        daoReserva daoReserva;
        public ctrReserva()
        {
            daoReserva = new daoReserva();
        }
        public void Create(Reserva reserva)
        {
            daoReserva.Create(reserva);
        }
        public Reserva ReadCPF(Reserva reserva)
        {
            return daoReserva.ReadCPF(reserva);
        }
        public Reserva ReadReserva(Reserva reserva)
        {
            return daoReserva.ReadReserva(reserva);
        }
        public Reserva ReadDisp(Reserva reserva)
        {
            return daoReserva.ReadDisp(reserva);
        }
        public void Update(Reserva reserva)
        {
            daoReserva.Update(reserva);
        }
        public void UpdateQuarto(Reserva reserva)
        {
            daoReserva.UpdateQuarto(reserva);
        }
        public void Delete(Reserva reserva)
        {
            daoReserva.Delete(reserva);
        }
        public Reserva ReadQuarto(Reserva reserva)
        {
            return daoReserva.ReadQuarto(reserva);
        }
    }
}
