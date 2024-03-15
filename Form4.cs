using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bineva_L_08._01._24.Authenticate;
using static Bineva_L_08._01._24.ImgUploader;

namespace Bineva_L_08._01._24
{
    public partial class Form4 : Form
    {
        public User AuthenticatedUser;
        public Form4(User user)
        {
            InitializeComponent();
            AuthenticatedUser = user;
            username_welcome.Text = $"Welcome to our Platform {user.Username} !";
            label_email.Text = $"Your Email: {user.Email}";
            label_phone.Text = $"Your Phone {user.Phone}";


            if (user.Image != null && user.Image.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(user.Image))
                {
                    imagepic.Image = Image.FromStream(memoryStream);
                }
            }
        }

        private void more_info_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 more_info = new Form2();
            more_info.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void image_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    byte[] imageData = ImageConvert(selectedImage);
                    UploadImage(AuthenticatedUser.Username, imageData);
                    imagepic.Image = selectedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Your image couldn't be uploaded: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
