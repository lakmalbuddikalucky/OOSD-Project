using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class WorkingExperience
    {
        public string institute { set; get; }
        public string address { set; get; }
        public string telephone { set; get; }
        public string email { set; get; }
        public string department { set; get; }
        public string contact { set; get; }


        DateTime date_from;
        public DateTime getDate_from()
        {
            return date_from;
        }
        public void setDate_from(DateTime dt)
        {

            this.date_from = dt;
        }


        DateTime date_to;
        public DateTime getDate_to()
        {
            return date_to;
        }
        public void setDate_to(DateTime dt)
        {

            this.date_to = dt;
        }


        DateTime date_perma;
        public DateTime getDate_perma()
        {
            return date_perma;
        }
        public void setDate_perma(DateTime dt)
        {

            this.date_perma = dt;
        }
     

        public string resign_reason { set; get; }
        public string responsibility { set; get; }
        public bool occupation_relevant { set; get; }
        public string award { set; get; }
    }
}
