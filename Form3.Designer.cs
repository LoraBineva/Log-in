namespace Bineva_L_08._01._24
{
    partial class Form3
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
            Log_In_lbl = new Label();
            username_label = new Label();
            username = new TextBox();
            password = new TextBox();
            password_label = new Label();
            login_btn = new Button();
            SuspendLayout();
            // 
            // Log_In_lbl
            // 
            Log_In_lbl.AutoSize = true;
            Log_In_lbl.BackColor = Color.Transparent;
            Log_In_lbl.FlatStyle = FlatStyle.Popup;
            Log_In_lbl.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Log_In_lbl.ForeColor = SystemColors.ActiveCaptionText;
            Log_In_lbl.Location = new Point(309, 86);
            Log_In_lbl.Name = "Log_In_lbl";
            Log_In_lbl.Size = new Size(83, 28);
            Log_In_lbl.TabIndex = 1;
            Log_In_lbl.Text = "Log In";
            Log_In_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BackColor = Color.Transparent;
            username_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(246, 135);
            username_label.Name = "username_label";
            username_label.Size = new Size(114, 20);
            username_label.TabIndex = 3;
            username_label.Text = "Your Username:";
            // 
            // username
            // 
            username.BackColor = Color.RosyBrown;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(246, 158);
            username.Name = "username";
            username.Size = new Size(242, 22);
            username.TabIndex = 4;
            // 
            // password
            // 
            password.BackColor = Color.RosyBrown;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(246, 227);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(242, 22);
            password.TabIndex = 21;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.BackColor = Color.Transparent;
            password_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            password_label.Location = new Point(249, 202);
            password_label.Name = "password_label";
            password_label.Size = new Size(112, 20);
            password_label.TabIndex = 20;
            password_label.Text = "Your Password:";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.RosyBrown;
            login_btn.BackgroundImageLayout = ImageLayout.Center;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.ForeColor = Color.WhiteSmoke;
            login_btn.Location = new Point(246, 280);
            login_btn.Name = "login_btn";
            login_btn.RightToLeft = RightToLeft.Yes;
            login_btn.Size = new Size(242, 41);
            login_btn.TabIndex = 22;
            login_btn.Text = "DONE";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._900w_uS8QA4tnBqU;
            ClientSize = new Size(800, 450);
            Controls.Add(login_btn);
            Controls.Add(password);
            Controls.Add(password_label);
            Controls.Add(username);
            Controls.Add(username_label);
            Controls.Add(Log_In_lbl);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Log_In_lbl;
        private Label username_label;
        private TextBox username;
        private TextBox password;
        private Label password_label;
        private Button login_btn;
    }
}