using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ST10081966_Prog_Part2.Classes
{
    public class PasswordClass
    {

        /// <summary>
        ///     SQL DB Connection String
        /// </summary>
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ST10081966DatabaseEntities"].ConnectionString;

        /// <summary>
        ///     SQL Command
        /// </summary>
        private SqlCommand Command;

        /// <summary>
        ///     SQL Connection
        /// </summary>
        private SqlConnection Connection;

        private ST10081966DatabaseEntities Entity;
        public string HashPassword(string Password)
        {
            SHA1CryptoServiceProvider sHA1Hash = new SHA1CryptoServiceProvider();

            byte[] hashPassword_bytes = Encoding.ASCII.GetBytes(Password);
            byte[] salt_bytes = sHA1Hash.ComputeHash(hashPassword_bytes);
            return Convert.ToBase64String(salt_bytes);
        }

        /* public bool CheckPassword(string Username)
        {
            string HashedPW;
            string PlainPW;

            try
            {
                using (this.Entity = new ST10081966DatabaseEntities())
                {
                    Employee EmailCheck = Entity.Employees.FirstOrDefault(e => string.Compare(e.Email, Email, true) == 0);
                }
            }

            return false;
        }
        
        */
    }
}