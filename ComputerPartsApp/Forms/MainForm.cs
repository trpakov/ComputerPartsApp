using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public partial class MainForm : Form
    {
        private Computer currentComputer;
        internal bool LoggedIn { get; set; } = false;
        private StatsForm statsForm;

        // MainForm Constructor
        public MainForm()
        {
            Items.LoadItems();
            DebugFile.StartDebbuging();

            InitializeComponent();
            // Subscribe to ApplicationExit event
            Application.ApplicationExit += Application_ApplicationExit;
            // Initialize CefSharp
            InitializeChromium();
            // Initialize MainForm comboboxes
            ComboBoxInitializer();
            // Initialize ToolTips
            InitializeToolTips();

            currentComputer = new Computer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //InitializeChromium();
            //ComboBoxInitializer();
            //Items.AllParts.Find(x => x.GetType() == typeof(CPU)).GetPartInfo();
            //ToolTip tt = new ToolTip();
            //tt.SetToolTip(labelCPU, Items.AllParts.Find(x => x is CPU).GetPartInfo());
            //tt.SetToolTip(labelMB, Items.AllParts.Find(x => x is MotherBoard).GetPartInfo());
            //tt.SetToolTip(labelRAM, Items.AllParts.Find(x => x is RAM).GetPartInfo());
            //tt.SetToolTip(labelVC, Items.AllParts.Find(x => x is VideoCard).GetPartInfo());
            //tt.SetToolTip(labelPSU, Items.AllParts.Find(x => x is PSU).GetPartInfo());
            //tt.SetToolTip(labelDrive, Items.AllParts.Find(x => x is Drive).GetPartInfo());
            //tt.SetToolTip(labelCase, Items.AllParts.Find(x => x is Case).GetPartInfo());
            //tt.SetToolTip(labelMonitor, Items.AllParts.Find(x => x is Monitor).GetPartInfo());      
            //tt.SetToolTip(labelMouse, Items.AllParts.Find(x => x is Mouse).GetPartInfo());
            //tt.SetToolTip(labelKeyboard, Items.AllParts.Find(x => x is Keyboard).GetPartInfo());
            //tt.SetToolTip(labelSpeakers, Items.AllParts.Find(x => x is Speakers).GetPartInfo());

            //currentComputer = new Computer();
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            currentComputer.ForgetAbout();

            Items.SaveItems();
            // Shutdown CefSharp
            Cef.ShutdownWithoutChecks();
            // Unsubscribe from ApplicationExit event
            Application.ApplicationExit -= Application_ApplicationExit;
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }

        public void InitializeToolTips()
        {
            ToolTip tt = new ToolTip();

            tt.SetToolTip(labelCPU, Items.AllParts.Find(x => x is CPU).GetPartInfo());
            tt.SetToolTip(labelMB, Items.AllParts.Find(x => x is MotherBoard).GetPartInfo());
            tt.SetToolTip(labelRAM, Items.AllParts.Find(x => x is RAM).GetPartInfo());
            tt.SetToolTip(labelVC, Items.AllParts.Find(x => x is VideoCard).GetPartInfo());
            tt.SetToolTip(labelPSU, Items.AllParts.Find(x => x is PSU).GetPartInfo());
            tt.SetToolTip(labelDrive, Items.AllParts.Find(x => x is Drive).GetPartInfo());
            tt.SetToolTip(labelCase, Items.AllParts.Find(x => x is Case).GetPartInfo());
            tt.SetToolTip(labelMonitor, Items.AllParts.Find(x => x is Monitor).GetPartInfo());      
            tt.SetToolTip(labelMouse, Items.AllParts.Find(x => x is Mouse).GetPartInfo());
            tt.SetToolTip(labelKeyboard, Items.AllParts.Find(x => x is Keyboard).GetPartInfo());
            tt.SetToolTip(labelSpeakers, Items.AllParts.Find(x => x is Speakers).GetPartInfo());
            tt.SetToolTip(btnCoupon, "Валиден само при текуща покупка (взимане на разписка)");
        }

        private void ComboBoxInitializer()
        {
            foreach (var comboBox in tableLayoutFields.Controls.OfType<ComboBox>()) comboBox.Items.Clear();

            comboBoxCPU.Items.AddRange((from part in Items.AllParts where part is CPU select part).OrderBy(x => x.Price).ToArray());
            comboBoxMB.Items.AddRange((from part in Items.AllParts where part is MotherBoard select part).OrderBy(x => x.Price).ToArray());
            comboBoxRAM.Items.AddRange((from part in Items.AllParts where part is RAM select part).OrderBy(x => x.Price).ToArray());
            comboBoxVC.Items.AddRange((from part in Items.AllParts where part is VideoCard select part).OrderBy(x => x.Price).ToArray());
            comboBoxPSU.Items.AddRange((from part in Items.AllParts where part is PSU select part).OrderBy(x => x.Price).ToArray());
            comboBoxDrive.Items.AddRange((from part in Items.AllParts where part is Drive select part).OrderBy(x => x.Price).ToArray());
            comboBoxCase.Items.AddRange((from part in Items.AllParts where part is Case select part).OrderBy(x => x.Price).ToArray());
            comboBoxMonitor.Items.AddRange((from part in Items.AllParts where part is Monitor select part).OrderBy(x => x.Price).ToArray());
            comboBoxMouse.Items.AddRange((from part in Items.AllParts where part is Mouse select part).OrderBy(x => x.Price).ToArray());
            comboBoxKeyboard.Items.AddRange((from part in Items.AllParts where part is Keyboard select part).OrderBy(x => x.Price).ToArray());
            comboBoxSpeakers.Items.AddRange((from part in Items.AllParts where part is Speakers select part).OrderBy(x => x.Price).ToArray());
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            if (currentComputer.Count == 0)
            {
                MessageBox.Show("Моля, изберете поне една част!", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult couponDialogResult = MessageBox.Show("След прилагане на код за отстъпка няма да може да редактирате текущата конфигурация.\n\nИскате ли да продължите?", "Код за отстъпка", MessageBoxButtons.YesNo, MessageBoxIcon.Question , MessageBoxDefaultButton.Button2);

            if (couponDialogResult == DialogResult.Yes)
            {
                //// Disable MainForm comboboxes
                //FieldsDisabler();

                // Get currentComputer price
                lblPriceNum.Text = currentComputer.Price.ToString("C");

                var couponForm = new CouponForm(currentComputer);
                var couponFormDialogResult = couponForm.ShowDialog();
                
                if(couponFormDialogResult == DialogResult.OK)
                {
                    // Disable MainForm comboboxes
                    FieldsDisabler();
                    // Show price info
                    lblPrice.Visible = true;
                    lblPriceNum.Visible = true;
                    lblPromoPrice.Visible = true;
                    lblPromoPriceNum.Text = currentComputer.Price.ToString("C");
                    lblPromoPriceNum.Visible = true;
                    // Disable Coupon and Show price buttons
                    btnCoupon.Enabled = false;
                    btnShowPrice.Enabled = false;

                    // Create timer (0,5n sec)
                    System.Timers.Timer timer = new System.Timers.Timer(500);
                    // Subscribe to timer.Elapsed event
                    timer.Elapsed += ColorChanger;
                    // Start the timer;
                    timer.Start();
                }

            }
        }

        // Disables MainForm comboboxes
        private void FieldsDisabler()
        {
            comboBoxCPU.Enabled = false;
            comboBoxMB.Enabled = false;
            comboBoxRAM.Enabled = false;
            comboBoxVC.Enabled = false;
            comboBoxPSU.Enabled = false;
            comboBoxDrive.Enabled = false;
            comboBoxCase.Enabled = false;
            comboBoxMonitor.Enabled = false;
            comboBoxMouse.Enabled = false;
            comboBoxKeyboard.Enabled = false;
            comboBoxSpeakers.Enabled = false;
           
        }

        // Enables MainForm comboboxes
        private void FieldsEnabler()
        {
            comboBoxCPU.Enabled = true;
            comboBoxMB.Enabled = true;
            comboBoxRAM.Enabled = true;
            comboBoxVC.Enabled = true;
            comboBoxPSU.Enabled = true;
            comboBoxDrive.Enabled = true;
            comboBoxCase.Enabled = true;
            comboBoxMonitor.Enabled = true;
            comboBoxMouse.Enabled = true;
            comboBoxKeyboard.Enabled = true;
            comboBoxSpeakers.Enabled = true;
           
        }

        // Disables MainForm Info and Image buttons for all comboboxes
        private void ButtonDisabler()
        {
            tableLayoutFields.Controls.OfType<Button>().ToList().ForEach(x => x.Enabled = false);
        }

        // Creates new Computer using selected parts and assigns it to currentComputer variable
        internal Computer InitializeConfiguration()
        {
            var comboBoxes = tableLayoutFields.Controls.OfType<ComboBox>();
            var selectedParts = from comboBox in comboBoxes where comboBox.SelectedItem != null select comboBox.SelectedItem as Part;
            var currentComputer = new Computer(selectedParts.ToArray());
            return currentComputer;
        }

        // Changes Promo price color
        internal void ColorChanger(object sender, EventArgs e)
        {
            var color = lblPromoPriceNum.ForeColor;
            if (lblPromoPriceNum.ForeColor == System.Drawing.Color.Black)
            {
                lblPromoPriceNum.ForeColor = System.Drawing.Color.Red;
                lblPromoPrice.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPromoPriceNum.ForeColor = System.Drawing.Color.Black;
                lblPromoPrice.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        bool WorkingWithLoadedComputerFlag = false;

        #region Field Selection Change

        private void comboBoxCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(currentComputer[typeof(CPU)] != null) currentComputer.RemovePart(currentComputer[typeof(CPU)]);
            if(comboBoxCPU.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxCPU.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnCPUweb.Enabled = true;
            btnCPUpic.Enabled = true;
        }

        private void comboBoxMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(currentComputer[typeof(MotherBoard)] != null) currentComputer.RemovePart(currentComputer[typeof(MotherBoard)]);
            if(comboBoxMB.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxMB.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnMBweb.Enabled = true;
            btnMBpic.Enabled = true;
        }

        private void comboBoxRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(currentComputer[typeof(RAM)] != null) currentComputer.RemovePart(currentComputer[typeof(RAM)]);
            if(comboBoxRAM.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxRAM.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnRAMweb.Enabled = true;
            btnRAMpic.Enabled = true;
        }

        private void comboBoxVC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(VideoCard)] != null) currentComputer.RemovePart(currentComputer[typeof(VideoCard)]);
            if(comboBoxVC.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxVC.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnVCweb.Enabled = true;
            btnVCpic.Enabled = true;
        }

        private void comboBoxPSU_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(PSU)] != null) currentComputer.RemovePart(currentComputer[typeof(PSU)]);
            if(comboBoxPSU.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxPSU.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnPSUweb.Enabled = true;
            btnPSUpic.Enabled = true;
        }

        private void comboBoxDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(Drive)] != null) currentComputer.RemovePart(currentComputer[typeof(Drive)]);
            if(comboBoxDrive.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxDrive.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnDriveWeb.Enabled = true;
            btnDrivePic.Enabled = true;
        }

        private void comboBoxCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(Case)] != null) currentComputer.RemovePart(currentComputer[typeof(Case)]);
            if(comboBoxCase.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxCase.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnCaseWeb.Enabled = true;
            btnCasePic.Enabled = true;
        }

        private void comboBoxMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(Monitor)] != null) currentComputer.RemovePart(currentComputer[typeof(Monitor)]);
            if(comboBoxMonitor.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxMonitor.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnMonitorWeb.Enabled = true;
            btnMonitorPic.Enabled = true;
        }

        private void comboBoxMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(Mouse)] != null) currentComputer.RemovePart(currentComputer[typeof(Mouse)]);
            if(comboBoxMouse.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxMouse.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnMouseWeb.Enabled = true;
            btnMousePic.Enabled = true;
        }

        private void comboBoxKeyboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(Keyboard)] != null) currentComputer.RemovePart(currentComputer[typeof(Keyboard)]);
            if(comboBoxKeyboard.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxKeyboard.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnKeyboardWeb.Enabled = true;
            btnKeyboardPic.Enabled = true;
        }

        private void comboBoxSpeakers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currentComputer[typeof(Speakers)] != null) currentComputer.RemovePart(currentComputer[typeof(Speakers)]);
            if(comboBoxSpeakers.SelectedIndex != -1 && !WorkingWithLoadedComputerFlag) currentComputer.AddPart((comboBoxSpeakers.SelectedItem as Part));
            statsForm?.StatsFormSetCurrentComputer(currentComputer);
            btnSpeakersWeb.Enabled = true;
            btnSpeakersPic.Enabled = true;
        }
        #endregion

        #region Info button click
        private void btnCPUweb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxCPU.SelectedItem as Part).URL, (comboBoxCPU.SelectedItem as Part).ToString()).ShowDialog();
        private void btnMBweb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxMB.SelectedItem as Part).URL, (comboBoxMB.SelectedItem as Part).ToString()).ShowDialog();
        private void btnRAMweb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxRAM.SelectedItem as Part).URL, (comboBoxRAM.SelectedItem as Part).ToString()).ShowDialog();
        private void btnVCweb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxVC.SelectedItem as Part).URL, (comboBoxVC.SelectedItem as Part).ToString()).ShowDialog();
        private void btnPSUweb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxPSU.SelectedItem as Part).URL, (comboBoxPSU.SelectedItem as Part).ToString()).ShowDialog();
        private void btnDriveWeb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxDrive.SelectedItem as Part).URL, (comboBoxDrive.SelectedItem as Part).ToString()).ShowDialog();
        private void btnCaseWeb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxCase.SelectedItem as Part).URL, (comboBoxCase.SelectedItem as Part).ToString()).ShowDialog();
        private void btnMonitorWeb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxMonitor.SelectedItem as Part).URL, (comboBoxMonitor.SelectedItem as Part).ToString()).ShowDialog();
        private void btnMouseWeb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxMouse.SelectedItem as Part).URL, (comboBoxMouse.SelectedItem as Part).ToString()).ShowDialog();
        private void btnKeyboardWeb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxKeyboard.SelectedItem as Part).URL, (comboBoxKeyboard.SelectedItem as Part).ToString()).ShowDialog();
        private void btnSpeakersWeb_Click(object sender, EventArgs e) => new ChromiumForm((comboBoxSpeakers.SelectedItem as Part).URL, (comboBoxSpeakers.SelectedItem as Part).ToString()).ShowDialog();

        // Deprecated
        //private void btnCPUweb_Click(object sender, EventArgs e) => (comboBoxCPU.SelectedItem as Part).ViewPicture();
        //private void btnMBweb_Click(object sender, EventArgs e) => (comboBoxMB.SelectedItem as Part).ViewInBrowser();
        //private void btnRAMweb_Click(object sender, EventArgs e) => (comboBoxRAM.SelectedItem as Part).ViewInBrowser();
        //private void btnVCweb_Click(object sender, EventArgs e) => (comboBoxVC.SelectedItem as Part).ViewInBrowser();
        //private void btnPSUweb_Click(object sender, EventArgs e) => (comboBoxPSU.SelectedItem as Part).ViewInBrowser();
        //private void btnDriveWeb_Click(object sender, EventArgs e) => (comboBoxDrive.SelectedItem as Part).ViewInBrowser();
        //private void btnCaseWeb_Click(object sender, EventArgs e) => (comboBoxCase.SelectedItem as Part).ViewInBrowser();
        //private void btnMonitorWeb_Click(object sender, EventArgs e) => (comboBoxMonitor.SelectedItem as Part).ViewInBrowser();
        //private void btnMouseWeb_Click(object sender, EventArgs e) => (comboBoxMouse.SelectedItem as Part).ViewInBrowser();
        //private void btnKeyboardWeb_Click(object sender, EventArgs e) => (comboBoxKeyboard.SelectedItem as Part).ViewInBrowser();
        //private void btnSpeakersWeb_Click(object sender, EventArgs e) => (comboBoxSpeakers.SelectedItem as Part).ViewInBrowser();
        #endregion

        #region Pic button click
        private void btnCPUpic_Click(object sender, EventArgs e) => (comboBoxCPU.SelectedItem as Part).ViewPicture();
        private void btnMBpic_Click(object sender, EventArgs e) => (comboBoxMB.SelectedItem as Part).ViewPicture();
        private void btnRAMpic_Click(object sender, EventArgs e) => (comboBoxRAM.SelectedItem as Part).ViewPicture();
        private void btnVCpic_Click(object sender, EventArgs e) => (comboBoxVC.SelectedItem as Part).ViewPicture();
        private void btnPSUpic_Click(object sender, EventArgs e) => (comboBoxPSU.SelectedItem as Part).ViewPicture();
        private void btnDrivePic_Click(object sender, EventArgs e) => (comboBoxDrive.SelectedItem as Part).ViewPicture();
        private void btnCasePic_Click(object sender, EventArgs e) => (comboBoxCase.SelectedItem as Part).ViewPicture();
        private void btnMonitorPic_Click(object sender, EventArgs e) => (comboBoxMonitor.SelectedItem as Part).ViewPicture();
        private void btnMousePic_Click(object sender, EventArgs e) => (comboBoxMouse.SelectedItem as Part).ViewPicture();
        private void btnKeyboardPic_Click(object sender, EventArgs e) => (comboBoxKeyboard.SelectedItem as Part).ViewPicture();
        private void btnSpeakersPic_Click(object sender, EventArgs e) => (comboBoxSpeakers.SelectedItem as Part).ViewPicture();
        #endregion

        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            // Get and show currentComputer price
            lblPrice.Visible = true;
            lblPriceNum.Text = currentComputer.Price.ToString("C");
            lblPriceNum.Visible = true;
        }

        private void ReturnComboboxToDefaultState()
        {
            var comboBoxes = tableLayoutFields.Controls.OfType<ComboBox>();
            foreach (var comboBox in comboBoxes) comboBox.SelectedIndex = -1;
        }

        // Resets the Main Form
        private void FormReset()
        {
            FieldsEnabler();
            ReturnComboboxToDefaultState();
            ButtonDisabler();
            btnShowPrice.Enabled = true;
            btnCoupon.Enabled = true;
            currentComputer.ForgetAbout();

            // Hide computer price
            lblPrice.Visible = false;
            lblPriceNum.Visible = false;
            lblPromoPrice.Visible = false;
            lblPromoPriceNum.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;

            if(!currentComputer.SavedToFile && currentComputer.Count != 0) result = MessageBox.Show("На път сте да създадете нова конфигурация, без да сте записали текущата. Искате ли да продължите?", "Нова конфигурация", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes || result == DialogResult.None)
            {
                FormReset();
                currentComputer = new Computer();
                statsForm?.StatsFormSetCurrentComputer(currentComputer);
            }
          
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            DialogResult areYouSureResult = DialogResult.None;

            if (!currentComputer.SavedToFile && currentComputer.Count != 0) areYouSureResult = MessageBox.Show("На път сте да променяте наличните части, без да сте записали текущата конфигурация. Искате ли да продължите?", "Добавяне на част", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (!LoggedIn && (areYouSureResult == DialogResult.Yes || areYouSureResult == DialogResult.None))
            {
                var loginForm = new LoginForm();
                var loginFormResult = loginForm.ShowDialog();
                if (loginFormResult == DialogResult.Yes)
                {
                    LoggedIn = true;
                    var addPartForm = new AddPartForm();
                    var addPartFormResult = addPartForm.ShowDialog();
                    if (addPartFormResult == DialogResult.OK)
                    {
                        ComboBoxInitializer();
                        FormReset();
                        currentComputer = new Computer();
                        statsForm?.StatsFormSetCurrentComputer(currentComputer);
                    }

                }
            }
            else if(areYouSureResult == DialogResult.Yes || areYouSureResult == DialogResult.None)
            {
                var addPartForm = new AddPartForm();
                var addPartFormResult = addPartForm.ShowDialog();
                if (addPartFormResult == DialogResult.OK)
                {
                    ComboBoxInitializer();
                    FormReset();
                    currentComputer = new Computer();
                    statsForm?.StatsFormSetCurrentComputer(currentComputer);
                }
            }

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            statsForm = new StatsForm(currentComputer);
            if (currentComputer.Count != 0) statsForm.Show();
            else MessageBox.Show("Моля, изберете поне една част!", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnGetReceipt_Click(object sender, EventArgs e)
        {
            if (currentComputer.Count == 0)
            {
                MessageBox.Show("Моля, изберете поне една част!", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetReceiptDialog.FileName = $"receipt{currentComputer.ID}";
            GetReceiptDialog.Filter = "Текстов документ (*.txt)|*.txt";
            var result = GetReceiptDialog.ShowDialog();
            if (result == DialogResult.OK) currentComputer.SaveToReceipt(GetReceiptDialog.FileName);
        }

        private void btnSavePC_Click(object sender, EventArgs e)
        {
            if (currentComputer.Count == 0)
            {
                MessageBox.Show("Моля, изберете поне една част.", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SavePCDialog.FileName = $"{currentComputer.GetHashCode()}";
            var result = SavePCDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Items.LoadedComputer = currentComputer.ToList();
                Items.SaveComputer(SavePCDialog.FileName);
                currentComputer.SavedToFile = true;
            }
        }

        private void btnLoadPC_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;

            if (!currentComputer.SavedToFile && currentComputer.Count != 0) result = MessageBox.Show("На път сте да създадете нова конфигурация, без да сте записали текущата. Искате ли да продължите?", "Нова конфигурация", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes || result == DialogResult.None)
            {
                var loadPCdialogResult = LoadPCDialog.ShowDialog();
                if (loadPCdialogResult == DialogResult.OK)
                {
                    WorkingWithLoadedComputerFlag = true;
                    // Reset the MainForm
                    FormReset();

                    Items.LoadComputer(LoadPCDialog.FileName);
                    currentComputer = new Computer(Items.LoadedComputer);

                    // Check for missing parts
                    var intersect = currentComputer.Select(x => x.ToStringNoPrice()).Intersect(Items.AllParts.Select(x => x.ToStringNoPrice())).Count();
                    if (currentComputer.Count != intersect)
                    {
                        MessageBox.Show("Избраната конфигурация съдържа части, които не са налични в момента. Съжаляваме за причиненото неудобство.", "Липсващи части",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        currentComputer = new Computer();
                        statsForm?.StatsFormSetCurrentComputer(currentComputer);
                    }


                    // Display loaded computer parts
                    foreach (var combobox in tableLayoutFields.Controls.OfType<ComboBox>())
                    {
                        foreach (var item in combobox.Items)
                        {
                            if (currentComputer.Contains(item as Part))
                            {
                                combobox.SelectedItem = item;
                                break;
                            }
                        }
                    }

                    WorkingWithLoadedComputerFlag = false;
                    //foreach(var combobox in tableLayoutFields.Controls.OfType<ComboBox>().Where(x => x.SelectedIndex != -1 ))
                    //{
                    //    if (!currentComputer.Contains(combobox.SelectedItem as Part)) combobox.SelectedIndex = -1;
                    //}

                    currentComputer.SavedToFile = true;
                }

            }
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            DialogResult areYouSureResult = DialogResult.None;

            if (!currentComputer.SavedToFile && currentComputer.Count != 0) areYouSureResult = MessageBox.Show("На път сте да променяте наличните части, без да сте записали текущата конфигурация. Искате ли да продължите?", "Премахване на част", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (!LoggedIn && (areYouSureResult == DialogResult.Yes || areYouSureResult == DialogResult.None))
            {
                var loginForm = new LoginForm();
                var loginFormResult = loginForm.ShowDialog();
                if (loginFormResult == DialogResult.Yes)
                {
                    LoggedIn = true;
                    var removePartForm = new RemovePartForm();
                    var removePartFormResult = removePartForm.ShowDialog();
                    if (removePartFormResult == DialogResult.OK)
                    {
                        ComboBoxInitializer();
                        FormReset();
                        currentComputer = new Computer();
                        statsForm?.StatsFormSetCurrentComputer(currentComputer);
                    }

                }
            }
            else if(areYouSureResult == DialogResult.Yes || areYouSureResult == DialogResult.None)
            {
                var removePartForm = new RemovePartForm();
                var removePartFormResult = removePartForm.ShowDialog();
                if (removePartFormResult == DialogResult.OK)
                {
                    ComboBoxInitializer();
                    FormReset();
                    //ButtonDisabler();
                    currentComputer = new Computer();
                    statsForm?.StatsFormSetCurrentComputer(currentComputer);
                }
            }
        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            DialogResult areYouSureResult = DialogResult.None;

            if (!currentComputer.SavedToFile && currentComputer.Count != 0) areYouSureResult = MessageBox.Show("На път сте да променяте наличните части, без да сте записали текущата конфигурация. Искате ли да продължите?", "Променяне на част", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (!LoggedIn && (areYouSureResult == DialogResult.Yes || areYouSureResult == DialogResult.None))
            {
                var loginForm = new LoginForm();
                var loginFormResult = loginForm.ShowDialog();
                if (loginFormResult == DialogResult.Yes) 
                {
                    LoggedIn = true;
                    var editPartForm = new EditPartForm();
                    var editPartFormResult = editPartForm.ShowDialog();
                    if (editPartFormResult == DialogResult.OK)
                    {
                        ComboBoxInitializer();
                        FormReset();
                        currentComputer = new Computer();
                        statsForm?.StatsFormSetCurrentComputer(currentComputer);
                    }
                }
            }
            else if(areYouSureResult == DialogResult.Yes || areYouSureResult == DialogResult.None)
            {
                var editPartForm = new EditPartForm();
                var editPartFormResult = editPartForm.ShowDialog();
                if (editPartFormResult == DialogResult.OK)
                {
                    ComboBoxInitializer();
                    FormReset();
                    currentComputer = new Computer();
                    statsForm?.StatsFormSetCurrentComputer(currentComputer);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = DialogResult.None;

            if (!currentComputer.SavedToFile && currentComputer.Count != 0) result = MessageBox.Show("На път сте да затворите програмата, без да сте записали текущата конфигурация. Искате ли да продължите?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes || result == DialogResult.None) Close();
        }
    }
}
