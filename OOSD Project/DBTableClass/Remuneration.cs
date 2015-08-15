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
        public float basic_salary { set; get; }
        public float transport_allowance { set; get; }
        public float fuel_allowance { set; get; }
        public float mobile_phone_allowance { set; get; }
        public float housing_allowance { set; get; }
        public float other_allowance { set; get; }

        DateTime salary_increase_date;
        public DateTime getsalary_increase_date()
        {
            return salary_increase_date;
        }
        public void setsalary_increase_date(DateTime dt)
        {
            this.salary_increase_date = dt;
        }

        public float salary_increase_amount { set; get; }
        public float current_total_salary { set; get; }

    }
}
