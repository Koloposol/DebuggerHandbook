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
    public partial class viewReadedForm : Form
    {
        public viewReadedForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
