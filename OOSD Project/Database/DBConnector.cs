﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project.Database
{
    class DBConnector
    {

        public MySqlConnection connection { set; get; }
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;

        public DBConnector()
        {
            server = "localhost";
            database = "ozious";
            user = "root";
            password = "123";
            port = "3306";
            string connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";Charset=utf8;";
            connection = new MySqlConnection(connectionString);
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message+"\n");
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message + "\n");
                return false;
            }
        }

    }
}
