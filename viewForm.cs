using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebuggerHandbook
{
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Close();
        }

        private void buttonReaded_Click(object sender, EventArgs e)
        {
            //AddResultToDB();

            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Close();
        }
    }
}
