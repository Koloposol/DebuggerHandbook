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

        //Нажатие кнопки "Зарегистрироваться"
        private void button4_Click(object sender, EventArgs e)
        {
            CheckingValidityOfFields();
        }
    }
}
