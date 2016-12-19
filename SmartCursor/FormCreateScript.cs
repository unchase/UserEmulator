using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SmartCursor
{
    public partial class FormCreateScript : Form
    {

        #region Для хука мыши
        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static string result;

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                result = "X = " + hookStruct.pt.x + "  Y = " + hookStruct.pt.y;
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        private FormMain formMain;
        private int lastIndex = -1;
        public int langNumber2 = 1;

        public FormCreateScript(FormMain f)
        {
            InitializeComponent();
            formMain = f;
            if (formMain.scriptPath != "" && formMain.scriptList.Count > 0)
            {
                listBoxScript.Items.Clear();
                foreach (var s in formMain.scriptList)
                    listBoxScript.Items.Add(s.ToString());
            }
            _hookID = SetHook(_proc);
            Timer tmr = new Timer();
            tmr.Interval = 20;
            tmr.Enabled = true;
            tmr.Tick += delegate { textBoxMousePosition.Text = FormCreateScript.result; };
            switch(f.langNumber)
            {
                case 1:
                    if (langNumber2 != 1)
                    {
                        langNumber2 = 1;
                        AllFromFileLang();
                    }
                    break;
                case 2:
                    if (langNumber2 != 2)
                    {
                        langNumber2 = 2;
                        AllFromFileLang();
                    }
                    break;
            }

        }

        public void AllFromFileLang()
        {
            foreach (var cont in this.Controls)
                formMain.TranslateTextInControl(cont.GetType().ToString(), cont);
        }

        private void buttonChoseFile_Click(object sender, EventArgs e)
        {
            Stream choseFileStream = null;
            OpenFileDialog choseFileDialog = new OpenFileDialog();
            choseFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            choseFileDialog.FilterIndex = 1;
            choseFileDialog.RestoreDirectory = true;
            if (choseFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((choseFileStream = choseFileDialog.OpenFile()) != null)
                    {
                        using (choseFileStream)
                        {
                            textBoxFilePath.Text = choseFileDialog.FileName;
                            FileInfo fi = new FileInfo(choseFileDialog.FileName);
                            if (langNumber2 == 1)
                            {
                                labelCreationTime.Text = "Время создания: " + fi.CreationTime.ToString();
                                labelExtension.Text = "Расширение: " + fi.Extension;
                                labelLastAccessTime.Text = "Последнее обращение: " + fi.LastAccessTime.ToString();
                                labelLastWriteTime.Text = "Последняя запись: " + fi.LastWriteTime.ToString();
                                labelLength.Text = "Размер в байтах: " + fi.Length.ToString();
                            }
                            else
                            {
                                labelCreationTime.Text = "Creation time: " + fi.CreationTime.ToString();
                                labelExtension.Text = "Extension: " + fi.Extension;
                                labelLastAccessTime.Text = "Last access time: " + fi.LastAccessTime.ToString();
                                labelLastWriteTime.Text = "Last write time: " + fi.LastWriteTime.ToString();
                                labelLength.Text = "Length in bytes: " + fi.Length.ToString();
                            }
                            formMain.tbP.Text = "";
                            formMain.cbP.Items.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Файл не может быть считан с диска. Оригинальная ошибка: " + ex.Message);
                }
            }
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Применить изменения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                применитьToolStripMenuItem_Click(sender, e);
            this.Close();
        }

        private void применитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMain.path = textBoxFilePath.Text;
            formMain.scriptPath = textBoxScriptPath.Text;
            formMain.tb1.Text = textBoxFilePath.Text;
            formMain.tb2.Text = textBoxScriptPath.Text;
            switch (MessageBox.Show("Сохранить изменённый сценарий?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    сохранитьToolStripMenuItem2_Click(sender, e);
                    break;
                case System.Windows.Forms.DialogResult.No:
                    
                    break;
            }
            formMain.scriptList.Clear();
            foreach (var s in listBoxScript.Items)
                formMain.scriptList.Add(s.ToString());
        }

        private void textBoxMousePosX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b\cA-\cZ]");
        }

        private void textBoxMousePosY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b\cA-\cZ]");
        }

        private void textBoxWaitMilliseconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b\cA-\cZ]");
        }

        private void comboBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEvent.SelectedItem.ToString() == "Нажатие клавиши")
                comboBoxKey.Enabled = true;
            else
                comboBoxKey.Enabled = false;
        }

        private void buttonDeleteFromScript_Click(object sender, EventArgs e)
        {
            if (checkBoxSelectionMode.Checked)
            {
                for (int i = 0; i < listBoxScript.Items.Count; i++)
                    if (listBoxScript.Items[i] == listBoxScript.SelectedItem)
                    {
                        listBoxScript.Items.Remove(listBoxScript.SelectedItem);
                        i--;
                    }
            }
            else
                listBoxScript.Items.Remove(listBoxScript.SelectedItem);
            if (checkBoxTakeAll.Checked)
            {
                checkBoxTakeAll.Checked = false;
                checkBoxTakeAll.Checked = true;
            }
        }

        private void buttonAddToScript_Click(object sender, EventArgs e)
        {
            string userEvent = GetEventFromComboBox();
            if (listBoxScript.SelectedItems.Count > 0)
            {
                if (checkBoxSelectionMode.Checked)
                {
                    int i = 0;
                    List<string> ls = new List<string>();
                    ListBox.SelectedObjectCollection sc = new ListBox.SelectedObjectCollection(listBoxScript);
                    while (i < listBoxScript.Items.Count)
                    {
                        if (!sc.Contains(listBoxScript.Items[i]))
                        {
                            ls.Add(listBoxScript.Items[i].ToString());
                            listBoxScript.Items.Remove(listBoxScript.Items[i]);
                        }
                        else
                        {
                            ls.Add(listBoxScript.Items[i].ToString());
                            listBoxScript.Items.Remove(listBoxScript.Items[i]);
                            ls.Add(CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width).ToString() + " " + CheckValueInTextBox(textBoxMousePosY, SystemInformation.PrimaryMonitorSize.Height).ToString() + " " + userEvent + " " + CheckValueInTextBox(textBoxWaitMilliseconds, 1000 * 60 * 60 * 24).ToString());
                        }
                    }
                    listBoxScript.Items.Clear(); // это не обязательно, потому что после while он будет пустой
                    foreach (var s in ls)
                        listBoxScript.Items.Add(s);
                }
                else
                {
                    List<string> tempList = new List<string>();
                    for (int i = 0; i < listBoxScript.Items.Count; i++)
                    {
                        if (listBoxScript.Items[i] == listBoxScript.SelectedItem)
                        {
                            tempList.Add(listBoxScript.Items[i].ToString());
                            tempList.Add(CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width).ToString() + " " + CheckValueInTextBox(textBoxMousePosY, SystemInformation.PrimaryMonitorSize.Height).ToString() + " " + userEvent + " " + CheckValueInTextBox(textBoxWaitMilliseconds, 1000 * 60 * 60 * 24).ToString());
                        }
                        else
                            tempList.Add(listBoxScript.Items[i].ToString());
                    }
                    listBoxScript.Items.Clear();
                    foreach (var s in tempList)
                        listBoxScript.Items.Add(s.ToString());
                    tempList.Clear();
                } 
            }
            else
                listBoxScript.Items.Add(CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width).ToString() + " " + CheckValueInTextBox(textBoxMousePosY, SystemInformation.PrimaryMonitorSize.Height).ToString() + " " + userEvent + " " + CheckValueInTextBox(textBoxWaitMilliseconds, 1000 * 60 * 60 * 24).ToString());
            if (checkBoxTakeAll.Checked)
            {
                checkBoxTakeAll.Checked = false;
                checkBoxTakeAll.Checked = true;
            }
        }

        private int CheckValueInTextBox(TextBox t, long maxValue)
        {
            int val;
            if (t.Text == "" || !int.TryParse(t.Text, out val))
                val = 0;
            else
                val = Convert.ToInt32(t.Text);
            if (val <= maxValue)
                return val;
            else
            {
                MessageBox.Show("Ошибка. Превышено допустимое значение.\nДолжно быть меньше " + maxValue.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Text = "0";
                return 0;
            }
        }

        private string GetEventFromComboBox()
        {
            if (comboBoxEvent.SelectedItem != null)
                switch (comboBoxEvent.SelectedItem.ToString())
                {
                    case "Ожидание":
                        return "WAIT";
                    case "Левая кнопка мыши (1 раз)":
                        return "LMOUSE1";
                    case "Правая кнопка мыши (1 раз)":
                        return "RMOUSE1";
                    case "Средняя кнопка мыши (1 раз)":
                        return "MMOUSE1";
                    case "Левая кнопка мыши (2 раза)":
                        return "LMOUSE2";
                    case "Правая кнопка мыши (2 раза)":
                        return "RMOUSE2";
                    case "Средняя кнопка мыши (2 раза)":
                        return "MMOUSE2";
                    case "Нажатие клавиши":
                        if (comboBoxKey.SelectedItem != null)
                        {
                            if (radioButtonNo.Checked || (!radioButtonNo.Checked && !radioButtonALT.Checked && !radioButtonCTRL.Checked && !radioButtonSHIFT.Checked))
                                return "{" + comboBoxKey.SelectedItem.ToString() + "}";
                            if (radioButtonALT.Checked)
                                return "%{" + comboBoxKey.SelectedItem.ToString() + "}";
                            if (radioButtonCTRL.Checked)
                                return "^{" + comboBoxKey.SelectedItem.ToString() + "}";
                            if (radioButtonSHIFT.Checked)
                                return "+{" + comboBoxKey.SelectedItem.ToString() + "}";
                        }
                        return "N";
                    default:
                        return "N";
                }
            else
                return "N";
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveScriptToFileDialog = new SaveFileDialog();
            saveScriptToFileDialog.Filter = "dat files (*.dat)|*.dat";
            saveScriptToFileDialog.FilterIndex = 1;
            saveScriptToFileDialog.RestoreDirectory = true;
            saveScriptToFileDialog.AddExtension = true;
            saveScriptToFileDialog.DefaultExt = ".dat";
            if (saveScriptToFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(saveScriptToFileDialog.FileName);
                foreach (var str in listBoxScript.Items)
                    sr.WriteLine(str.ToString());
                textBoxScriptPath.Text = saveScriptToFileDialog.FileName;
                formMain.scriptPath = saveScriptToFileDialog.FileName;
                MessageBox.Show("Сценарий сохранён в Файл: " + saveScriptToFileDialog.FileName, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sr.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openScriptFileDialog = new OpenFileDialog();
            openScriptFileDialog.Filter = "dat files (*.dat)|*.dat";
            openScriptFileDialog.FilterIndex = 1;
            openScriptFileDialog.RestoreDirectory = true;
            if (openScriptFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openScriptFileDialog.FileName);
                    using (sr)
                    {
                        listBoxScript.Items.Clear();
                        while (!sr.EndOfStream)
                            listBoxScript.Items.Add(sr.ReadLine());
                        textBoxScriptPath.Text = openScriptFileDialog.FileName;
                        MessageBox.Show("Сценарий загружен из Файла: " + openScriptFileDialog.FileName, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Файл не может быть считан с диска. Оригинальная ошибка: " + ex.Message);
                }
            }
        }

        private void FormCreateScript_Load(object sender, EventArgs e)
        {
            textBoxFilePath.Text = formMain.path;
            textBoxScriptPath.Text = formMain.scriptPath;
            if (formMain.path != "")
            {
                try
                {
                    FileInfo fi = new FileInfo(formMain.path);
                    labelCreationTime.Text = "Время создания: " + fi.CreationTime.ToString();
                    labelExtension.Text = "Расширение: " + fi.Extension;
                    labelLastAccessTime.Text = "Последнее обращение: " + fi.LastAccessTime.ToString();
                    labelLastWriteTime.Text = "Последняя запись: " + fi.LastWriteTime.ToString();
                    labelLength.Text = "Размер в байтах: " + fi.Length.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Файл не может быть считан с диска. Оригинальная ошибка: " + ex.Message);
                }
            }
        }

        private void checkBoxSelectionMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectionMode.Checked)
                listBoxScript.SelectionMode = SelectionMode.MultiSimple;
            else
                listBoxScript.SelectionMode = SelectionMode.One;
        }

        private void buttonEditInScript_Click(object sender, EventArgs e)
        {
            var selectedIndices = new List<int>();
            foreach (int index in listBoxScript.SelectedIndices)
            {
                selectedIndices.Add(index);
            }
            foreach (int index in selectedIndices)
            {
                string userEvent = GetEventFromComboBox();
                listBoxScript.Items[index] = CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width).ToString() + " " + CheckValueInTextBox(textBoxMousePosY, SystemInformation.PrimaryMonitorSize.Height).ToString() + " " + userEvent + " " + CheckValueInTextBox(textBoxWaitMilliseconds, 1000 * 60 * 60 * 24).ToString();              
            }
            if (checkBoxTakeAll.Checked)
            {
                checkBoxTakeAll.Checked = false;
                checkBoxTakeAll.Checked = true;
            }
        }

        private void buttonChoseScriptFile_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(sender, e);
        }

        private void listBoxScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkBoxSelectionMode.Checked && listBoxScript.SelectedItem != null)
            {
                string selectedString = listBoxScript.SelectedItem.ToString();
                var ssS = selectedString.Split(' ');
                if (ssS.Length == 4)
                {
                    textBoxMousePosX.Text = ssS[0];
                    textBoxMousePosY.Text = ssS[1];
                    switch (ssS[2])
                    {
                        case "WAIT":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[0];
                            break;
                        case "LMOUSE1":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[1];
                            break;
                        case "RMOUSE1":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[2];
                            break;
                        case "MMOUSE1":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[3];
                            break;
                        case "LMOUSE2":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[4];
                            break;
                        case "RMOUSE2":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[5];
                            break;
                        case "MMOUSE2":
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[6];
                            break;
                        case "N":
                            
                            break;
                        default:
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[7];
                            StringBuilder sb = null;
                            if (ssS[2][0] != '{')
                            {
                                switch (ssS[2][0])
                                {
                                    case '%':
                                        radioButtonALT.Checked = true;
                                        break;
                                    case '^':
                                        radioButtonCTRL.Checked = true;
                                        break;
                                    case '+':
                                        radioButtonSHIFT.Checked = true;
                                        break;
                                }
                            }
                            else
                                radioButtonNo.Checked = true;
                            if (radioButtonNo.Checked || (!radioButtonNo.Checked && !radioButtonALT.Checked && !radioButtonCTRL.Checked && !radioButtonSHIFT.Checked))
                                sb = new StringBuilder(ssS[2], 1, ssS[2].Length - 2, ssS[2].Length - 2);
                            if (radioButtonALT.Checked || radioButtonCTRL.Checked || radioButtonSHIFT.Checked)
                                sb = new StringBuilder(ssS[2], 2, ssS[2].Length - 3, ssS[2].Length - 3);
                            comboBoxKey.SelectedItem = comboBoxKey.Items[comboBoxKey.FindStringExact(sb.ToString())];
                            break;
                    }
                    textBoxWaitMilliseconds.Text = ssS[3];
                }

            }
        }

        private void сохранитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formMain.scriptPath == "")
                сохранитьToolStripMenuItem1_Click(sender, e);
            else
            {
                if (MessageBox.Show("Вы действительно хотите сохранить сценарий в файл:\n" + formMain.scriptPath, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    StreamWriter sr = new StreamWriter(formMain.scriptPath);
                    foreach (var str in listBoxScript.Items)
                        sr.WriteLine(str.ToString());
                    textBoxScriptPath.Text = formMain.scriptPath;
                    MessageBox.Show("Сценарий сохранён в Файл: " + formMain.scriptPath, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sr.Close();
                }
            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxScriptPath.Text = "";
            textBoxMousePosX.Text = "";
            textBoxMousePosY.Text = "";
            textBoxWaitMilliseconds.Text = "";
            comboBoxKey.SelectedItem = comboBoxKey.Items[0];
            comboBoxEvent.SelectedItem = comboBoxEvent.Items[0];
            listBoxScript.Items.Clear();
        }

        private void textBoxDoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b\cA-\cZ]");
        }

        private void buttonDoN_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (listBoxScript.SelectedIndex != null)
            {
                if (int.TryParse(textBoxDoN.Text, out count))
                {
                    listBoxScript.SelectedItems.Clear();
                    for (int i = 0; i < count; i++)
                        buttonAddToScript_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Не задано n.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Нет выделенных элементов.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxTakeAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTakeAll.Checked)
            {
                checkBoxSelectionMode.Checked = true;
                for (int i = 0; i < listBoxScript.Items.Count; i++)
                    listBoxScript.SelectedItems.Add(listBoxScript.Items[i]);
            }
            else
            {
                listBoxScript.SelectedItems.Clear();
                checkBoxSelectionMode.Checked = false;
            }
        }

        private void buttonInputString_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxInputString.Text != "")
            {
                var listBoxScriptTemp = new List<string>();
                foreach (var item in listBoxScript.Items)
                {
                    listBoxScriptTemp.Add(item.ToString());
                }
                bool wasContained = false;
                int i = 0;
                List<string> ls = new List<string>();
                ListBox.SelectedObjectCollection sc = new ListBox.SelectedObjectCollection(listBoxScript);
                while (i < listBoxScript.Items.Count)
                {
                    if (!sc.Contains(listBoxScript.Items[i]))
                    {
                        ls.Add(listBoxScript.Items[i].ToString());
                        listBoxScript.Items.Remove(listBoxScript.Items[i]);
                    }
                    else
                    {
                        wasContained = true;
                        ls.Add(listBoxScript.Items[i].ToString());
                        listBoxScript.Items.Remove(listBoxScript.Items[i]);
                        string str = textBoxInputString.Text;
                        if (str != "")
                        {
                            for (int j = 0; j < str.Length; j++)
                            {
                                textBoxMousePosX.Text = "0";
                                textBoxMousePosY.Text = "0";
                                textBoxWaitMilliseconds.Text = "100";
                                comboBoxEvent.SelectedItem = comboBoxEvent.Items[7];
                                comboBoxKey.SelectedItem =
                                    comboBoxKey.Items[comboBoxKey.FindStringExact(str[j].ToString())];
                                string userEvent = GetEventFromComboBox();
                                ls.Add(
                                    CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width)
                                        .ToString() + " " +
                                    CheckValueInTextBox(textBoxMousePosY, SystemInformation.PrimaryMonitorSize.Height)
                                        .ToString() + " " + userEvent + " " +
                                    CheckValueInTextBox(textBoxWaitMilliseconds, 1000*60*60*24).ToString());
                            }
                        }
                    }
                }
                listBoxScript.Items.Clear(); // это не обязательно, потому что после while он будет пустой
                foreach (var s in ls)
                    listBoxScript.Items.Add(s);
                if (!wasContained)
                {
                    string str = textBoxInputString.Text;
                    if (str != "")
                    {
                        for (int j = 0; j < str.Length; j++)
                        {
                            textBoxMousePosX.Text = "0";
                            textBoxMousePosY.Text = "0";
                            textBoxWaitMilliseconds.Text = "100";
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[7];
                            if (str[j] == ' ')
                                comboBoxKey.SelectedItem = comboBoxKey.Items[7];
                            else
                            {

                                if (comboBoxKey.FindStringExact(str[j].ToString()) == -1)
                                {
                                    listBoxScript.Items.Clear();
                                    foreach (var item in listBoxScriptTemp)
                                    {
                                        listBoxScript.Items.Add(item);
                                    }
                                    MessageBox.Show("Символ '" + str[j] + "' в заданной строке не был найден.", "Внимание",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                else
                                {
                                    comboBoxKey.SelectedItem =
                                        comboBoxKey.Items[comboBoxKey.FindStringExact(str[j].ToString())];
                                    string userEvent = GetEventFromComboBox();
                                    listBoxScript.Items.Add(
                                        CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width)
                                            .ToString() + " " +
                                        CheckValueInTextBox(textBoxMousePosY,
                                            SystemInformation.PrimaryMonitorSize.Height)
                                            .ToString() + " " + userEvent + " " +
                                        CheckValueInTextBox(textBoxWaitMilliseconds, 1000*60*60*24).ToString());
                                }
                            }
                            string userEvent2 = GetEventFromComboBox();
                            listBoxScript.Items.Add(
                                CheckValueInTextBox(textBoxMousePosX, SystemInformation.PrimaryMonitorSize.Width)
                                    .ToString() + " " +
                                CheckValueInTextBox(textBoxMousePosY,
                                    SystemInformation.PrimaryMonitorSize.Height)
                                    .ToString() + " " + userEvent2 + " " +
                                CheckValueInTextBox(textBoxWaitMilliseconds, 1000 * 60 * 60 * 24).ToString());
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Введите строку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDoCycle_Click(object sender, EventArgs e)
        {
            if (listBoxScript.SelectedItem != null)
            {
                int count = 0;
                int index;
                if (int.TryParse(textBoxDoCycle.Text, out count))
                {
                    if (!checkBoxSelectionMode.Checked)
                        for (int i = 0; i < count; i++)
                        {
                            index = listBoxScript.Items.IndexOf(listBoxScript.SelectedItem);
                            buttonAddToScript_Click(sender, e);
                            listBoxScript.SelectedItem = listBoxScript.Items[index + 1];
                        }
                    else
                    {
                        ListBox.SelectedObjectCollection sc = new ListBox.SelectedObjectCollection(listBoxScript);
                        if (CheckCollection(sc) && count > 0)
                        {
                            List<string> ls = new List<string>();
                            int i = 0;
                            while (i <= lastIndex)
                            {
                                ls.Add(listBoxScript.Items[i].ToString());
                                i++;
                            }
                            for (i = 0; i < count - 1; i++)
                            {
                                foreach (var s in sc)
                                    ls.Add(s.ToString());
                            }
                            i = lastIndex + 1;
                            while (i < listBoxScript.Items.Count)
                            {
                                ls.Add(listBoxScript.Items[i].ToString());
                                i++;
                            }
                            listBoxScript.Items.Clear();
                            foreach (var s in ls)
                                listBoxScript.Items.Add(s);
                            ls.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не задано n.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Нет выделенных элементов.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckCollection(ListBox.SelectedObjectCollection sysCol)
        {
            bool res = true;
            this.lastIndex = -1;
            int i = 0;
            while (i < listBoxScript.Items.Count && res)
            {
                if (sysCol.Contains(listBoxScript.Items[i]))
                {
                    if (this.lastIndex == -1)
                        this.lastIndex = i;
                    else
                    {
                        if (i != this.lastIndex + 1)
                            res = false;
                        this.lastIndex = i;
                    }
                }
                i++;
            }
            return res;
        }

        // не работает: выделяет только первое действие
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (listBoxScript.SelectedItems.Count == 1)
            {
                checkBoxSelectionMode.Checked = true;
                int index = 0;
                string currentString = listBoxScript.SelectedItem.ToString();
                listBoxScript.SelectedItems.Clear();
                while (index != -1 && index < listBoxScript.Items.Count)
                {
                    if (listBoxScript.FindString(currentString, index) > index)
                    {
                        index = listBoxScript.FindString(currentString, index);
                        listBoxScript.SelectedIndices.Add(index);
                    }
                    else
                        index = -1;
                }
            }
            else
                if (listBoxScript.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Искать можно только одинаковые действия!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkBoxSelectionMode.Checked = true;
                    //ListBox.SelectedObjectCollection sc = new ListBox.SelectedObjectCollection(listBoxScript);
                    listBoxScript.SelectedItems.Clear();
                    /*for (int i = 0; i < sc.Count; i++)
                    {
                        //listBoxScript.SelectedItem = listBoxScript.Items[listBoxScript.FindString(sc[i].ToString())];
                        //listBoxScript.SelectedItems.Add(listBoxScript.Items[listBoxScript.FindString(sc[i].ToString())]);
                        //buttonSearch_Click(sender, e);
                    }*/
                }
        }

        private void buttonClearChoseFile_Click(object sender, EventArgs e)
        {
            textBoxFilePath.Text = "";
            if (langNumber2 == 1)
            {
                labelCreationTime.Text = "Время создания: ";
                labelExtension.Text = "Расширение: ";
                labelLastAccessTime.Text = "Последнее обращение: ";
                labelLastWriteTime.Text = "Последняя запись: ";
                labelLength.Text = "Размер в байтах: ";
            }
            else
            {
                labelCreationTime.Text = "Creation time: ";
                labelExtension.Text = "Extension: ";
                labelLastAccessTime.Text = "Last access time: ";
                labelLastWriteTime.Text = "Last write time: ";
                labelLength.Text = "Length in bytes: ";
            }
            formMain.tbP.Text = "";
            formMain.cbP.Items.Clear();
        }

        private void buttonClearChoseScriptFile_Click(object sender, EventArgs e)
        {
            listBoxScript.Items.Clear();
            textBoxScriptPath.Text = "";
        }

        private void textBoxDoCycle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b\cA-\cZ]");
        }

        private void listBoxScript_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedIndex = listBoxScript.SelectedIndex;
            if (selectedIndex != -1)
            {
                //ToDo: добавить вывод новой формы для редактирования команды?
            }
        }

        /*protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("1");
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }*/
    }
}


//ToDo:
// Version 1.0:
// +1) Сделать добавление в сценарий после выбранного (а потом можно добавить добавление после всех выбранных)
// +2) Сделать редактирование многих полей сценария
// +3) Добавить Инструменты-Запоминание позиции мыши
// +4) Сделать Сохранить дополнительно к Сохранить как
// +5) При выборе действия заполнять поля текстбоксов и комбобоксов
// +6) Добавить возможность нажатия ALT, CTRL, SHIFT + клавиша
// +7) Добавить возможность ввода строки после выбранного действия
// +8) Реализовать выбор всех уникальных действий
// +9) Сделать возможность добавления циклов (с кол-вом этих добавлений)
// Version 1.1:
// 10) Добавить возможность добавления текста из другого скрипта в конец текущего.
// 11) Добавить возможность пошагового режима выполнения скрипта (каждый шаг контролируется пользователем: у него спрашивается, нужно ли делать шаг?).
// 12) Добавить возможность шифрования текста скрипта. При этом, возможно, сделать выбор метода шифрования. Может быть, с файлом-ключом.
// 13) Найти изображение для кнопки для очистки выбранных файлов.