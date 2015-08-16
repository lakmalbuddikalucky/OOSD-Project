using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class DisciplinaryDetails
    {

        public string rank { get; set; }
        public string post { get; set; }
        public string breaking { get; set; }
        public string request_main_admin { get; set; }
        public DateTime breaking_date { get; set; }
        public string given_sentence { get; set; }
        public DateTime given_sentence_date { get; set; }
        public string verdict_of_director_general { get; set; }
        public DateTime verdict_of_director_general_date { get; set; }
        public string inquiry_officer { get; set; }
        public DateTime suspended_date { get; set; }
        public DateTime rejoined_date { get; set; }
        public string suspended_time { get; set; }
    }
}
