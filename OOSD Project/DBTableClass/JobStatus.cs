using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class JobStatus
    {

        public string rank { get; set; }
        public string post { get; set; }
        public string em_type { get; set; }
        public DateTime contract_started_date { get; set; }
        public DateTime contract_ended_date { get; set; }
        public string probation_time { get; set; }
        public DateTime probation_started_date { get; set; }
        public DateTime probation_ended_date { get; set; }
        public bool probation_to_permanent_status { get; set; }
        public DateTime probation_to_permanent_date { get; set; }
        public DateTime contract_to_permanent_date { get; set; }

    }
}
