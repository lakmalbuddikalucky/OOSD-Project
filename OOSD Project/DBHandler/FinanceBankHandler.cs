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
    class FinanceBankHandler
    {

        public static bool addFinanceBank(FinanceBank fb)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO finance_bank (bank_name, branch_name, account_number, account_type, begin_date, end_date, qualification, qual_year, employee_idemployee) VALUES (N'" + fb.bank_name + "', N'" + fb.branch_name + "', N'" + fb.account_number + "', N'" + fb.account_type + "', '" + fb.getBegin_date().ToString("yyyy-MM-dd") + "', '" + fb.getEnd_date().ToString("yyyy-MM-dd") + "', N'" + fb.qualification + "', N'" + fb.Qual_year + "', " + Employee.employee_id + ")";
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


        public static FinanceBank getFinanceBank()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM finance_bank WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                FinanceBank fb = null;

                if (reader.Read())
                {
                    fb = new FinanceBank();
                    fb.fb_id = int.Parse(reader["idfinance_bank"].ToString());
                    fb.bank_name = reader["bank_name"].ToString();
                    fb.branch_name = reader["branch_name"].ToString();
                    fb.account_number = reader["account_number"].ToString();
                    fb.account_type = reader["account_type"].ToString();
                    fb.qualification = reader["qualification"].ToString();
                    fb.Qual_year = reader["qual_year"].ToString();

                    fb.setBegin_date(Convert.ToDateTime(reader["begin_date"]));
                    fb.setEnd_date(Convert.ToDateTime(reader["end_date"]));

                }

                reader.Close();

                dbcon.closeConnection();

                return fb;
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



        public static bool updateFinanceBank(FinanceBank fb)
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE finance_bank SET bank_name=N'" + fb.bank_name + "', branch_name=N'" + fb.branch_name + "', account_number=N'" + fb.account_number + "', account_type=N'" + fb.account_type + "', begin_date='" + fb.getBegin_date().ToString("yyyy-MM-dd") + "', end_date='" + fb.getEnd_date().ToString("yyyy-MM-dd") + "', qualification=N'" + fb.qualification + "', qual_year=N'" + fb.Qual_year + "' WHERE employee_idemployee=" + Employee.employee_id + " AND idfinance_bank=" + fb.fb_id;
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
