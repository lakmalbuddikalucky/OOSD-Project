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
    class MembershipHandler
    {

        public static bool addMembership(Membership m)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO membership (institute, post_name, method, member_id, contribution, begin_date, renewal_date, status, personal_payment, active_date_person, institutional_payment, active_date_insti, employee_idemployee) VALUES (N'" + m.institute + "', N'" + m.post_name + "', N'" + m.method + "', N'" + m.member_id + "', N'" + m.contribution + "', '" + m.getBegin_date() + "', '" + m.getRenewal_date() + "', N'" + m.status + "', " + m.personal_payment + ", '" + m.getActive_date_person() + "', " + m.institutional_payment + ", '" + m.getActive_date_insti() + "', " + Employee.employee_id + ")";
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
