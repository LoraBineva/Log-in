using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Bineva_L_08._01._24.Authenticate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Identity.Client;

namespace Bineva_L_08._01._24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           InitializeComponent();
        }
        SqlConnection sql;
        SqlDataReader dr;

        private void birthday_Validating(object sender, CancelEventArgs e)
        {
            int age = DateTime.Now.Year - birthday.Value.Year - (DateTime.Now.DayOfYear < birthday.Value.DayOfYear ? 1 : 0);
            if (age < 18)
            {
                MessageBox.Show("You can't enter", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void signup_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
                if (sql.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand("Select username From Records where username=@username", sql);
                    command.Parameters.AddWithValue("@username","");

                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        string Query = "Insert Into Records (username, email, password, phone, image) \r\n Values (@username, @email, @password, @phone, NULLIF(Convert(varbinary(max), @image), ''));";
                        SqlCommand cmd = new SqlCommand(Query, sql);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.Parameters.AddWithValue("@phone", phone.Text);
                        cmd.Parameters.AddWithValue("@image", "");

                        Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Your account has been created! Please login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
