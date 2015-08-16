using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class PensionAndDeath
    {

        public bool retired { get; set; }
        public bool dead { get; set; }
        public DateTime died_date { get; set; }
        public string note { get; set; }
        public DateTime informed_date { get; set; }
    }
}
