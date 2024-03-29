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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
