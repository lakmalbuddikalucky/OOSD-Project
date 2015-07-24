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
    class WorkingExperienceHandler
    {

        public static bool addWorkingExperience(WorkingExperience we)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO working_experience (institute, address, telephone, email, department, contact, date_from, date_to, date_perma, resign_reason, responsibility, occupation_relevant, award, employee_idemployee) VALUES (N'" + we.institute + "', N'" + we.address + "', N'" + we.telephone + "', N'" + we.email + "', N'" + we.department + "', N'" + we.contact + "', '" + we.getDate_from() + "', '" + we.getDate_to() + "', '" + we.getDate_perma() + "', N'" + we.resign_reason + "', N'" + we.responsibility + "', " + we.occupation_relevant + ", N'" + we.award + "', " + Employee.employee_id + ")";
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
