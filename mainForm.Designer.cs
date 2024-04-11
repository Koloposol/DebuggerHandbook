﻿namespace DebuggerHandbook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonProfileSettings = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPractice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTheory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonWebsite = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPactice1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWebsite)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonProfileSettings);
            this.groupBox1.Controls.Add(this.buttonLogOut);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labelPractice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelTheory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(244, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Профиль";
            // 
            // buttonProfileSettings
            // 
            this.buttonProfileSettings.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonProfileSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfileSettings.ForeColor = System.Drawing.Color.White;
            this.buttonProfileSettings.Location = new System.Drawing.Point(8, 391);
            this.buttonProfileSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProfileSettings.Name = "buttonProfileSettings";
            this.buttonProfileSettings.Size = new System.Drawing.Size(228, 37);
            this.buttonProfileSettings.TabIndex = 8;
            this.buttonProfileSettings.Text = "Настройка профиля";
            this.buttonProfileSettings.UseVisualStyleBackColor = false;
            this.buttonProfileSettings.Click += new System.EventHandler(this.buttonProfileSettings_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(8, 436);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(228, 37);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Выйти из профиля";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 228);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelPractice
            // 
            this.labelPractice.AutoSize = true;
            this.labelPractice.Location = new System.Drawing.Point(199, 351);
            this.labelPractice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPractice.Name = "labelPractice";
            this.labelPractice.Size = new System.Drawing.Size(45, 28);
            this.labelPractice.TabIndex = 6;
            this.labelPractice.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пройдено задании: ";
            // 
            // labelTheory
            // 
            this.labelTheory.AutoSize = true;
            this.labelTheory.Location = new System.Drawing.Point(199, 323);
            this.labelTheory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTheory.Name = "labelTheory";
            this.labelTheory.Size = new System.Drawing.Size(45, 28);
            this.labelTheory.TabIndex = 4;
            this.labelTheory.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Прочитано лекции: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 287);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(3, 258);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(96, 28);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.buttonAbout);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonWebsite);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(989, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label10.Location = new System.Drawing.Point(588, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 55);
            this.label10.TabIndex = 4;
            this.label10.Text = "Приволжский федеральный округ., Самарская область, г.о. Новокуйбышевск, ул. Успен" +
    "ского, 2";
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(843, 23);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(140, 37);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email: so_coll_ngtk_nkb@samara.edu.ru";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Телефон: 8(846)35 6-60-35";
            // 
            // buttonWebsite
            // 
            this.buttonWebsite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWebsite.BackgroundImage")));
            this.buttonWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWebsite.Location = new System.Drawing.Point(291, 12);
            this.buttonWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWebsite.Name = "buttonWebsite";
            this.buttonWebsite.Size = new System.Drawing.Size(289, 55);
            this.buttonWebsite.TabIndex = 0;
            this.buttonWebsite.TabStop = false;
            this.buttonWebsite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonWebsite_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(255, 53);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(245, 421);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Теоретический модуль";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(7, 70);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "лекция 1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPactice1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(507, 53);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(236, 421);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Практический модуль";
            // 
            // buttonPactice1
            // 
            this.buttonPactice1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice1.ForeColor = System.Drawing.Color.White;
            this.buttonPactice1.Location = new System.Drawing.Point(7, 70);
            this.buttonPactice1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice1.Name = "buttonPactice1";
            this.buttonPactice1.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice1.TabIndex = 10;
            this.buttonPactice1.Text = "Практикум 1";
            this.buttonPactice1.UseVisualStyleBackColor = false;
            this.buttonPactice1.Click += new System.EventHandler(this.buttonPactice1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(749, 53);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(233, 421);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ссылки";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(7, 70);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(221, 37);
            this.button6.TabIndex = 11;
            this.button6.Text = "Ссылка 1";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(421, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 41);
            this.label11.TabIndex = 5;
            this.label11.Text = "База знаний «Отладчик»";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 554);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База знаний «Отладчик»";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWebsite)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPractice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTheory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox buttonWebsite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonProfileSettings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonPactice1;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelSurname;
    }
}

