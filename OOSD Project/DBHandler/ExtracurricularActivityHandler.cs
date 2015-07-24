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
    class ExtracurricularActivityHandler
    {
        public static bool addExtracurricularActivity(ExtracurricularActivity eca)
        {

            DBConnector dbcon = new DBConnector();

            try
            {
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO extracurricular_activity (type, method, award, employee_idemployee) VALUES (N'" + eca.type + "', N'" + eca.method + "', N'" + eca.award + "', " + Employee.employee_id + ")";
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
                dbcon.closeConnection();
                return false;
            }


        }


        public static ExtracurricularActivity getExtracurricularActivity()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM extracurricular_activity WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                ExtracurricularActivity ea = new ExtracurricularActivity();

                if (reader.Read())
                {
                    ea.award = reader["award"].ToString();
                    ea.method = reader["method"].ToString();
                    ea.type = reader["type"].ToString();

                }

                reader.Close();

                dbcon.closeConnection();

                return ea;
            }
            else
            {

                return null;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //return null;
            //}

        }

    }
}
