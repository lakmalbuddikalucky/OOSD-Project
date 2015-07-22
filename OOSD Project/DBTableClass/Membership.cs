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
        public DateTime begin_date { set; get; }
        public DateTime renewal_date { set; get; }
        public string status { set; get; }
        public bool personal_payment { set; get; }
        public DateTime active_date_person { set; get; }
        public bool institutional_payment { set; get; }
        public DateTime active_date_insti { set; get; }
    }
}
