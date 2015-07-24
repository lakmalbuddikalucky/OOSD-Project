using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Membership
    {
        public string institute { set; get; }
        public string post_name { set; get; }
        public string method { set; get; }
        public string member_id { set; get; }
        public string contribution { set; get; }


        string begin_date;
        public string getBegin_date()
        {
            return begin_date;
        }
        public void setBegin_date(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.begin_date = dt.ToString("yyyy-MM-dd");
        }


        string renewal_date;
        public string getRenewal_date()
        {
            return renewal_date;
        }
        public void setRenewal_date(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.renewal_date = dt.ToString("yyyy-MM-dd");
        }


        public string status { set; get; }
        public bool personal_payment { set; get; }


        string active_date_person;
        public string getActive_date_person()
        {
            return active_date_person;
        }
        public void setActive_date_person(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.active_date_person = dt.ToString("yyyy-MM-dd");
        }


        public bool institutional_payment { set; get; }


        string active_date_insti;
        public string getActive_date_insti()
        {
            return active_date_insti;
        }
        public void setActive_date_insti(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.active_date_insti = dt.ToString("yyyy-MM-dd");
        }

    }
}
