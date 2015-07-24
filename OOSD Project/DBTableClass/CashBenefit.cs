using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class CashBenefit
    {
        string approved_benefit { set; get; }
        float price { set; get; }

        public CashBenefit()
        {

        }
        public CashBenefit(string approved_benefit, float price)
        {
            this.approved_benefit = approved_benefit;
            this.price = price;
        }
    }
}
