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
        
        
        public string date_from;
        public string getDate_from()
        {
            return date_from;
        }
        public void setDate_from(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_from = dt.ToString("yyyy-MM-dd");
        }


        public string date_to;
        public string getDate_to()
        {
            return date_to;
        }
        public void setDate_to(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_to = dt.ToString("yyyy-MM-dd");
        }

        public string date_perma;
        public string getDate_perma()
        {
            return date_perma;
        }
        public void setDate_perma(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_perma = dt.ToString("yyyy-MM-dd");
        }
     

        public string resign_reason { set; get; }
        public string responsibility { set; get; }
        public bool occupation_relevant { set; get; }
        public string award { set; get; }
    }
}
