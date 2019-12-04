using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Getir1.Data
{
    class SqlData
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4GO0PNJ; Initial Catalog=SanalPazar;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        User user;
        
        public User GetUser(string email)
        {
            user = new User();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where email = '" + email + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user.id = Convert.ToInt32(dr["id"].ToString());
                user.email = dr["email"].ToString();
                user.password = dr["password"].ToString();
                user.name = dr["name"].ToString();
                user.surname = dr["surname"].ToString();
                user.phone = Convert.ToInt32(dr["phone"].ToString());
                con.Close();
                return user;
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public bool Login(string email,string password)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where email = '" + email + "' and password = '" + password + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public bool NewPassword(string email,int newPass)
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update Users set password = '" + newPass + "' where email = '" + email + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool NewUser(string email,string password,string name,string surname,int phone)
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into Users (email,password,name,surname,phone) values (@email,@password,@name,@surname,@phone)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
    }
}
