using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Bineva_L_08._01._24
{
    public class ImgUploader
    {
        public static void UploadImage(string username, byte[] image)
        {
            using (SqlConnection sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=User_records; User ID=sa; Password=your_password;"))
            {
                sql.Open();

                string Query_img = "UPDATE Records SET image=@Image where username=@Username";
                SqlCommand cmd = new SqlCommand(Query_img, sql);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Image", image);
                cmd.ExecuteNonQuery();
            }
        }
        public static byte[] ImageConvert(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }

}
