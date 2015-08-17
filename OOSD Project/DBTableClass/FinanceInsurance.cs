using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class FinanceInsurance
    {
        public int fi_id { set; get; }
        public string type { set; get; }
        public double value { set; get; }

        DateTime begin_date;
        public DateTime getBegin_date()
        {
            return begin_date;
        }
        public void setBegin_date(DateTime dt)
        {
            this.begin_date = dt;
        }


        DateTime end_date;
        public DateTime getEnd_date()
        {
            return end_date;
        }
        public void setEnd_date(DateTime dt)
        {
            this.end_date = dt;
        }

        public string note { set; get; }

    }
}
