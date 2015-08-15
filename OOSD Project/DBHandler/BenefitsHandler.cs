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
    class BenefitsHandler
    {

        public static bool addCashBenefit(CashBenefit cb)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
                if (dbcon.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO cash_benefit (approved_benefit, date_issued, price, employee_idemployee) VALUES (N'" + cb.approved_benefit + "', '" + cb.getdate_issued().ToString("yyyy-MM-dd") + "', " + cb.price + ", " + Employee.employee_id + ")";
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

           /* }
            catch (MySqlException e)
            {
                int errorcode = e.Number;
                dbcon.closeConnection();
                return false;
            }*/

        }


        public static CashBenefit getCashBenefit()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM cash_benefit WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                CashBenefit cb = new CashBenefit();

                if (reader.Read())
                {

                    cb.approved_benefit = reader["approved_benefit"].ToString();
                    cb.price = (float)Convert.ToDouble(reader["price"].ToString());
                    cb.setdate_issued(Convert.ToDateTime(reader["date_issued"]));


                }

                reader.Close();

                dbcon.closeConnection();

                return cb;
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


        public static bool addNonCashBenefit(NonCashBenefit ncb)
        {
            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO noncash_benefit (approved_benefit, date_issued, amount, price, employee_idemployee) VALUES (N'" + ncb.approved_benefit + "', '" + ncb.getdate_issued().ToString("yyyy-MM-dd") + "', " + ncb.amount + ", " + ncb.price + ", " + Employee.employee_id + ")";
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

            /* }
             catch (MySqlException e)
             {
                 int errorcode = e.Number;
                 dbcon.closeConnection();
                 return false;
             }*/

        }

        public static NonCashBenefit getNonCashBenefit()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM noncash_benefit WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                NonCashBenefit ncb = new NonCashBenefit();

                if (reader.Read())
                {

                    ncb.approved_benefit = reader["approved_benefit"].ToString();
                    ncb.price = (float)Convert.ToDouble(reader["price"].ToString());
                    ncb.setdate_issued(Convert.ToDateTime(reader["date_issued"]));
                    ncb.amount = (float)Convert.ToDouble(reader["amount"].ToString());

                }

                reader.Close();

                dbcon.closeConnection();

                return ncb;
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
