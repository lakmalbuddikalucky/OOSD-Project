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
    class QualificationsHandler
    {

        public static bool addQualification(Qualification q) {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO qualification (qualification_no, institute, months, occupation_relevant, highest_qualification, status, note, qualification, year, employee_idemployee) VALUES (N'" + q.qualification_no + "', N'" + q.institute + "', N'" + q.months + "', " + q.occupation_relevant + ", " + q.highest_qualification + ", N'" + q.status + "', N'" + q.note + "', N'" + q.qualification + "', N'" + q.year + "', " + Employee.employee_id + ")";
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
