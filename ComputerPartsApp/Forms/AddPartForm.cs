using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public partial class AddPartForm : Form
    {
        string partAsText;
        const string defaultImageURL = "..\\..\\..\\Items\\Images\\default.png";
        // Set to true if tab change initiated through combobox, otherwise false
        bool internalTabChange = false;
        //RegEx invalid input
        bool invalidInput = false;

        public AddPartForm()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = defaultImageURL;
            //tabControlMain.Enabled = false;

            // Change tab pages color
            //tabControlMain.TabPages.Cast<TabPage>().ToList().ForEach(x => x.BackColor = System.Drawing.Color.OldLace);

            // Initialize combobox with types
            foreach (var tab in tabControlMain.TabPages) comboBoxTypes.Items.Add((tab as TabPage).Text);

            // Hides tab pages
            //tabControlMain.Appearance = TabAppearance.FlatButtons;
            //tabControlMain.ItemSize = new Size(0, 1);
            //tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        int previousSelectedIndex = -1;

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {            
            pictureBox1.Visible = true;
            // Check if actual change is committed
            if((sender as ComboBox).SelectedIndex != previousSelectedIndex) internalTabChange = true;
            // Check if the user selects the first tab page at first
            if ((sender as ComboBox).SelectedIndex == 0 && previousSelectedIndex == -1) internalTabChange = false;

            // Enable and clear default part characteristic
            foreach (var control in tableLayoutMainChar.Controls) (control as Control).Enabled = true;

            tabControlMain.Enabled = true;
            textBoxMF.ResetText();
            textBoxModel.ResetText();
            textBoxName.ResetText();
            textBoxPrice.ResetText();
            textBoxURL.ResetText();
            pictureBox1.ImageLocation = defaultImageURL;

            // Enable and clear specific part characteristics, select part tab page
            switch(comboBoxTypes.SelectedItem.ToString())
            {
                case "Процесор":
                    {
                        foreach (var control in tableLayoutCPU.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                        }
                        tabControlMain.SelectedTab = tabPageCPU;
                        break;
                    }
                case "Дънна платка":
                    {
                        foreach (var control in tableLayoutMB.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                        }
                        tabControlMain.SelectedTab = tabPageMB;
                        break;
                    }
                case "RAM":
                    {
                        foreach (var control in tableLayoutRAM.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                        }
                        tabControlMain.SelectedTab = tabPageRAM;
                        break;
                    }
                case "Видеокарта":
                    {
                        foreach (var control in tableLayoutVC.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                        }
                        tabControlMain.SelectedTab = tabPageVC;
                        break;
                    }
                case "Захранване":
                    {
                        foreach (var control in tableLayoutPSU.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                        }
                        tabControlMain.SelectedTab = tabPagePSU;
                        break;
                    }
                case "Твърд диск":
                    {
                        foreach (var control in tableLayoutHDD.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                        }
                        tabControlMain.SelectedTab = tabPageHDD;
                        break;
                    }
                case "SSD":
                    {
                        foreach (var control in tableLayoutSSD.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                        }
                        tabControlMain.SelectedTab = tabPageSSD;
                        break;
                    }
                case "Кутия":
                    {
                        foreach (var control in tableLayoutCase.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                        }
                        tabControlMain.SelectedTab = tabPageCase;
                        break;
                    }
                case "Монитор":
                    {
                        foreach (var control in tableLayoutMonitor.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }
                        tabControlMain.SelectedTab = tabPageMonitor;

                        // Initialize color combobox
                        comboBoxMonitorColor.DisplayMember = "Description";
                        comboBoxMonitorColor.ValueMember = "Value";
                        comboBoxMonitorColor.DataSource = Enum
                            .GetValues(typeof(Color))
                            .Cast<Enum>()
                            .Select(value => new
                            {
                                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                                value
                            })
                            .OrderBy(item => item.Description)
                            .ToList();

                        comboBoxMonitorColor.SelectedIndex = -1;
                        break;
                    }
                case "Мишка":
                    {
                        foreach (var control in tableLayoutMouse.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }
                        tabControlMain.SelectedTab = tabPageMouse;

                        // Initialize color combobox
                        comboBoxMouseColor.DisplayMember = "Description";
                        comboBoxMouseColor.ValueMember = "Value";
                        comboBoxMouseColor.DataSource = Enum
                            .GetValues(typeof(Color))
                            .Cast<Enum>()
                            .Select(value => new
                            {
                                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                                value
                            })
                            .OrderBy(item => item.Description)
                            .ToList();

                        comboBoxMouseColor.SelectedIndex = -1;
                        break;
                    }
                case "Клавиатура":
                    {
                        foreach (var control in tableLayoutKeyboard.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }
                        tabControlMain.SelectedTab = tabPageKeyboard;

                        // Initialize color combobox
                        comboBoxKeyboardColor.DisplayMember = "Description";
                        comboBoxKeyboardColor.ValueMember = "Value";
                        comboBoxKeyboardColor.DataSource = Enum
                            .GetValues(typeof(Color))
                            .Cast<Enum>()
                            .Select(value => new
                            {
                                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                                value
                            })
                            .OrderBy(item => item.Description)
                            .ToList();

                        comboBoxKeyboardColor.SelectedIndex = -1;
                        break;
                    }
                case "Тонколони":
                    {
                        foreach (var control in tableLayoutSpeakers.Controls)
                        {
                            (control as Control).Enabled = true;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }
                        tabControlMain.SelectedTab = tabPageSpeakers;

                        // Initialize color combobox
                        comboBoxSpeakersColor.DisplayMember = "Description";
                        comboBoxSpeakersColor.ValueMember = "Value";
                        comboBoxSpeakersColor.DataSource = Enum
                            .GetValues(typeof(Color))
                            .Cast<Enum>()
                            .Select(value => new
                            {
                                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                                value
                            })
                            .OrderBy(item => item.Description)
                            .ToList();

                        comboBoxSpeakersColor.SelectedIndex = -1;
                        break;
                    }
                default:
                    {
                        break;
                    }

            }

            previousSelectedIndex = (sender as ComboBox).SelectedIndex;
        }

        private void tabControlMain_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            // If tab change not initiated using combobox), don't change pages
            if(!internalTabChange)
            {
                e.Cancel = true;
                if (!invalidInput) comboBoxTypes.DroppedDown = true;
            }

            internalTabChange = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTypes.SelectedItem == null) MessageBox.Show("Моля, изберете типа на частта, която искате да добавите.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {            
                // Check if there are empty fields
                bool emptyFields = false;

                foreach (var textBox in tableLayoutMainChar.Controls.OfType<TextBox>())
                {
                    if (textBox.Text == string.Empty)
                    {
                        emptyFields = true;
                        break;
                    }
                }

                foreach (var textBox in tabControlMain.SelectedTab.Controls.Cast<TableLayoutPanel>().FirstOrDefault().Controls.OfType<TextBox>())
                {
                    if (textBox.Text == string.Empty)
                    {
                        emptyFields = true;
                        break;
                    }
                }

                foreach(var comboBox in tabControlMain.SelectedTab.Controls.Cast<TableLayoutPanel>().FirstOrDefault().Controls.OfType<ComboBox>())
                {
                    if(comboBox.SelectedIndex == -1)
                    {
                        emptyFields = true;
                        break;
                    }
                }

                if (pictureBox1.ImageLocation == defaultImageURL) emptyFields = true;

                if (emptyFields) MessageBox.Show("Моля, попълнете всички полета.", "Празни полета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Convert field input to CSV string
                    switch (comboBoxTypes.SelectedItem.ToString())
                    {
                        case "Процесор":
                            {
                                partAsText = $"\"CPU\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxFreq.Text}\",\"{textBoxArch.Text}\",\"{textBoxCores.Text}\",\"{textBoxSegm.Text}\",\"{textBoxTech.Text}\",\"{textBoxCache.Text}\"";
                                break;
                            }
                        case "Дънна платка":
                            {
                                partAsText = $"\"MotherBoard\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxMBform.Text}\",\"{textBoxMBsock.Text}\",\"{textBoxMBchip.Text}\",\"{textBoxMBtypeMem.Text}\"";
                                break;
                            }
                        case "RAM":
                            {
                                partAsText = $"\"RAM\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxName.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxRAMcap.Text}\",\"{textBoxRAMtype.Text}\",\"{textBoxRAMspeed.Text}\"";
                                break;
                            }
                        case "Видеокарта":
                            {
                                partAsText = $"\"VideoCard\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxName.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxVCchip.Text}\",\"{textBoxVCinterf.Text}\",\"{textBoxVCmemType.Text}\",\"{textBoxVCmemSize.Text}\"";
                                break;
                            }
                        case "Захранване":
                            {
                                var dimensions = textBoxPSUdim.Text.Split(new char[] { ',' }, 3, StringSplitOptions.RemoveEmptyEntries);

                                partAsText = $"\"PSU\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxPSUpower.Text}\",\"{dimensions[0]},{dimensions[1]},{dimensions[2]}\",\"{textBoxPSUform.Text}\",\"{textBoxPSUeffic.Text}\",\"{textBoxPSUfanSize.Text}\"";
                                break;
                            }
                        case "Твърд диск":
                            {
                                bool isPortable = checkBoxHDDportable.Checked;

                                partAsText = $"\"HDD\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxHDDcap.Text}\",\"{textBoxHDDinterf.Text}\",\"{textBoxHDDcache.Text}\",\"{textBoxHDDform.Text}\",\"{textBoxHDDrpm.Text}\",\"{textBoxHDDmtr.Text}\",\"{isPortable}\"";
                                break;
                            }
                        case "SSD":
                            {
                                bool isPortable = checkBoxSSDportable.Checked;

                                partAsText = $"\"SSD\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxSSDcap.Text}\",\"{textBoxSSDinterf.Text}\",\"{textBoxSSDcontr.Text}\",\"{textBoxSSDform.Text}\",\"{isPortable}\",\"{textBoxSSDmrs.Text}\",\"{textBoxSSDmws.Text}\"";
                                break;
                            }
                        case "Кутия":
                            {
                                var dimensions = textBoxCaseDim.Text.Split(new char[] { ',' }, 3, StringSplitOptions.RemoveEmptyEntries);
                                bool liquidCooling = checkBoxLiquidCool.Checked;

                                partAsText = $"\"Case\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxCaseForm.Text}\",\"{dimensions[0]},{dimensions[1]},{dimensions[2]}\",\"{textBoxCaseDiskSlots.Text}\",\"{textBoxCaseSock.Text}\",\"{textBoxCaseMaxNumFans.Text}\",\"{liquidCooling}\"";
                                break;
                            }
                        case "Монитор":
                            {
                                var dimensions = textBoxMonDim.Text.Split(new char[] { ',' }, 3, StringSplitOptions.RemoveEmptyEntries);
                                bool isWireless = checkBoxMonWireless.Checked;

                                partAsText = $"\"Monitor\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxMonSize.Text}\",\"{textBoxMonRes.Text}\",\"{textBoxMonTypeScreen.Text}\",\"{textBoxMonPanType.Text}\",\"{isWireless}\",\"{1}\",\"{dimensions[0]},{dimensions[1]},{dimensions[2]}\",\"{textBoxMonWeight.Text}\",\"{(int)(Color)comboBoxMonitorColor.SelectedValue}\"";
                                break;
                            }
                        case "Мишка":
                            {
                                var dimensions = textBoxMouseDim.Text.Split(new char[] { ',' }, 3, StringSplitOptions.RemoveEmptyEntries);
                                bool isWireless = checkBoxMouseIsWireless.Checked;

                                partAsText = $"\"Mouse\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxMouseType.Text}\",\"{textBoxMouseDPI.Text}\",\"{textBoxMouseNumButtons.Text}\",\"{textBoxMouseWeight.Text}\",\"{textBoxMouseSensor.Text}\",\"{dimensions[0]},{dimensions[1]},{dimensions[2]}\",\"{isWireless}\",\"{0}\",\"{(int)(Color)comboBoxMouseColor.SelectedValue}\"";
                                break;
                            }
                        case "Клавиатура":
                            {
                                var dimensions = textBoxKeyboardDim.Text.Split(new char[] { ',' }, 3, StringSplitOptions.RemoveEmptyEntries);
                                bool isWireless = checkBoxKeyboardIsWireless.Checked;

                                partAsText = $"\"Keyboard\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxKeyboardKeyType.Text}\",\"{textBoxKeyboardFom.Text}\",\"{textBoxKeyboardLayout.Text}\",\"{textBoxKeyboardLoc.Text}\",\"{textBoxKeryboardPolling.Text}\",\"{dimensions[0]},{dimensions[1]},{dimensions[2]}\",\"{isWireless}\",\"{textBoxKeyboardWeight.Text}\",\"{0}\",\"{(int)(Color)comboBoxKeyboardColor.SelectedValue}\"";
                                break;
                            }
                        case "Тонколони":
                            {
                                var dimensions = textBoxSpeakersDim.Text.Split(new char[] { ',' }, 3, StringSplitOptions.RemoveEmptyEntries);
                                bool isWireless = checkBoxSpeakersIsWireless.Checked;

                                partAsText = $"\"Speakers\",\"{textBoxMF.Text}\",\"{textBoxName.Text}\",\"{textBoxModel.Text}\",\"{textBoxPrice.Text}\",\"{pictureBox1.ImageLocation}\",\"{textBoxURL.Text}\",\"{textBoxSpeakersType.Text}\",\"{textBoxSpeakersPower.Text}\",\"{textBoxSpeakersFreq.Text}\",\"{isWireless}\",\"{1}\",\"{dimensions[0]},{dimensions[1]},{dimensions[2]}\",\"{textBoxSpeakersWeight.Text}\",\"{(int)(Color)comboBoxSpeakersColor.SelectedValue}\"";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }

                    // Save added part
                    using (var sr = new StringReader(partAsText)) { Items.LoadPartGUI(sr); }
                    Items.SaveAddedPart();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Частта е добавена успешо.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void textBoxWithPrice_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var regex = new Regex(@"^((\d{1,})(,\d{1,2}|))?$");

            if (!regex.IsMatch(textBox.Text))
            {
                invalidInput = true;
                MessageBox.Show("Моля, въведете коректна цена.", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();
            }
            else invalidInput = false;
        }

        private void textBoxWithInt_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var regex = new Regex(@"^\d+$");

            if (textBox.Text != string.Empty && !regex.IsMatch(textBox.Text))
            {
                invalidInput = true;
                MessageBox.Show("Моля, въведете цяло число.", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();
            }
            else invalidInput = false;
        }

        private void textBoxWithDimensions_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var regex = new Regex(@"^\d{1,3}, \d{1,3}, \d{1,3}$");

            if (textBox.Text != string.Empty && !regex.IsMatch(textBox.Text))
            {
                invalidInput = true;
                MessageBox.Show("Моля, въведете коректни размери.", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();
            }
            else invalidInput = false;
        }

        private void textBoxWithDouble_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var regex = new Regex(@"^\d{1,6}(,\d{1,6})?$");

            if (textBox.Text != string.Empty && !regex.IsMatch(textBox.Text))
            {
                invalidInput = true;
                MessageBox.Show("Моля, въведете коректно десетично число.", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();
            }
            else invalidInput = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var result = openPicDialog.ShowDialog();
                if (result == DialogResult.OK) pictureBox1.ImageLocation = openPicDialog.FileName;
            }
            else if (e.Button == MouseButtons.Right && pictureBox1.ImageLocation != defaultImageURL) Process.Start(pictureBox1.ImageLocation);
        }
    }
}
