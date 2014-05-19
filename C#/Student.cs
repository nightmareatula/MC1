using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MC1.C_
{
    class Student
    {
        private string _name;
        public string Name
        {
            get
            {
                return "Gamer" + this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int ID { get; set; }
        private string _password;
        public string Password
        {
            get { return.this._password; }
            set 
                {
                    HashAlgorithm hassword = new MD5CryptoServiceProvider();
                    byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));
                    this._password = Convert.ToBase64String(hassbyte);
                }
        }
    }
}
