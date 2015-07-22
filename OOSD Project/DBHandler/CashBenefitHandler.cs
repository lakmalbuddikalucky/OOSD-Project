using OOSD_Project.Database;
using OOSD_Project.DBTableClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.Handler
{
    class CashBenefitHandler
    {
        //Create Read Update Delete
        public void addCashBenefit(CashBenefit obj)
        {
            DBConnector dbCon = new DBConnector();
            if (dbCon.openConnection())
            {
                string query = "INSERT INTO `ozious`.`cash_benefit` (`idcash_benefit`,`approved_benefit`,`date_issued`,`price`,`employee_idemployee`) VALUES(<{idcash_benefit: }>,<{approved_benefit: }>,<{date_issued: }>,<{price: }>,<{employee_idemployee: }>)";
            }
        }
    }
}
