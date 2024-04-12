using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DebuggerHandbook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        public string userEmail = "";

        private void CheckProgress()
        {
            foreach (var button in this.groupBoxTheoty.Controls.OfType<Button>())
            {
                if (theoryProgress.ToString().Contains(button.Name.Substring(button.Name.Length - 1)))
                    button.BackColor = Color.Gray;
            }

            foreach (var button in this.groupBoxPractice.Controls.OfType<Button>())
            {
                if (practiceProgress.ToString().Contains(button.Name.Substring(button.Name.Length - 1)))
                    button.BackColor = Color.Gray;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserData(userEmail);
            CheckProgress();//TODO Добавить метод проверки прогресса (чтобы закрашивать кнопки прочитанных лекции/пройденных заданий)
        }

        private void buttonWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://nggtk.ru/");
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            //TODO заменить about.html формой aboutForm
            viewForm viewForm = new viewForm();
            viewForm.ShowDialog();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\about.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);
        }

        private void buttonPactice1_Click(object sender, EventArgs e)
        {
            practiceForm_1 prcticeForm = new practiceForm_1();
            prcticeForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();

            this.Close();
        }

        public string userPassword = "";
        private int userId;

        private void buttonProfileSettings_Click(object sender, EventArgs e)
        {
            UserProfileSettings userProfileSettings = new UserProfileSettings();

            userProfileSettings.userId = userId;
            userProfileSettings.textBoxSurname.Text = labelSurname.Text;
            userProfileSettings.textBoxName.Text = labelName.Text;
            userProfileSettings.textBoxEmail.Text = userEmail;
            userProfileSettings.textBoxPassword.Text = userPassword;
            
            userProfileSettings.ShowDialog();
            if (userProfileSettings.DialogResult == DialogResult.OK)
                this.Close();
        }

        private void LoadUserData(string email)
        {
            DataBase db = new DataBase();

            string query = $"SELECT id, surname, name, theory_count, practice_count, theory_progress, practice_progress " +
                $"FROM users_db " +
                $"WHERE email = '{email}'";

            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());
            db.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userId = (int)reader["id"];
                    labelSurname.Text = reader["surname"].ToString();
                    labelName.Text = reader["name"].ToString();
                    labelTheory.Text = reader["theory_count"].ToString();
                    labelPractice.Text = reader["practice_count"].ToString();
                    theoryProgress = (int)reader["theory_progress"];
                    practiceProgress = (int)reader["practice_progress"];
                }

            }
            else
                MessageBox.Show("Неудалось считать данные пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            reader.Close();
        }

        private int theoryProgress;
        private int practiceProgress;

        private void AddResultToDb(int theoryNumber)
        {
            string email = userEmail;

            int result = Convert.ToInt32(labelTheory.Text) + 1;
            string progressString = theoryProgress.ToString() + theoryNumber.ToString();
            int _progress = Convert.ToInt32(progressString);

            DataBase db = new DataBase();

            string query = $"UPDATE users_db " +
                    $"SET theory_count = {result}, theory_progress = {_progress} " +
                    $"WHERE email = '{email}'";

            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());

            db.openConnection();

            if (sqlCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("Данные успешно добавлены!", "Данные добавлены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Неудалось обноаить данные!", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            db.closeConnection();
        }

        private void buttonTheory1_Click(object sender, EventArgs e)
        {
            if (buttonTheory1.BackColor != Color.Gray)
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\what_is_debugging.html";
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddResultToDb(1);
                    LoadUserData(userEmail);
                    buttonTheory1.BackColor = Color.Gray;
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\what_is_debugging.html";
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;
            }
        }
    }
}
