namespace DebuggerHandbook
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
            this.components = new System.ComponentModel.Container();
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
            this.groupBoxTheoty = new System.Windows.Forms.GroupBox();
            this.buttonTheory8 = new System.Windows.Forms.Button();
            this.buttonTheory7 = new System.Windows.Forms.Button();
            this.buttonTheory6 = new System.Windows.Forms.Button();
            this.buttonTheory5 = new System.Windows.Forms.Button();
            this.buttonTheory4 = new System.Windows.Forms.Button();
            this.buttonTheory3 = new System.Windows.Forms.Button();
            this.buttonTheory2 = new System.Windows.Forms.Button();
            this.buttonTheory1 = new System.Windows.Forms.Button();
            this.groupBoxPractice = new System.Windows.Forms.GroupBox();
            this.buttonPactice8 = new System.Windows.Forms.Button();
            this.buttonPactice7 = new System.Windows.Forms.Button();
            this.buttonPactice6 = new System.Windows.Forms.Button();
            this.buttonPactice5 = new System.Windows.Forms.Button();
            this.buttonPactice4 = new System.Windows.Forms.Button();
            this.buttonPactice3 = new System.Windows.Forms.Button();
            this.buttonPactice2 = new System.Windows.Forms.Button();
            this.buttonPactice1 = new System.Windows.Forms.Button();
            this.groupBoxLinks = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWebsite)).BeginInit();
            this.groupBoxTheoty.SuspendLayout();
            this.groupBoxPractice.SuspendLayout();
            this.groupBoxLinks.SuspendLayout();
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
            // groupBoxTheoty
            // 
            this.groupBoxTheoty.Controls.Add(this.buttonTheory8);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory7);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory6);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory5);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory4);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory3);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory2);
            this.groupBoxTheoty.Controls.Add(this.buttonTheory1);
            this.groupBoxTheoty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTheoty.Location = new System.Drawing.Point(255, 53);
            this.groupBoxTheoty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTheoty.Name = "groupBoxTheoty";
            this.groupBoxTheoty.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTheoty.Size = new System.Drawing.Size(245, 421);
            this.groupBoxTheoty.TabIndex = 2;
            this.groupBoxTheoty.TabStop = false;
            this.groupBoxTheoty.Text = "Теоретический модуль";
            // 
            // buttonTheory8
            // 
            this.buttonTheory8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory8.ForeColor = System.Drawing.Color.White;
            this.buttonTheory8.Location = new System.Drawing.Point(6, 372);
            this.buttonTheory8.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory8.Name = "buttonTheory8";
            this.buttonTheory8.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory8.TabIndex = 16;
            this.buttonTheory8.Text = "лекция 8";
            this.buttonTheory8.UseVisualStyleBackColor = false;
            this.buttonTheory8.Click += new System.EventHandler(this.buttonTheory8_Click);
            // 
            // buttonTheory7
            // 
            this.buttonTheory7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory7.ForeColor = System.Drawing.Color.White;
            this.buttonTheory7.Location = new System.Drawing.Point(6, 327);
            this.buttonTheory7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory7.Name = "buttonTheory7";
            this.buttonTheory7.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory7.TabIndex = 15;
            this.buttonTheory7.Text = "лекция 7";
            this.buttonTheory7.UseVisualStyleBackColor = false;
            this.buttonTheory7.Click += new System.EventHandler(this.buttonTheory7_Click);
            // 
            // buttonTheory6
            // 
            this.buttonTheory6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory6.ForeColor = System.Drawing.Color.White;
            this.buttonTheory6.Location = new System.Drawing.Point(6, 282);
            this.buttonTheory6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory6.Name = "buttonTheory6";
            this.buttonTheory6.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory6.TabIndex = 14;
            this.buttonTheory6.Text = "лекция 6";
            this.buttonTheory6.UseVisualStyleBackColor = false;
            this.buttonTheory6.Click += new System.EventHandler(this.buttonTheory6_Click);
            // 
            // buttonTheory5
            // 
            this.buttonTheory5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory5.ForeColor = System.Drawing.Color.White;
            this.buttonTheory5.Location = new System.Drawing.Point(6, 237);
            this.buttonTheory5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory5.Name = "buttonTheory5";
            this.buttonTheory5.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory5.TabIndex = 13;
            this.buttonTheory5.Text = "лекция 5";
            this.buttonTheory5.UseVisualStyleBackColor = false;
            this.buttonTheory5.Click += new System.EventHandler(this.buttonTheory5_Click);
            // 
            // buttonTheory4
            // 
            this.buttonTheory4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory4.ForeColor = System.Drawing.Color.White;
            this.buttonTheory4.Location = new System.Drawing.Point(7, 192);
            this.buttonTheory4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory4.Name = "buttonTheory4";
            this.buttonTheory4.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory4.TabIndex = 12;
            this.buttonTheory4.Text = "лекция 4";
            this.buttonTheory4.UseVisualStyleBackColor = false;
            this.buttonTheory4.Click += new System.EventHandler(this.buttonTheory4_Click);
            // 
            // buttonTheory3
            // 
            this.buttonTheory3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory3.ForeColor = System.Drawing.Color.White;
            this.buttonTheory3.Location = new System.Drawing.Point(7, 147);
            this.buttonTheory3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory3.Name = "buttonTheory3";
            this.buttonTheory3.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory3.TabIndex = 11;
            this.buttonTheory3.Text = "лекция 3";
            this.buttonTheory3.UseVisualStyleBackColor = false;
            this.buttonTheory3.Click += new System.EventHandler(this.buttonTheory3_Click);
            // 
            // buttonTheory2
            // 
            this.buttonTheory2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory2.ForeColor = System.Drawing.Color.White;
            this.buttonTheory2.Location = new System.Drawing.Point(7, 102);
            this.buttonTheory2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory2.Name = "buttonTheory2";
            this.buttonTheory2.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory2.TabIndex = 10;
            this.buttonTheory2.Text = "лекция 2";
            this.buttonTheory2.UseVisualStyleBackColor = false;
            this.buttonTheory2.Click += new System.EventHandler(this.buttonTheory2_Click);
            // 
            // buttonTheory1
            // 
            this.buttonTheory1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTheory1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTheory1.ForeColor = System.Drawing.Color.White;
            this.buttonTheory1.Location = new System.Drawing.Point(7, 57);
            this.buttonTheory1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTheory1.Name = "buttonTheory1";
            this.buttonTheory1.Size = new System.Drawing.Size(232, 37);
            this.buttonTheory1.TabIndex = 9;
            this.buttonTheory1.Text = "лекция 1";
            this.buttonTheory1.UseVisualStyleBackColor = false;
            this.buttonTheory1.Click += new System.EventHandler(this.buttonTheory1_Click);
            // 
            // groupBoxPractice
            // 
            this.groupBoxPractice.Controls.Add(this.buttonPactice8);
            this.groupBoxPractice.Controls.Add(this.buttonPactice7);
            this.groupBoxPractice.Controls.Add(this.buttonPactice6);
            this.groupBoxPractice.Controls.Add(this.buttonPactice5);
            this.groupBoxPractice.Controls.Add(this.buttonPactice4);
            this.groupBoxPractice.Controls.Add(this.buttonPactice3);
            this.groupBoxPractice.Controls.Add(this.buttonPactice2);
            this.groupBoxPractice.Controls.Add(this.buttonPactice1);
            this.groupBoxPractice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPractice.Location = new System.Drawing.Point(507, 53);
            this.groupBoxPractice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPractice.Name = "groupBoxPractice";
            this.groupBoxPractice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPractice.Size = new System.Drawing.Size(236, 421);
            this.groupBoxPractice.TabIndex = 3;
            this.groupBoxPractice.TabStop = false;
            this.groupBoxPractice.Text = "Практический модуль";
            // 
            // buttonPactice8
            // 
            this.buttonPactice8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice8.ForeColor = System.Drawing.Color.White;
            this.buttonPactice8.Location = new System.Drawing.Point(7, 372);
            this.buttonPactice8.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice8.Name = "buttonPactice8";
            this.buttonPactice8.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice8.TabIndex = 17;
            this.buttonPactice8.Text = "Практикум 8";
            this.buttonPactice8.UseVisualStyleBackColor = false;
            // 
            // buttonPactice7
            // 
            this.buttonPactice7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice7.ForeColor = System.Drawing.Color.White;
            this.buttonPactice7.Location = new System.Drawing.Point(7, 327);
            this.buttonPactice7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice7.Name = "buttonPactice7";
            this.buttonPactice7.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice7.TabIndex = 16;
            this.buttonPactice7.Text = "Практикум 7";
            this.buttonPactice7.UseVisualStyleBackColor = false;
            // 
            // buttonPactice6
            // 
            this.buttonPactice6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice6.ForeColor = System.Drawing.Color.White;
            this.buttonPactice6.Location = new System.Drawing.Point(7, 282);
            this.buttonPactice6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice6.Name = "buttonPactice6";
            this.buttonPactice6.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice6.TabIndex = 15;
            this.buttonPactice6.Text = "Практикум 6";
            this.buttonPactice6.UseVisualStyleBackColor = false;
            // 
            // buttonPactice5
            // 
            this.buttonPactice5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice5.ForeColor = System.Drawing.Color.White;
            this.buttonPactice5.Location = new System.Drawing.Point(7, 237);
            this.buttonPactice5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice5.Name = "buttonPactice5";
            this.buttonPactice5.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice5.TabIndex = 14;
            this.buttonPactice5.Text = "Практикум 5";
            this.buttonPactice5.UseVisualStyleBackColor = false;
            // 
            // buttonPactice4
            // 
            this.buttonPactice4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice4.ForeColor = System.Drawing.Color.White;
            this.buttonPactice4.Location = new System.Drawing.Point(7, 192);
            this.buttonPactice4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice4.Name = "buttonPactice4";
            this.buttonPactice4.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice4.TabIndex = 13;
            this.buttonPactice4.Text = "Практикум 4";
            this.buttonPactice4.UseVisualStyleBackColor = false;
            // 
            // buttonPactice3
            // 
            this.buttonPactice3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice3.ForeColor = System.Drawing.Color.White;
            this.buttonPactice3.Location = new System.Drawing.Point(7, 147);
            this.buttonPactice3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice3.Name = "buttonPactice3";
            this.buttonPactice3.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice3.TabIndex = 12;
            this.buttonPactice3.Text = "Практикум 3";
            this.buttonPactice3.UseVisualStyleBackColor = false;
            // 
            // buttonPactice2
            // 
            this.buttonPactice2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice2.ForeColor = System.Drawing.Color.White;
            this.buttonPactice2.Location = new System.Drawing.Point(7, 102);
            this.buttonPactice2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice2.Name = "buttonPactice2";
            this.buttonPactice2.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice2.TabIndex = 11;
            this.buttonPactice2.Text = "Практикум 2";
            this.buttonPactice2.UseVisualStyleBackColor = false;
            // 
            // buttonPactice1
            // 
            this.buttonPactice1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPactice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPactice1.ForeColor = System.Drawing.Color.White;
            this.buttonPactice1.Location = new System.Drawing.Point(7, 57);
            this.buttonPactice1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPactice1.Name = "buttonPactice1";
            this.buttonPactice1.Size = new System.Drawing.Size(221, 37);
            this.buttonPactice1.TabIndex = 10;
            this.buttonPactice1.Text = "Практикум 1";
            this.buttonPactice1.UseVisualStyleBackColor = false;
            this.buttonPactice1.Click += new System.EventHandler(this.buttonPactice1_Click);
            // 
            // groupBoxLinks
            // 
            this.groupBoxLinks.Controls.Add(this.button6);
            this.groupBoxLinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLinks.Location = new System.Drawing.Point(749, 53);
            this.groupBoxLinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLinks.Name = "groupBoxLinks";
            this.groupBoxLinks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLinks.Size = new System.Drawing.Size(233, 421);
            this.groupBoxLinks.TabIndex = 4;
            this.groupBoxLinks.TabStop = false;
            this.groupBoxLinks.Text = "Ссылки";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(6, 57);
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
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Справка:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 554);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxLinks);
            this.Controls.Add(this.groupBoxPractice);
            this.Controls.Add(this.groupBoxTheoty);
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
            this.groupBoxTheoty.ResumeLayout(false);
            this.groupBoxPractice.ResumeLayout(false);
            this.groupBoxLinks.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxTheoty;
        private System.Windows.Forms.GroupBox groupBoxPractice;
        private System.Windows.Forms.GroupBox groupBoxLinks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonProfileSettings;
        private System.Windows.Forms.Button buttonTheory1;
        private System.Windows.Forms.Button buttonPactice1;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonTheory8;
        private System.Windows.Forms.Button buttonTheory7;
        private System.Windows.Forms.Button buttonTheory6;
        private System.Windows.Forms.Button buttonTheory5;
        private System.Windows.Forms.Button buttonTheory4;
        private System.Windows.Forms.Button buttonTheory3;
        private System.Windows.Forms.Button buttonTheory2;
        private System.Windows.Forms.Button buttonPactice8;
        private System.Windows.Forms.Button buttonPactice7;
        private System.Windows.Forms.Button buttonPactice6;
        private System.Windows.Forms.Button buttonPactice5;
        private System.Windows.Forms.Button buttonPactice4;
        private System.Windows.Forms.Button buttonPactice3;
        private System.Windows.Forms.Button buttonPactice2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

