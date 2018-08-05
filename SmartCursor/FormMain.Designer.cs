namespace SmartCursor
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonRunProcess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMousePositionY = new System.Windows.Forms.Label();
            this.labelMousePositionX = new System.Windows.Forms.Label();
            this.textBoxMousePositionY = new System.Windows.Forms.TextBox();
            this.textBoxMousePositionX = new System.Windows.Forms.TextBox();
            this.timerMouseMove = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьСценарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСценарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxExeFilePath = new System.Windows.Forms.TextBox();
            this.textBoxScriptFilePath = new System.Windows.Forms.TextBox();
            this.labelExeFilePath = new System.Windows.Forms.Label();
            this.labelScriptFilePath = new System.Windows.Forms.Label();
            this.buttonOpenExeFilePath = new System.Windows.Forms.Button();
            this.buttonOpenScriptFilePath = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonClearScriptFilePath = new System.Windows.Forms.Button();
            this.buttonClearExeFilePath = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.checkBoxNow = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.comboBoxSeconds = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.groupBoxProcesses = new System.Windows.Forms.GroupBox();
            this.textBoxProcessesCount = new System.Windows.Forms.TextBox();
            this.labelProcessesCount = new System.Windows.Forms.Label();
            this.comboBoxProcesses = new System.Windows.Forms.ComboBox();
            this.labelProcesses = new System.Windows.Forms.Label();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.checkBoxClose = new System.Windows.Forms.CheckBox();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(22, 425);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(95, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Запуск";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonRunProcess
            // 
            this.buttonRunProcess.Location = new System.Drawing.Point(123, 425);
            this.buttonRunProcess.Name = "buttonRunProcess";
            this.buttonRunProcess.Size = new System.Drawing.Size(166, 23);
            this.buttonRunProcess.TabIndex = 1;
            this.buttonRunProcess.Text = "Запуск выбранного процесса";
            this.buttonRunProcess.UseVisualStyleBackColor = true;
            this.buttonRunProcess.Click += new System.EventHandler(this.buttonRunProcess_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(358, 425);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(76, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMousePositionY
            // 
            this.labelMousePositionY.AutoSize = true;
            this.labelMousePositionY.Location = new System.Drawing.Point(13, 48);
            this.labelMousePositionY.Name = "labelMousePositionY";
            this.labelMousePositionY.Size = new System.Drawing.Size(133, 13);
            this.labelMousePositionY.TabIndex = 3;
            this.labelMousePositionY.Text = "Позиция мыши по оси Y:";
            // 
            // labelMousePositionX
            // 
            this.labelMousePositionX.AutoSize = true;
            this.labelMousePositionX.Location = new System.Drawing.Point(13, 22);
            this.labelMousePositionX.Name = "labelMousePositionX";
            this.labelMousePositionX.Size = new System.Drawing.Size(133, 13);
            this.labelMousePositionX.TabIndex = 2;
            this.labelMousePositionX.Text = "Позиция мыши по оси X:";
            // 
            // textBoxMousePositionY
            // 
            this.textBoxMousePositionY.Location = new System.Drawing.Point(152, 45);
            this.textBoxMousePositionY.Name = "textBoxMousePositionY";
            this.textBoxMousePositionY.ReadOnly = true;
            this.textBoxMousePositionY.Size = new System.Drawing.Size(84, 20);
            this.textBoxMousePositionY.TabIndex = 1;
            // 
            // textBoxMousePositionX
            // 
            this.textBoxMousePositionX.Location = new System.Drawing.Point(152, 19);
            this.textBoxMousePositionX.Name = "textBoxMousePositionX";
            this.textBoxMousePositionX.ReadOnly = true;
            this.textBoxMousePositionX.Size = new System.Drawing.Size(84, 20);
            this.textBoxMousePositionX.TabIndex = 0;
            // 
            // timerMouseMove
            // 
            this.timerMouseMove.Enabled = true;
            this.timerMouseMove.Interval = 1;
            this.timerMouseMove.Tick += new System.EventHandler(this.timerMouseMove_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(295, 425);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(55, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьСценарийToolStripMenuItem,
            this.загрузитьСценарийToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // создатьСценарийToolStripMenuItem
            // 
            this.создатьСценарийToolStripMenuItem.Name = "создатьСценарийToolStripMenuItem";
            this.создатьСценарийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.создатьСценарийToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.создатьСценарийToolStripMenuItem.Text = "Редактор сценариев";
            this.создатьСценарийToolStripMenuItem.Click += new System.EventHandler(this.создатьСценарийToolStripMenuItem_Click);
            // 
            // загрузитьСценарийToolStripMenuItem
            // 
            this.загрузитьСценарийToolStripMenuItem.Name = "загрузитьСценарийToolStripMenuItem";
            this.загрузитьСценарийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.загрузитьСценарийToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.загрузитьСценарийToolStripMenuItem.Text = "Загрузить сценарий";
            this.загрузитьСценарийToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСценарийToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.языкToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.настройкаToolStripMenuItem.Text = "Опции";
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.языкToolStripMenuItem.Text = "Языки";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.русскийToolStripMenuItem.ShowShortcutKeys = false;
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.русскийToolStripMenuItem.Text = "рус-eng (eng-рус)";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // textBoxExeFilePath
            // 
            this.textBoxExeFilePath.Location = new System.Drawing.Point(16, 84);
            this.textBoxExeFilePath.Name = "textBoxExeFilePath";
            this.textBoxExeFilePath.ReadOnly = true;
            this.textBoxExeFilePath.Size = new System.Drawing.Size(332, 20);
            this.textBoxExeFilePath.TabIndex = 4;
            // 
            // textBoxScriptFilePath
            // 
            this.textBoxScriptFilePath.Location = new System.Drawing.Point(16, 123);
            this.textBoxScriptFilePath.Name = "textBoxScriptFilePath";
            this.textBoxScriptFilePath.ReadOnly = true;
            this.textBoxScriptFilePath.Size = new System.Drawing.Size(332, 20);
            this.textBoxScriptFilePath.TabIndex = 5;
            // 
            // labelExeFilePath
            // 
            this.labelExeFilePath.AutoSize = true;
            this.labelExeFilePath.Location = new System.Drawing.Point(13, 68);
            this.labelExeFilePath.Name = "labelExeFilePath";
            this.labelExeFilePath.Size = new System.Drawing.Size(155, 13);
            this.labelExeFilePath.TabIndex = 6;
            this.labelExeFilePath.Text = "Путь к исполняемому файлу:";
            // 
            // labelScriptFilePath
            // 
            this.labelScriptFilePath.AutoSize = true;
            this.labelScriptFilePath.Location = new System.Drawing.Point(13, 107);
            this.labelScriptFilePath.Name = "labelScriptFilePath";
            this.labelScriptFilePath.Size = new System.Drawing.Size(128, 13);
            this.labelScriptFilePath.TabIndex = 7;
            this.labelScriptFilePath.Text = "Путь к файлу сценария:";
            // 
            // buttonOpenExeFilePath
            // 
            this.buttonOpenExeFilePath.AccessibleDescription = "";
            this.buttonOpenExeFilePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenExeFilePath.BackgroundImage")));
            this.buttonOpenExeFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenExeFilePath.Location = new System.Drawing.Point(354, 84);
            this.buttonOpenExeFilePath.Name = "buttonOpenExeFilePath";
            this.buttonOpenExeFilePath.Size = new System.Drawing.Size(22, 20);
            this.buttonOpenExeFilePath.TabIndex = 8;
            this.buttonOpenExeFilePath.UseVisualStyleBackColor = true;
            this.buttonOpenExeFilePath.Click += new System.EventHandler(this.buttonOpenExeFilePath_Click);
            // 
            // buttonOpenScriptFilePath
            // 
            this.buttonOpenScriptFilePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenScriptFilePath.BackgroundImage")));
            this.buttonOpenScriptFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenScriptFilePath.Location = new System.Drawing.Point(354, 123);
            this.buttonOpenScriptFilePath.Name = "buttonOpenScriptFilePath";
            this.buttonOpenScriptFilePath.Size = new System.Drawing.Size(22, 20);
            this.buttonOpenScriptFilePath.TabIndex = 9;
            this.buttonOpenScriptFilePath.UseVisualStyleBackColor = true;
            this.buttonOpenScriptFilePath.Click += new System.EventHandler(this.buttonOpenScriptFilePath_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.buttonClearScriptFilePath);
            this.groupBoxInfo.Controls.Add(this.buttonClearExeFilePath);
            this.groupBoxInfo.Controls.Add(this.groupBoxTime);
            this.groupBoxInfo.Controls.Add(this.buttonOpenScriptFilePath);
            this.groupBoxInfo.Controls.Add(this.textBoxMousePositionX);
            this.groupBoxInfo.Controls.Add(this.buttonOpenExeFilePath);
            this.groupBoxInfo.Controls.Add(this.textBoxMousePositionY);
            this.groupBoxInfo.Controls.Add(this.labelScriptFilePath);
            this.groupBoxInfo.Controls.Add(this.labelMousePositionX);
            this.groupBoxInfo.Controls.Add(this.labelExeFilePath);
            this.groupBoxInfo.Controls.Add(this.labelMousePositionY);
            this.groupBoxInfo.Controls.Add(this.textBoxScriptFilePath);
            this.groupBoxInfo.Controls.Add(this.textBoxExeFilePath);
            this.groupBoxInfo.Location = new System.Drawing.Point(24, 41);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(410, 255);
            this.groupBoxInfo.TabIndex = 7;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // buttonClearScriptFilePath
            // 
            this.buttonClearScriptFilePath.Location = new System.Drawing.Point(382, 123);
            this.buttonClearScriptFilePath.Name = "buttonClearScriptFilePath";
            this.buttonClearScriptFilePath.Size = new System.Drawing.Size(22, 20);
            this.buttonClearScriptFilePath.TabIndex = 15;
            this.buttonClearScriptFilePath.UseVisualStyleBackColor = true;
            this.buttonClearScriptFilePath.Click += new System.EventHandler(this.buttonClearScriptFilePath_Click);
            // 
            // buttonClearExeFilePath
            // 
            this.buttonClearExeFilePath.Location = new System.Drawing.Point(382, 84);
            this.buttonClearExeFilePath.Name = "buttonClearExeFilePath";
            this.buttonClearExeFilePath.Size = new System.Drawing.Size(22, 20);
            this.buttonClearExeFilePath.TabIndex = 14;
            this.buttonClearExeFilePath.UseVisualStyleBackColor = true;
            this.buttonClearExeFilePath.Click += new System.EventHandler(this.buttonClearExeFilePath_Click);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.checkBoxNow);
            this.groupBoxTime.Controls.Add(this.labelTime);
            this.groupBoxTime.Controls.Add(this.labelData);
            this.groupBoxTime.Controls.Add(this.comboBoxSeconds);
            this.groupBoxTime.Controls.Add(this.comboBoxMinutes);
            this.groupBoxTime.Controls.Add(this.comboBoxHours);
            this.groupBoxTime.Controls.Add(this.comboBoxYear);
            this.groupBoxTime.Controls.Add(this.comboBoxDay);
            this.groupBoxTime.Controls.Add(this.comboBoxMonth);
            this.groupBoxTime.Location = new System.Drawing.Point(16, 149);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(388, 101);
            this.groupBoxTime.TabIndex = 13;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Время и дата запуска";
            // 
            // checkBoxNow
            // 
            this.checkBoxNow.AutoSize = true;
            this.checkBoxNow.Location = new System.Drawing.Point(127, 78);
            this.checkBoxNow.Name = "checkBoxNow";
            this.checkBoxNow.Size = new System.Drawing.Size(116, 17);
            this.checkBoxNow.TabIndex = 18;
            this.checkBoxNow.Text = "Запустить сейчас";
            this.checkBoxNow.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(26, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(87, 13);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = "Время запуска:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(26, 22);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(80, 13);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Дата запуска:";
            // 
            // comboBoxSeconds
            // 
            this.comboBoxSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeconds.FormattingEnabled = true;
            this.comboBoxSeconds.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxSeconds.Location = new System.Drawing.Point(286, 46);
            this.comboBoxSeconds.Name = "comboBoxSeconds";
            this.comboBoxSeconds.Size = new System.Drawing.Size(54, 21);
            this.comboBoxSeconds.TabIndex = 15;
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinutes.Location = new System.Drawing.Point(226, 46);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(54, 21);
            this.comboBoxMinutes.TabIndex = 14;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHours.Location = new System.Drawing.Point(166, 46);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(54, 21);
            this.comboBoxHours.TabIndex = 13;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxYear.Location = new System.Drawing.Point(286, 19);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(54, 21);
            this.comboBoxYear.TabIndex = 12;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(166, 19);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(54, 21);
            this.comboBoxDay.TabIndex = 10;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(226, 19);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(54, 21);
            this.comboBoxMonth.TabIndex = 11;
            // 
            // timerRun
            // 
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // groupBoxProcesses
            // 
            this.groupBoxProcesses.Controls.Add(this.textBoxProcessesCount);
            this.groupBoxProcesses.Controls.Add(this.labelProcessesCount);
            this.groupBoxProcesses.Controls.Add(this.comboBoxProcesses);
            this.groupBoxProcesses.Controls.Add(this.labelProcesses);
            this.groupBoxProcesses.Location = new System.Drawing.Point(24, 302);
            this.groupBoxProcesses.Name = "groupBoxProcesses";
            this.groupBoxProcesses.Size = new System.Drawing.Size(409, 70);
            this.groupBoxProcesses.TabIndex = 8;
            this.groupBoxProcesses.TabStop = false;
            this.groupBoxProcesses.Text = "Активные процессы, связанные с исполняемым файлом";
            // 
            // textBoxProcessesCount
            // 
            this.textBoxProcessesCount.Location = new System.Drawing.Point(323, 43);
            this.textBoxProcessesCount.Name = "textBoxProcessesCount";
            this.textBoxProcessesCount.ReadOnly = true;
            this.textBoxProcessesCount.Size = new System.Drawing.Size(53, 20);
            this.textBoxProcessesCount.TabIndex = 3;
            // 
            // labelProcessesCount
            // 
            this.labelProcessesCount.AutoSize = true;
            this.labelProcessesCount.Location = new System.Drawing.Point(13, 46);
            this.labelProcessesCount.Name = "labelProcessesCount";
            this.labelProcessesCount.Size = new System.Drawing.Size(286, 13);
            this.labelProcessesCount.TabIndex = 2;
            this.labelProcessesCount.Text = "Кол-во связанных с исполняемым файлом процессов:";
            // 
            // comboBoxProcesses
            // 
            this.comboBoxProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcesses.FormattingEnabled = true;
            this.comboBoxProcesses.Location = new System.Drawing.Point(116, 19);
            this.comboBoxProcesses.Name = "comboBoxProcesses";
            this.comboBoxProcesses.Size = new System.Drawing.Size(288, 21);
            this.comboBoxProcesses.TabIndex = 1;
            this.comboBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcesses_SelectedIndexChanged);
            // 
            // labelProcesses
            // 
            this.labelProcesses.AutoSize = true;
            this.labelProcesses.Location = new System.Drawing.Point(13, 22);
            this.labelProcesses.Name = "labelProcesses";
            this.labelProcesses.Size = new System.Drawing.Size(99, 13);
            this.labelProcesses.TabIndex = 0;
            this.labelProcesses.Text = "Выбрать процесс:";
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(40, 390);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(150, 17);
            this.checkBoxHide.TabIndex = 9;
            this.checkBoxHide.Text = "Скрыть при выполнении";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            // 
            // checkBoxClose
            // 
            this.checkBoxClose.AutoSize = true;
            this.checkBoxClose.Location = new System.Drawing.Point(243, 390);
            this.checkBoxClose.Name = "checkBoxClose";
            this.checkBoxClose.Size = new System.Drawing.Size(168, 17);
            this.checkBoxClose.TabIndex = 10;
            this.checkBoxClose.Text = "Закрыть после выполнения";
            this.checkBoxClose.UseVisualStyleBackColor = true;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 460);
            this.Controls.Add(this.checkBoxClose);
            this.Controls.Add(this.checkBoxHide);
            this.Controls.Add(this.groupBoxProcesses);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRunProcess);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEmulator v1.02";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxProcesses.ResumeLayout(false);
            this.groupBoxProcesses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonRunProcess;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMousePositionY;
        private System.Windows.Forms.Label labelMousePositionX;
        private System.Windows.Forms.TextBox textBoxMousePositionY;
        private System.Windows.Forms.TextBox textBoxMousePositionX;
        private System.Windows.Forms.Timer timerMouseMove;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьСценарийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСценарийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenScriptFilePath;
        private System.Windows.Forms.Button buttonOpenExeFilePath;
        private System.Windows.Forms.Label labelScriptFilePath;
        private System.Windows.Forms.Label labelExeFilePath;
        private System.Windows.Forms.TextBox textBoxScriptFilePath;
        private System.Windows.Forms.TextBox textBoxExeFilePath;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.CheckBox checkBoxNow;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboBoxSeconds;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.GroupBox groupBoxProcesses;
        private System.Windows.Forms.ComboBox comboBoxProcesses;
        private System.Windows.Forms.Label labelProcesses;
        private System.Windows.Forms.TextBox textBoxProcessesCount;
        private System.Windows.Forms.Label labelProcessesCount;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.CheckBox checkBoxClose;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearExeFilePath;
        private System.Windows.Forms.Button buttonClearScriptFilePath;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

