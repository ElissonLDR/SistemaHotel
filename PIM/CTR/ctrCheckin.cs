using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIM.DAO;
using PIM.Model;

namespace PIM.CTR
{
    class ctrCheckin
    {
        daoCheckin daoCheckin;
        public ctrCheckin()
        {
            daoCheckin = new daoCheckin();
        }
        public void UpdateCheckin(Checkin checkin)
        {
            daoCheckin.UpdateCheckin(checkin);
        }
        public void UpdateCheckout(Checkin checkin)
        {
            daoCheckin.UpdateCheckout(checkin);
        }
    }
}
