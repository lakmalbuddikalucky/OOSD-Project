using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class NonCashBenefit
    {

        public int ncb_id { set; get; }
        public string approved_benefit { set; get; }

        DateTime date_issued;
        public DateTime getdate_issued()
        {
            return date_issued;
        }
        public void setdate_issued(DateTime dt)
        {
            this.date_issued = dt;
        }

        public float amount { set; get; }
        public float price { set; get; }
    }
}
