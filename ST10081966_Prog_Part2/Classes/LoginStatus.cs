using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ST10081966_Prog_Part2.Classes
{
    public class LoginStatus
    {
        //ensure only one instance is created, thus keeping the data
        private static readonly LoginStatus instance = new LoginStatus();
        public static LoginStatus Instance => instance;

        private string UserType = "";
        private string UserID = "";

        public string UserType1 { get => UserType; set => UserType = value; }
        public string UserID1 { get => UserID; set => UserID = value; }
    }
}