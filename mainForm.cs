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

        private void чтоТакоеОтладкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\what_is_debugging.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }
        private void методРучногоТестированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\handle_testing.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }
        private void методИндукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\induction_testing.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void методДедукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\deduction_testing.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void методОбратногоПрослеживанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\backtracking_testing.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void отладчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\debuggers.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void профилировщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\profiler.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void дизассемблерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\disassemblers.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void анализаторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm viewForm = new viewForm();
            viewForm.Show();

            string lectureLink = $@"{applicationDirectory}\LecturesBase\analyzers.html";
            viewForm.webBrowser1.Url = new Uri(lectureLink);

            this.Hide();
        }

        private void отладкаКакПользоватьсяОтладчикомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=_ZairtpcXTs&t=14s");
        }

        private void отладкаПрограммToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=qut3cTKcFhg&t=851s");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
