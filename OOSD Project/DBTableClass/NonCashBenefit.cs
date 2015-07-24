using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class NonCashBenefit
    {
        public string approved_benefit { set; get; }
        public DateTime date_issued { set; get; }
        public string amount { set; get; }
        public string price { set; get; }
    }
}
