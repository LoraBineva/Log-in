namespace Bineva_L_08._01._24
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            more_info = new Label();
            username_welcome = new Label();
            phone_label = new Label();
            more_info_btn = new Button();
            imagepic = new PictureBox();
            image_btn = new Button();
            label_email = new Label();
            label_phone = new Label();
            ((System.ComponentModel.ISupportInitialize)imagepic).BeginInit();
            SuspendLayout();
            // 
            // more_info
            // 
            more_info.AutoSize = true;
            more_info.BackColor = Color.Transparent;
            more_info.FlatStyle = FlatStyle.Popup;
            more_info.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            more_info.ForeColor = SystemColors.ActiveCaptionText;
            more_info.Location = new Point(157, 367);
            more_info.Name = "more_info";
            more_info.Size = new Size(299, 56);
            more_info.TabIndex = 2;
            more_info.Text = "Tell us more about you by\r\n cliking the button below.";
            more_info.TextAlign = ContentAlignment.TopCenter;
            // 
            // username_welcome
            // 
            username_welcome.AutoSize = true;
            username_welcome.BackColor = Color.Transparent;
            username_welcome.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            username_welcome.Location = new Point(157, 54);
            username_welcome.Name = "username_welcome";
            username_welcome.Size = new Size(0, 28);
            username_welcome.TabIndex = 4;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.BackColor = Color.Transparent;
            phone_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            phone_label.Location = new Point(174, 454);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(0, 20);
            phone_label.TabIndex = 29;
            // 
            // more_info_btn
            // 
            more_info_btn.BackColor = Color.RosyBrown;
            more_info_btn.BackgroundImageLayout = ImageLayout.Center;
            more_info_btn.FlatAppearance.BorderSize = 0;
            more_info_btn.FlatStyle = FlatStyle.Flat;
            more_info_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            more_info_btn.ForeColor = Color.WhiteSmoke;
            more_info_btn.Location = new Point(174, 442);
            more_info_btn.Name = "more_info_btn";
            more_info_btn.RightToLeft = RightToLeft.Yes;
            more_info_btn.Size = new Size(242, 41);
            more_info_btn.TabIndex = 30;
            more_info_btn.Text = "Okay";
            more_info_btn.UseVisualStyleBackColor = false;
            more_info_btn.Click += more_info_btn_Click;
            // 
            // imagepic
            // 
            imagepic.BackColor = Color.RosyBrown;
            imagepic.BackgroundImage = Properties.Resources._900w_uS8QA4tnBqU;
            imagepic.Image = Properties.Resources.Image_user;
            imagepic.Location = new Point(221, 99);
            imagepic.Name = "imagepic";
            imagepic.Size = new Size(142, 92);
            imagepic.SizeMode = PictureBoxSizeMode.Zoom;
            imagepic.TabIndex = 31;
            imagepic.TabStop = false;
            // 
            // image_btn
            // 
            image_btn.BackColor = Color.RosyBrown;
            image_btn.BackgroundImageLayout = ImageLayout.Center;
            image_btn.FlatAppearance.BorderSize = 0;
            image_btn.FlatStyle = FlatStyle.Flat;
            image_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            image_btn.ForeColor = Color.WhiteSmoke;
            image_btn.Location = new Point(174, 197);
            image_btn.Name = "image_btn";
            image_btn.RightToLeft = RightToLeft.Yes;
            image_btn.Size = new Size(242, 41);
            image_btn.TabIndex = 32;
            image_btn.Text = "Upload Image";
            image_btn.UseVisualStyleBackColor = false;
            image_btn.Click += image_btn_Click;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.BackColor = Color.Transparent;
            label_email.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_email.Location = new Point(208, 254);
            label_email.Name = "label_email";
            label_email.Size = new Size(0, 28);
            label_email.TabIndex = 33;
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.BackColor = Color.Transparent;
            label_phone.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_phone.Location = new Point(208, 296);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(0, 28);
            label_phone.TabIndex = 34;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._900w_uS8QA4tnBqU;
            ClientSize = new Size(644, 522);
            Controls.Add(label_phone);
            Controls.Add(label_email);
            Controls.Add(image_btn);
            Controls.Add(imagepic);
            Controls.Add(more_info_btn);
            Controls.Add(phone_label);
            Controls.Add(username_welcome);
            Controls.Add(more_info);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)imagepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label more_info;
        private Label username_welcome;
        private Label phone_label;
        private Button more_info_btn;
        private PictureBox imagepic;
        private Button image_btn;
        private Label label_email;
        private Label label_phone;
    }
}