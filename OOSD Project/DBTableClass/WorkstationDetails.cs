using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class WorkstationDetails
    {
        public string rank { set; get; }
        public string division { set; get; }
        public string post { set; get; }
        
        
        public string date_of_post;
        public string getDate_of_post()
        {
            return this.date_of_post;
        }
        public void setDate_of_post(string year, string month, string date)
        {
            DateTime dt = Convert.ToDateTime(month + "/" + date + "/" + year);
            this.date_of_post = dt.ToString("yyyy-MM-dd");
        }


        public string salary_station { set; get; }
        public string responsibility { set; get; }
        public string power { set; get; }

    }
}
