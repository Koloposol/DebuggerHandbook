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

        private void viewForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(backButton, "Выйти на главную форму.");
            toolTip1.SetToolTip(buttonReaded, "Отметить лекцию прочитанной.");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReaded_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
