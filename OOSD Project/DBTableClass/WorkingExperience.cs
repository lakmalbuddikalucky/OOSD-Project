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
        public DateTime date_from { set; get; }
        public DateTime date_to { set; get; }
        public DateTime date_perma { set; get; }
        public string resign_reason { set; get; }
        public string responsibility { set; get; }
        public bool occupation_relevant { set; get; }
        public string award { set; get; }
    }
}
