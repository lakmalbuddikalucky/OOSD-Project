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

            try
            {
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO working_experience (institute, address, telephone, email, department, contact, date_from, date_to, date_perma, resign_reason, responsibility, occupation_relevant, award, employee_idemployee) VALUES (N'" + we.institute + "', N'" + we.address + "', N'" + we.telephone + "', N'" + we.email + "', N'" + we.department + "', N'" + we.contact + "', '" + we.getDate_from().ToString("yyyy-MM-dd") + "', '" + we.getDate_to().ToString("yyyy-MM-dd") + "', '" + we.getDate_perma().ToString("yyyy-MM-dd") + "', N'" + we.resign_reason + "', N'" + we.responsibility + "', " + we.occupation_relevant + ", N'" + we.award + "', " + Employee.employee_id + ")";
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

        public static WorkingExperience getWorkingExperience()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM working_experience WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                WorkingExperience we = new WorkingExperience();

                if (reader.Read())
                {
                    we.address = reader["address"].ToString();
                    we.award = reader["award"].ToString();
                    we.contact = reader["contact"].ToString();
                    we.department = reader["department"].ToString();
                    we.email = reader["email"].ToString();
                    we.institute = reader["institute"].ToString();
                    we.resign_reason = reader["resign_reason"].ToString();
                    we.responsibility = reader["responsibility"].ToString();
                    we.telephone = reader["telephone"].ToString();

                    if (reader["occupation_relevant"].ToString() == "True") { we.occupation_relevant = true; }
                    else { we.occupation_relevant = false; }

                    we.setDate_from(Convert.ToDateTime(reader["date_from"]));
                    we.setDate_to(Convert.ToDateTime(reader["date_to"]));
                    we.setDate_perma(Convert.ToDateTime(reader["date_perma"]));


                }

                reader.Close();

                dbcon.closeConnection();

                return we;
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
