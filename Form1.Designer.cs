namespace Bineva_L_08._01._24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            register = new Label();
            username_label = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            username = new TextBox();
            password_label = new Label();
            phone = new TextBox();
            reminder_word_label = new Label();
            signup_btn = new Button();
            email = new TextBox();
            email_label = new Label();
            username_check = new Label();
            should_label = new Label();
            lenght = new Label();
            capital = new Label();
            lower = new Label();
            number = new Label();
            phone_label = new Label();
            password = new TextBox();
            Alr = new Label();
            log_in = new Label();
            SuspendLayout();
            // 
            // register
            // 
            register.AutoSize = true;
            register.BackColor = Color.Transparent;
            register.FlatStyle = FlatStyle.Popup;
            register.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            register.ForeColor = SystemColors.ActiveCaptionText;
            register.Location = new Point(235, 95);
            register.Name = "register";
            register.Size = new Size(168, 28);
            register.TabIndex = 0;
            register.Text = "Register Now!";
            register.TextAlign = ContentAlignment.TopCenter;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BackColor = Color.Transparent;
            username_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(203, 161);
            username_label.Name = "username_label";
            username_label.Size = new Size(114, 20);
            username_label.TabIndex = 2;
            username_label.Text = "Your Username:";
            // 
            // username
            // 
            username.BackColor = Color.RosyBrown;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(203, 192);
            username.Name = "username";
            username.Size = new Size(242, 22);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            username.Validating += username_Validating;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.BackColor = Color.Transparent;
            password_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            password_label.Location = new Point(203, 286);
            password_label.Name = "password_label";
            password_label.Size = new Size(112, 20);
            password_label.TabIndex = 4;
            password_label.Text = "Your Password:";
            // 
            // phone
            // 
            phone.BackColor = Color.RosyBrown;
            phone.BorderStyle = BorderStyle.None;
            phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(203, 380);
            phone.Name = "phone";
            phone.Size = new Size(242, 22);
            phone.TabIndex = 7;
            phone.Validating += phone_Validating;
            // 
            // reminder_word_label
            // 
            reminder_word_label.AutoSize = true;
            reminder_word_label.BackColor = Color.Transparent;
            reminder_word_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            reminder_word_label.Location = new Point(484, 435);
            reminder_word_label.Name = "reminder_word_label";
            reminder_word_label.Size = new Size(0, 20);
            reminder_word_label.TabIndex = 6;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.RosyBrown;
            signup_btn.BackgroundImageLayout = ImageLayout.Center;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signup_btn.ForeColor = Color.WhiteSmoke;
            signup_btn.Location = new Point(200, 422);
            signup_btn.Name = "signup_btn";
            signup_btn.RightToLeft = RightToLeft.Yes;
            signup_btn.Size = new Size(242, 41);
            signup_btn.TabIndex = 9;
            signup_btn.Text = "DONE";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // email
            // 
            email.BackColor = Color.RosyBrown;
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(203, 250);
            email.Name = "email";
            email.Size = new Size(242, 22);
            email.TabIndex = 11;
            email.Validating += email_Validating;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.BackColor = Color.Transparent;
            email_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            email_label.Location = new Point(203, 227);
            email_label.Name = "email_label";
            email_label.Size = new Size(87, 20);
            email_label.TabIndex = 10;
            email_label.Text = "Your Email:";
            // 
            // username_check
            // 
            username_check.AutoSize = true;
            username_check.BackColor = Color.Transparent;
            username_check.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            username_check.Location = new Point(464, 192);
            username_check.Name = "username_check";
            username_check.Size = new Size(174, 15);
            username_check.TabIndex = 12;
            username_check.Text = "This should at least 8 characters";
            // 
            // should_label
            // 
            should_label.AutoSize = true;
            should_label.BackColor = Color.Transparent;
            should_label.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            should_label.Location = new Point(484, 271);
            should_label.Name = "should_label";
            should_label.Size = new Size(154, 15);
            should_label.TabIndex = 13;
            should_label.Text = "Your password should have:\r\n";
            // 
            // lenght
            // 
            lenght.AutoSize = true;
            lenght.BackColor = Color.Transparent;
            lenght.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lenght.Location = new Point(495, 300);
            lenght.Name = "lenght";
            lenght.Size = new Size(121, 15);
            lenght.TabIndex = 14;
            lenght.Text = "- At least 8 characters";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.BackColor = Color.Transparent;
            capital.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            capital.Location = new Point(495, 316);
            capital.Name = "capital";
            capital.Size = new Size(133, 15);
            capital.TabIndex = 15;
            capital.Text = "- At least 1 capital letter";
            // 
            // lower
            // 
            lower.AutoSize = true;
            lower.BackColor = Color.Transparent;
            lower.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lower.Location = new Point(495, 331);
            lower.Name = "lower";
            lower.Size = new Size(148, 15);
            lower.TabIndex = 16;
            lower.Text = "- At least 1 lowercase letter";
            // 
            // number
            // 
            number.AutoSize = true;
            number.BackColor = Color.Transparent;
            number.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            number.Location = new Point(495, 347);
            number.Name = "number";
            number.Size = new Size(108, 15);
            number.TabIndex = 17;
            number.Text = "- At least 1 number";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.BackColor = Color.Transparent;
            phone_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            phone_label.Location = new Point(203, 347);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(90, 20);
            phone_label.TabIndex = 18;
            phone_label.Text = "Your Phone:";
            // 
            // password
            // 
            password.BackColor = Color.RosyBrown;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(200, 311);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(242, 22);
            password.TabIndex = 19;
            password.TextChanged += password_TextChanged;
            password.Validating += password_Validating_1;
            // 
            // Alr
            // 
            Alr.AutoSize = true;
            Alr.BackColor = Color.Transparent;
            Alr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Alr.Location = new Point(203, 475);
            Alr.Name = "Alr";
            Alr.Size = new Size(143, 15);
            Alr.TabIndex = 20;
            Alr.Text = "Already have an account?";
            // 
            // log_in
            // 
            log_in.AutoSize = true;
            log_in.BackColor = Color.Transparent;
            log_in.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            log_in.Location = new Point(352, 475);
            log_in.Name = "log_in";
            log_in.Size = new Size(67, 15);
            log_in.TabIndex = 21;
            log_in.Text = "Log In Here";
            log_in.Click += log_in_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = Properties.Resources._900w_uS8QA4tnBqU;
            ClientSize = new Size(686, 574);
            Controls.Add(log_in);
            Controls.Add(Alr);
            Controls.Add(password);
            Controls.Add(phone_label);
            Controls.Add(number);
            Controls.Add(lower);
            Controls.Add(capital);
            Controls.Add(lenght);
            Controls.Add(should_label);
            Controls.Add(username_check);
            Controls.Add(email);
            Controls.Add(email_label);
            Controls.Add(signup_btn);
            Controls.Add(phone);
            Controls.Add(reminder_word_label);
            Controls.Add(password_label);
            Controls.Add(username);
            Controls.Add(username_label);
            Controls.Add(register);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label register;
        private Label username_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox username;
        private TextBox password;
        private Label password_label;
        private TextBox reminder_word;
        private Label reminder_word_label;
        private Label forget_label;
        private Button signup_btn;
        private TextBox email;
        private Label email_label;
        private Label username_check;
        private Label should_label;
        private Label lenght;
        private Label capital;
        private Label lower;
        private Label number;
        private Label phone_label;
        private TextBox phone;
        private Label Alr;
        private Label log_in;
    }
}