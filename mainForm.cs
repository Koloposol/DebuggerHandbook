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

namespace DebuggerHandbook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);

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

    }
}
