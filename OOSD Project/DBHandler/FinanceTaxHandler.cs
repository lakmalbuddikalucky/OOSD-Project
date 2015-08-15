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
    class FinanceTaxHandler
    {

        public static bool addFinanceTax(FinanceTax ft)
        {

            DBConnector dbcon = new DBConnector();

            //try
            //{
            if (dbcon.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO finance_tax (type, number, payment_method, status, note, employee_idemployee) VALUES (N'" + ft.type + "', N'" + ft.number + "', N'" + ft.payment_method + "', N'" + ft.status + "', N'" + ft.note + "', " + Employee.employee_id + ")";
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


        public static FinanceTax getFinanceTax()
        {

            //try
            //{

            DBConnector dbcon = new DBConnector();

            if (dbcon.openConnection())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM finance_tax WHERE employee_idemployee=" + Employee.employee_id;
                cmd.Connection = dbcon.connection;

                MySqlDataReader reader = cmd.ExecuteReader();

                FinanceTax ft = new FinanceTax();

                if (reader.Read())
                {
                    ft.type = reader["type"].ToString();
                    ft.number = reader["number"].ToString();
                    ft.note = reader["note"].ToString();
                    ft.payment_method = reader["payment_method"].ToString();
                    ft.status = reader["status"].ToString();


                }

                reader.Close();

                dbcon.closeConnection();

                return ft;
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
