using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Transport
    {
        public string route { set; get; }
        public string transport_method { set; get; }
        public string distance_to_home { set; get; }
        public string time_spent { set; get; }
        public string nearest_station { set; get; }
        public string official_transport_method { set; get; }
        public string type_of_vehicle { set; get; }
        public string year_of_manufacture { set; get; }
        public string type_of_fuel { set; get; }
        public string fuel_limit { set; get; }
    }
}
