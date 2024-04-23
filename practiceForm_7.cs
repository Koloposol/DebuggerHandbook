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
    public partial class practiceForm_7 : Form
    {
        public practiceForm_7()
        {
            InitializeComponent();
        }

        private void practiceForm_7_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(backButton, "Выйти на главную форму.");
            toolTip1.SetToolTip(buttonComplited, "Завершить практикум.");
        }

        private int totalScore = 0;

        private void CalculateResult()
        {
            if (trueAnswer1.Checked) totalScore++;
            if (trueAnswer2.Checked) totalScore++;
            if (trueAnswer31.Checked) totalScore++;
        }

        private void buttonComplited_Click(object sender, EventArgs e)
        {
            CalculateResult();

            if (totalScore == 3)
            {
                DialogResult messageResult = MessageBox.Show(
                    $"Вы ответили верно на все вопросы.\nТак держать!",
                    "Практикум №7 завершен!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (messageResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                DialogResult messageResult = MessageBox.Show(
                    $"Правильных ответов {totalScore} из 3.\n" +
                    $"Повторите теоретический материал и у вас всё получится!",
                    "К сожалению, вы не прошли практикум.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (messageResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult messageResult = MessageBox.Show(
                "Вы точно хотите выйти?\nВ случае выхода прогресс выполнения практики будет утерян!",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

            if (messageResult == DialogResult.Yes)
                this.Close();
        }
    }
}
