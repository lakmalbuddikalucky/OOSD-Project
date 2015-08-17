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
                cmd.CommandText = "INSERT INTO workstation_details (rank, division, post, date_of_post, salary_station, responsibility, power, employee_idemployee) VALUES (N'" + wd.rank + "', N'" + wd.division + "', N'" + wd.post + "', '" + wd.getDate_of_post().ToString("yyyy-MM-dd") + "', N'" + wd.salary_station + "', N'" + wd.responsibility + "', N'" + wd.power + "', " + Employee.employee_id + ")";
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



        public static WorkstationDetails getWorkstationDetails()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM workstation_details WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                WorkstationDetails wd = null;

                if (reader.Read())
                {
                    wd = new WorkstationDetails();

                    wd.ws_id = int.Parse(reader["idworkstation_details"].ToString());
                    wd.division = reader["division"].ToString();
                    wd.post = reader["post"].ToString();
                    wd.power = reader["power"].ToString();
                    wd.rank = reader["rank"].ToString();
                    wd.responsibility = reader["responsibility"].ToString();
                    wd.salary_station = reader["salary_station"].ToString();
                    wd.setDate_of_post(Convert.ToDateTime(reader["date_of_post"]));
                }

                reader.Close();

                dbcon.closeConnection();

                return wd;
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


        public static bool updateWorkstationDetails(WorkstationDetails ws)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE workstation_details SET rank=N'" + ws.rank + "', division=N'" + ws.division + "', post=N'" + ws.post + "', date_of_post='" + ws.getDate_of_post().ToString("yyyy-MM-dd") + "', salary_station=N'" + ws.salary_station + "', responsibility=N'" + ws.responsibility + "', power=N'" + ws.power + "' WHERE employee_idemployee=" + Employee.employee_id + " AND idworkstation_details=" + ws.ws_id;
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
