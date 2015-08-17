using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Membership
    {
        public int mem_id { set; get; }
        public string institute { set; get; }
        public string post_name { set; get; }
        public string method { set; get; }
        public string member_id { set; get; }
        public string contribution { set; get; }


        DateTime begin_date;
        public DateTime getBegin_date()
        {
            return begin_date;
        }
        public void setBegin_date(DateTime dt)
        {
            this.begin_date = dt;
        }


        DateTime renewal_date;
        public DateTime getRenewal_date()
        {
            return renewal_date;
        }
        public void setRenewal_date(DateTime dt)
        {
            this.renewal_date = dt;
        }


        public string status { set; get; }
        public bool personal_payment { set; get; }


        DateTime active_date_person;
        public DateTime getActive_date_person()
        {
            return active_date_person;
        }
        public void setActive_date_person(DateTime dt)
        {
            this.active_date_person = dt;
        }


        public bool institutional_payment { set; get; }


        DateTime active_date_insti;
        public DateTime getActive_date_insti()
        {
            return active_date_insti;
        }
        public void setActive_date_insti(DateTime dt)
        {
            this.active_date_insti = dt;
        }

    }
}
