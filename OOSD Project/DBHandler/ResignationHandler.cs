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
    class ResignationHandler
    {

        public static bool addResignation(Resignation r)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO resignation (rank, post, letter_submitted_date, resignation_date, reason, resignation_letter, employee_idemployee) VALUES (N'" + r.rank + "', N'" + r.post + "', '" + r.letter_submitted_date.ToString("yyyy-MM-dd") + "', '" + r.resignation_date.ToString("yyyy-MM-dd") + "', N'" + r.reason + "', N'" + r.resignation_letter + "', " + Employee.employee_id + ")";
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



        public static bool addResignationRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO resignation (letter_submitted_date, resignation_date, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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




        public static bool updateResignation(Resignation r)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE resignation SET rank=N'" + r.rank + "n, post=N'" + r.post + "', letter_submitted_date='" + r.letter_submitted_date.ToString("yyyy-MM-dd") + "', resignation_date='" + r.resignation_date.ToString("yyyy-MM-dd") + "', reason=N'" + r.reason + "', resignation_letter=N'" + r.resignation_letter + "' WHERE employee_idemployee=" + Employee.employee_id;
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


        public static Resignation getResignation()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM resignation WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                Resignation r = null;

                if (reader.Read())
                {
                    r = new Resignation();

                    r.rank = reader["rank"].ToString();
                    r.post = reader["post"].ToString();
                    r.reason = reader["reason"].ToString();
                    r.resignation_letter = reader["resignation_letter"].ToString();

                    r.letter_submitted_date = Convert.ToDateTime(reader["letter_submitted_date"]);
                    r.resignation_date = Convert.ToDateTime(reader["resignation_date"]);


                }

                reader.Close();

                dbcon.closeConnection();

                return r;
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
