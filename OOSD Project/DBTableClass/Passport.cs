using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Passport
    {
        public string rank { set; get; }
        public string post { set; get; }
        public string number { set; get; }
        public string place_of_issue { set; get; }
        public DateTime date_of_issue { set; get; }
        public DateTime date_of_renewal { set; get; }
        public bool status { set; get; }

    }
}
