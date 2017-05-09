using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpProject.DAL
{
    /// <summary>
    /// class for generating random nicknames
    /// </summary>
    public static class NicknamesRepository
    {
        //string for data base connection
        private const string connectionString = @"Data Source=Brow;Integrated Security=SSPI;Initial Catalog=nicknames";

        /// <summary>
        /// generates unique random nickname
        /// </summary>
        /// <returns>string with generated nickname</returns>
        public static string GenerateNickname()
        {
            //name of data base stored procedure
            string sqlExpression = "GenerateNickname";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader red = command.ExecuteReader();

                string nickname = "";
                if (red.Read())
                {
                    nickname = red.GetString(0);
                }
                red.Close();

                return nickname;
            }
        }

    }
}
