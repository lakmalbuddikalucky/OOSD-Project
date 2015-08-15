using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Passport
    {
        public string rank { set; get; }
        public string post { set; get; }
        public string number { set; get; }
        public string place_of_issue { set; get; }

        DateTime date_of_issue;
        public DateTime getdate_of_issue()
        {
            return date_of_issue;
        }
        public void setdate_of_issue(DateTime dt)
        {
            this.date_of_issue = dt;
        }


        DateTime date_of_renewal;
        public DateTime getdate_of_renewal()
        {
            return date_of_renewal;
        }
        public void setdate_of_renewal(DateTime dt)
        {
            this.date_of_renewal = dt;
        }

        public bool status { set; get; }

    }
}
