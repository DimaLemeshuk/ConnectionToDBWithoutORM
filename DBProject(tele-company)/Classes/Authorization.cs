using DBProject_tele_company_.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_tele_company_.Classes
{
 
    internal class Authorization
    {
        public static string UserName, typeUser, ErrorMessage;
        public static void Login(string login, string password)
        {
            try
            { 
                DBConection.MySqlCommand.CommandText = @"SELECT typeIdUser FROM `tele-company`.user where loginUser = '"+login+"' and passwordUser = '"+password+"';";
                Object result = DBConection.MySqlCommand.ExecuteScalar();
                if (result != null)
                {
                    UserName = login;
                    typeUser = result.ToString();   
                }
                else 
                {
                    UserName = typeUser = null;
                    
                }
            }
            catch
            {
                UserName = typeUser = null;
            }
            

        }
    }
}
