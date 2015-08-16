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
    class PensionAndDeathHandler
    {

        public static bool addPensionAndDeath(PensionAndDeath pd)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO pension_death (retired, dead, died_date, informed_date, note, employee_idemployee) VALUES (" + pd.retired + ", " + pd.dead + ", '" + pd.died_date.ToString("yyyy-MM-dd") + "', '" + pd.informed_date.ToString("yyyy-MM-dd") + "', N'" + pd.note + "', " + Employee.employee_id + ")";
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



        public static bool addPensionAndDeathRecord()
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO pension_death (died_date, informed_date, employee_idemployee) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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




        public static bool updatePensionAndDeath(PensionAndDeath pd)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE pension_death SET retired=" + pd.retired + ", dead=" + pd.dead + ", died_date='" + pd.died_date.ToString("yyyy-MM-dd") + "', informed_date='" + pd.informed_date.ToString("yyyy-MM-dd") + "', note=N'" + pd.note + "' WHERE employee_idemployee=" + Employee.employee_id;
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


        public static PensionAndDeath getPensionAndDeath()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM pension_death WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                PensionAndDeath pd = null;

                if (reader.Read())
                {
                    pd = new PensionAndDeath();

                    pd.note = reader["note"].ToString();

                    pd.died_date = Convert.ToDateTime(reader["died_date"]);
                    pd.informed_date = Convert.ToDateTime(reader["informed_date"]);

                    if (reader["retired"].ToString() == "True") { pd.retired = true; }
                    else { pd.retired = false; }

                    if (reader["dead"].ToString() == "True") { pd.dead = true; }
                    else { pd.dead = false; }


                }

                reader.Close();

                dbcon.closeConnection();

                return pd;
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
