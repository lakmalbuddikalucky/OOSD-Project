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
    class MembershipHandler
    {

        public static bool addMembership(Membership m)
        {

            DBConnector dbcon = new DBConnector();

            try
            {
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO membership (institute, post_name, method, member_id, contribution, begin_date, renewal_date, status, personal_payment, active_date_person, institutional_payment, active_date_insti, employee_idemployee) VALUES (N'" + m.institute + "', N'" + m.post_name + "', N'" + m.method + "', N'" + m.member_id + "', N'" + m.contribution + "', '" + m.getBegin_date() + "', '" + m.getRenewal_date() + "', N'" + m.status + "', " + m.personal_payment + ", '" + m.getActive_date_person() + "', " + m.institutional_payment + ", '" + m.getActive_date_insti() + "', " + Employee.employee_id + ")";
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



        public static Membership getMembership()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM membership WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                Membership mem = new Membership();

                if (reader.Read())
                {
                    mem.contribution = reader["contribution"].ToString();
                    mem.institute = reader["institute"].ToString();
                    mem.member_id = reader["tmember_id"].ToString();
                    mem.method = reader["method"].ToString();
                    mem.post_name = reader["post_name"].ToString();
                    mem.status = reader["status"].ToString();
                    mem.active_date_insti = reader["active_date_insti"].ToString();
                    mem.active_date_person = reader["active_date_person"].ToString();
                    mem.begin_date = reader["begin_date"].ToString();

                    if (reader["institutional_payment"].ToString() == "True") { mem.institutional_payment = true; }
                    else { mem.institutional_payment = false; }

                    if (reader["personal_payment"].ToString() == "True") { mem.personal_payment = true; }
                    else { mem.personal_payment = false; }

                }

                reader.Close();

                dbcon.closeConnection();

                return mem;
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
