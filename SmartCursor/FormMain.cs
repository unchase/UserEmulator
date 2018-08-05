using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace SmartCursor
{
    public partial class FormMain : Form
    {
        #region WinAPI подключение для работы с мышью и клавиатурой в другом окне

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, KeyboardEvent Msg, KeyboardEvent wParam, Int32 lParam);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, KeyboardEvent Msg, KeyboardEvent wParam, Int64 lParam);

        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String WindowName);

        [DllImportAttribute("User32.dll")]
        private static extern IntPtr SetForegroundWindow(int hWnd);

        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(MouseEvent dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public enum KeyboardEvent
        {
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            VK_A = 0x41,
            VK_ENTER = 0x0D,
            VK_ESC = 0x1B,
        };

        public enum MouseEvent
        {
            MOUSEEVENTF_LEFTDOWN = 0x02,
            MOUSEEVENTF_LEFTUP = 0x04,
            MOUSEEVENTF_MIDDLEDOWN = 0x00000020,
            MOUSEEVENTF_MIDDLEUP = 0x00000040,
            MOUSEEVENTF_RIGHTDOWN = 0x08,
            MOUSEEVENTF_RIGHTUP = 0x10,
        }
        #endregion

        private FormCreateScript formCreateScript;
        private bool wasRun;
        public string path = "";
        public string scriptPath = "";
        public List<string> scriptList;
        public TextBox tb1, tb2, tbP;
        public ComboBox cbP;
        private Process currentProcess;
        private Process[] currentProcesses;
        private string currentLangFile = "eng-rus.lng";
        public int langNumber = 1;

        public FormMain()
        {
            InitializeComponent();
            textBoxExeFilePath.Text = path;
            textBoxScriptFilePath.Text = scriptPath;
            buttonRunProcess.Enabled = false;
            buttonStop.Enabled = false;
            textBoxProcessesCount.Text = "";
            comboBoxProcesses.Items.Clear();
            scriptList = new List<string>();
            tb1 = textBoxExeFilePath;
            tb2 = textBoxScriptFilePath;
            tbP = textBoxProcessesCount;
            cbP = comboBoxProcesses;
            checkBoxNow.Checked = true;
            comboBoxDay.SelectedItem = comboBoxDay.Items[comboBoxDay.FindString(DateTime.Now.Day.ToString())];
            comboBoxMonth.SelectedItem = comboBoxMonth.Items[comboBoxMonth.FindString(DateTime.Now.Month.ToString())];
            comboBoxYear.SelectedItem = comboBoxYear.Items[comboBoxYear.FindString(DateTime.Now.Year.ToString())];
            comboBoxHours.SelectedItem = comboBoxHours.Items[comboBoxHours.FindString(DateTime.Now.Hour.ToString())];
            comboBoxMinutes.SelectedItem = comboBoxMinutes.Items[comboBoxMinutes.FindString(DateTime.Now.Minute.ToString())];
            comboBoxSeconds.SelectedItem = comboBoxSeconds.Items[comboBoxSeconds.FindString(DateTime.Now.Second.ToString())];
            wasRun = true; // пока так
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            textBoxProcessesCount.Text = "";
            comboBoxProcesses.Items.Clear();
            if (checkBoxNow.Checked)
                run();
            else
            {
                buttonRun.Text = langNumber == 1 ? "Перезапуск" : "Run again";
                timerRun.Start();
            }
        }

        private void buttonRunProcess_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            wasRun = true;
            if (CheckProgram(currentProcess.MainWindowTitle))
                RunScript(scriptList);
            //if (checkBoxNow.Checked)
            //    run();
            //else
            //    timerRun.Start();
        }

        private void run()
        {
            if (timerRun.Enabled)
                timerRun.Stop();
            if (path != "" && textBoxExeFilePath.Text != "")
            {
                if (scriptList.Count != 0 && textBoxScriptFilePath.Text != "")
                {
                    var pr = new Process
                    {
                        StartInfo =
                        {
                            FileName = path,
                            CreateNoWindow = true
                        }
                    };
                    pr.Start();
                    currentProcesses = Process.GetProcessesByName(pr.ProcessName);
                    if (currentProcesses.Length > 1)
                    {
                        textBoxProcessesCount.Text = currentProcesses.Length.ToString();
                        for (var i = 0; i < currentProcesses.Length; i++)
                            comboBoxProcesses.Items.Add(i + " " + currentProcesses[i].ProcessName);
                        comboBoxProcesses.SelectedItem = comboBoxProcesses.Items[0];
                    }
                    else
                        if (currentProcesses.Length == 1)
                            currentProcess = pr;
                    buttonRunProcess.Enabled = true;
                }
                else
                {
                    if (MessageBox.Show("Файл сценария не был загружен.\nЗагрузить его?", "Загрузить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        загрузитьСценарийToolStripMenuItem_Click(new object(), new EventArgs());
                }
            }
            else
            {
                if (scriptList.Count != 0 && textBoxScriptFilePath.Text != "")
                    RunScript(scriptList);
                else
                {
                    buttonStop.Enabled = false;
                    if (MessageBox.Show("Файл сценария не был загружен.\nЗагрузить его?", "Загрузить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        загрузитьСценарийToolStripMenuItem_Click(new object(), new EventArgs());
                }
            }
        }

        private void RunScript(List<string> sList)
        {
            if (checkBoxHide.Checked)
            {
                ShowInTaskbar = false;
                Opacity = 0;
            }
            foreach (var s in sList)
            {
                if (!wasRun) continue;
                var ss = s.Split(' ');
                switch (ss[2])
                {
                    case "WAIT":
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "LMOUSE1":
                        MouseLeftClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "RMOUSE1":
                        MouseRightClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "MMOUSE1":
                        MouseMiddleClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "LMOUSE2":
                        MouseLeftClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        MouseLeftClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "RMOUSE2":
                        MouseRightClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        MouseRightClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "MMOUSE2":
                        MouseMiddleClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        MouseMiddleClick(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                    case "N":
                        // не было выбрано событие, то есть считаем, что его нет
                        Wait(0);
                        break;
                    default:
                        KeyboardPressKey(ss[2]);
                        Wait(Convert.ToInt32(ss[3]));
                        break;
                }
            }
            buttonStop.Enabled = false;
            buttonRunProcess.Enabled = false;
            if (checkBoxHide.Checked && !checkBoxClose.Checked)
                Opacity = 100;
            else
                MessageBox.Show("Скрипт " + scriptPath + " был исполнен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (checkBoxClose.Checked)
                Close();
            else
                if (!ShowInTaskbar)
                    ShowInTaskbar = true;
        }

        #region MouseClicks нажатия клавиш мышки и другие события
        private void MouseLeftClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MouseEvent.MOUSEEVENTF_LEFTDOWN | MouseEvent.MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);  
        }

        private void MouseRightClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MouseEvent.MOUSEEVENTF_RIGHTDOWN | MouseEvent.MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        private void MouseMiddleClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MouseEvent.MOUSEEVENTF_MIDDLEDOWN | MouseEvent.MOUSEEVENTF_MIDDLEUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        private void Wait(int millisec)
        {
            System.Threading.Thread.Sleep(millisec);
        }

        private void KeyboardPressKey(string key)
        {
            switch (key)
            {
                case "SHIFT":
                    SendKeys.Send("+");
                    break;
                case "CTRL":
                    SendKeys.Send("^");
                    break;
                case "ALT":
                    SendKeys.Send("%");
                    break;
                default:
                    SendKeys.Send(key);
                    break;
            }
        }
        #endregion

        private bool CheckProgram(string apps)
        {
            var hWnd = FindWindow(null, apps);
            if (hWnd > 0)
            {
                SetForegroundWindow(hWnd);
                return true;
            }
            else
            {
                MessageBox.Show("Программа с заголовком " + apps + " не запущена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void timerMouseMove_Tick(object sender, EventArgs e)
        {
            if (wasRun)
            {
                textBoxMousePositionX.Text = Cursor.Position.X.ToString();
                textBoxMousePositionY.Text = Cursor.Position.Y.ToString();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            wasRun = false;
            buttonStop.Enabled = false;
            textBoxMousePositionX.Text = "";
            textBoxMousePositionY.Text = "";
            if (timerRun.Enabled)
                timerRun.Stop();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void создатьСценарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCreateScript = new FormCreateScript(this);
            formCreateScript.ShowDialog();
        }

        private void загрузитьСценарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openScriptFileDialog = new OpenFileDialog
            {
                Filter = @"dat files (*.dat)|*.dat",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openScriptFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                var sr = new StreamReader(openScriptFileDialog.FileName);
                using (sr)
                {
                    scriptPath = openScriptFileDialog.FileName;
                    scriptList.Clear();
                    while (!sr.EndOfStream)
                        scriptList.Add(sr.ReadLine());
                    textBoxScriptFilePath.Text = scriptPath;
                    MessageBox.Show("Файл сценария " + scriptPath + " был загружен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: Файл не может быть считан с диска. Оригинальная ошибка: " + ex.Message);
            }
        }

        private void buttonOpenScriptFilePath_Click(object sender, EventArgs e)
        {
            загрузитьСценарийToolStripMenuItem_Click(sender, e);
        }

        private void buttonOpenExeFilePath_Click(object sender, EventArgs e)
        {
            var choseFileDialog = new OpenFileDialog
            {
                Filter = @"exe files (*.exe)|*.exe|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (choseFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (var choseFileStream = choseFileDialog.OpenFile())
                {
                    path = choseFileDialog.FileName;
                    textBoxExeFilePath.Text = choseFileDialog.FileName;
                    textBoxProcessesCount.Text = "";
                    comboBoxProcesses.Items.Clear();
                    MessageBox.Show(" Исполняемый файл " + path + " был загружен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: Файл не может быть считан с диска. Оригинальная ошибка: " + ex.Message);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxExeFilePath.Text = path;
            textBoxScriptFilePath.Text = scriptPath;
        }

        private void timerRun_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DateTime.Now.Day.ToString()) < Convert.ToInt32(comboBoxDay.SelectedItem.ToString()) || Convert.ToInt32(DateTime.Now.Month.ToString()) < Convert.ToInt32(comboBoxMonth.SelectedItem.ToString()) || Convert.ToInt32(DateTime.Now.Year.ToString()) < Convert.ToInt32(comboBoxYear.SelectedItem.ToString()))
                return;
            else
                if (Convert.ToInt32(DateTime.Now.Day.ToString()) > Convert.ToInt32(comboBoxDay.SelectedItem.ToString()) || Convert.ToInt32(DateTime.Now.Month.ToString()) > Convert.ToInt32(comboBoxMonth.SelectedItem.ToString()) || Convert.ToInt32(DateTime.Now.Year.ToString()) > Convert.ToInt32(comboBoxYear.SelectedItem.ToString()))
                {
                    buttonRun.Text = langNumber == 1 ? "Запуск" : "Run";
                    timerRun.Stop();
                    MessageBox.Show("Выбранный год, месяц или день уже прошел. Поменяйте время запуска.", "Информация.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (Convert.ToInt32(comboBoxHours.SelectedItem.ToString()) > DateTime.Now.Hour)
                        return;
                    else
                        if (Convert.ToInt32(comboBoxHours.SelectedItem.ToString()) < DateTime.Now.Hour)
                        {
                            buttonRun.Text = langNumber == 1 ? "Запуск" : "Run";
                            timerRun.Stop();
                            MessageBox.Show("Выбранный час уже прошел. Поменяйте время запуска.", "Информация.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                            if (Convert.ToInt32(comboBoxMinutes.SelectedItem.ToString()) > DateTime.Now.Minute)
                                return;
                            else
                                if (Convert.ToInt32(comboBoxMinutes.SelectedItem.ToString()) < DateTime.Now.Minute)
                                {
                                    buttonRun.Text = langNumber == 1 ? "Запуск" : "Run";
                                    timerRun.Stop();
                                    MessageBox.Show("Выбранная минута уже прошла. Поменяйте время запуска.", "Информация.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                    if (Convert.ToInt32(comboBoxSeconds.SelectedItem.ToString()) > DateTime.Now.Second)
                                        return;
                                    else
                                        if (Convert.ToInt32(comboBoxSeconds.SelectedItem.ToString()) < DateTime.Now.Second)
                                        {
                                            buttonRun.Text = langNumber == 1 ? "Запуск" : "Run";
                                            timerRun.Stop();
                                            MessageBox.Show("Выбранная секунда уже прошла. Поменяйте время запуска.", "Информация.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        else
                                        {
                                            buttonRun.Text = langNumber == 1 ? "Запуск" : "Run";
                                            run();
                                        }
                }
        }

        private void comboBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = comboBoxProcesses.SelectedItem.ToString();
            var ss = s.Split(' ');
            if (int.TryParse(ss[0], out var indexOfProcess))
                currentProcess = currentProcesses[indexOfProcess];
            //MessageBox.Show(indexOfProcess.ToString());
        }

        public void AllFromFileLang()
        {
            foreach (var cont in Controls)
                TranslateTextInControl(cont.GetType().ToString(), cont);
        }

        public void TranslateTextInControl(string typeOfControl, Object obj)
        {
            string translateText;
            switch (typeOfControl)
            {
                case "System.Windows.Forms.GroupBox":
                    translateText = FindTranslateFromLangFile(((GroupBox)obj).Text, currentLangFile);
                    ((GroupBox)obj).Text = translateText;
                    foreach(var gb in ((GroupBox)obj).Controls)
                        TranslateTextInControl(gb.GetType().ToString(), gb);
                    break;
                case "System.Windows.Forms.MenuStrip":
                    foreach (var ms in ((MenuStrip)obj).Items)
                        TranslateTextInControl(ms.GetType().ToString(), ms);
                    break;
                case "System.Windows.Forms.Button":
                    translateText = FindTranslateFromLangFile(((Button)obj).Text, currentLangFile);
                    ((Button)obj).Text = translateText;
                    break;
                case "System.Windows.Forms.CheckBox":
                    translateText = FindTranslateFromLangFile(((CheckBox)obj).Text, currentLangFile);
                    ((CheckBox)obj).Text = translateText;
                    break;
                case "System.Windows.Forms.Label" :
                    translateText = FindTranslateFromLangFile(((Label)obj).Text, currentLangFile);
                    ((Label)obj).Text = translateText;
                    break;
                case "System.Windows.Forms.ToolStripMenuItem":
                    translateText = FindTranslateFromLangFile(((ToolStripMenuItem)obj).Text, currentLangFile);
                    ((ToolStripMenuItem)obj).Text = translateText;
                    foreach (var mi in ((ToolStripMenuItem)obj).DropDownItems)
                        TranslateTextInControl(mi.GetType().ToString(), mi);
                    break;
            }
        }

        public string FindTranslateFromLangFile(string text, string nameOfLangFile)
        {
            try
            {
                var sr = new StreamReader(nameOfLangFile);
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        var currString = sr.ReadLine();
                        var ss = currString.Split('=');
                        if (ss[0] == text)
                            return ss[1];
                        else
                            if (ss[1] == text)
                                return ss[0];
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: Файл " + nameOfLangFile + " не может быть считан с диска. Оригинальная ошибка: " + ex.Message);
            }
            return text;
        }

        public void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (langNumber)
            {
                case 1:
                    langNumber = 2;
                    break;
                case 2:
                    langNumber = 1;
                    break;
            }
            currentLangFile = "eng-rus.lng";
            AllFromFileLang();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все права на данную программу принадлежат 'unchase' (https://github.com/unchase)", "О программе UserEmulator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClearExeFilePath_Click(object sender, EventArgs e)
        {
            path = "";
            textBoxExeFilePath.Text = "";
            textBoxProcessesCount.Text = "";
        }

        private void buttonClearScriptFilePath_Click(object sender, EventArgs e)
        {
            scriptPath = "";
            scriptList.Clear();
            textBoxScriptFilePath.Text = "";
        }

    }
}

// ToDo:
// Version 1.0:
// 1) Сделать работу не с текущим выбранным окном, а с хэндлером.
// +2) Реализовать работу с несколькими процессами + выбор нужного процесса.
// +3) Добавить время запуска исполняемого файла.
// -4) Сделать кейлогер как доп. инструмент (и написать сценарий для его запуска и остановки).
// +5) Добавить выбор языка.
// Version 1.01:
// +6) Исправить: не правильно работает отложенный запуск сценария.
// +7) Сделать так, чтобы можно было очищать поле с выбранным исполняемым файлом. И для файла скрипта то же самое.
// Version 1.1:
// 8) Добавить запуск процесса без сценария.
// 9) Найти изображение для кнопки для очистки выбранных файлов.
// 10) Сделать выполнение сценария (запуск выбранного процесса) в отдельном потоке, чтобы его можно было остановить из основного.
// 11) Разобраться с кнопкой "Стоп". Проверить работоспособность. Возможно, приспособить к пункту 10.
