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

      
        public string qualification { set; get; }


        string qual_year;

        public string Qual_year
        {
            get { return qual_year; }
            set { qual_year = value; }
        }

       

    }
}
