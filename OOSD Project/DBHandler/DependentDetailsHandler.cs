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
    class DependentDetailsHandler
    {

        public static bool addDependentDetails(DependentDetails dd)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO dependent_details (salutation, full_name, relation, date_of_post, nic_no, personal_tp, office_tp, personal_address, official_address, education, status, note, birth_certificate, marriage_certificate, deathade, doctor, employee_idemployee) VALUES (N'" + dd.salutation + "', N'" + dd.full_name + "', N'" + dd.relation + "', '" + dd.getDate_of_post().ToString("yyyy-MM-dd") + "', N'" + dd.nic_no + "', N'" + dd.personal_tp + "', N'" + dd.office_tp + "', N'" + dd.personal_address + "', N'" + dd.official_address + "', N'" + dd.education + "', N'" + dd.status + "', N'" + dd.note + "', N'" + dd.birth_certificate + "', N'" + dd.marriage_certificate + "', " + dd.deathade + ", " + dd.doctor + ", " + Employee.employee_id + ")";
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



        public static DependentDetails getDependentDetails()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM dependent_details WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id + "\n");

                DependentDetails dd = null;

                if (reader.Read())
                {
                    dd = new DependentDetails();

                    dd.dd_id = int.Parse(reader["iddependent_details"].ToString());
                    dd.birth_certificate = reader["birth_certificate"].ToString();
                    dd.setDate_of_post(Convert.ToDateTime(reader["date_of_post"]));

                    if (reader["deathade"].ToString() == "True") { dd.deathade = true; }
                    else { dd.deathade = false; }

                    if (reader["doctor"].ToString() == "True") { dd.doctor = true; }
                    else { dd.doctor = false; }

                    dd.full_name = reader["full_name"].ToString();
                    dd.marriage_certificate = reader["marriage_certificate"].ToString();
                    dd.nic_no = reader["nic_no"].ToString();
                    dd.note = reader["note"].ToString();
                    dd.office_tp = reader["office_tp"].ToString();
                    dd.official_address = reader["official_address"].ToString();
                    dd.personal_address = reader["personal_address"].ToString();
                    dd.personal_tp = reader["personal_tp"].ToString();
                    dd.relation = reader["relation"].ToString();
                    dd.salutation = reader["salutation"].ToString();
                    dd.status = reader["status"].ToString();
                    dd.education = reader["education"].ToString(); 
                    

                }

                reader.Close();

                dbcon.closeConnection();

                return dd;
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


        public static bool updateDependentDetails(DependentDetails dd)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE dependent_details SET salutation=N'" + dd.salutation + "', full_name=N'" + dd.full_name + "', relation=N'" + dd.relation + "', date_of_post='" + dd.getDate_of_post().ToString("yyyy-MM-dd") + "', nic_no=N'" + dd.nic_no + "', office_tp=N'" + dd.office_tp + "', personal_address=N'" + dd.personal_address + "', official_address=N'" + dd.official_address + "', personal_tp=N'" + dd.personal_tp + "', education=N'" + dd.education + "', status=N'" + dd.status + "', note=N'" + dd.note + "', birth_certificate=N'" + dd.birth_certificate + "', marriage_certificate=N'" + dd.marriage_certificate + "', deathade=" + dd.deathade + ", doctor=" + dd.doctor + " WHERE employee_idemployee=" + Employee.employee_id + " AND iddependent_details=" + dd.dd_id;
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
