using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bineva_L_08._01._24.Authenticate;

namespace Bineva_L_08._01._24
{
    public partial class Form3 : Form
    {
    

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
           string username_inp = username.Text;
           string password_inp = password.Text;

            if (!string.IsNullOrWhiteSpace(username_inp) && !string.IsNullOrWhiteSpace(password_inp))
            {
                User authenticatedUser = DatabaseManager.AuthenticateUser(username_inp, password_inp);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    Form4 welcome = new Form4(authenticatedUser);
                    welcome.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }

        }

         
        }

    }

