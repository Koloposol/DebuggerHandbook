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

        //Отобразить пароль
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button1.Visible = false;
            button2.Visible = true;
        }

        //Скрыть пароль
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button2.Visible = false;
            button1.Visible = true;
        }

        private void CheckingValidityOfFields()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Необходимо заполнить все поля!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(textBox1.Text, pattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Email указан в неверном формате!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string fioPattern = @"[А-Яа-я]";
                if (!Regex.IsMatch(textBox3.Text, fioPattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Фамилия указано в неверном формате!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!Regex.IsMatch(textBox4.Text, fioPattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Имя указано в неверном формате!", "Ошибка регистрации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private bool checkUser()
        //{

        //}

        //Нажатие кнопки "Зарегистрироваться"
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CheckingValidityOfFields();

                string surname = textBox3.Text;
                string name = textBox4.Text;
                string email = textBox1.Text;
                string password = textBox2.Text;

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
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
        }
    }
}
