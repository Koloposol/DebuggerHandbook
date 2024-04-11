using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebuggerHandbook
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void buttonViewPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            buttonViewPassword.Visible = false;
            buttonHidePassword.Visible = true;
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            buttonHidePassword.Visible = false;
            buttonViewPassword.Visible = true;
        }

        private void CheckingValidityOfFields()
        {
            if (textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxSurname.Text == "" || textBoxName.Text == "")
                MessageBox.Show("Необходимо заполнить все поля!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(textBoxEmail.Text, pattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Email указан в неверном формате!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string fioPattern = @"[А-Яа-я]";
                if (!Regex.IsMatch(textBoxSurname.Text, fioPattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Фамилия указано в неверном формате!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!Regex.IsMatch(textBoxName.Text, fioPattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Имя указано в неверном формате!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                CheckingValidityOfFields();

                string surname = textBoxSurname.Text;
                string name = textBoxName.Text;
                string email = textBoxEmail.Text;
                string password = textBoxPassword.Text;

                DataBase db = new DataBase();

                string query = $"INSERT INTO users_db(surname, name, email, password) " +
                    $"VALUES ('{surname}', '{name}', '{email}', '{password}')";

                SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());

                db.openConnection();

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Учетная запись успешно создана!", "Регистрация завершена!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LogInForm logInForm = new LogInForm();
                    logInForm.Show();

                    this.Close();
                }
                else
                    MessageBox.Show("Неудалось создать учетную запись!\nВозможно указанные email или пароль уже зарегистрированы.", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неудалось создать учетную запись!\nВозможно указанные email или пароль уже зарегистрированы.", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                return;
            }
        }
    }
}
