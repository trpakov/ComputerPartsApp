namespace ComputerPartsApp
{
    partial class MainForm
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
            this.tableLayoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnGetReceipt = new System.Windows.Forms.Button();
            this.btnSavePC = new System.Windows.Forms.Button();
            this.btnLoadPC = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutFields = new System.Windows.Forms.TableLayoutPanel();
            this.btnPSUpic = new System.Windows.Forms.Button();
            this.btnVCpic = new System.Windows.Forms.Button();
            this.btnRAMpic = new System.Windows.Forms.Button();
            this.btnCPUpic = new System.Windows.Forms.Button();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelMB = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelVC = new System.Windows.Forms.Label();
            this.labelPSU = new System.Windows.Forms.Label();
            this.labelDrive = new System.Windows.Forms.Label();
            this.labelCase = new System.Windows.Forms.Label();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.labelMouse = new System.Windows.Forms.Label();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.labelSpeakers = new System.Windows.Forms.Label();
            this.comboBoxCPU = new System.Windows.Forms.ComboBox();
            this.comboBoxMB = new System.Windows.Forms.ComboBox();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.comboBoxVC = new System.Windows.Forms.ComboBox();
            this.comboBoxPSU = new System.Windows.Forms.ComboBox();
            this.comboBoxDrive = new System.Windows.Forms.ComboBox();
            this.comboBoxCase = new System.Windows.Forms.ComboBox();
            this.comboBoxMonitor = new System.Windows.Forms.ComboBox();
            this.comboBoxMouse = new System.Windows.Forms.ComboBox();
            this.comboBoxKeyboard = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeakers = new System.Windows.Forms.ComboBox();
            this.btnCPUweb = new System.Windows.Forms.Button();
            this.btnMBweb = new System.Windows.Forms.Button();
            this.btnRAMweb = new System.Windows.Forms.Button();
            this.btnVCweb = new System.Windows.Forms.Button();
            this.btnPSUweb = new System.Windows.Forms.Button();
            this.btnDriveWeb = new System.Windows.Forms.Button();
            this.btnCaseWeb = new System.Windows.Forms.Button();
            this.btnMonitorWeb = new System.Windows.Forms.Button();
            this.btnMouseWeb = new System.Windows.Forms.Button();
            this.btnKeyboardWeb = new System.Windows.Forms.Button();
            this.btnSpeakersWeb = new System.Windows.Forms.Button();
            this.btnMBpic = new System.Windows.Forms.Button();
            this.btnDrivePic = new System.Windows.Forms.Button();
            this.btnCasePic = new System.Windows.Forms.Button();
            this.btnMonitorPic = new System.Windows.Forms.Button();
            this.btnMousePic = new System.Windows.Forms.Button();
            this.btnKeyboardPic = new System.Windows.Forms.Button();
            this.btnSpeakersPic = new System.Windows.Forms.Button();
            this.tableLayoutPrice = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnShowPrice = new System.Windows.Forms.Button();
            this.lblPromoPrice = new System.Windows.Forms.Label();
            this.lblPriceNum = new System.Windows.Forms.Label();
            this.lblPromoPriceNum = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GetReceiptDialog = new System.Windows.Forms.SaveFileDialog();
            this.SavePCDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadPCDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutBase.SuspendLayout();
            this.tableLayoutButtons.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutFields.SuspendLayout();
            this.tableLayoutPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutBase
            // 
            this.tableLayoutBase.BackColor = System.Drawing.Color.Linen;
            this.tableLayoutBase.ColumnCount = 2;
            this.tableLayoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.50862F));
            this.tableLayoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.49138F));
            this.tableLayoutBase.Controls.Add(this.tableLayoutButtons, 1, 0);
            this.tableLayoutBase.Controls.Add(this.tableLayoutMain, 0, 0);
            this.tableLayoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutBase.Name = "tableLayoutBase";
            this.tableLayoutBase.RowCount = 1;
            this.tableLayoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBase.Size = new System.Drawing.Size(928, 610);
            this.tableLayoutBase.TabIndex = 0;
            // 
            // tableLayoutButtons
            // 
            this.tableLayoutButtons.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutButtons.ColumnCount = 1;
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutButtons.Controls.Add(this.btnClose, 0, 9);
            this.tableLayoutButtons.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutButtons.Controls.Add(this.btnStats, 0, 1);
            this.tableLayoutButtons.Controls.Add(this.btnCoupon, 0, 2);
            this.tableLayoutButtons.Controls.Add(this.btnAddPart, 0, 3);
            this.tableLayoutButtons.Controls.Add(this.btnRemovePart, 0, 8);
            this.tableLayoutButtons.Controls.Add(this.btnGetReceipt, 0, 4);
            this.tableLayoutButtons.Controls.Add(this.btnSavePC, 0, 5);
            this.tableLayoutButtons.Controls.Add(this.btnLoadPC, 0, 6);
            this.tableLayoutButtons.Controls.Add(this.btnEditPart, 0, 7);
            this.tableLayoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutButtons.Location = new System.Drawing.Point(787, 3);
            this.tableLayoutButtons.Name = "tableLayoutButtons";
            this.tableLayoutButtons.RowCount = 10;
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.Size = new System.Drawing.Size(138, 604);
            this.tableLayoutButtons.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(7, 547);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Изход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(7, 5);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 50);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Нова конфигурация";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStats
            // 
            this.btnStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStats.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStats.Location = new System.Drawing.Point(7, 65);
            this.btnStats.Margin = new System.Windows.Forms.Padding(0);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(124, 50);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Статистически данни";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoupon.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoupon.Location = new System.Drawing.Point(7, 125);
            this.btnCoupon.Margin = new System.Windows.Forms.Padding(0);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(124, 50);
            this.btnCoupon.TabIndex = 2;
            this.btnCoupon.Text = "Код за отстъпка";
            this.btnCoupon.UseVisualStyleBackColor = true;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoupon_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPart.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPart.Location = new System.Drawing.Point(7, 185);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(124, 50);
            this.btnAddPart.TabIndex = 3;
            this.btnAddPart.Text = "Добави част";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemovePart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemovePart.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemovePart.Location = new System.Drawing.Point(7, 485);
            this.btnRemovePart.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(124, 50);
            this.btnRemovePart.TabIndex = 8;
            this.btnRemovePart.Text = "Премахни част";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnGetReceipt
            // 
            this.btnGetReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetReceipt.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetReceipt.Location = new System.Drawing.Point(7, 245);
            this.btnGetReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.btnGetReceipt.Name = "btnGetReceipt";
            this.btnGetReceipt.Size = new System.Drawing.Size(124, 50);
            this.btnGetReceipt.TabIndex = 4;
            this.btnGetReceipt.Text = "Вземи разписка";
            this.btnGetReceipt.UseVisualStyleBackColor = true;
            this.btnGetReceipt.Click += new System.EventHandler(this.btnGetReceipt_Click);
            // 
            // btnSavePC
            // 
            this.btnSavePC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePC.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePC.Location = new System.Drawing.Point(7, 305);
            this.btnSavePC.Margin = new System.Windows.Forms.Padding(0);
            this.btnSavePC.Name = "btnSavePC";
            this.btnSavePC.Size = new System.Drawing.Size(124, 50);
            this.btnSavePC.TabIndex = 5;
            this.btnSavePC.Text = "Запази конфигурация";
            this.btnSavePC.UseVisualStyleBackColor = true;
            this.btnSavePC.Click += new System.EventHandler(this.btnSavePC_Click);
            // 
            // btnLoadPC
            // 
            this.btnLoadPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPC.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadPC.Location = new System.Drawing.Point(7, 365);
            this.btnLoadPC.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadPC.Name = "btnLoadPC";
            this.btnLoadPC.Size = new System.Drawing.Size(124, 50);
            this.btnLoadPC.TabIndex = 6;
            this.btnLoadPC.Text = "Зареди конфигурация";
            this.btnLoadPC.UseVisualStyleBackColor = true;
            this.btnLoadPC.Click += new System.EventHandler(this.btnLoadPC_Click);
            // 
            // btnEditPart
            // 
            this.btnEditPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPart.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditPart.Location = new System.Drawing.Point(7, 425);
            this.btnEditPart.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(124, 50);
            this.btnEditPart.TabIndex = 7;
            this.btnEditPart.Text = "Промени част";
            this.btnEditPart.UseVisualStyleBackColor = true;
            this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.BackColor = System.Drawing.Color.LemonChiffon;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutFields, 0, 1);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPrice, 0, 2);
            this.tableLayoutMain.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutMain.Size = new System.Drawing.Size(778, 604);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // tableLayoutFields
            // 
            this.tableLayoutFields.ColumnCount = 5;
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutFields.Controls.Add(this.btnPSUpic, 4, 4);
            this.tableLayoutFields.Controls.Add(this.btnVCpic, 4, 3);
            this.tableLayoutFields.Controls.Add(this.btnRAMpic, 4, 2);
            this.tableLayoutFields.Controls.Add(this.btnCPUpic, 4, 0);
            this.tableLayoutFields.Controls.Add(this.labelCPU, 0, 0);
            this.tableLayoutFields.Controls.Add(this.labelMB, 0, 1);
            this.tableLayoutFields.Controls.Add(this.labelRAM, 0, 2);
            this.tableLayoutFields.Controls.Add(this.labelVC, 0, 3);
            this.tableLayoutFields.Controls.Add(this.labelPSU, 0, 4);
            this.tableLayoutFields.Controls.Add(this.labelDrive, 0, 5);
            this.tableLayoutFields.Controls.Add(this.labelCase, 0, 6);
            this.tableLayoutFields.Controls.Add(this.labelMonitor, 0, 7);
            this.tableLayoutFields.Controls.Add(this.labelMouse, 0, 8);
            this.tableLayoutFields.Controls.Add(this.labelKeyboard, 0, 9);
            this.tableLayoutFields.Controls.Add(this.labelSpeakers, 0, 10);
            this.tableLayoutFields.Controls.Add(this.comboBoxCPU, 1, 0);
            this.tableLayoutFields.Controls.Add(this.comboBoxMB, 1, 1);
            this.tableLayoutFields.Controls.Add(this.comboBoxRAM, 1, 2);
            this.tableLayoutFields.Controls.Add(this.comboBoxVC, 1, 3);
            this.tableLayoutFields.Controls.Add(this.comboBoxPSU, 1, 4);
            this.tableLayoutFields.Controls.Add(this.comboBoxDrive, 1, 5);
            this.tableLayoutFields.Controls.Add(this.comboBoxCase, 1, 6);
            this.tableLayoutFields.Controls.Add(this.comboBoxMonitor, 1, 7);
            this.tableLayoutFields.Controls.Add(this.comboBoxMouse, 1, 8);
            this.tableLayoutFields.Controls.Add(this.comboBoxKeyboard, 1, 9);
            this.tableLayoutFields.Controls.Add(this.comboBoxSpeakers, 1, 10);
            this.tableLayoutFields.Controls.Add(this.btnCPUweb, 3, 0);
            this.tableLayoutFields.Controls.Add(this.btnMBweb, 3, 1);
            this.tableLayoutFields.Controls.Add(this.btnRAMweb, 3, 2);
            this.tableLayoutFields.Controls.Add(this.btnVCweb, 3, 3);
            this.tableLayoutFields.Controls.Add(this.btnPSUweb, 3, 4);
            this.tableLayoutFields.Controls.Add(this.btnDriveWeb, 3, 5);
            this.tableLayoutFields.Controls.Add(this.btnCaseWeb, 3, 6);
            this.tableLayoutFields.Controls.Add(this.btnMonitorWeb, 3, 7);
            this.tableLayoutFields.Controls.Add(this.btnMouseWeb, 3, 8);
            this.tableLayoutFields.Controls.Add(this.btnKeyboardWeb, 3, 9);
            this.tableLayoutFields.Controls.Add(this.btnSpeakersWeb, 3, 10);
            this.tableLayoutFields.Controls.Add(this.btnMBpic, 4, 1);
            this.tableLayoutFields.Controls.Add(this.btnDrivePic, 4, 5);
            this.tableLayoutFields.Controls.Add(this.btnCasePic, 4, 6);
            this.tableLayoutFields.Controls.Add(this.btnMonitorPic, 4, 7);
            this.tableLayoutFields.Controls.Add(this.btnMousePic, 4, 8);
            this.tableLayoutFields.Controls.Add(this.btnKeyboardPic, 4, 9);
            this.tableLayoutFields.Controls.Add(this.btnSpeakersPic, 4, 10);
            this.tableLayoutFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFields.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutFields.Name = "tableLayoutFields";
            this.tableLayoutFields.RowCount = 11;
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutFields.Size = new System.Drawing.Size(772, 477);
            this.tableLayoutFields.TabIndex = 1;
            // 
            // btnPSUpic
            // 
            this.btnPSUpic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPSUpic.Enabled = false;
            this.btnPSUpic.Location = new System.Drawing.Point(669, 175);
            this.btnPSUpic.Name = "btnPSUpic";
            this.btnPSUpic.Size = new System.Drawing.Size(89, 23);
            this.btnPSUpic.TabIndex = 53;
            this.btnPSUpic.Text = "Изображение";
            this.btnPSUpic.UseVisualStyleBackColor = true;
            this.btnPSUpic.Click += new System.EventHandler(this.btnPSUpic_Click);
            // 
            // btnVCpic
            // 
            this.btnVCpic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVCpic.Enabled = false;
            this.btnVCpic.Location = new System.Drawing.Point(669, 132);
            this.btnVCpic.Name = "btnVCpic";
            this.btnVCpic.Size = new System.Drawing.Size(89, 23);
            this.btnVCpic.TabIndex = 51;
            this.btnVCpic.Text = "Изображение";
            this.btnVCpic.UseVisualStyleBackColor = true;
            this.btnVCpic.Click += new System.EventHandler(this.btnVCpic_Click);
            // 
            // btnRAMpic
            // 
            this.btnRAMpic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRAMpic.Enabled = false;
            this.btnRAMpic.Location = new System.Drawing.Point(669, 89);
            this.btnRAMpic.Name = "btnRAMpic";
            this.btnRAMpic.Size = new System.Drawing.Size(89, 23);
            this.btnRAMpic.TabIndex = 49;
            this.btnRAMpic.Text = "Изображение";
            this.btnRAMpic.UseVisualStyleBackColor = true;
            this.btnRAMpic.Click += new System.EventHandler(this.btnRAMpic_Click);
            // 
            // btnCPUpic
            // 
            this.btnCPUpic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCPUpic.Enabled = false;
            this.btnCPUpic.Location = new System.Drawing.Point(669, 3);
            this.btnCPUpic.Name = "btnCPUpic";
            this.btnCPUpic.Size = new System.Drawing.Size(89, 23);
            this.btnCPUpic.TabIndex = 35;
            this.btnCPUpic.Text = "Изображение";
            this.btnCPUpic.UseVisualStyleBackColor = true;
            this.btnCPUpic.Click += new System.EventHandler(this.btnCPUpic_Click);
            // 
            // labelCPU
            // 
            this.labelCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPU.Location = new System.Drawing.Point(58, 0);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(93, 20);
            this.labelCPU.TabIndex = 12;
            this.labelCPU.Text = "Процесор:";
            // 
            // labelMB
            // 
            this.labelMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMB.AutoSize = true;
            this.labelMB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMB.Location = new System.Drawing.Point(36, 43);
            this.labelMB.Name = "labelMB";
            this.labelMB.Size = new System.Drawing.Size(115, 20);
            this.labelMB.TabIndex = 13;
            this.labelMB.Text = "Дънна платка:";
            // 
            // labelRAM
            // 
            this.labelRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRAM.Location = new System.Drawing.Point(51, 86);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(100, 20);
            this.labelRAM.TabIndex = 14;
            this.labelRAM.Text = "RAM памет:";
            // 
            // labelVC
            // 
            this.labelVC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVC.AutoSize = true;
            this.labelVC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVC.Location = new System.Drawing.Point(51, 129);
            this.labelVC.Name = "labelVC";
            this.labelVC.Size = new System.Drawing.Size(100, 20);
            this.labelVC.TabIndex = 15;
            this.labelVC.Text = "Видеокарта";
            // 
            // labelPSU
            // 
            this.labelPSU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPSU.AutoSize = true;
            this.labelPSU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPSU.Location = new System.Drawing.Point(47, 172);
            this.labelPSU.Name = "labelPSU";
            this.labelPSU.Size = new System.Drawing.Size(104, 20);
            this.labelPSU.TabIndex = 16;
            this.labelPSU.Text = "Захранване:";
            // 
            // labelDrive
            // 
            this.labelDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrive.AutoSize = true;
            this.labelDrive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrive.Location = new System.Drawing.Point(100, 215);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(51, 20);
            this.labelDrive.TabIndex = 17;
            this.labelDrive.Text = "Диск:";
            // 
            // labelCase
            // 
            this.labelCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCase.AutoSize = true;
            this.labelCase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCase.Location = new System.Drawing.Point(99, 258);
            this.labelCase.Name = "labelCase";
            this.labelCase.Size = new System.Drawing.Size(52, 20);
            this.labelCase.TabIndex = 18;
            this.labelCase.Text = "Кутия:";
            // 
            // labelMonitor
            // 
            this.labelMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonitor.Location = new System.Drawing.Point(69, 301);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(82, 20);
            this.labelMonitor.TabIndex = 19;
            this.labelMonitor.Text = "Монитор:";
            // 
            // labelMouse
            // 
            this.labelMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMouse.AutoSize = true;
            this.labelMouse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMouse.Location = new System.Drawing.Point(82, 344);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(69, 20);
            this.labelMouse.TabIndex = 20;
            this.labelMouse.Text = "Мишка:";
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKeyboard.Location = new System.Drawing.Point(51, 387);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(100, 20);
            this.labelKeyboard.TabIndex = 21;
            this.labelKeyboard.Text = "Клавиатура:";
            // 
            // labelSpeakers
            // 
            this.labelSpeakers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpeakers.AutoSize = true;
            this.labelSpeakers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeakers.Location = new System.Drawing.Point(60, 430);
            this.labelSpeakers.Name = "labelSpeakers";
            this.labelSpeakers.Size = new System.Drawing.Size(91, 20);
            this.labelSpeakers.TabIndex = 22;
            this.labelSpeakers.Text = "Тонколони:";
            // 
            // comboBoxCPU
            // 
            this.comboBoxCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxCPU, 2);
            this.comboBoxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCPU.FormattingEnabled = true;
            this.comboBoxCPU.Location = new System.Drawing.Point(157, 3);
            this.comboBoxCPU.Name = "comboBoxCPU";
            this.comboBoxCPU.Size = new System.Drawing.Size(380, 24);
            this.comboBoxCPU.TabIndex = 23;
            this.comboBoxCPU.SelectedIndexChanged += new System.EventHandler(this.comboBoxCPU_SelectedIndexChanged);
            // 
            // comboBoxMB
            // 
            this.comboBoxMB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxMB, 2);
            this.comboBoxMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMB.FormattingEnabled = true;
            this.comboBoxMB.Location = new System.Drawing.Point(157, 46);
            this.comboBoxMB.Name = "comboBoxMB";
            this.comboBoxMB.Size = new System.Drawing.Size(380, 24);
            this.comboBoxMB.TabIndex = 24;
            this.comboBoxMB.SelectedIndexChanged += new System.EventHandler(this.comboBoxMB_SelectedIndexChanged);
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxRAM, 2);
            this.comboBoxRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Location = new System.Drawing.Point(157, 89);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(380, 24);
            this.comboBoxRAM.TabIndex = 25;
            this.comboBoxRAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAM_SelectedIndexChanged);
            // 
            // comboBoxVC
            // 
            this.comboBoxVC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxVC, 2);
            this.comboBoxVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxVC.FormattingEnabled = true;
            this.comboBoxVC.Location = new System.Drawing.Point(157, 132);
            this.comboBoxVC.Name = "comboBoxVC";
            this.comboBoxVC.Size = new System.Drawing.Size(380, 24);
            this.comboBoxVC.TabIndex = 26;
            this.comboBoxVC.SelectedIndexChanged += new System.EventHandler(this.comboBoxVC_SelectedIndexChanged);
            // 
            // comboBoxPSU
            // 
            this.comboBoxPSU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxPSU, 2);
            this.comboBoxPSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPSU.FormattingEnabled = true;
            this.comboBoxPSU.Location = new System.Drawing.Point(157, 175);
            this.comboBoxPSU.Name = "comboBoxPSU";
            this.comboBoxPSU.Size = new System.Drawing.Size(380, 24);
            this.comboBoxPSU.TabIndex = 27;
            this.comboBoxPSU.SelectedIndexChanged += new System.EventHandler(this.comboBoxPSU_SelectedIndexChanged);
            // 
            // comboBoxDrive
            // 
            this.comboBoxDrive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxDrive, 2);
            this.comboBoxDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDrive.FormattingEnabled = true;
            this.comboBoxDrive.Location = new System.Drawing.Point(157, 218);
            this.comboBoxDrive.Name = "comboBoxDrive";
            this.comboBoxDrive.Size = new System.Drawing.Size(380, 24);
            this.comboBoxDrive.TabIndex = 28;
            this.comboBoxDrive.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrive_SelectedIndexChanged);
            // 
            // comboBoxCase
            // 
            this.comboBoxCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxCase, 2);
            this.comboBoxCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCase.FormattingEnabled = true;
            this.comboBoxCase.Location = new System.Drawing.Point(157, 261);
            this.comboBoxCase.Name = "comboBoxCase";
            this.comboBoxCase.Size = new System.Drawing.Size(380, 24);
            this.comboBoxCase.TabIndex = 29;
            this.comboBoxCase.SelectedIndexChanged += new System.EventHandler(this.comboBoxCase_SelectedIndexChanged);
            // 
            // comboBoxMonitor
            // 
            this.comboBoxMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxMonitor, 2);
            this.comboBoxMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMonitor.FormattingEnabled = true;
            this.comboBoxMonitor.Location = new System.Drawing.Point(157, 304);
            this.comboBoxMonitor.Name = "comboBoxMonitor";
            this.comboBoxMonitor.Size = new System.Drawing.Size(380, 24);
            this.comboBoxMonitor.TabIndex = 30;
            this.comboBoxMonitor.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonitor_SelectedIndexChanged);
            // 
            // comboBoxMouse
            // 
            this.comboBoxMouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxMouse, 2);
            this.comboBoxMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMouse.FormattingEnabled = true;
            this.comboBoxMouse.Location = new System.Drawing.Point(157, 347);
            this.comboBoxMouse.Name = "comboBoxMouse";
            this.comboBoxMouse.Size = new System.Drawing.Size(380, 24);
            this.comboBoxMouse.TabIndex = 31;
            this.comboBoxMouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxMouse_SelectedIndexChanged);
            // 
            // comboBoxKeyboard
            // 
            this.comboBoxKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxKeyboard, 2);
            this.comboBoxKeyboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKeyboard.FormattingEnabled = true;
            this.comboBoxKeyboard.Location = new System.Drawing.Point(157, 390);
            this.comboBoxKeyboard.Name = "comboBoxKeyboard";
            this.comboBoxKeyboard.Size = new System.Drawing.Size(380, 24);
            this.comboBoxKeyboard.TabIndex = 32;
            this.comboBoxKeyboard.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeyboard_SelectedIndexChanged);
            // 
            // comboBoxSpeakers
            // 
            this.comboBoxSpeakers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFields.SetColumnSpan(this.comboBoxSpeakers, 2);
            this.comboBoxSpeakers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSpeakers.FormattingEnabled = true;
            this.comboBoxSpeakers.Location = new System.Drawing.Point(157, 433);
            this.comboBoxSpeakers.Name = "comboBoxSpeakers";
            this.comboBoxSpeakers.Size = new System.Drawing.Size(380, 24);
            this.comboBoxSpeakers.TabIndex = 33;
            this.comboBoxSpeakers.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeakers_SelectedIndexChanged);
            // 
            // btnCPUweb
            // 
            this.btnCPUweb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCPUweb.Enabled = false;
            this.btnCPUweb.Location = new System.Drawing.Point(560, 3);
            this.btnCPUweb.Name = "btnCPUweb";
            this.btnCPUweb.Size = new System.Drawing.Size(75, 23);
            this.btnCPUweb.TabIndex = 34;
            this.btnCPUweb.Text = "Инфо";
            this.btnCPUweb.UseVisualStyleBackColor = true;
            this.btnCPUweb.Click += new System.EventHandler(this.btnCPUweb_Click);
            // 
            // btnMBweb
            // 
            this.btnMBweb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMBweb.Enabled = false;
            this.btnMBweb.Location = new System.Drawing.Point(560, 46);
            this.btnMBweb.Name = "btnMBweb";
            this.btnMBweb.Size = new System.Drawing.Size(75, 23);
            this.btnMBweb.TabIndex = 36;
            this.btnMBweb.Text = "Инфо";
            this.btnMBweb.UseVisualStyleBackColor = true;
            this.btnMBweb.Click += new System.EventHandler(this.btnMBweb_Click);
            // 
            // btnRAMweb
            // 
            this.btnRAMweb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRAMweb.Enabled = false;
            this.btnRAMweb.Location = new System.Drawing.Point(560, 89);
            this.btnRAMweb.Name = "btnRAMweb";
            this.btnRAMweb.Size = new System.Drawing.Size(75, 23);
            this.btnRAMweb.TabIndex = 37;
            this.btnRAMweb.Text = "Инфо";
            this.btnRAMweb.UseVisualStyleBackColor = true;
            this.btnRAMweb.Click += new System.EventHandler(this.btnRAMweb_Click);
            // 
            // btnVCweb
            // 
            this.btnVCweb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVCweb.Enabled = false;
            this.btnVCweb.Location = new System.Drawing.Point(560, 132);
            this.btnVCweb.Name = "btnVCweb";
            this.btnVCweb.Size = new System.Drawing.Size(75, 23);
            this.btnVCweb.TabIndex = 38;
            this.btnVCweb.Text = "Инфо";
            this.btnVCweb.UseVisualStyleBackColor = true;
            this.btnVCweb.Click += new System.EventHandler(this.btnVCweb_Click);
            // 
            // btnPSUweb
            // 
            this.btnPSUweb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPSUweb.Enabled = false;
            this.btnPSUweb.Location = new System.Drawing.Point(560, 175);
            this.btnPSUweb.Name = "btnPSUweb";
            this.btnPSUweb.Size = new System.Drawing.Size(75, 23);
            this.btnPSUweb.TabIndex = 39;
            this.btnPSUweb.Text = "Инфо";
            this.btnPSUweb.UseVisualStyleBackColor = true;
            this.btnPSUweb.Click += new System.EventHandler(this.btnPSUweb_Click);
            // 
            // btnDriveWeb
            // 
            this.btnDriveWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDriveWeb.Enabled = false;
            this.btnDriveWeb.Location = new System.Drawing.Point(560, 218);
            this.btnDriveWeb.Name = "btnDriveWeb";
            this.btnDriveWeb.Size = new System.Drawing.Size(75, 23);
            this.btnDriveWeb.TabIndex = 40;
            this.btnDriveWeb.Text = "Инфо";
            this.btnDriveWeb.UseVisualStyleBackColor = true;
            this.btnDriveWeb.Click += new System.EventHandler(this.btnDriveWeb_Click);
            // 
            // btnCaseWeb
            // 
            this.btnCaseWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCaseWeb.Enabled = false;
            this.btnCaseWeb.Location = new System.Drawing.Point(560, 261);
            this.btnCaseWeb.Name = "btnCaseWeb";
            this.btnCaseWeb.Size = new System.Drawing.Size(75, 23);
            this.btnCaseWeb.TabIndex = 41;
            this.btnCaseWeb.Text = "Инфо";
            this.btnCaseWeb.UseVisualStyleBackColor = true;
            this.btnCaseWeb.Click += new System.EventHandler(this.btnCaseWeb_Click);
            // 
            // btnMonitorWeb
            // 
            this.btnMonitorWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMonitorWeb.Enabled = false;
            this.btnMonitorWeb.Location = new System.Drawing.Point(560, 304);
            this.btnMonitorWeb.Name = "btnMonitorWeb";
            this.btnMonitorWeb.Size = new System.Drawing.Size(75, 23);
            this.btnMonitorWeb.TabIndex = 42;
            this.btnMonitorWeb.Text = "Инфо";
            this.btnMonitorWeb.UseVisualStyleBackColor = true;
            this.btnMonitorWeb.Click += new System.EventHandler(this.btnMonitorWeb_Click);
            // 
            // btnMouseWeb
            // 
            this.btnMouseWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMouseWeb.Enabled = false;
            this.btnMouseWeb.Location = new System.Drawing.Point(560, 347);
            this.btnMouseWeb.Name = "btnMouseWeb";
            this.btnMouseWeb.Size = new System.Drawing.Size(75, 23);
            this.btnMouseWeb.TabIndex = 43;
            this.btnMouseWeb.Text = "Инфо";
            this.btnMouseWeb.UseVisualStyleBackColor = true;
            this.btnMouseWeb.Click += new System.EventHandler(this.btnMouseWeb_Click);
            // 
            // btnKeyboardWeb
            // 
            this.btnKeyboardWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKeyboardWeb.Enabled = false;
            this.btnKeyboardWeb.Location = new System.Drawing.Point(560, 390);
            this.btnKeyboardWeb.Name = "btnKeyboardWeb";
            this.btnKeyboardWeb.Size = new System.Drawing.Size(75, 23);
            this.btnKeyboardWeb.TabIndex = 44;
            this.btnKeyboardWeb.Text = "Инфо";
            this.btnKeyboardWeb.UseVisualStyleBackColor = true;
            this.btnKeyboardWeb.Click += new System.EventHandler(this.btnKeyboardWeb_Click);
            // 
            // btnSpeakersWeb
            // 
            this.btnSpeakersWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpeakersWeb.Enabled = false;
            this.btnSpeakersWeb.Location = new System.Drawing.Point(560, 433);
            this.btnSpeakersWeb.Name = "btnSpeakersWeb";
            this.btnSpeakersWeb.Size = new System.Drawing.Size(75, 23);
            this.btnSpeakersWeb.TabIndex = 45;
            this.btnSpeakersWeb.Text = "Инфо";
            this.btnSpeakersWeb.UseVisualStyleBackColor = true;
            this.btnSpeakersWeb.Click += new System.EventHandler(this.btnSpeakersWeb_Click);
            // 
            // btnMBpic
            // 
            this.btnMBpic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMBpic.Enabled = false;
            this.btnMBpic.Location = new System.Drawing.Point(669, 46);
            this.btnMBpic.Name = "btnMBpic";
            this.btnMBpic.Size = new System.Drawing.Size(89, 23);
            this.btnMBpic.TabIndex = 46;
            this.btnMBpic.Text = "Изображение";
            this.btnMBpic.UseVisualStyleBackColor = true;
            this.btnMBpic.Click += new System.EventHandler(this.btnMBpic_Click);
            // 
            // btnDrivePic
            // 
            this.btnDrivePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDrivePic.Enabled = false;
            this.btnDrivePic.Location = new System.Drawing.Point(669, 218);
            this.btnDrivePic.Name = "btnDrivePic";
            this.btnDrivePic.Size = new System.Drawing.Size(89, 23);
            this.btnDrivePic.TabIndex = 47;
            this.btnDrivePic.Text = "Изображение";
            this.btnDrivePic.UseVisualStyleBackColor = true;
            this.btnDrivePic.Click += new System.EventHandler(this.btnDrivePic_Click);
            // 
            // btnCasePic
            // 
            this.btnCasePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCasePic.Enabled = false;
            this.btnCasePic.Location = new System.Drawing.Point(669, 261);
            this.btnCasePic.Name = "btnCasePic";
            this.btnCasePic.Size = new System.Drawing.Size(89, 23);
            this.btnCasePic.TabIndex = 48;
            this.btnCasePic.Text = "Изображение";
            this.btnCasePic.UseVisualStyleBackColor = true;
            this.btnCasePic.Click += new System.EventHandler(this.btnCasePic_Click);
            // 
            // btnMonitorPic
            // 
            this.btnMonitorPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMonitorPic.Enabled = false;
            this.btnMonitorPic.Location = new System.Drawing.Point(669, 304);
            this.btnMonitorPic.Name = "btnMonitorPic";
            this.btnMonitorPic.Size = new System.Drawing.Size(89, 23);
            this.btnMonitorPic.TabIndex = 50;
            this.btnMonitorPic.Text = "Изображение";
            this.btnMonitorPic.UseVisualStyleBackColor = true;
            this.btnMonitorPic.Click += new System.EventHandler(this.btnMonitorPic_Click);
            // 
            // btnMousePic
            // 
            this.btnMousePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMousePic.Enabled = false;
            this.btnMousePic.Location = new System.Drawing.Point(669, 347);
            this.btnMousePic.Name = "btnMousePic";
            this.btnMousePic.Size = new System.Drawing.Size(89, 23);
            this.btnMousePic.TabIndex = 52;
            this.btnMousePic.Text = "Изображение";
            this.btnMousePic.UseVisualStyleBackColor = true;
            this.btnMousePic.Click += new System.EventHandler(this.btnMousePic_Click);
            // 
            // btnKeyboardPic
            // 
            this.btnKeyboardPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKeyboardPic.Enabled = false;
            this.btnKeyboardPic.Location = new System.Drawing.Point(669, 390);
            this.btnKeyboardPic.Name = "btnKeyboardPic";
            this.btnKeyboardPic.Size = new System.Drawing.Size(89, 23);
            this.btnKeyboardPic.TabIndex = 54;
            this.btnKeyboardPic.Text = "Изображение";
            this.btnKeyboardPic.UseVisualStyleBackColor = true;
            this.btnKeyboardPic.Click += new System.EventHandler(this.btnKeyboardPic_Click);
            // 
            // btnSpeakersPic
            // 
            this.btnSpeakersPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpeakersPic.Enabled = false;
            this.btnSpeakersPic.Location = new System.Drawing.Point(669, 433);
            this.btnSpeakersPic.Name = "btnSpeakersPic";
            this.btnSpeakersPic.Size = new System.Drawing.Size(89, 23);
            this.btnSpeakersPic.TabIndex = 55;
            this.btnSpeakersPic.Text = "Изображение";
            this.btnSpeakersPic.UseVisualStyleBackColor = true;
            this.btnSpeakersPic.Click += new System.EventHandler(this.btnSpeakersPic_Click);
            // 
            // tableLayoutPrice
            // 
            this.tableLayoutPrice.ColumnCount = 6;
            this.tableLayoutPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48252F));
            this.tableLayoutPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48252F));
            this.tableLayoutPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48252F));
            this.tableLayoutPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48252F));
            this.tableLayoutPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48252F));
            this.tableLayoutPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58741F));
            this.tableLayoutPrice.Controls.Add(this.lblPrice, 1, 0);
            this.tableLayoutPrice.Controls.Add(this.btnShowPrice, 0, 0);
            this.tableLayoutPrice.Controls.Add(this.lblPromoPrice, 3, 0);
            this.tableLayoutPrice.Controls.Add(this.lblPriceNum, 2, 0);
            this.tableLayoutPrice.Controls.Add(this.lblPromoPriceNum, 4, 0);
            this.tableLayoutPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPrice.Location = new System.Drawing.Point(3, 546);
            this.tableLayoutPrice.Name = "tableLayoutPrice";
            this.tableLayoutPrice.RowCount = 1;
            this.tableLayoutPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrice.Size = new System.Drawing.Size(772, 55);
            this.tableLayoutPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(162, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 48);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Обща цена:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrice.Visible = false;
            // 
            // btnShowPrice
            // 
            this.btnShowPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowPrice.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowPrice.Location = new System.Drawing.Point(6, 3);
            this.btnShowPrice.Name = "btnShowPrice";
            this.btnShowPrice.Size = new System.Drawing.Size(122, 49);
            this.btnShowPrice.TabIndex = 0;
            this.btnShowPrice.Text = "Изчисли цена";
            this.btnShowPrice.UseVisualStyleBackColor = true;
            this.btnShowPrice.Click += new System.EventHandler(this.btnShowPrice_Click);
            // 
            // lblPromoPrice
            // 
            this.lblPromoPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPromoPrice.AutoSize = true;
            this.lblPromoPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPromoPrice.Location = new System.Drawing.Point(427, 0);
            this.lblPromoPrice.Name = "lblPromoPrice";
            this.lblPromoPrice.Size = new System.Drawing.Size(84, 48);
            this.lblPromoPrice.TabIndex = 2;
            this.lblPromoPrice.Text = "Промо цена:";
            this.lblPromoPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPromoPrice.Visible = false;
            // 
            // lblPriceNum
            // 
            this.lblPriceNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPriceNum.AutoSize = true;
            this.lblPriceNum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceNum.Location = new System.Drawing.Point(293, 0);
            this.lblPriceNum.Name = "lblPriceNum";
            this.lblPriceNum.Size = new System.Drawing.Size(84, 24);
            this.lblPriceNum.TabIndex = 3;
            this.lblPriceNum.Text = "0.00 лв.";
            this.lblPriceNum.Visible = false;
            // 
            // lblPromoPriceNum
            // 
            this.lblPromoPriceNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPromoPriceNum.AutoSize = true;
            this.lblPromoPriceNum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPromoPriceNum.Location = new System.Drawing.Point(561, 0);
            this.lblPromoPriceNum.Name = "lblPromoPriceNum";
            this.lblPromoPriceNum.Size = new System.Drawing.Size(84, 24);
            this.lblPromoPriceNum.TabIndex = 4;
            this.lblPromoPriceNum.Text = "0.00 лв.";
            this.lblPromoPriceNum.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(153, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(472, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Компютърна конфигурация:";
            // 
            // GetReceiptDialog
            // 
            this.GetReceiptDialog.DefaultExt = "txt";
            this.GetReceiptDialog.InitialDirectory = "%USERPROFILE%";
            this.GetReceiptDialog.Title = "Запис на разписка";
            // 
            // SavePCDialog
            // 
            this.SavePCDialog.DefaultExt = "csv";
            this.SavePCDialog.Filter = "Comma-separated Values file|*.csv";
            this.SavePCDialog.Title = "Запис на конфигурация";
            // 
            // LoadPCDialog
            // 
            this.LoadPCDialog.FileName = ".csv";
            this.LoadPCDialog.Filter = "Comma-separated values file|*.csv";
            this.LoadPCDialog.Title = "Зареди конфигурация";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(928, 610);
            this.Controls.Add(this.tableLayoutBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComputerPartsApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutBase.ResumeLayout(false);
            this.tableLayoutButtons.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tableLayoutFields.ResumeLayout(false);
            this.tableLayoutFields.PerformLayout();
            this.tableLayoutPrice.ResumeLayout(false);
            this.tableLayoutPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnLoadPC;
        private System.Windows.Forms.Button btnSavePC;
        private System.Windows.Forms.Button btnGetReceipt;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCoupon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFields;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelMB;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelVC;
        private System.Windows.Forms.Label labelPSU;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.Label labelCase;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.Label labelKeyboard;
        private System.Windows.Forms.Label labelSpeakers;
        private System.Windows.Forms.ComboBox comboBoxCPU;
        private System.Windows.Forms.ComboBox comboBoxMB;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.ComboBox comboBoxVC;
        private System.Windows.Forms.ComboBox comboBoxPSU;
        private System.Windows.Forms.ComboBox comboBoxDrive;
        private System.Windows.Forms.ComboBox comboBoxCase;
        private System.Windows.Forms.ComboBox comboBoxMonitor;
        private System.Windows.Forms.ComboBox comboBoxMouse;
        private System.Windows.Forms.ComboBox comboBoxKeyboard;
        private System.Windows.Forms.ComboBox comboBoxSpeakers;
        private System.Windows.Forms.Button btnCPUweb;
        private System.Windows.Forms.Button btnCPUpic;
        private System.Windows.Forms.Button btnMBweb;
        private System.Windows.Forms.Button btnRAMweb;
        private System.Windows.Forms.Button btnVCweb;
        private System.Windows.Forms.Button btnPSUweb;
        private System.Windows.Forms.Button btnDriveWeb;
        private System.Windows.Forms.Button btnCaseWeb;
        private System.Windows.Forms.Button btnMonitorWeb;
        private System.Windows.Forms.Button btnMouseWeb;
        private System.Windows.Forms.Button btnKeyboardWeb;
        private System.Windows.Forms.Button btnSpeakersWeb;
        private System.Windows.Forms.Button btnPSUpic;
        private System.Windows.Forms.Button btnVCpic;
        private System.Windows.Forms.Button btnRAMpic;
        private System.Windows.Forms.Button btnMBpic;
        private System.Windows.Forms.Button btnDrivePic;
        private System.Windows.Forms.Button btnCasePic;
        private System.Windows.Forms.Button btnMonitorPic;
        private System.Windows.Forms.Button btnMousePic;
        private System.Windows.Forms.Button btnKeyboardPic;
        private System.Windows.Forms.Button btnSpeakersPic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnShowPrice;
        private System.Windows.Forms.Label lblPromoPrice;
        private System.Windows.Forms.Label lblPriceNum;
        private System.Windows.Forms.Label lblPromoPriceNum;
        private System.Windows.Forms.SaveFileDialog GetReceiptDialog;
        private System.Windows.Forms.SaveFileDialog SavePCDialog;
        private System.Windows.Forms.OpenFileDialog LoadPCDialog;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.Button btnClose;
    }
}

