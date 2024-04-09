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

namespace DebuggerHandbook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            //FIXME: сохранение поля email из формы LogIn
            string email = "egor_lomakin@inbox.ru"/*logInForm.textBox1.Text*/;

            DataBase db = new DataBase();

            string query = $"SELECT surname, name, theory_count, practice_count, theory_progress, practice_progress " +
                $"FROM users_db " +
                $"WHERE email = '{email}'";
            
            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());
            db.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    labelSurname.Text = reader["surname"].ToString();
                    labelName.Text = reader["name"].ToString();
                    labelTheory.Text = reader["theory_count"].ToString();
                    labelPractice.Text = reader["practice_count"].ToString();
                }

            }
            else
                MessageBox.Show("Неудалось считать данные пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            reader.Close();
        }

        //private void чтоТакоеОтладкаToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    viewForm viewForm = new viewForm();
        //    viewForm.Show();

        //    string lectureLink = $@"{applicationDirectory}\LecturesBase\what_is_debugging.html";
        //    viewForm.webBrowser1.Url = new Uri(lectureLink);

        //    this.Hide();
        //}
        
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://nggtk.ru/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO заменить about.html формой aboutForm
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\about.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            practiceForm_1 prcticeForm = new practiceForm_1();
            prcticeForm.Show();

            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Кнопка "Выйти из профиля"
        private void button2_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();

            this.Hide();
        }

    }
}
