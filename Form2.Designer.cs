namespace Bineva_L_08._01._24
{
    partial class Form2
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
            age_check = new Label();
            age_label = new Label();
            phone_label = new Label();
            gender_label = new Label();
            gender_opt = new Label();
            reminder_word_label = new Label();
            reminder_word = new TextBox();
            birthday = new DateTimePicker();
            label1 = new Label();
            gender = new ComboBox();
            signup_btn = new Button();
            SuspendLayout();
            // 
            // more_info
            // 
            more_info.AutoSize = true;
            more_info.BackColor = Color.Transparent;
            more_info.FlatStyle = FlatStyle.Popup;
            more_info.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            more_info.ForeColor = SystemColors.ActiveCaptionText;
            more_info.Location = new Point(192, 95);
            more_info.Name = "more_info";
            more_info.Size = new Size(289, 28);
            more_info.TabIndex = 1;
            more_info.Text = "Tell Us More About You!";
            more_info.TextAlign = ContentAlignment.TopCenter;
            // 
            // age_check
            // 
            age_check.AutoSize = true;
            age_check.BackColor = Color.Transparent;
            age_check.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            age_check.Location = new Point(453, 174);
            age_check.Name = "age_check";
            age_check.Size = new Size(219, 30);
            age_check.TabIndex = 15;
            age_check.Text = "(Be advised that people under 18 cannot\r\nhave an account on our platform.)";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.BackColor = Color.Transparent;
            age_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            age_label.Location = new Point(192, 143);
            age_label.Name = "age_label";
            age_label.Size = new Size(132, 20);
            age_label.TabIndex = 13;
            age_label.Text = "Your Date of Birth:";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.BackColor = Color.Transparent;
            phone_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            phone_label.Location = new Point(192, 208);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(0, 20);
            phone_label.TabIndex = 16;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.BackColor = Color.Transparent;
            gender_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            gender_label.Location = new Point(192, 208);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(97, 20);
            gender_label.TabIndex = 18;
            gender_label.Text = "Your Gender:";
            // 
            // gender_opt
            // 
            gender_opt.AutoSize = true;
            gender_opt.BackColor = Color.Transparent;
            gender_opt.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gender_opt.Location = new Point(453, 306);
            gender_opt.Name = "gender_opt";
            gender_opt.Size = new Size(55, 15);
            gender_opt.TabIndex = 20;
            gender_opt.Text = "*optional";
            // 
            // reminder_word_label
            // 
            reminder_word_label.AutoSize = true;
            reminder_word_label.BackColor = Color.Transparent;
            reminder_word_label.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            reminder_word_label.Location = new Point(192, 278);
            reminder_word_label.Name = "reminder_word_label";
            reminder_word_label.Size = new Size(115, 20);
            reminder_word_label.TabIndex = 21;
            reminder_word_label.Text = "Reminder Word:";
            // 
            // reminder_word
            // 
            reminder_word.BackColor = Color.RosyBrown;
            reminder_word.BorderStyle = BorderStyle.None;
            reminder_word.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reminder_word.Location = new Point(192, 301);
            reminder_word.Name = "reminder_word";
            reminder_word.Size = new Size(242, 22);
            reminder_word.TabIndex = 22;
            // 
            // birthday
            // 
            birthday.CalendarForeColor = Color.RosyBrown;
            birthday.CalendarMonthBackground = Color.RosyBrown;
            birthday.CalendarTitleBackColor = Color.RosyBrown;
            birthday.CalendarTitleForeColor = Color.RosyBrown;
            birthday.CalendarTrailingForeColor = Color.RosyBrown;
            birthday.Location = new Point(192, 168);
            birthday.Name = "birthday";
            birthday.Size = new Size(242, 23);
            birthday.TabIndex = 23;
            birthday.Validating += birthday_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(453, 244);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 24;
            label1.Text = "*optional";
            // 
            // gender
            // 
            gender.BackColor = Color.RosyBrown;
            gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gender.ForeColor = SystemColors.MenuBar;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female", "Non-binary", "Other" });
            gender.Location = new Point(192, 236);
            gender.Name = "gender";
            gender.Size = new Size(242, 29);
            gender.TabIndex = 25;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.RosyBrown;
            signup_btn.BackgroundImageLayout = ImageLayout.Center;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signup_btn.ForeColor = Color.WhiteSmoke;
            signup_btn.Location = new Point(221, 351);
            signup_btn.Name = "signup_btn";
            signup_btn.RightToLeft = RightToLeft.Yes;
            signup_btn.Size = new Size(177, 67);
            signup_btn.TabIndex = 26;
            signup_btn.Text = "DONE";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._900w_uS8QA4tnBqU;
            ClientSize = new Size(720, 450);
            Controls.Add(signup_btn);
            Controls.Add(gender);
            Controls.Add(label1);
            Controls.Add(birthday);
            Controls.Add(reminder_word);
            Controls.Add(reminder_word_label);
            Controls.Add(gender_opt);
            Controls.Add(gender_label);
            Controls.Add(phone_label);
            Controls.Add(age_check);
            Controls.Add(age_label);
            Controls.Add(more_info);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label more_info;
        private Label age_check;
        private Label age_label;
        private Label phone_label;
        private Label gender_label;
        private Label gender_opt;
        private Label reminder_word_label;
        private TextBox reminder_word;
        private DateTimePicker birthday;
        private Label label1;
        private ComboBox gender;
        private Button signup_btn;
    }
}