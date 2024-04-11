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
    public partial class practiceForm_1 : Form
    {
        public practiceForm_1()
        {
            InitializeComponent();
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
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();

                this.Close();
            }
        }

        private int totalScore = 0;

        private void CalculateResult()
        {
            //if ( выбран правильный вариант ответа ) totalScore++;
            //if ( выбран НЕправильный вариант ответа ) totalScore--;
            if (checkBox2.Checked && checkBox4.Checked) totalScore++;
            if (checkBox1.Checked || checkBox3.Checked) totalScore--;
            if (radioButton1.Checked) totalScore++;
            if (radioButton2.Checked) totalScore++;
            if (radioButton3.Checked) totalScore++;
            if (checkBox5.Checked) totalScore++;
            if (radioButton7.Checked) totalScore++;
        }

        private void buttonComplited_Click(object sender, EventArgs e)
        {
            CalculateResult();
            
            if (totalScore > 3)
            {
                DialogResult messageResult = MessageBox.Show(
                    $"Практический модуль №1 завершен!\nПравильных ответов {totalScore} из 5",
                    "Ваш результат",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (messageResult == DialogResult.OK)
                    this.Close();

                //AddResultToDB();
            }
            else
            {
                DialogResult messageResult = MessageBox.Show(
                    $"Правильных ответов {totalScore} из 5\nК сожалению, вы не прошли практический модуль. " +
                    $"Повторите теоретический материал и у вас всё получится!",
                    "Ваш результат",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (messageResult == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
