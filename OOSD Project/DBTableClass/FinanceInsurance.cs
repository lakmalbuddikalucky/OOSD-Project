using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class FinanceInsurance
    {
        public string type { set; get; }
        public double value { set; get; }
        public DateTime begin_date { set; get; }
        public DateTime end_date { set; get; }
        public string note { set; get; }

    }
}
