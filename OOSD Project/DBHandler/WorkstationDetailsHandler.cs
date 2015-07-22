using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using OOSD_Project.DBTableClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBHandler
{
    class WorkstationDetailsHandler
    {

        public static bool addWorkstationDetails(WorkstationDetails wd)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO workstation_details (rank, division, post, date_of_post, salary_station, responsibility, power, employee_idemployee) VALUES (N'" + wd.rank + "', N'" + wd.division + "', N'" + wd.post + "', '" + wd.getDate_of_post() + "', N'" + wd.salary_station + "', N'" + wd.responsibility + "', N'" + wd.power + "', " + Employee.employee_id + ")";
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();
                return true;
            }
            else
            {
                dbcon.closeConnection();
                return false;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //dbcon.closeConnection();
            //return false;
            //}

        }

    }
}
