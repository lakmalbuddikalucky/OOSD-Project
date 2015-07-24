using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class FinanceBank
    {

        public string bank_name { set; get; }
        public string branch_name { set; get; }
        public string account_number { set; get; }
        public string account_type { set; get; }
        public DateTime begin_date { set; get; }
        public DateTime end_date { set; get; }
        public string qualification { set; get; }
        public DateTime qual_date { set; get; }

    }
}
