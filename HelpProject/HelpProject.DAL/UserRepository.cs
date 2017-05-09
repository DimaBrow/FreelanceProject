using HelpProject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace HelpProject.DAL
{
    /// <summary>
    /// class for working with user's information
    /// </summary>
    public static class UserRepository
    {
        //string for data base connection
        private const string userConectionString = @"Data Source=Brow;Integrated Security=SSPI;Initial Catalog=users";

        /// <summary>
        /// registers user if possible
        /// </summary>
        /// <param name="user">gets new user to register</param>
        /// <returns>either user could login or no</returns>
        public static bool RegisterNewUser(User user)
        {
            using (SqlConnection conection = new SqlConnection(userConectionString))
            {
                try
                {
                    conection.Open();
                    SqlCommand cmd = conection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select [e-mail] from dbo.users";
                    SqlDataReader red = cmd.ExecuteReader();
                    while (red.Read())
                    {
                        string login = red.GetString(0);
                        if (login == user.Login)
                        {
                            red.Close();
                            return false;
                        }
                    }
                    red.Close();

                    cmd.CommandText = @"INSERT INTO dbo.users VALUES (@email, @password)";
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
                    cmd.Parameters["@email"].Value = user.Login;
                    cmd.Parameters["@password"].Value = user.Password;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// login user, if possible
        /// </summary>
        /// <param name="user">user, who tries to login</param>
        /// <returns>either user could login or no</returns>
        public static bool LoginUser(User user)
        {
            using (SqlConnection conection = new SqlConnection(userConectionString))
            {
                try
                {
                    conection.Open();
                    SqlCommand cmd = conection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select [e-mail], password from dbo.users";
                    SqlDataReader red = cmd.ExecuteReader();
                    while (red.Read())
                    {
                        string login = red.GetString(0);
                        string password = red.GetString(1);
                        if (login == user.Login && password == user.Password)
                        {
                            red.Close();
                            return true;
                        }
                    }
                    red.Close();
                    return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
    }
}
