using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using OOSD_Project.DBTableClass;
using OOSD_Project.UserLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBHandler
{
    class NotificationHandler
    {

        public static bool addNotification(Notification n)
        {
            DBConnector dbcon = new DBConnector();

            try
            {
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO notification (title, content, date, employee_name, employee_number, employee_idemployee, user_iduser) VALUES (N'" + n.Title + "', N'" + n.Content + "', '" + n.Date.ToString("yyyy-MM-dd") + "', N'" + n.Employee_name + "', N'" + n.Employee_number + "', " + n.Employee_idemployee + ", " + n.User_iduser + ")";
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

            }
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                Console.Write(e.Message + "\n");
                dbcon.closeConnection();
                return false;
            }

        }

    }
}
