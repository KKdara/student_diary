using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudentProfileButton_Click(object sender, EventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
        }

        private void EditButtonStudentProfile_Click(object sender, EventArgs e)
        {
            string name = this.NameStudentProfileText.Text;
            string surname = this.SurnameStudentProfileText.Text;
            string patronymic = this.PatronymicStudentProfileText.Text;
            string email = this.EmailStudentProfileText.Text;
            string number = this.PhoneNumberStudentProfileText.Text;
            
            try
            {
                EditStudentProfile(name, surname, patronymic, email, number);
                MessageBox.Show("Профиль успешно отредактирован");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void EditStudentProfile(string name, string surname, string patronymic, string email, string number)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(patronymic) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(number))
            {
                throw new ArgumentException("Все поля должны быть заполнены!");
            }
            var user = GetUser(name, email);
            if (user = null)
            {
                throw new ArgumentException("Пользователь не найден");
            }
            user.name = name;
            user.surname = surname;
            user.patronymic = patronymic;
            user.email = email;
            user.number = number;

            SaveUser(user);
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
        }
    }
}
