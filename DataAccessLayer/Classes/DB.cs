using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccessLayer.Classes
{
    public class DB
    {
        private string connString = "server=localhost;database=calorietrackerdb;uid=root;pwd=Barnacles";

        MySqlConnection conn = null;

        public bool Connected()
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connString);
                conn.Open();
            }
            return true;
        }

        public bool CredentialsCorrect(string UN, string PW)
        {
            bool correct = false;
            if (Connected())
            {
                if (UN != null && PW != null)
                {
                    correct = true;
                    return correct;
                }
                else
                {
                    correct = false;
                    return correct;
                }
            }
            return correct;
        }

        public void AddNewUserToDB(UserDAL newUser)
        {
            if (Connected())
            {
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO calorietrackerdb.user (username, password) VALUES (@Name, @Password);", conn);
                    cmd.Parameters.AddWithValue("@Name", newUser.getName);
                    cmd.Parameters.AddWithValue("@Password", newUser.getPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public UserDAL GetUser(string userName)
        {
            UserDAL currentUser = null;
            if (Connected())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * from calorietrackerdb.user WHERE username=@userName ORDER BY CustomerID", conn);
                cmd.Parameters.AddWithValue("@Name", userName);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    currentUser.setUsername = userName;
                }
                r.Close();
                Close();
            }
            return currentUser;
        }

        public void UpdateUserData(double weight, int age, int userid)
        {
            if (Connected())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE calorietrackerdb.user SET weight=@Weight, age=@Age WHERE id_user=@userid", conn);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUserData(double weight, int age, double weeklyWeightLoss, int userid)
        {
            if (Connected())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE calorietrackerdb.user SET weight=@Weight, age=@Age, weekly_weightloss=@wwl WHERE id_user=@userid", conn);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@wwl", weeklyWeightLoss);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }

        public void Close()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }

    }
}
