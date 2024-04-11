using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DebuggerHandbook
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
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

        private void buttonSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();   
            signUpForm.Show();

            this.Hide();
        }

        private void CheckingValidityOfFields()
        {
            if (textBoxEmail.Text == "" || textBoxPassword.Text == "")
                MessageBox.Show("Необходимо заполнить все поля!", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(textBoxEmail.Text, pattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Email указан в неверном формате!", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            CheckingValidityOfFields();

            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            DataBase db = new DataBase();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string query = $"SELECT surname, name, theory_count, practice_count " +
                $"FROM users_db " +
                $"WHERE email = '{email}' and password = '{password}'";

            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.userEmail = email;
                mainForm.userPassword = password;
                this.Hide();
                mainForm.ShowDialog();
            }
            else
                MessageBox.Show("Неудалось подключиться к базе данных!\nПроверьте email и пароль.", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
