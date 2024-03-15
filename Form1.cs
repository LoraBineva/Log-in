using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Bineva_L_08._01._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql;
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=User_records; Integrated Security=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (username.Text.Length < 8)
            {
                MessageBox.Show("Your username has to be at least 8 characters", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.SelectAll();
                e.Cancel = true;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            username_check.Show();
            if (username.Text.Length < 8)
            {
                username_check.ForeColor = Color.Red;
            }
            else
            {
                username_check.Hide();
            }

        }

        private void email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (email.Text != string.Empty)
            {
                if (!Email_Valid(email.Text))
                {
                    MessageBox.Show("Your email is not in the correct form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        private bool Email_Valid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private void password_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(password.Text.Length >= 8 && password.Text.Any(char.IsUpper) && password.Text.Any(char.IsLower) && password.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more conditions for the password haven't been met.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.SelectAll();
                e.Cancel = true;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            should_label.Show();
            lenght.Show();
            capital.Show();
            lower.Show();
            number.Show();

            bool lenght_bool;
            bool capital_bool;
            bool lower_bool;
            bool number_bool;

            //length
            if (password.Text.Length < 8)
            {
                lenght.ForeColor = Color.Red;
                lenght_bool = false;
            }
            else
            {
                lenght.ForeColor = Color.Green;
                lenght_bool = true;
            }
            //capital
            if (!password.Text.Any(char.IsUpper))
            {
                capital.ForeColor = Color.Red;
                capital_bool = false;
            }
            else
            {
                capital.ForeColor = Color.Green;
                capital_bool = true;
            }
            //lower
            if (!password.Text.Any(char.IsLower))
            {
                lower.ForeColor = Color.Red;
                lower_bool = false;
            }
            else
            {
                lower.ForeColor = Color.Green;
                lower_bool = true;
            }
            //number
            if (!password.Text.Any(char.IsDigit))
            {
                number.ForeColor = Color.Red;
                number_bool = false;
            }
            else
            {
                number.ForeColor = Color.Green;
                number_bool = true;
            }
            //All
            if (lenght_bool == true && capital_bool == true && lower_bool == true && number_bool == true)
            {
                should_label.Hide();
                lenght.Hide();
                capital.Hide();
                lower.Hide();
                number.Hide();
            }

        }

        private void phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex number = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!number.IsMatch(phone.Text))
            {
                MessageBox.Show("Not a VALID phone number!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
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
                    command.Parameters.AddWithValue("@username", username.Text);

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

        private void log_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

    }
}