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
                    cmd.CommandText = "INSERT INTO membership (institute, post_name, method, member_id, contribution, begin_date, renewal_date, status, personal_payment, active_date_person, institutional_payment, active_date_insti, employee_idemployee) VALUES (N'" + m.institute + "', N'" + m.post_name + "', N'" + m.method + "', N'" + m.member_id + "', N'" + m.contribution + "', '" + m.getBegin_date().ToString("yyyy-MM-dd") + "', '" + m.getRenewal_date().ToString("yyyy-MM-dd") + "', N'" + m.status + "', " + m.personal_payment + ", '" + m.getActive_date_person().ToString("yyyy-MM-dd") + "', " + m.institutional_payment + ", '" + m.getActive_date_insti().ToString("yyyy-MM-dd") + "', " + Employee.employee_id + ")";
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

                Membership mem = null;

                if (reader.Read())
                {
                    mem = new Membership();

                    mem.contribution = reader["contribution"].ToString();
                    mem.institute = reader["institute"].ToString();
                    mem.member_id = reader["member_id"].ToString();
                    mem.method = reader["method"].ToString();
                    mem.post_name = reader["post_name"].ToString();
                    mem.status = reader["status"].ToString();

                    mem.setBegin_date(Convert.ToDateTime(reader["begin_date"]));
                    mem.setRenewal_date(Convert.ToDateTime(reader["renewal_date"]));
                    mem.setActive_date_insti(Convert.ToDateTime(reader["active_date_insti"]));
                    mem.setActive_date_person(Convert.ToDateTime(reader["active_date_person"]));

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


        public static bool updateMembership(Membership m)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE membership SET institute=N'" + m.institute + "', post_name=N'" + m.post_name + "', method=N'" + m.method + "', member_id=N'" + m.member_id + "', contribution=N'" + m.contribution + "', begin_date='" + m.getBegin_date().ToString("yyyy-MM-dd") + "', renewal_date='" + m.getRenewal_date().ToString("yyyy-MM-dd") + "', status=N'" + m.status + "', personal_payment=" + m.personal_payment + ", active_date_person='" + m.getActive_date_person().ToString("yyyy-MM-dd") + "', institutional_payment=" + m.institutional_payment + ", active_date_insti='" + m.getActive_date_insti().ToString("yyyy-MM-dd") + "' WHERE employee_idemployee=" + Employee.employee_id;
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
