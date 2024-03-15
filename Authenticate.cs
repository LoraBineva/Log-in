using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Bineva_L_08._01._24
{
    public class Authenticate
    {

        public class User { 
            public string Username { get; set; }
            public byte[] Image { get; set; }
            public string Email {  get; set; }
            public string Phone { get; set; }
         }
        public class DatabaseManager
        {
            public static User AuthenticateUser (string username, string password) // you should get these parameters from form 3
            {
                User user = RetrieveInfo(username,password);
                return user;
            }

            private static User RetrieveInfo(string username, string password)
            {

                using (SqlConnection sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=User_records; Integrated Security=True;")) {
                    sql.Open();

                    string Query = "SELECT COUNT(1) FROM Records Where username=@Username AND password=@Password";
                    string Image_query = "Select * FROM Records where username=@Username AND password=@Password";
                  
                    SqlCommand cmd = new SqlCommand(Query, sql);
                    SqlCommand cmd_img = new SqlCommand(Image_query, sql);
                    cmd.CommandType = CommandType.Text;
                    cmd_img.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd_img.Parameters.AddWithValue("@Username", username);
                    cmd_img.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        using (SqlDataReader reader = cmd_img.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] image = reader["image"] as byte[];
                                string email = reader["email"].ToString();
                                string phone = reader["phone"] as string;
                                return new User { Username = username, Image = image, Email=email, Phone=phone };
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password or username is incorrect. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    return null;
                }
            }


            }
        }
  
    }

