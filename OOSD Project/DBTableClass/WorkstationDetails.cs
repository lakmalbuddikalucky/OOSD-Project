﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class WorkstationDetails
    {
        public int ws_id { set; get; }
        public string rank { set; get; }
        public string division { set; get; }
        public string post { set; get; }


        DateTime date_of_post;
        public DateTime getDate_of_post()
        {
            return date_of_post;
        }
        public void setDate_of_post(DateTime dt)
        {
            this.date_of_post = dt;
        }


        public string salary_station { set; get; }
        public string responsibility { set; get; }
        public string power { set; get; }

    }
}
