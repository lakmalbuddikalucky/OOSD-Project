using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class FinanceTax
    {
        public int ft_id { set; get; }
        public string type { set; get; }
        public string number { set; get; }
        public string payment_method { set; get; }
        public string status { set; get; }
        public string note { set; get; }

    }
}
