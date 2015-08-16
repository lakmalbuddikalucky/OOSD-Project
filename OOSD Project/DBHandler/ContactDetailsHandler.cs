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
    class ContactDetailsHandler
    {

        public static bool addContactDetails(ContactDetails cd)
        {
            DBConnector dbcon = new DBConnector();

            try
            {                
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO contact_details (perm_home_no, perm_address, perm_city, perm_province, perm_district, perm_uc, perm_grama, perm_polling_division, perm_teleophone, perm_mobile, perm_fax, perm_email, cur_home_no, cur_address, cur_city, cur_province, cur_uc, cur_grama, cur_polling_division, cur_teleophone, cur_mobile, cur_fax, cur_email, employee_idemployee) VALUES (N'" + cd.perm_home_no + "', N'" + cd.perm_address + "', N'" + cd.perm_city + "', N'" + cd.perm_province + "', N'" + cd.perm_district + "', N'" + cd.perm_uc + "', N'" + cd.perm_grama + "', N'" + cd.perm_polling_division + "', N'" + cd.perm_teleophone + "', N'" + cd.perm_mobile + "', N'" + cd.perm_fax + "', N'" + cd.perm_email + "', N'" + cd.cur_home_no + "', N'" + cd.cur_address + "', N'" + cd.cur_city + "', N'" + cd.cur_province + "', N'" + cd.cur_uc + "', N'" + cd.cur_grama + "', N'" + cd.cur_polling_division + "', N'" + cd.cur_teleophone + "', N'" + cd.cur_mobile + "', N'" + cd.cur_fax + "', N'" + cd.cur_email + "', " + Employee.employee_id + ")";
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

            }catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }

        }


        public static ContactDetails getContactDetails()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM contact_details WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.Write(Employee.employee_id+"\n");

                ContactDetails cd = null;

                if (reader.Read())
                {
                    cd = new ContactDetails();

                    cd.cur_address=reader["cur_address"].ToString();
                    cd.cur_city = reader["cur_city"].ToString();
                    cd.cur_district = reader["cur_district"].ToString();
                    cd.cur_email = reader["cur_email"].ToString();
                    cd.cur_fax = reader["cur_fax"].ToString();
                    cd.cur_grama = reader["cur_grama"].ToString();
                    cd.cur_home_no = reader["cur_home_no"].ToString();
                    cd.cur_mobile = reader["cur_mobile"].ToString();
                    cd.cur_polling_division = reader["cur_polling_division"].ToString();
                    cd.cur_province = reader["cur_province"].ToString();
                    cd.cur_teleophone = reader["cur_teleophone"].ToString();
                    cd.cur_uc = reader["cur_uc"].ToString();
                    cd.perm_address = reader["perm_address"].ToString();
                    cd.perm_city = reader["perm_city"].ToString();
                    cd.perm_district = reader["perm_district"].ToString();
                    cd.perm_email = reader["perm_email"].ToString();
                    cd.perm_fax = reader["perm_fax"].ToString();
                    cd.perm_grama = reader["perm_grama"].ToString();
                    cd.perm_home_no = reader["perm_home_no"].ToString();
                    cd.perm_mobile = reader["perm_mobile"].ToString();
                    cd.perm_polling_division = reader["perm_polling_division"].ToString();
                    cd.perm_province = reader["perm_province"].ToString();
                    cd.perm_teleophone = reader["perm_teleophone"].ToString();
                    cd.perm_uc = reader["perm_uc"].ToString();
                    

                }

                reader.Close();

                dbcon.closeConnection();

                return cd;
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


        public static bool updateContactDetails(ContactDetails cd)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE contact_details SET perm_home_no=N'" + cd.perm_home_no + "', perm_address=N'" + cd.perm_address + "', perm_city=N'" + cd.perm_city + "', perm_province=N'" + cd.perm_province + "', perm_district=N'" + cd.perm_district + "', perm_uc=N'" + cd.perm_uc + "', perm_grama=N'" + cd.perm_grama + "', perm_polling_division=N'" + cd.perm_polling_division + "', perm_teleophone=N'" + cd.perm_teleophone + "', perm_mobile=N'" + cd.perm_mobile + "', perm_fax=N'" + cd.perm_fax + "', perm_email=N'" + cd.perm_email + "', cur_home_no=N'" + cd.cur_home_no + "', cur_address=N'" + cd.cur_address + "', cur_city=N'" + cd.cur_city + "', cur_province=N'" + cd.cur_province + "', cur_district=N'" + cd.cur_district + "', cur_uc=N'" + cd.cur_uc + "', cur_grama=N'" + cd.cur_grama + "', cur_polling_division=N'" + cd.cur_polling_division + "', cur_teleophone=N'" + cd.cur_teleophone + "', cur_mobile=N'" + cd.cur_mobile + "', cur_fax=N'" + cd.cur_fax + "', cur_email=N'" + cd.cur_email + "' WHERE employee_idemployee=" + Employee.employee_id;
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
