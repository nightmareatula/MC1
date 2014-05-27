using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MC1.C_
{
    class DatabaseConnect
    {
        //Khai bao bien
        
        private string _user;
        private string _password;
        private string _serverurl;
        private string _database;
        private string _connectionstring;
        public string StatusConnect { get; private set; }
        public string ErrorConnect { get; private set; }
    
    
    
        //*
        
        public DatabaseConnect()
        {
            try
            {
                this._user = ConfigurationManager.AppSettings.Get("user");
                this._password = ConfigurationManager.AppSettings.Get("password");
                this._serverurl = ConfigurationManager.AppSettings.Get("serverurl");
                this._database = ConfigurationManager.AppSettings.Get("database");
                this._connectionstring = "user id=" + this._user + ";" +
                                            "password=" + this._password + ";" +
                                            "server=" + this._serverurl + ";" +
                                            "Trusted_connection=no;" +
                                            "database=" + this._database + ";" +
                                            "connection timeout=30;";


                SqlConnection SqlConnect = new SqlConnection(this._connectionstring);
                SqlConnect.Open();
                this.StatusConnect = SqlConnect.State.ToString();
            }
            catch (Exception e)
            { 
                this.ErrorConnect = e.ToString();
            }
        }
    }
}
