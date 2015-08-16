using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Resignation
    {
        public string rank { get; set; }
        public string post { get; set; }
        public DateTime letter_submitted_date { get; set; }
        public DateTime resignation_date { get; set; }
        public string reason { get; set; }
        public string resignation_letter { get; set; }
    }
}
