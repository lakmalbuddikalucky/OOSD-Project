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
    class PassportHandler
    {

        public static bool addPassport(Passport p)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO passport (rank, post, passport_no, place_of_issue, date_of_issue, date_of_renewal, status, employee_idemployee) VALUES (N'" + p.rank + "', N'" + p.post + "', N'" + p.number + "', N'" + p.place_of_issue + "', '" + p.getdate_of_issue().ToString("yyyy-MM-dd") + "', '" + p.getdate_of_renewal().ToString("yyyy-MM-dd") + "', " + p.status + ", " + Employee.employee_id + ")";
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


        public static Passport getPassport()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM passport WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Passport p = null;

                if (reader.Read())
                {
                    p = new Passport();

                    if (reader["status"].ToString() == "True") { p.status=true; }
                    else { p.status = false; }

                    p.rank = reader["rank"].ToString();
                    p.post = reader["post"].ToString();
                    p.number = reader["passport_no"].ToString();
                    p.place_of_issue = reader["place_of_issue"].ToString();

                    p.setdate_of_issue(Convert.ToDateTime(reader["date_of_issue"]));
                    p.setdate_of_renewal(Convert.ToDateTime(reader["date_of_renewal"]));

                }

                reader.Close();

                dbcon.closeConnection();

                return p;
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


        public static bool updatePassport(Passport p)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE passport SET rank=N'" + p.rank + "', post=N'" + p.post + "', passport_no=N'" + p.number + "', place_of_issue=N'" + p.place_of_issue + "', date_of_issue='" + p.getdate_of_issue().ToString("yyyy-MM-dd") + "', date_of_renewal='" + p.getdate_of_renewal().ToString("yyyy-MM-dd") + "', status=" + p.status + " WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                dbcon.closeConnection();

                return true;
            }
            else
            {

                return false;
            }

            //}
            //catch (MySqlException e)
            //{
            //int errorcode = e.Number;
            //return false;
            //}

        }

    }
}
