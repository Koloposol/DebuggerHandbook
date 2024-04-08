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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();   
            signUpForm.Show();

            this.Hide();
        }

        private void CheckingValidityOfFields()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Необходимо заполнить все поля!", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(textBox1.Text, pattern, RegexOptions.IgnoreCase))
                    MessageBox.Show("Email указан в неверном формате!", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Нажатие кнопки "Войти"
        private void button4_Click(object sender, EventArgs e)
        {
            CheckingValidityOfFields();

            string email = textBox1.Text;
            string password = textBox2.Text;

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
                mainForm.Show();

                this.Hide();
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
