using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Training
    {

        public string course_name { get; set; }
        public string course_type { get; set; }
        public string institute { get; set; }
        public string payments { get; set; }
        public DateTime started_date { get; set; }
        public DateTime ending_date { get; set; }
        public string extended_days { get; set; }
        public DateTime new_ending_date { get; set; }
        public string country { get; set; }
        public string result { get; set; }

    }
}
