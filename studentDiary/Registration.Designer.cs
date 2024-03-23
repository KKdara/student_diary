namespace studentDiary
{
    partial class RegistrationWindow
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
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.CheckPassword = new System.Windows.Forms.Label();
            this.RegistrationStart = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.PatronymicText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.CheckPasswordText = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.YearText = new System.Windows.Forms.TextBox();
            this.IStudentButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(43, 32);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(53, 25);
            this.Name.TabIndex = 0;
            this.Name.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(259, 32);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 25);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Фамилия";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.Location = new System.Drawing.Point(498, 32);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(236, 25);
            this.Patronymic.TabIndex = 2;
            this.Patronymic.Text = "Отчество(при наличии)";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.Location = new System.Drawing.Point(43, 138);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(158, 25);
            this.Birthday.TabIndex = 3;
            this.Birthday.Text = "Дата рождения";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(43, 234);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 25);
            this.Email.TabIndex = 4;
            this.Email.Text = "Электронная почта";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(43, 330);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(84, 25);
            this.Password.TabIndex = 5;
            this.Password.Text = "Пароль";
            // 
            // CheckPassword
            // 
            this.CheckPassword.AutoSize = true;
            this.CheckPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPassword.Location = new System.Drawing.Point(434, 330);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(188, 25);
            this.CheckPassword.TabIndex = 6;
            this.CheckPassword.Text = "Повторите пароль";
            // 
            // RegistrationStart
            // 
            this.RegistrationStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegistrationStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrationStart.Location = new System.Drawing.Point(264, 535);
            this.RegistrationStart.Name = "RegistrationStart";
            this.RegistrationStart.Size = new System.Drawing.Size(262, 68);
            this.RegistrationStart.TabIndex = 7;
            this.RegistrationStart.Text = "Зарегистрироваться";
            this.RegistrationStart.UseVisualStyleBackColor = false;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(48, 72);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(173, 31);
            this.NameText.TabIndex = 8;
            // 
            // SurnameText
            // 
            this.SurnameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameText.Location = new System.Drawing.Point(264, 72);
            this.SurnameText.Multiline = true;
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(206, 31);
            this.SurnameText.TabIndex = 9;
            // 
            // PatronymicText
            // 
            this.PatronymicText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicText.Location = new System.Drawing.Point(503, 72);
            this.PatronymicText.Multiline = true;
            this.PatronymicText.Name = "PatronymicText";
            this.PatronymicText.Size = new System.Drawing.Size(267, 31);
            this.PatronymicText.TabIndex = 10;
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailText.Location = new System.Drawing.Point(48, 271);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(722, 31);
            this.EmailText.TabIndex = 11;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(48, 372);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(285, 31);
            this.PasswordText.TabIndex = 12;
            // 
            // CheckPasswordText
            // 
            this.CheckPasswordText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPasswordText.Location = new System.Drawing.Point(439, 372);
            this.CheckPasswordText.Multiline = true;
            this.CheckPasswordText.Name = "CheckPasswordText";
            this.CheckPasswordText.Size = new System.Drawing.Size(285, 31);
            this.CheckPasswordText.TabIndex = 13;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date.FormattingEnabled = true;
            this.Date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Date.Location = new System.Drawing.Point(48, 178);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(121, 28);
            this.Date.TabIndex = 14;
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.Month.Location = new System.Drawing.Point(212, 178);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(121, 28);
            this.Month.TabIndex = 15;
            // 
            // YearText
            // 
            this.YearText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YearText.Location = new System.Drawing.Point(393, 178);
            this.YearText.Multiline = true;
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(121, 32);
            this.YearText.TabIndex = 16;
            // 
            // IStudentButton
            // 
            this.IStudentButton.AutoSize = true;
            this.IStudentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IStudentButton.Location = new System.Drawing.Point(48, 452);
            this.IStudentButton.Name = "IStudentButton";
            this.IStudentButton.Size = new System.Drawing.Size(127, 31);
            this.IStudentButton.TabIndex = 17;
            this.IStudentButton.TabStop = true;
            this.IStudentButton.Text = "Я студент";
            this.IStudentButton.UseVisualStyleBackColor = true;
            this.IStudentButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(247, 452);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(207, 31);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Я администратор";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.IStudentButton);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CheckPasswordText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.PatronymicText);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.RegistrationStart);
            this.Controls.Add(this.CheckPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Name = "RegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label CheckPassword;
        private System.Windows.Forms.Button RegistrationStart;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox PatronymicText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox CheckPasswordText;
        private System.Windows.Forms.ComboBox Date;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.RadioButton IStudentButton;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}