using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public partial class EditPartForm : Form
    {
        bool changeIsMade = false;
        const string defaultImageURL = "..\\..\\..\\Items\\Images\\default.png";
        Part currentPart;
        // Set to true if change initiated through combobox, otherwise false
        bool internalTabChange = false;
        // RegEx invalid input
        bool invalidInput = false;

        public EditPartForm()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = defaultImageURL;
            //tabControlMain.Enabled = false;  
            
            // Change tab pages color
            // tabControlMain.TabPages.Cast<TabPage>().ToList().ForEach(x => x.BackColor = System.Drawing.Color.OldLace);

            // Initialize combobox with types
            foreach (var tab in tabControlMain.TabPages) comboBoxTypes.Items.Add((tab as TabPage).Text);
        }

        int previousSelectedIndex = -1;

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            
            // Check if actual change is committed
            if ((sender as ComboBox).SelectedIndex != previousSelectedIndex) internalTabChange = true;
            // Check if the user selects the first tab page at first
            if ((sender as ComboBox).SelectedIndex == 0 && previousSelectedIndex == -1) internalTabChange = false;

            // Disable and Clear default part characteristics
            foreach (var control in tableLayoutMainChar.Controls) (control as Control).Enabled = false;

            textBoxMF.ResetText();
            textBoxModel.ResetText();
            textBoxName.ResetText();
            textBoxPrice.ResetText();
            textBoxURL.ResetText();
            pictureBox1.ImageLocation = defaultImageURL;

            // Clear previos parts in comboBoxParts
            comboBoxParts.Items.Clear();

            // Select part tab page, add the parts to comboBoxParts
            switch(comboBoxTypes.SelectedItem.ToString())
            {
                case "Процесор":
                    {
                        foreach (var control in tableLayoutCPU.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                        }

                        tabControlMain.SelectedTab = tabPageCPU;
                        foreach (var item in Items.AllParts.OfType<CPU>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "Дънна платка":
                    {
                        foreach (var control in tableLayoutMB.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                        }

                        tabControlMain.SelectedTab = tabPageMB;
                        foreach (var item in Items.AllParts.OfType<MotherBoard>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "RAM":
                    {
                        foreach (var control in tableLayoutRAM.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                        }

                        tabControlMain.SelectedTab = tabPageRAM;
                        foreach (var item in Items.AllParts.OfType<RAM>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "Видеокарта":
                    {
                        foreach (var control in tableLayoutVC.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                        }

                        tabControlMain.SelectedTab = tabPageVC;
                        foreach (var item in Items.AllParts.OfType<VideoCard>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "Захранване":
                    {
                        foreach (var control in tableLayoutPSU.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                        }

                        tabControlMain.SelectedTab = tabPagePSU;
                        foreach (var item in Items.AllParts.OfType<PSU>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "Твърд диск":
                    {
                        foreach (var control in tableLayoutHDD.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                        }

                        tabControlMain.SelectedTab = tabPageHDD;
                        foreach (var item in Items.AllParts.OfType<HDD>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "SSD":
                    {
                        foreach (var control in tableLayoutSSD.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                        }

                        tabControlMain.SelectedTab = tabPageSSD;
                        foreach (var item in Items.AllParts.OfType<SSD>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "Кутия":
                    {
                        foreach (var control in tableLayoutCase.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                        }

                        tabControlMain.SelectedTab = tabPageCase;
                        foreach (var item in Items.AllParts.OfType<Case>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                        break;
                    }
                case "Монитор":
                    {
                        foreach (var control in tableLayoutMonitor.Controls)
                        {
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }

                        tabControlMain.SelectedTab = tabPageMonitor;
                        foreach (var item in Items.AllParts.OfType<Monitor>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);

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
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }

                        tabControlMain.SelectedTab = tabPageMouse;
                        foreach (var item in Items.AllParts.OfType<Mouse>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);

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
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }

                        tabControlMain.SelectedTab = tabPageKeyboard;
                        foreach (var item in Items.AllParts.OfType<Keyboard>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);

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
                            (control as Control).Enabled = false;
                            if (control is TextBox tb) tb.Clear();
                            if (control is CheckBox chB) chB.Checked = false;
                            if (control is ComboBox cB) cB.SelectedIndex = -1;
                        }

                        tabControlMain.SelectedTab = tabPageSpeakers;
                        foreach (var item in Items.AllParts.OfType<Speakers>().OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);

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
            comboBoxParts.DroppedDown = true;
        }

        private void tabControlMain_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            // If tab change not initiated using combobox), don't change pages
            if (!internalTabChange)
            {
                e.Cancel = true;
                if(!invalidInput) comboBoxTypes.DroppedDown = true;
            }

            internalTabChange = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (changeIsMade) DialogResult = DialogResult.OK;
            else
            {
                DialogResult = DialogResult.None;
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTypes.SelectedItem == null || comboBoxParts.SelectedItem == null) MessageBox.Show("Моля, изберете частта, която искате да промените.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Convert field input to part
                    currentPart.Manufacturer = textBoxMF.Text;
                    currentPart.Name = textBoxName.Text;
                    currentPart.Model = textBoxModel.Text;
                    currentPart.Price = decimal.Parse(textBoxPrice.Text);
                    currentPart.URL = textBoxURL.Text;
                    currentPart.PictureURL = pictureBox1.ImageLocation;

                    switch(comboBoxTypes.SelectedText)
                    {
                        case "Процесор":
                            (currentPart as CPU).FrequencyGHz = double.Parse(textBoxFreq.Text);
                            (currentPart as CPU).NumOfCores = int.Parse(textBoxCores.Text);
                            (currentPart as CPU).Architecture = textBoxArch.Text;
                            (currentPart as CPU).Technology = textBoxTech.Text;
                            (currentPart as CPU).Segment = textBoxSegm.Text;
                            (currentPart as CPU).CacheMB = int.Parse(textBoxCache.Text);
                            break;
                        case "Дънна платка":
                            (currentPart as MotherBoard).FormFactor = textBoxMBform.Text;
                            (currentPart as MotherBoard).Chipset = textBoxMBchip.Text;
                            (currentPart as MotherBoard).CPU_Socket = textBoxMBsock.Text;
                            (currentPart as MotherBoard).MemoryType = textBoxMBtypeMem.Text;
                            break;
                        case "RAM":
                            (currentPart as RAM).CapacityGB = int.Parse(textBoxRAMcap.Text);
                            (currentPart as RAM).Type = textBoxRAMtype.Text;
                            (currentPart as RAM).SpeedMHz = int.Parse(textBoxRAMspeed.Text);
                            break;
                        case "Видеокарта":
                            (currentPart as VideoCard).Chipset = textBoxVCchip.Text;
                            (currentPart as VideoCard).Interface = textBoxVCinterf.Text;
                            (currentPart as VideoCard).MemoryType = textBoxVCmemType.Text;
                            (currentPart as VideoCard).MemorySize = int.Parse(textBoxVCmemSize.Text);
                            break;
                        case "Захранване":
                            (currentPart as PSU).FormFactor = textBoxPSUform.Text;
                            (currentPart as PSU).PowerW = int.Parse(textBoxPSUpower.Text);
                            (currentPart as PSU).EffectivnesPercent = int.Parse(textBoxPSUeffic.Text);
                            (currentPart as PSU).FanSizeMM = int.Parse(textBoxPSUfanSize.Text);
                            (currentPart as PSU).Dimensions = Dimensions.Parse(textBoxPSUdim.Text);
                         break;
                        case "Твърд диск":
                            (currentPart as HDD).CapacityGB = int.Parse(textBoxHDDcap.Text);
                            (currentPart as HDD).Interface = textBoxHDDinterf.Text;
                            (currentPart as HDD).FormFactorInch = double.Parse(textBoxHDDform.Text);
                            (currentPart as HDD).RPM = int.Parse(textBoxHDDrpm.Text);
                            (currentPart as HDD).MaxTransferRateGBs = int.Parse(textBoxHDDmtr.Text);
                            (currentPart as HDD).CacheMB = int.Parse(textBoxHDDcache.Text);
                            (currentPart as HDD).IsPortable = checkBoxHDDportable.Checked;
                            break;
                        case "SSD":
                            (currentPart as SSD).CapacityGB = int.Parse(textBoxSSDcap.Text);
                            (currentPart as SSD).Interface = textBoxSSDinterf.Text;
                            (currentPart as SSD).Controller = textBoxSSDcontr.Text;
                            (currentPart as SSD).FormFactorInch = double.Parse(textBoxSSDform.Text);
                            (currentPart as SSD).MaxReadMBs = int.Parse(textBoxSSDmrs.Text);
                            (currentPart as SSD).MaxWriteMBs = int.Parse(textBoxSSDmws.Text);
                            (currentPart as SSD).IsPortable = checkBoxSSDportable.Checked;
                            break;
                        case "Кутия":
                            (currentPart as Case).FormFactor = textBoxCaseForm.Text;
                            (currentPart as Case).Dimensions = Dimensions.Parse(textBoxCaseDim.Text);
                            (currentPart as Case).NumOfDriveBays = int.Parse(textBoxCaseDiskSlots.Text);
                            (currentPart as Case).NumOfSlots = int.Parse(textBoxCaseSock.Text);
                            (currentPart as Case).MaxNumOfFans = int.Parse(textBoxCaseMaxNumFans.Text);
                            (currentPart as Case).SupportsLiquidCooling = checkBoxLiquidCool.Checked;
                            break;
                        case "Монитор":
                            (currentPart as Monitor).SizeInch = double.Parse(textBoxMonSize.Text);
                            (currentPart as Monitor).ScreenType = textBoxMonTypeScreen.Text;
                            (currentPart as Monitor).PanelType = textBoxMonPanType.Text;
                            (currentPart as Monitor).Resolution = textBoxMonRes.Text;
                            (currentPart as Monitor).WeightGrams = double.Parse(textBoxMonWeight.Text);
                            (currentPart as Monitor).Dimensions = Dimensions.Parse(textBoxMonDim.Text);
                            (currentPart as Monitor).IsWireless = checkBoxMonWireless.Checked;
                            (currentPart as Monitor).Color = (Color)comboBoxMonitorColor.SelectedValue;
                            break;
                        case "Мишка":
                            (currentPart as Mouse).Type = textBoxMouseType.Text;
                            (currentPart as Mouse).Sensor = textBoxMouseSensor.Text;
                            (currentPart as Mouse).DPI = int.Parse(textBoxMouseDPI.Text);
                            (currentPart as Mouse).NumOfButtons = int.Parse(textBoxMouseNumButtons.Text);
                            (currentPart as Mouse).WeightGrams = int.Parse(textBoxMonWeight.Text);
                            (currentPart as Mouse).Dimensions = Dimensions.Parse(textBoxMouseDim.Text);
                            (currentPart as Mouse).IsWireless = checkBoxMouseIsWireless.Checked;
                            (currentPart as Mouse).Color = (Color)comboBoxMouseColor.SelectedValue;
                            break;
                        case "Клавиатура":
                            (currentPart as Keyboard).FormFactor = textBoxKeyboardForm.Text;
                            (currentPart as Keyboard).KeysType = textBoxKeyboardKeyType.Text;
                            (currentPart as Keyboard).Layout = textBoxKeyboardLayout.Text;
                            (currentPart as Keyboard).Localisation = textBoxKeyboardLoc.Text;
                            (currentPart as Keyboard).PollingRateHz = int.Parse(textBoxKeryboardPolling.Text);
                            (currentPart as Keyboard).WeightGrams = int.Parse(textBoxKeyboardWeight.Text);
                            (currentPart as Keyboard).Dimensions = Dimensions.Parse(textBoxKeyboardDim.Text);
                            (currentPart as Keyboard).IsWireless = checkBoxKeyboardIsWireless.Checked;
                            (currentPart as Keyboard).Color = (Color)comboBoxKeyboardColor.SelectedValue;
                            break;
                        case "Тонколони":
                            (currentPart as Speakers).Type = double.Parse(textBoxSpeakersType.Text);
                            (currentPart as Speakers).TotalRMSPowerWatts = double.Parse(textBoxSpeakersPower.Text);
                            (currentPart as Speakers).FrequencyResponse = textBoxSpeakersFreq.Text;
                            (currentPart as Speakers).WeightGrams = int.Parse(textBoxSpeakersWeight.Text);
                            (currentPart as Speakers).Dimensions = Dimensions.Parse(textBoxSpeakersDim.Text);
                            (currentPart as Speakers).IsWireless = checkBoxSpeakersIsWireless.Checked;
                            (currentPart as Speakers).Color = (Color)comboBoxSpeakersColor.SelectedValue;
                        break;
                        default:
                            break;
                    }
                    // Save parts after edit
                    Items.SaveItems();
                    changeIsMade = true;
                    var currentIndex = comboBoxParts.SelectedIndex;
                    comboBoxParts.Items.Clear();
                    // Refresh comboBox with parts
                    foreach (var item in Items.AllParts.Where(x => x.GetType() == currentPart.GetType()).OrderBy(x => x.Price)) comboBoxParts.Items.Add(item);
                    comboBoxParts.SelectedIndex = currentIndex;
                    MessageBox.Show("Частта е променена успешо.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable default part characteristic
            foreach (var control in tableLayoutMainChar.Controls) (control as Control).Enabled = true;

            //Enable and populate fields with selected part characteristics
            currentPart = comboBoxParts.SelectedItem as Part;
            textBoxMF.Text = currentPart.Manufacturer;
            textBoxName.Text = currentPart.Name;
            textBoxModel.Text = currentPart.Model;
            textBoxPrice.Text = currentPart.Price.ToString();
            textBoxURL.Text = currentPart.URL;
            pictureBox1.ImageLocation = currentPart.PictureURL;

            switch(currentPart.GetType().Name)
            {
                case "CPU":
                    foreach (var control in tableLayoutCPU.Controls) (control as Control).Enabled = true;

                    textBoxFreq.Text = (currentPart as CPU).FrequencyGHz.ToString();
                    textBoxCores.Text = (currentPart as CPU).NumOfCores.ToString();
                    textBoxArch.Text = (currentPart as CPU).Architecture;
                    textBoxTech.Text = (currentPart as CPU).Technology;
                    textBoxSegm.Text = (currentPart as CPU).Segment;
                    textBoxCache.Text = (currentPart as CPU).CacheMB.ToString();
                    break;
                case "MotherBoard":
                    foreach (var control in tableLayoutMB.Controls) (control as Control).Enabled = true;

                    textBoxMBform.Text = (currentPart as MotherBoard).FormFactor;
                    textBoxMBchip.Text = (currentPart as MotherBoard).Chipset;
                    textBoxMBsock.Text = (currentPart as MotherBoard).CPU_Socket;
                    textBoxMBtypeMem.Text = (currentPart as MotherBoard).MemoryType;
                    break;
                case "RAM":
                    foreach (var control in tableLayoutRAM.Controls) (control as Control).Enabled = true;

                    textBoxRAMcap.Text = (currentPart as RAM).CapacityGB.ToString();
                    textBoxRAMspeed.Text = (currentPart as RAM).SpeedMHz.ToString();
                    textBoxRAMtype.Text = (currentPart as RAM).Type;
                    break;
                case "VideoCard":
                    foreach (var control in tableLayoutVC.Controls) (control as Control).Enabled = true;

                    textBoxVCchip.Text = (currentPart as VideoCard).Chipset;
                    textBoxVCinterf.Text = (currentPart as VideoCard).Interface;
                    textBoxVCmemSize.Text = (currentPart as VideoCard).MemorySize.ToString();
                    textBoxVCmemType.Text = (currentPart as VideoCard).MemoryType;
                    break;
                case "PSU":
                    foreach (var control in tableLayoutPSU.Controls) (control as Control).Enabled = true;

                    textBoxPSUform.Text = (currentPart as PSU).FormFactor;
                    textBoxPSUpower.Text = (currentPart as PSU).PowerW.ToString();
                    textBoxPSUeffic.Text = (currentPart as PSU).EffectivnesPercent.ToString();
                    textBoxPSUfanSize.Text = (currentPart as PSU).FanSizeMM.ToString();
                    textBoxPSUdim.Text = (currentPart as PSU).Dimensions.ToString();
                    break;
                case "SSD":
                    foreach (var control in tableLayoutSSD.Controls) (control as Control).Enabled = true;

                    textBoxSSDcap.Text = (currentPart as SSD).CapacityGB.ToString();
                    textBoxSSDinterf.Text = (currentPart as SSD).Interface;
                    textBoxSSDcontr.Text = (currentPart as SSD).Controller;
                    textBoxSSDform.Text = (currentPart as SSD).FormFactorInch.ToString();
                    textBoxSSDmrs.Text = (currentPart as SSD).MaxReadMBs.ToString();
                    textBoxSSDmws.Text = (currentPart as SSD).MaxWriteMBs.ToString();
                    checkBoxSSDportable.Checked = (currentPart as SSD).IsPortable;
                    break;
                case "HDD":
                    foreach (var control in tableLayoutHDD.Controls) (control as Control).Enabled = true;

                    textBoxHDDcap.Text = (currentPart as HDD).CapacityGB.ToString();
                    textBoxHDDinterf.Text = (currentPart as HDD).Interface;
                    textBoxHDDform.Text = (currentPart as HDD).FormFactorInch.ToString();
                    textBoxHDDrpm.Text = (currentPart as HDD).RPM.ToString();
                    textBoxHDDmtr.Text = (currentPart as HDD).MaxTransferRateGBs.ToString();
                    textBoxHDDcache.Text = (currentPart as HDD).CacheMB.ToString();
                    checkBoxHDDportable.Checked = (currentPart as HDD).IsPortable;
                    break;
                case "Case":
                    foreach (var control in tableLayoutCase.Controls) (control as Control).Enabled = true;

                    textBoxCaseForm.Text = (currentPart as Case).FormFactor;
                    textBoxCaseDim.Text = (currentPart as Case).Dimensions.ToString();
                    textBoxCaseDiskSlots.Text = (currentPart as Case).NumOfDriveBays.ToString();
                    textBoxCaseSock.Text = (currentPart as Case).NumOfSlots.ToString();
                    textBoxCaseMaxNumFans.Text = (currentPart as Case).MaxNumOfFans.ToString();
                    checkBoxLiquidCool.Checked = (currentPart as Case).SupportsLiquidCooling;
                    break;
                case "Monitor":
                    foreach (var control in tableLayoutMonitor.Controls) (control as Control).Enabled = true;

                    textBoxMonSize.Text = (currentPart as Monitor).SizeInch.ToString();
                    textBoxMonTypeScreen.Text = (currentPart as Monitor).ScreenType;
                    textBoxMonPanType.Text = (currentPart as Monitor).PanelType;
                    textBoxMonRes.Text = (currentPart as Monitor).Resolution;
                    textBoxMonWeight.Text = (currentPart as Monitor).WeightGrams.ToString();
                    textBoxMonDim.Text = (currentPart as Monitor).Dimensions.ToString();
                    checkBoxMonWireless.Checked = (currentPart as Monitor).IsWireless;
                    comboBoxMonitorColor.SelectedValue = (currentPart as Monitor).Color;
                    break;
                case "Mouse":
                    foreach (var control in tableLayoutMouse.Controls) (control as Control).Enabled = true;

                    textBoxMouseType.Text = (currentPart as Mouse).Type;
                    textBoxMouseSensor.Text = (currentPart as Mouse).Sensor;
                    textBoxMouseDPI.Text = (currentPart as Mouse).DPI.ToString();
                    textBoxMouseNumButtons.Text = (currentPart as Mouse).NumOfButtons.ToString();
                    textBoxMouseWeight.Text = (currentPart as Mouse).WeightGrams.ToString();
                    textBoxMouseDim.Text = (currentPart as Mouse).Dimensions.ToString();
                    checkBoxMouseIsWireless.Checked = (currentPart as Mouse).IsWireless;
                    comboBoxMouseColor.SelectedValue = (currentPart as Mouse).Color;
                    break;
                case "Keyboard":
                    foreach (var control in tableLayoutKeyboard.Controls) (control as Control).Enabled = true;

                    textBoxKeyboardForm.Text = (currentPart as Keyboard).FormFactor;
                    textBoxKeyboardKeyType.Text = (currentPart as Keyboard).KeysType;
                    textBoxKeyboardLayout.Text = (currentPart as Keyboard).Layout;
                    textBoxKeyboardLoc.Text = (currentPart as Keyboard).Localisation;
                    textBoxKeryboardPolling.Text = (currentPart as Keyboard).PollingRateHz.ToString();
                    textBoxKeyboardWeight.Text = (currentPart as Keyboard).WeightGrams.ToString();
                    textBoxKeyboardDim.Text = (currentPart as Keyboard).Dimensions.ToString();
                    checkBoxKeyboardIsWireless.Checked = (currentPart as Keyboard).IsWireless;
                    comboBoxKeyboardColor.SelectedValue = (currentPart as Keyboard).Color;
                    break;
                case "Speakers":
                    foreach (var control in tableLayoutSpeakers.Controls) (control as Control).Enabled = true;

                    textBoxSpeakersType.Text = (currentPart as Speakers).Type.ToString();
                    textBoxSpeakersPower.Text = (currentPart as Speakers).TotalRMSPowerWatts.ToString();
                    textBoxSpeakersFreq.Text = (currentPart as Speakers).FrequencyResponse;
                    textBoxSpeakersWeight.Text = (currentPart as Speakers).WeightGrams.ToString();
                    textBoxSpeakersDim.Text = (currentPart as Speakers).Dimensions.ToString();
                    checkBoxSpeakersIsWireless.Checked = (currentPart as Speakers).IsWireless;
                    comboBoxSpeakersColor.SelectedValue = (currentPart as Speakers).Color;
                    break;
                default:
                    throw new Exception($"Error");
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
            if (comboBoxParts.SelectedIndex != -1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var result = openPicDialog.ShowDialog();
                    if (result == DialogResult.OK) pictureBox1.ImageLocation = openPicDialog.FileName;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    currentPart.ViewPicture();
                }
            }
        }
    }
}
