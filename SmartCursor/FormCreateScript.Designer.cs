namespace SmartCursor
{
    partial class FormCreateScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateScript));
            this.buttonChoseFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.применитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFileInfo = new System.Windows.Forms.GroupBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelLastWriteTime = new System.Windows.Forms.Label();
            this.labelLastAccessTime = new System.Windows.Forms.Label();
            this.labelExtension = new System.Windows.Forms.Label();
            this.labelCreationTime = new System.Windows.Forms.Label();
            this.groupBoxScript = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxSelectionMode = new System.Windows.Forms.CheckBox();
            this.groupBoxAddToScript = new System.Windows.Forms.GroupBox();
            this.groupBoxModifiers = new System.Windows.Forms.GroupBox();
            this.radioButtonSHIFT = new System.Windows.Forms.RadioButton();
            this.radioButtonCTRL = new System.Windows.Forms.RadioButton();
            this.radioButtonALT = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.textBoxWaitMilliseconds = new System.Windows.Forms.TextBox();
            this.textBoxMousePosY = new System.Windows.Forms.TextBox();
            this.textBoxMousePosX = new System.Windows.Forms.TextBox();
            this.labelWaitMilliseconds = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelMousePosY = new System.Windows.Forms.Label();
            this.labelMousePosX = new System.Windows.Forms.Label();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.buttonEditInScript = new System.Windows.Forms.Button();
            this.buttonDeleteFromScript = new System.Windows.Forms.Button();
            this.buttonAddToScript = new System.Windows.Forms.Button();
            this.labelScriptPath = new System.Windows.Forms.Label();
            this.textBoxScriptPath = new System.Windows.Forms.TextBox();
            this.buttonChoseScriptFile = new System.Windows.Forms.Button();
            this.groupBoxSpecial = new System.Windows.Forms.GroupBox();
            this.labelDoCycle = new System.Windows.Forms.Label();
            this.textBoxDoCycle = new System.Windows.Forms.TextBox();
            this.buttonDoCycle = new System.Windows.Forms.Button();
            this.checkBoxTakeAll = new System.Windows.Forms.CheckBox();
            this.labelDoN = new System.Windows.Forms.Label();
            this.textBoxDoN = new System.Windows.Forms.TextBox();
            this.buttonDoN = new System.Windows.Forms.Button();
            this.buttonInputString = new System.Windows.Forms.Button();
            this.labelInputString = new System.Windows.Forms.Label();
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.groupBoxMousePosition = new System.Windows.Forms.GroupBox();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.textBoxMousePosition = new System.Windows.Forms.TextBox();
            this.buttonClearChoseFile = new System.Windows.Forms.Button();
            this.buttonClearChoseScriptFile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFileInfo.SuspendLayout();
            this.groupBoxScript.SuspendLayout();
            this.groupBoxAddToScript.SuspendLayout();
            this.groupBoxModifiers.SuspendLayout();
            this.groupBoxSpecial.SuspendLayout();
            this.groupBoxMousePosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoseFile
            // 
            this.buttonChoseFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChoseFile.BackgroundImage")));
            this.buttonChoseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonChoseFile.Location = new System.Drawing.Point(653, 47);
            this.buttonChoseFile.Name = "buttonChoseFile";
            this.buttonChoseFile.Size = new System.Drawing.Size(24, 20);
            this.buttonChoseFile.TabIndex = 0;
            this.buttonChoseFile.UseVisualStyleBackColor = true;
            this.buttonChoseFile.Click += new System.EventHandler(this.buttonChoseFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 48);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(632, 20);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(9, 32);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(155, 13);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Путь к исполняемому файлу:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.применитьToolStripMenuItem,
            this.отменаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem2,
            this.сохранитьToolStripMenuItem1});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.сохранитьToolStripMenuItem.Text = "Сценарий";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem2
            // 
            this.сохранитьToolStripMenuItem2.Name = "сохранитьToolStripMenuItem2";
            this.сохранитьToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem2.Size = new System.Drawing.Size(234, 22);
            this.сохранитьToolStripMenuItem2.Text = "Сохранить";
            this.сохранитьToolStripMenuItem2.Click += new System.EventHandler(this.сохранитьToolStripMenuItem2_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить как...";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // применитьToolStripMenuItem
            // 
            this.применитьToolStripMenuItem.Name = "применитьToolStripMenuItem";
            this.применитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.применитьToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.применитьToolStripMenuItem.Text = "Применить";
            this.применитьToolStripMenuItem.Click += new System.EventHandler(this.применитьToolStripMenuItem_Click);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.отменаToolStripMenuItem.Text = "Закрыть редактор";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // groupBoxFileInfo
            // 
            this.groupBoxFileInfo.Controls.Add(this.labelLength);
            this.groupBoxFileInfo.Controls.Add(this.labelLastWriteTime);
            this.groupBoxFileInfo.Controls.Add(this.labelLastAccessTime);
            this.groupBoxFileInfo.Controls.Add(this.labelExtension);
            this.groupBoxFileInfo.Controls.Add(this.labelCreationTime);
            this.groupBoxFileInfo.Location = new System.Drawing.Point(12, 113);
            this.groupBoxFileInfo.Name = "groupBoxFileInfo";
            this.groupBoxFileInfo.Size = new System.Drawing.Size(255, 183);
            this.groupBoxFileInfo.TabIndex = 6;
            this.groupBoxFileInfo.TabStop = false;
            this.groupBoxFileInfo.Text = "Информация об исполняемом файле";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(6, 152);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(95, 13);
            this.labelLength.TabIndex = 4;
            this.labelLength.Text = "Размер в байтах:";
            // 
            // labelLastWriteTime
            // 
            this.labelLastWriteTime.AutoSize = true;
            this.labelLastWriteTime.Location = new System.Drawing.Point(6, 120);
            this.labelLastWriteTime.Name = "labelLastWriteTime";
            this.labelLastWriteTime.Size = new System.Drawing.Size(105, 13);
            this.labelLastWriteTime.TabIndex = 3;
            this.labelLastWriteTime.Text = "Последняя запись:";
            // 
            // labelLastAccessTime
            // 
            this.labelLastAccessTime.AutoSize = true;
            this.labelLastAccessTime.Location = new System.Drawing.Point(6, 90);
            this.labelLastAccessTime.Name = "labelLastAccessTime";
            this.labelLastAccessTime.Size = new System.Drawing.Size(126, 13);
            this.labelLastAccessTime.TabIndex = 2;
            this.labelLastAccessTime.Text = "Последнее обращение:";
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(6, 29);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(73, 13);
            this.labelExtension.TabIndex = 1;
            this.labelExtension.Text = "Расширение:";
            // 
            // labelCreationTime
            // 
            this.labelCreationTime.AutoSize = true;
            this.labelCreationTime.Location = new System.Drawing.Point(6, 59);
            this.labelCreationTime.Name = "labelCreationTime";
            this.labelCreationTime.Size = new System.Drawing.Size(94, 13);
            this.labelCreationTime.TabIndex = 0;
            this.labelCreationTime.Text = "Время создания:";
            // 
            // groupBoxScript
            // 
            this.groupBoxScript.Controls.Add(this.buttonSearch);
            this.groupBoxScript.Controls.Add(this.checkBoxSelectionMode);
            this.groupBoxScript.Controls.Add(this.groupBoxAddToScript);
            this.groupBoxScript.Controls.Add(this.listBoxScript);
            this.groupBoxScript.Controls.Add(this.buttonEditInScript);
            this.groupBoxScript.Controls.Add(this.buttonDeleteFromScript);
            this.groupBoxScript.Controls.Add(this.buttonAddToScript);
            this.groupBoxScript.Location = new System.Drawing.Point(273, 113);
            this.groupBoxScript.Name = "groupBoxScript";
            this.groupBoxScript.Size = new System.Drawing.Size(446, 390);
            this.groupBoxScript.TabIndex = 7;
            this.groupBoxScript.TabStop = false;
            this.groupBoxScript.Text = "Редактирование сценария";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.Location = new System.Drawing.Point(20, 313);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(24, 24);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxSelectionMode
            // 
            this.checkBoxSelectionMode.AutoSize = true;
            this.checkBoxSelectionMode.Location = new System.Drawing.Point(54, 231);
            this.checkBoxSelectionMode.Name = "checkBoxSelectionMode";
            this.checkBoxSelectionMode.Size = new System.Drawing.Size(168, 17);
            this.checkBoxSelectionMode.TabIndex = 5;
            this.checkBoxSelectionMode.Text = "Выбрать несколько команд";
            this.checkBoxSelectionMode.UseVisualStyleBackColor = true;
            this.checkBoxSelectionMode.CheckedChanged += new System.EventHandler(this.checkBoxSelectionMode_CheckedChanged);
            // 
            // groupBoxAddToScript
            // 
            this.groupBoxAddToScript.Controls.Add(this.groupBoxModifiers);
            this.groupBoxAddToScript.Controls.Add(this.comboBoxKey);
            this.groupBoxAddToScript.Controls.Add(this.comboBoxEvent);
            this.groupBoxAddToScript.Controls.Add(this.textBoxWaitMilliseconds);
            this.groupBoxAddToScript.Controls.Add(this.textBoxMousePosY);
            this.groupBoxAddToScript.Controls.Add(this.textBoxMousePosX);
            this.groupBoxAddToScript.Controls.Add(this.labelWaitMilliseconds);
            this.groupBoxAddToScript.Controls.Add(this.labelEvent);
            this.groupBoxAddToScript.Controls.Add(this.labelMousePosY);
            this.groupBoxAddToScript.Controls.Add(this.labelMousePosX);
            this.groupBoxAddToScript.Location = new System.Drawing.Point(20, 30);
            this.groupBoxAddToScript.Name = "groupBoxAddToScript";
            this.groupBoxAddToScript.Size = new System.Drawing.Size(415, 198);
            this.groupBoxAddToScript.TabIndex = 4;
            this.groupBoxAddToScript.TabStop = false;
            this.groupBoxAddToScript.Text = "Добавление команды в скрипт";
            // 
            // groupBoxModifiers
            // 
            this.groupBoxModifiers.Controls.Add(this.radioButtonSHIFT);
            this.groupBoxModifiers.Controls.Add(this.radioButtonCTRL);
            this.groupBoxModifiers.Controls.Add(this.radioButtonALT);
            this.groupBoxModifiers.Controls.Add(this.radioButtonNo);
            this.groupBoxModifiers.Location = new System.Drawing.Point(9, 111);
            this.groupBoxModifiers.Name = "groupBoxModifiers";
            this.groupBoxModifiers.Size = new System.Drawing.Size(405, 42);
            this.groupBoxModifiers.TabIndex = 9;
            this.groupBoxModifiers.TabStop = false;
            this.groupBoxModifiers.Text = "Модификаторы";
            // 
            // radioButtonSHIFT
            // 
            this.radioButtonSHIFT.AutoSize = true;
            this.radioButtonSHIFT.Location = new System.Drawing.Point(314, 19);
            this.radioButtonSHIFT.Name = "radioButtonSHIFT";
            this.radioButtonSHIFT.Size = new System.Drawing.Size(56, 17);
            this.radioButtonSHIFT.TabIndex = 3;
            this.radioButtonSHIFT.TabStop = true;
            this.radioButtonSHIFT.Text = "SHIFT";
            this.radioButtonSHIFT.UseVisualStyleBackColor = true;
            // 
            // radioButtonCTRL
            // 
            this.radioButtonCTRL.AutoSize = true;
            this.radioButtonCTRL.Location = new System.Drawing.Point(213, 19);
            this.radioButtonCTRL.Name = "radioButtonCTRL";
            this.radioButtonCTRL.Size = new System.Drawing.Size(53, 17);
            this.radioButtonCTRL.TabIndex = 2;
            this.radioButtonCTRL.TabStop = true;
            this.radioButtonCTRL.Text = "CTRL";
            this.radioButtonCTRL.UseVisualStyleBackColor = true;
            // 
            // radioButtonALT
            // 
            this.radioButtonALT.AutoSize = true;
            this.radioButtonALT.Location = new System.Drawing.Point(119, 19);
            this.radioButtonALT.Name = "radioButtonALT";
            this.radioButtonALT.Size = new System.Drawing.Size(45, 17);
            this.radioButtonALT.TabIndex = 1;
            this.radioButtonALT.TabStop = true;
            this.radioButtonALT.Text = "ALT";
            this.radioButtonALT.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(25, 19);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNo.TabIndex = 0;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Нет";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKey.Enabled = false;
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Items.AddRange(new object[] {
            "ENTER",
            "ESC",
            "TAB",
            "SHIFT",
            "CTRL",
            "ALT",
            "BACKSPACE",
            "SPACE",
            "CAPSLOCK",
            "DELETE",
            "DOWN",
            "END",
            "HELP",
            "HOME",
            "INSERT",
            "LEFT",
            "NUMLOCK",
            "PGDN",
            "PGUP",
            "PRTSC",
            "RIGHT",
            "SCROLLLOCK",
            "UP",
            "ADD",
            "SUBTRACT",
            "MULTIPLY",
            "DIVIDE",
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
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
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            ".",
            ",",
            "/",
            "<",
            ">",
            "?",
            ";",
            ":",
            "\'",
            "[",
            "{",
            "]",
            "}",
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "-",
            "+",
            "_",
            "=",
            "`",
            "~",
            "№"});
            this.comboBoxKey.Location = new System.Drawing.Point(339, 84);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(70, 21);
            this.comboBoxKey.TabIndex = 8;
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Items.AddRange(new object[] {
            "Ожидание",
            "Левая кнопка мыши (1 раз)",
            "Правая кнопка мыши (1 раз)",
            "Средняя кнопка мыши (1 раз)",
            "Левая кнопка мыши (2 раза)",
            "Правая кнопка мыши (2 раза)",
            "Средняя кнопка мыши (2 раза)",
            "Нажатие клавиши"});
            this.comboBoxEvent.Location = new System.Drawing.Point(146, 84);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(187, 21);
            this.comboBoxEvent.TabIndex = 7;
            this.comboBoxEvent.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvent_SelectedIndexChanged);
            // 
            // textBoxWaitMilliseconds
            // 
            this.textBoxWaitMilliseconds.Location = new System.Drawing.Point(290, 159);
            this.textBoxWaitMilliseconds.Name = "textBoxWaitMilliseconds";
            this.textBoxWaitMilliseconds.Size = new System.Drawing.Size(119, 20);
            this.textBoxWaitMilliseconds.TabIndex = 6;
            this.textBoxWaitMilliseconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWaitMilliseconds_KeyPress);
            // 
            // textBoxMousePosY
            // 
            this.textBoxMousePosY.Location = new System.Drawing.Point(198, 50);
            this.textBoxMousePosY.Name = "textBoxMousePosY";
            this.textBoxMousePosY.Size = new System.Drawing.Size(211, 20);
            this.textBoxMousePosY.TabIndex = 5;
            this.textBoxMousePosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMousePosY_KeyPress);
            // 
            // textBoxMousePosX
            // 
            this.textBoxMousePosX.Location = new System.Drawing.Point(198, 23);
            this.textBoxMousePosX.Name = "textBoxMousePosX";
            this.textBoxMousePosX.Size = new System.Drawing.Size(211, 20);
            this.textBoxMousePosX.TabIndex = 4;
            this.textBoxMousePosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMousePosX_KeyPress);
            // 
            // labelWaitMilliseconds
            // 
            this.labelWaitMilliseconds.AutoSize = true;
            this.labelWaitMilliseconds.Location = new System.Drawing.Point(6, 162);
            this.labelWaitMilliseconds.Name = "labelWaitMilliseconds";
            this.labelWaitMilliseconds.Size = new System.Drawing.Size(275, 13);
            this.labelWaitMilliseconds.TabIndex = 3;
            this.labelWaitMilliseconds.Text = "Время ожидания после действия (в миллисекундах):";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(6, 87);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(131, 13);
            this.labelEvent.TabIndex = 2;
            this.labelEvent.Text = "Совершаемое действие:";
            // 
            // labelMousePosY
            // 
            this.labelMousePosY.AutoSize = true;
            this.labelMousePosY.Location = new System.Drawing.Point(6, 57);
            this.labelMousePosY.Name = "labelMousePosY";
            this.labelMousePosY.Size = new System.Drawing.Size(183, 13);
            this.labelMousePosY.TabIndex = 1;
            this.labelMousePosY.Text = "Позиция мышки по Y (в пикселях):";
            // 
            // labelMousePosX
            // 
            this.labelMousePosX.AutoSize = true;
            this.labelMousePosX.Location = new System.Drawing.Point(6, 26);
            this.labelMousePosX.Name = "labelMousePosX";
            this.labelMousePosX.Size = new System.Drawing.Size(183, 13);
            this.labelMousePosX.TabIndex = 0;
            this.labelMousePosX.Text = "Позиция мышки по X (в пикселях):";
            // 
            // listBoxScript
            // 
            this.listBoxScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxScript.Location = new System.Drawing.Point(54, 254);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.ScrollAlwaysVisible = true;
            this.listBoxScript.Size = new System.Drawing.Size(381, 119);
            this.listBoxScript.TabIndex = 3;
            this.listBoxScript.SelectedIndexChanged += new System.EventHandler(this.listBoxScript_SelectedIndexChanged);
            this.listBoxScript.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxScript_MouseDoubleClick);
            // 
            // buttonEditInScript
            // 
            this.buttonEditInScript.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditInScript.Image")));
            this.buttonEditInScript.Location = new System.Drawing.Point(20, 288);
            this.buttonEditInScript.Name = "buttonEditInScript";
            this.buttonEditInScript.Size = new System.Drawing.Size(24, 24);
            this.buttonEditInScript.TabIndex = 2;
            this.buttonEditInScript.UseVisualStyleBackColor = true;
            this.buttonEditInScript.Click += new System.EventHandler(this.buttonEditInScript_Click);
            // 
            // buttonDeleteFromScript
            // 
            this.buttonDeleteFromScript.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteFromScript.BackgroundImage")));
            this.buttonDeleteFromScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteFromScript.Location = new System.Drawing.Point(20, 338);
            this.buttonDeleteFromScript.Name = "buttonDeleteFromScript";
            this.buttonDeleteFromScript.Size = new System.Drawing.Size(24, 24);
            this.buttonDeleteFromScript.TabIndex = 1;
            this.buttonDeleteFromScript.UseVisualStyleBackColor = true;
            this.buttonDeleteFromScript.Click += new System.EventHandler(this.buttonDeleteFromScript_Click);
            // 
            // buttonAddToScript
            // 
            this.buttonAddToScript.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddToScript.BackgroundImage")));
            this.buttonAddToScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddToScript.Location = new System.Drawing.Point(20, 264);
            this.buttonAddToScript.Name = "buttonAddToScript";
            this.buttonAddToScript.Size = new System.Drawing.Size(24, 24);
            this.buttonAddToScript.TabIndex = 0;
            this.buttonAddToScript.UseVisualStyleBackColor = true;
            this.buttonAddToScript.Click += new System.EventHandler(this.buttonAddToScript_Click);
            // 
            // labelScriptPath
            // 
            this.labelScriptPath.AutoSize = true;
            this.labelScriptPath.Location = new System.Drawing.Point(9, 71);
            this.labelScriptPath.Name = "labelScriptPath";
            this.labelScriptPath.Size = new System.Drawing.Size(128, 13);
            this.labelScriptPath.TabIndex = 8;
            this.labelScriptPath.Text = "Путь к файлу сценария:";
            // 
            // textBoxScriptPath
            // 
            this.textBoxScriptPath.Location = new System.Drawing.Point(12, 87);
            this.textBoxScriptPath.Name = "textBoxScriptPath";
            this.textBoxScriptPath.ReadOnly = true;
            this.textBoxScriptPath.Size = new System.Drawing.Size(632, 20);
            this.textBoxScriptPath.TabIndex = 9;
            // 
            // buttonChoseScriptFile
            // 
            this.buttonChoseScriptFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChoseScriptFile.BackgroundImage")));
            this.buttonChoseScriptFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonChoseScriptFile.Location = new System.Drawing.Point(653, 87);
            this.buttonChoseScriptFile.Name = "buttonChoseScriptFile";
            this.buttonChoseScriptFile.Size = new System.Drawing.Size(24, 20);
            this.buttonChoseScriptFile.TabIndex = 10;
            this.buttonChoseScriptFile.UseVisualStyleBackColor = true;
            this.buttonChoseScriptFile.Click += new System.EventHandler(this.buttonChoseScriptFile_Click);
            // 
            // groupBoxSpecial
            // 
            this.groupBoxSpecial.Controls.Add(this.labelDoCycle);
            this.groupBoxSpecial.Controls.Add(this.textBoxDoCycle);
            this.groupBoxSpecial.Controls.Add(this.buttonDoCycle);
            this.groupBoxSpecial.Controls.Add(this.checkBoxTakeAll);
            this.groupBoxSpecial.Controls.Add(this.labelDoN);
            this.groupBoxSpecial.Controls.Add(this.textBoxDoN);
            this.groupBoxSpecial.Controls.Add(this.buttonDoN);
            this.groupBoxSpecial.Controls.Add(this.buttonInputString);
            this.groupBoxSpecial.Controls.Add(this.labelInputString);
            this.groupBoxSpecial.Controls.Add(this.textBoxInputString);
            this.groupBoxSpecial.Location = new System.Drawing.Point(12, 347);
            this.groupBoxSpecial.Name = "groupBoxSpecial";
            this.groupBoxSpecial.Size = new System.Drawing.Size(255, 156);
            this.groupBoxSpecial.TabIndex = 11;
            this.groupBoxSpecial.TabStop = false;
            this.groupBoxSpecial.Text = "Специальные возможности";
            // 
            // labelDoCycle
            // 
            this.labelDoCycle.AutoSize = true;
            this.labelDoCycle.Location = new System.Drawing.Point(6, 89);
            this.labelDoCycle.Name = "labelDoCycle";
            this.labelDoCycle.Size = new System.Drawing.Size(147, 13);
            this.labelDoCycle.TabIndex = 9;
            this.labelDoCycle.Text = "Цикл n раз из выделенных:";
            // 
            // textBoxDoCycle
            // 
            this.textBoxDoCycle.Location = new System.Drawing.Point(159, 86);
            this.textBoxDoCycle.Name = "textBoxDoCycle";
            this.textBoxDoCycle.Size = new System.Drawing.Size(57, 20);
            this.textBoxDoCycle.TabIndex = 8;
            this.textBoxDoCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoCycle_KeyPress);
            // 
            // buttonDoCycle
            // 
            this.buttonDoCycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoCycle.BackgroundImage")));
            this.buttonDoCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDoCycle.Location = new System.Drawing.Point(222, 82);
            this.buttonDoCycle.Name = "buttonDoCycle";
            this.buttonDoCycle.Size = new System.Drawing.Size(26, 24);
            this.buttonDoCycle.TabIndex = 7;
            this.buttonDoCycle.UseVisualStyleBackColor = true;
            this.buttonDoCycle.Click += new System.EventHandler(this.buttonDoCycle_Click);
            // 
            // checkBoxTakeAll
            // 
            this.checkBoxTakeAll.AutoSize = true;
            this.checkBoxTakeAll.Location = new System.Drawing.Point(9, 125);
            this.checkBoxTakeAll.Name = "checkBoxTakeAll";
            this.checkBoxTakeAll.Size = new System.Drawing.Size(205, 17);
            this.checkBoxTakeAll.TabIndex = 6;
            this.checkBoxTakeAll.Text = "Выбрать все уникальные действия";
            this.checkBoxTakeAll.UseVisualStyleBackColor = true;
            this.checkBoxTakeAll.CheckedChanged += new System.EventHandler(this.checkBoxTakeAll_CheckedChanged);
            // 
            // labelDoN
            // 
            this.labelDoN.AutoSize = true;
            this.labelDoN.Location = new System.Drawing.Point(5, 63);
            this.labelDoN.Name = "labelDoN";
            this.labelDoN.Size = new System.Drawing.Size(124, 13);
            this.labelDoN.TabIndex = 5;
            this.labelDoN.Text = "Сделать n раз в конце:";
            // 
            // textBoxDoN
            // 
            this.textBoxDoN.Location = new System.Drawing.Point(159, 60);
            this.textBoxDoN.Name = "textBoxDoN";
            this.textBoxDoN.Size = new System.Drawing.Size(57, 20);
            this.textBoxDoN.TabIndex = 4;
            this.textBoxDoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoN_KeyPress);
            // 
            // buttonDoN
            // 
            this.buttonDoN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoN.BackgroundImage")));
            this.buttonDoN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDoN.Location = new System.Drawing.Point(222, 56);
            this.buttonDoN.Name = "buttonDoN";
            this.buttonDoN.Size = new System.Drawing.Size(26, 24);
            this.buttonDoN.TabIndex = 3;
            this.buttonDoN.UseVisualStyleBackColor = true;
            this.buttonDoN.Click += new System.EventHandler(this.buttonDoN_Click);
            // 
            // buttonInputString
            // 
            this.buttonInputString.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInputString.BackgroundImage")));
            this.buttonInputString.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInputString.Location = new System.Drawing.Point(222, 30);
            this.buttonInputString.Name = "buttonInputString";
            this.buttonInputString.Size = new System.Drawing.Size(26, 24);
            this.buttonInputString.TabIndex = 2;
            this.buttonInputString.UseVisualStyleBackColor = true;
            this.buttonInputString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonInputString_MouseClick);
            // 
            // labelInputString
            // 
            this.labelInputString.AutoSize = true;
            this.labelInputString.Location = new System.Drawing.Point(5, 36);
            this.labelInputString.Name = "labelInputString";
            this.labelInputString.Size = new System.Drawing.Size(83, 13);
            this.labelInputString.TabIndex = 1;
            this.labelInputString.Text = "Ввести строку:";
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.Location = new System.Drawing.Point(94, 33);
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(122, 20);
            this.textBoxInputString.TabIndex = 0;
            // 
            // groupBoxMousePosition
            // 
            this.groupBoxMousePosition.Controls.Add(this.labelMousePosition);
            this.groupBoxMousePosition.Controls.Add(this.textBoxMousePosition);
            this.groupBoxMousePosition.Location = new System.Drawing.Point(12, 302);
            this.groupBoxMousePosition.Name = "groupBoxMousePosition";
            this.groupBoxMousePosition.Size = new System.Drawing.Size(254, 38);
            this.groupBoxMousePosition.TabIndex = 12;
            this.groupBoxMousePosition.TabStop = false;
            this.groupBoxMousePosition.Text = "Мышь";
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.Location = new System.Drawing.Point(6, 19);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(132, 13);
            this.labelMousePosition.TabIndex = 1;
            this.labelMousePosition.Text = "Координаты клика ЛКМ:";
            // 
            // textBoxMousePosition
            // 
            this.textBoxMousePosition.Location = new System.Drawing.Point(144, 12);
            this.textBoxMousePosition.Name = "textBoxMousePosition";
            this.textBoxMousePosition.ReadOnly = true;
            this.textBoxMousePosition.Size = new System.Drawing.Size(104, 20);
            this.textBoxMousePosition.TabIndex = 0;
            // 
            // buttonClearChoseFile
            // 
            this.buttonClearChoseFile.Location = new System.Drawing.Point(683, 48);
            this.buttonClearChoseFile.Name = "buttonClearChoseFile";
            this.buttonClearChoseFile.Size = new System.Drawing.Size(25, 19);
            this.buttonClearChoseFile.TabIndex = 13;
            this.buttonClearChoseFile.UseVisualStyleBackColor = true;
            this.buttonClearChoseFile.Click += new System.EventHandler(this.buttonClearChoseFile_Click);
            // 
            // buttonClearChoseScriptFile
            // 
            this.buttonClearChoseScriptFile.Location = new System.Drawing.Point(683, 87);
            this.buttonClearChoseScriptFile.Name = "buttonClearChoseScriptFile";
            this.buttonClearChoseScriptFile.Size = new System.Drawing.Size(25, 20);
            this.buttonClearChoseScriptFile.TabIndex = 14;
            this.buttonClearChoseScriptFile.UseVisualStyleBackColor = true;
            this.buttonClearChoseScriptFile.Click += new System.EventHandler(this.buttonClearChoseScriptFile_Click);
            // 
            // FormCreateScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 515);
            this.Controls.Add(this.buttonClearChoseScriptFile);
            this.Controls.Add(this.buttonClearChoseFile);
            this.Controls.Add(this.groupBoxMousePosition);
            this.Controls.Add(this.groupBoxSpecial);
            this.Controls.Add(this.buttonChoseScriptFile);
            this.Controls.Add(this.textBoxScriptPath);
            this.Controls.Add(this.labelScriptPath);
            this.Controls.Add(this.groupBoxScript);
            this.Controls.Add(this.groupBoxFileInfo);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonChoseFile);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormCreateScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание и редактирование сценария";
            this.Load += new System.EventHandler(this.FormCreateScript_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFileInfo.ResumeLayout(false);
            this.groupBoxFileInfo.PerformLayout();
            this.groupBoxScript.ResumeLayout(false);
            this.groupBoxScript.PerformLayout();
            this.groupBoxAddToScript.ResumeLayout(false);
            this.groupBoxAddToScript.PerformLayout();
            this.groupBoxModifiers.ResumeLayout(false);
            this.groupBoxModifiers.PerformLayout();
            this.groupBoxSpecial.ResumeLayout(false);
            this.groupBoxSpecial.PerformLayout();
            this.groupBoxMousePosition.ResumeLayout(false);
            this.groupBoxMousePosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoseFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBoxFileInfo;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelLastWriteTime;
        private System.Windows.Forms.Label labelLastAccessTime;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Label labelCreationTime;
        private System.Windows.Forms.ToolStripMenuItem применитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxScript;
        private System.Windows.Forms.Button buttonEditInScript;
        private System.Windows.Forms.Button buttonDeleteFromScript;
        private System.Windows.Forms.Button buttonAddToScript;
        private System.Windows.Forms.ListBox listBoxScript;
        private System.Windows.Forms.GroupBox groupBoxAddToScript;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.TextBox textBoxWaitMilliseconds;
        private System.Windows.Forms.TextBox textBoxMousePosY;
        private System.Windows.Forms.TextBox textBoxMousePosX;
        private System.Windows.Forms.Label labelWaitMilliseconds;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelMousePosY;
        private System.Windows.Forms.Label labelMousePosX;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.CheckBox checkBoxSelectionMode;
        private System.Windows.Forms.Label labelScriptPath;
        private System.Windows.Forms.TextBox textBoxScriptPath;
        private System.Windows.Forms.Button buttonChoseScriptFile;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxModifiers;
        private System.Windows.Forms.RadioButton radioButtonSHIFT;
        private System.Windows.Forms.RadioButton radioButtonCTRL;
        private System.Windows.Forms.RadioButton radioButtonALT;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.GroupBox groupBoxSpecial;
        private System.Windows.Forms.Button buttonInputString;
        private System.Windows.Forms.Label labelInputString;
        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.Label labelDoN;
        private System.Windows.Forms.TextBox textBoxDoN;
        private System.Windows.Forms.Button buttonDoN;
        private System.Windows.Forms.CheckBox checkBoxTakeAll;
        private System.Windows.Forms.Label labelDoCycle;
        private System.Windows.Forms.TextBox textBoxDoCycle;
        private System.Windows.Forms.Button buttonDoCycle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxMousePosition;
        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.TextBox textBoxMousePosition;
        private System.Windows.Forms.Button buttonClearChoseFile;
        private System.Windows.Forms.Button buttonClearChoseScriptFile;
    }
}