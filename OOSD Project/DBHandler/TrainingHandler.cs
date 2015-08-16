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
    class TrainingHandler
    {

        public static bool addTraining(Training t)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO training (course_name, course_type, institute, payments, started_date, ending_date, extended_days, new_ending_date, country, result, employee_idemployee) VALUES (N'" + t.course_name + "', N'" + t.course_type + "', N'" + t.institute + "', N'" + t.payments + "', '" + t.started_date.ToString("yyyy-MM-dd") + "', '" + t.ending_date.ToString("yyyy-MM-dd") + "', N'" + t.extended_days + "', '" + t.new_ending_date.ToString("yyyy-MM-dd") + "', N'" + t.country + "', N'" + t.result + "', " + Employee.employee_id + ")";
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

            /*}
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/


        }



        public static bool addTrainingRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO training (started_date, ending_date, new_ending_date, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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

            /*}
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/


        }




        public static bool updateTraining(Training t)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE training SET course_name=N'" + t.course_name + "', course_type=N'" + t.course_type + "', institute=N'" + t.institute + "', payments=N'" + t.payments + "', started_date='" + t.started_date.ToString("yyyy-MM-dd") + "', ending_date='" + t.ending_date.ToString("yyyy-MM-dd") + "', extended_days=N'" + t.extended_days + "', new_ending_date='" + t.new_ending_date.ToString("yyyy-MM-dd") + "', country=N'" + t.country + "', result=N'" + t.result + "' WHERE employee_idemployee=" + Employee.employee_id;
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

            /*}
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/

        }


        public static Training getTraining()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM training WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                Training t = null;

                if (reader.Read())
                {
                    t = new Training();

                    t.course_name = reader["course_name"].ToString();
                    t.course_type = reader["course_type"].ToString();
                    t.institute = reader["institute"].ToString();
                    t.payments = reader["payments"].ToString();
                    t.started_date = Convert.ToDateTime(reader["started_date"]);
                    t.ending_date = Convert.ToDateTime(reader["ending_date"]);
                    t.new_ending_date = Convert.ToDateTime(reader["new_ending_date"]);
                    t.extended_days = reader["extended_days"].ToString();
                    t.country = reader["country"].ToString();
                    t.result = reader["result"].ToString();
                }

                reader.Close();

                dbcon.closeConnection();

                return t;
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
