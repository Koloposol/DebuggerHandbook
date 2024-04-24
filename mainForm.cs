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
using System.Threading;

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
                else
                    button.BackColor = Color.DeepSkyBlue;
            }

            foreach (var button in this.groupBoxPractice.Controls.OfType<Button>())
            {
                if (practiceProgress.ToString().Contains(button.Name.Substring(button.Name.Length - 1)))
                    button.BackColor = Color.Gray;
                else
                    button.BackColor = Color.DeepSkyBlue;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserData(userEmail);
            CheckProgress();

            toolTip1.SetToolTip(buttonProfileSettings, "Изменить данные профиля.");
            toolTip1.SetToolTip(buttonLogOut, "Выйти из текущего профиля.");
            toolTip1.SetToolTip(buttonAbout, "Посмотреть информацию о программе.");
            toolTip1.SetToolTip(buttonWebsite, "Перейти на сайт колледжа.");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            HasCourseCompleted();
        }

        private void buttonWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://nggtk.ru/");
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
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

            LoadUserData(userEmail);
            CheckProgress();
        }

        public void HasCourseCompleted()
        {
            if (labelTheory.Text == "8" && labelPractice.Text == "8")
            {
                DialogResult message = MessageBox.Show(
                "Вы прочли все лекции и успешно прошли все практикумы!\nТеперь вы обладаете фундаментальными знаниями в области отладки программного обеспечения.",
                "Поздравляем вас с прохождением курса \"Основы отладки\"!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );
            }
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
            db.closeConnection();

            HasCourseCompleted();
        }

        private int theoryProgress;
        private int practiceProgress;

        private void AddTheoryToDb(int theoryNumber)
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
                Thread.Sleep(100);

            db.closeConnection();
        }

        // Лекции
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
                    AddTheoryToDb(1);
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

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory2_Click(object sender, EventArgs e)
        {
            if (buttonTheory2.BackColor != Color.Gray)
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\error_types.html";
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(2);
                    LoadUserData(userEmail);
                    buttonTheory2.BackColor = Color.Gray;
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\error_types.html";
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory3_Click(object sender, EventArgs e)
        {
            if (buttonTheory3.BackColor != Color.Gray) //<-
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\debugging_methods.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(3); //<-
                    LoadUserData(userEmail);
                    buttonTheory3.BackColor = Color.Gray; //<-
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\debugging_methods.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory4_Click(object sender, EventArgs e)
        {
            if (buttonTheory4.BackColor != Color.Gray) //<-
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\debugging_tools.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(4); //<-
                    LoadUserData(userEmail);
                    buttonTheory4.BackColor = Color.Gray; //<-
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\debugging_tools.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory5_Click(object sender, EventArgs e)
        {
            if (buttonTheory5.BackColor != Color.Gray) //<-
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\Profiling.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(5); //<-
                    LoadUserData(userEmail);
                    buttonTheory5.BackColor = Color.Gray; //<-
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\Profiling.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory6_Click(object sender, EventArgs e)
        {
            if (buttonTheory6.BackColor != Color.Gray) //<-
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\Disassembler.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(6); //<-
                    LoadUserData(userEmail);
                    buttonTheory6.BackColor = Color.Gray; //<-
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\Disassembler.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory7_Click(object sender, EventArgs e)
        {
            if (buttonTheory7.BackColor != Color.Gray) //<-
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\MS_Visual_Studio_Debugger.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(7); //<-
                    LoadUserData(userEmail);
                    buttonTheory7.BackColor = Color.Gray; //<-
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\MS_Visual_Studio_Debugger.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void buttonTheory8_Click(object sender, EventArgs e)
        {
            if (buttonTheory8.BackColor != Color.Gray) //<-
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\Breakpoints.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);

                viewForm.ShowDialog();
                if (viewForm.DialogResult == DialogResult.Yes)
                {
                    AddTheoryToDb(8); //<-
                    LoadUserData(userEmail);
                    buttonTheory8.BackColor = Color.Gray; //<-
                }
            }
            else
            {
                viewForm viewForm = new viewForm();
                string lectureLink = $@"{applicationDirectory}\LecturesBase\Breakpoints.html"; //<-
                viewForm.webBrowser1.Url = new Uri(lectureLink);
                viewForm.buttonReaded.Visible = false;

                viewForm.ShowDialog();
            }
        }

        private void AddPracticeToDb(int practiceNumber)
        {
            string email = userEmail;

            int result = Convert.ToInt32(labelPractice.Text) + 1;
            string progressString = practiceProgress.ToString() + practiceNumber.ToString();
            int _progress = Convert.ToInt32(progressString);

            DataBase db = new DataBase();

            string query = $"UPDATE users_db " +
                    $"SET practice_count = {result}, practice_progress = {_progress} " +
                    $"WHERE email = '{email}'";

            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());

            db.openConnection();

            if (sqlCommand.ExecuteNonQuery() == 1)
                Thread.Sleep(100);

            db.closeConnection();
        }

        // Практикумы
        private void buttonPactice1_Click(object sender, EventArgs e)
        {
            if (buttonPactice1.BackColor != Color.Gray) //
            {
                practiceForm_1 practiceForm_1 = new practiceForm_1(); //
                practiceForm_1.ShowDialog(); //

                if (practiceForm_1.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(1); //
                    LoadUserData(userEmail);
                    buttonPactice1.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_1 practiceForm_1 = new practiceForm_1(); //
                practiceForm_1.ShowDialog(); //
            }
        }

        private void buttonPactice2_Click(object sender, EventArgs e)
        {
            if (buttonPactice2.BackColor != Color.Gray) //
            {
                practiceForm_2 practiceForm_2 = new practiceForm_2(); //
                practiceForm_2.ShowDialog(); //

                if (practiceForm_2.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(2); //
                    LoadUserData(userEmail);
                    buttonPactice2.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_2 practiceForm_2 = new practiceForm_2(); //
                practiceForm_2.ShowDialog(); //
            }
        }

        private void buttonPactice3_Click(object sender, EventArgs e)
        {
            if (buttonPactice3.BackColor != Color.Gray) //
            {
                practiceForm_3 practiceForm_3 = new practiceForm_3(); //
                practiceForm_3.ShowDialog(); //

                if (practiceForm_3.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(3); //
                    LoadUserData(userEmail);
                    buttonPactice3.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_3 practiceForm_3 = new practiceForm_3(); //
                practiceForm_3.ShowDialog(); //
            }
        }

        private void buttonPactice4_Click(object sender, EventArgs e)
        {
            if (buttonPactice4.BackColor != Color.Gray) //
            {
                practiceForm_4 practiceForm_4 = new practiceForm_4(); //
                practiceForm_4.ShowDialog(); //

                if (practiceForm_4.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(4); //
                    LoadUserData(userEmail);
                    buttonPactice4.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_4 practiceForm_4 = new practiceForm_4(); //
                practiceForm_4.ShowDialog(); //
            }
        }

        private void buttonPactice5_Click(object sender, EventArgs e)
        {
            if (buttonPactice5.BackColor != Color.Gray) //
            {
                practiceForm_5 practiceForm_5 = new practiceForm_5(); //
                practiceForm_5.ShowDialog(); //

                if (practiceForm_5.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(5); //
                    LoadUserData(userEmail);
                    buttonPactice5.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_5 practiceForm_5 = new practiceForm_5(); //
                practiceForm_5.ShowDialog(); //
            }
        }

        private void buttonPactice6_Click(object sender, EventArgs e)
        {
            if (buttonPactice6.BackColor != Color.Gray) //
            {
                practiceForm_6 practiceForm_6 = new practiceForm_6(); //
                practiceForm_6.ShowDialog(); //

                if (practiceForm_6.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(6); //
                    LoadUserData(userEmail);
                    buttonPactice6.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_6 practiceForm_6 = new practiceForm_6(); //
                practiceForm_6.ShowDialog(); //
            }
        }

        private void buttonPactice7_Click(object sender, EventArgs e)
        {
            if (buttonPactice7.BackColor != Color.Gray) //
            {
                practiceForm_7 practiceForm_7 = new practiceForm_7(); //
                practiceForm_7.ShowDialog(); //

                if (practiceForm_7.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(7); //
                    LoadUserData(userEmail);
                    buttonPactice7.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_7 practiceForm_7 = new practiceForm_7(); //
                practiceForm_7.ShowDialog(); //
            }
        }

        private void buttonPactice8_Click(object sender, EventArgs e)
        {
            if (buttonPactice8.BackColor != Color.Gray) //
            {
                practiceForm_8 practiceForm_8 = new practiceForm_8(); //
                practiceForm_8.ShowDialog(); //

                if (practiceForm_8.DialogResult == DialogResult.Yes) //
                {
                    AddPracticeToDb(8); //
                    LoadUserData(userEmail);
                    buttonPactice8.BackColor = Color.Gray; //
                }
            }
            else
            {
                practiceForm_8 practiceForm_8 = new practiceForm_8(); //
                practiceForm_8.ShowDialog(); //
            }
        }

        // Ссылки
        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://visualstudio.microsoft.com/ru/");
        }

        private void linkLessons_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=qut3cTKcFhg");
        }

        private void linkArticle1_Click(object sender, EventArgs e)
        {
            Process.Start("https://learn.microsoft.com/ru-ru/visualstudio/debugger/what-is-debugging?view=vs-2022");
        }

        private void linkArticle2_Click(object sender, EventArgs e)
        {
            Process.Start("https://learn.microsoft.com/ru-ru/visualstudio/debugger/debugger-feature-tour?view=vs-2022");
        }

        private void linkArticle3_Click(object sender, EventArgs e)
        {
            Process.Start("https://learn.microsoft.com/ru-ru/visualstudio/debugger/write-better-code-with-visual-studio?view=vs-2022");
        }

        private void linkArticle4_Click(object sender, EventArgs e)
        {
            Process.Start("https://learn.microsoft.com/ru-ru/visualstudio/debugger/find-your-debugging-task?view=vs-2022");
        }
    }
}
