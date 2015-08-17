using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Qualification
    {
        public int q_id { set; get; }
        public string qualification_no { set; get; }
        public string institute { set; get; }
        public string months { set; get; }
        public bool occupation_relevant { set; get; }
        public bool highest_qualification { set; get; }
        public string status { set; get; }
        public string note { set; get; }
        public string qualification { set; get; }
        public string year { set; get; }
    }
}
