using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using QuetzalCoatlWeb.Models;

namespace QuetzalCoatlWeb.DAL
{
    public class UserDAL
    {
        static MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString);

        public static void InsertUserInfo(string name, string surname, string email, string username, string password)
        {
            //MySqlConnection con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("insert into user(UserFN, UserLN, UserEMail, UserLogin, Password) values (@a,@b,@c,@d,@e)", con);
            cmd.Parameters.Add(new MySqlParameter("@a", name));
            cmd.Parameters.Add(new MySqlParameter("@b", surname));
            cmd.Parameters.Add(new MySqlParameter("@c", email));
            cmd.Parameters.Add(new MySqlParameter("@d", username));
            cmd.Parameters.Add(new MySqlParameter("@e", password));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static List<User> GetUserData()
        {
            List<User> customer = new List<User>();
            MySqlCommand cmd = new MySqlCommand("select * from user order by UserId", con);
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                customer.Add(new User() { Uid = Convert.ToInt32(dr[0].ToString()), FName = dr[1].ToString(), LName = dr[2].ToString(), Email = dr[3].ToString(), Login = dr[4].ToString() });
            }
            con.Close();
            return customer;

        }

        internal static bool ValidateUserInfo(string name, string password, out string userId)
        {
            userId = String.Empty;
            MySqlCommand cmd = new MySqlCommand("select * from user where UserLogin = '" + name + "' and Password = '" + password + "'", con);
            int rowCount = 0;
            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                userId = dr[0].ToString();
                rowCount++;
            }
            con.Close();
            if (rowCount > 0)
                return true;
            else
                return false;
        }
    }
}