using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ST10081966_Prog_Part2.Classes;

namespace ST10081966_Prog_Part2.Classes
{
    public class DBClass
    {

        
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ST10081966DatabaseEntities2"].ConnectionString;

        private SqlCommand Command;

        private SqlConnection Connection;

        private ST10081966DatabaseEntities Entity;

        private UserDetails userDetails;

        PasswordClass passwordClass;

        public bool DoesEmailExist(string Email)
        {
            try
            {
                using (this.Entity = new ST10081966DatabaseEntities())
                {
                    Employee EmailCheck = Entity.Employees.FirstOrDefault(e => string.Compare(e.Email, Email, true) == 0);
                    if (EmailCheck != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;
            }
        }
        public Login FindUserLogin(string Username)
        {
            new UserDetails();
            var login = new Login();
            var employee = new Employee();
            var farmer = new Farmer();
            try
            {
                using (this.Entity = new ST10081966DatabaseEntities())
                {
                    Employee EmployeeEmailCheck = Entity.Employees.FirstOrDefault(e => string.Compare(e.Email, Username, true) == 0);

                    if (EmployeeEmailCheck != null)
                    {
                        login = this.Entity.Logins.Find(EmployeeEmailCheck.LoginID);

                    }

                    Farmer FarmerEmailCheck = Entity.Farmers.FirstOrDefault(e => string.Compare(e.Email, Username, true) == 0);

                    if(FarmerEmailCheck != null)
                    {
                        login = this.Entity.Logins.Find(FarmerEmailCheck.LoginID);
                    }

                    return login;
                }
                
            }
            catch (Exception ex)
            {
                return login;
            }
        }

        public bool VerifyFarmerLogin(string username, string password)
        {
            string storedHashedPassword = GetHashedPassword(username);

            if (string.IsNullOrEmpty(storedHashedPassword))
            {
                return false; 
            }

            string hashedPassword = passwordClass.HashPassword(password);

            return string.Equals(storedHashedPassword, hashedPassword);
        }

        public bool VerifyEmployeeLogin(string username, string password)
        {
            string storedHashedPassword = GetHashedPassword(username);

            if (string.IsNullOrEmpty(storedHashedPassword))
            {
                return false;
            }

            string hashedPassword = passwordClass.HashPassword(password);

            return string.Equals(storedHashedPassword, hashedPassword);
        }

        private string GetHashedPassword(string Username)
        {
             
            string query = "SELECT Hash FROM Login WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    return result != null ? result.ToString() : null;
                }
            }
        }




        public int SaveLoginID(Login login)
        {
            try
            {
                using (var context = new ST10081966DatabaseEntities())
                {
                    context.Logins.Add(login);
                    context.SaveChanges();

                    var newUserLoginID = login.LoginID;
                    return newUserLoginID;
                }

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public bool RegisterFarmer(Farmer FarmerIn)
        {
            try
            {
                using (var context = new ST10081966DatabaseEntities())
                {
                    context.Farmers.Add(FarmerIn);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool AddProductMethod(Product newProduct)
        {
            try
            {
                using (var context = new ST10081966DatabaseEntities())
                {
                    context.Products.Add(newProduct);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void ConnectDb()
        {
            this.Connection = new SqlConnection();
            this.Command = new SqlCommand();
            this.Connection.ConnectionString = this.ConnectionString;
            this.Command.Connection = this.Connection;
            this.Command.CommandType = CommandType.Text;
        }
        public DataTable GetProductsDataTable()
        {
            this.ConnectDb();

            try
            {
                var sqlCmd = new SqlCommand
                {
                    Connection = this.Connection,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT * FROM Product"
                };
                var sqlDataAdap = new SqlDataAdapter(sqlCmd);
                var dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                return dtRecord;
            }
            catch (Exception e)
            {
                
            }

            finally
            {
                this.Connection.Close();
            }

            return null;
        }
    }
}