using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBTableClass
{
    class Remuneration
    {
        public string salary_grade { set; get; }
        public string salary_slip_no { set; get; }
        public string basic_salary { set; get; }
        public string transport_allowance { set; get; }
        public string fuel_allowance { set; get; }
        public string mobile_phone_allowance { set; get; }
        public string housing_allowance { set; get; }
        public string other_allowance { set; get; }
        public DateTime salary_increase_date { set; get; }
        public string salary_increase_amount { set; get; }
        public string current_total_salary { set; get; }

    }
}
