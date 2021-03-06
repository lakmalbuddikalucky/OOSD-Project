﻿using MySql.Data.MySqlClient;
using OOSD_Project.Database;
using OOSD_Project.DBTableClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.DBHandler
{
    class QualificationsHandler
    {

        public static bool addQualification(Qualification q) {

            DBConnector dbcon = new DBConnector();

            try
            {
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO qualification (qualification_no, institute, months, occupation_relevant, highest_qualification, status, note, qualification, year, employee_idemployee) VALUES (N'" + q.qualification_no + "', N'" + q.institute + "', N'" + q.months + "', " + q.occupation_relevant + ", " + q.highest_qualification + ", N'" + q.status + "', N'" + q.note + "', N'" + q.qualification + "', N'" + q.year + "', " + Employee.employee_id + ")";
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



        public static Qualification getQualification()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM qualification WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                Qualification q = null;

                if (reader.Read())
                {
                    q = new Qualification();

                    q.q_id = int.Parse(reader["idqualification"].ToString());
                    q.institute = reader["institute"].ToString();
                    q.months = reader["months"].ToString();
                    q.status = reader["status"].ToString();
                    q.note = reader["note"].ToString();
                    q.qualification = reader["qualification"].ToString();
                    q.year = reader["year"].ToString();
                    q.qualification_no = reader["qualification_no"].ToString();

                    if (reader["occupation_relevant"].ToString() == "True") { q.occupation_relevant = true; }
                    else { q.occupation_relevant = false; }

                    if (reader["highest_qualification"].ToString() == "True") { q.highest_qualification = true; }
                    else { q.highest_qualification = false; }

                }

                reader.Close();

                dbcon.closeConnection();

                return q;
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


        public static bool updateQualifications(Qualification q)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE qualification SET qualification_no=N'" + q.qualification_no + "', institute=N'" + q.institute + "', months=N'" + q.months + "', occupation_relevant=" + q.occupation_relevant + ", highest_qualification=" + q.highest_qualification + ", status=N'" + q.status + "', note=N'" + q.note + "', qualification=N'" + q.qualification + "', year=N'" + q.year + "' WHERE employee_idemployee=" + Employee.employee_id + " AND idqualification=" + q.q_id;
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
