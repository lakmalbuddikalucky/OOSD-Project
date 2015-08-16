using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class InterdictSuspend
    {

        public string post { get; set; }
        public string rank { get; set; }
        public string reason { get; set; }
        public DateTime unattended_from { get; set; }
        public DateTime unattended_to { get; set; }
        public bool rejoined { get; set; }
        public DateTime suspend_from { get; set; }
        public DateTime suspend_to { get; set; }
        public string more_notes { get; set; }

    }
}
