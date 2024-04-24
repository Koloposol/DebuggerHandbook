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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DebuggerHandbook
{
    public partial class UserProfileSettings : Form
    {
        public UserProfileSettings()
        {
            InitializeComponent();
        }

        private void UserProfileSettings_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonHidePas, "Скрыть пароль.");
            toolTip1.SetToolTip(buttonViewPas, "Показать пароль.");
        }

        private void buttonViewPas_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            buttonViewPas.Visible = false;
            buttonHidePas.Visible = true;
        }

        private void buttonHidePas_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            buttonHidePas.Visible = false;
            buttonViewPas.Visible = true;
        }

        private void CheckingValidityOfFields()
        {
            if (textBoxSurname.Text == "" || textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxPassword.Text == "")
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

        public int userId;

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                CheckingValidityOfFields();

                int id = userId;
                string surname = textBoxSurname.Text;
                string name = textBoxName.Text;
                string email = textBoxEmail.Text;
                string password = textBoxPassword.Text;

                DataBase db = new DataBase();

                string query = $"UPDATE users_db " +
                    $"SET surname = '{surname}', name = '{name}', email = '{email}', password = '{password}' " +
                    $"WHERE id = {id}";

                SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());

                db.openConnection();

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Учетная запись успешно изменена!\nНеобходима повторная авторизация", "Изменение завершено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Неудалось изменить учетную запись!\nВозможно указанные email или пароль уже зарегистрированы.", "Ошибка изменения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неудалось изменить учетную запись!\nВозможно указанные email или пароль уже зарегистрированы.", "Ошибка изменения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                return;
            }
        }

        private void ResetProgress()
        {
            DataBase db = new DataBase();

            int id = userId;

            string query = $"UPDATE users_db " +
            $"SET theory_count = 0, practice_count = 0, theory_progress = 0, practice_progress = 0" +
            $"WHERE id = {id}";

            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());

            db.openConnection();

            if (sqlCommand.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Прогресс учетной записи удален!", "Удаление завершено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            db.closeConnection();
        }

        private void buttonResetProgress_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show
                (
                    "При нажатий кнопки \"Да\" весь ваш прогресс будет удален!\n" +
                    "Вы уверены, что хотите сбросить прогресс?",
                    "Сброс прогресса",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

            if (warning == DialogResult.Yes)
                ResetProgress();
        }
    }
}
