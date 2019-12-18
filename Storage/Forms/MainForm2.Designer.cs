namespace Storage.Forms
{
    partial class MainForm2
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpBuys = new System.Windows.Forms.TabPage();
            this.tpProviders = new System.Windows.Forms.TabPage();
            this.gridBuys = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCreateCheck = new System.Windows.Forms.Button();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.tpDiscount = new System.Windows.Forms.TabPage();
            this.tpStaff = new System.Windows.Forms.TabPage();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProvider = new System.Windows.Forms.DataGridView();
            this.btnRemoveProvider = new System.Windows.Forms.Button();
            this.btnCreateProvider = new System.Windows.Forms.Button();
            this.btnSaveProvider = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.gridDiscount = new System.Windows.Forms.DataGridView();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAccrued = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAccrued = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.gridStaff = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.btnLoadSearch = new System.Windows.Forms.Button();
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpBuys.SuspendLayout();
            this.tpProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.tpDiscount.SuspendLayout();
            this.tpStaff.SuspendLayout();
            this.tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpBuys);
            this.tabControl.Controls.Add(this.tpProviders);
            this.tabControl.Controls.Add(this.tpDiscount);
            this.tabControl.Controls.Add(this.tpStaff);
            this.tabControl.Controls.Add(this.tpSearch);
            this.tabControl.Controls.Add(this.tpReport);
            this.tabControl.Controls.Add(this.tpSettings);
            this.tabControl.Location = new System.Drawing.Point(-2, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1012, 651);
            this.tabControl.TabIndex = 0;
            // 
            // tpBuys
            // 
            this.tpBuys.Controls.Add(this.gridBuys);
            this.tpBuys.Controls.Add(this.btnExit);
            this.tpBuys.Controls.Add(this.btnBuy);
            this.tpBuys.Controls.Add(this.btnCreateCheck);
            this.tpBuys.Controls.Add(this.gridProducts);
            this.tpBuys.Controls.Add(this.lbName);
            this.tpBuys.Controls.Add(this.lbPosition);
            this.tpBuys.Location = new System.Drawing.Point(4, 22);
            this.tpBuys.Name = "tpBuys";
            this.tpBuys.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuys.Size = new System.Drawing.Size(1004, 625);
            this.tpBuys.TabIndex = 0;
            this.tpBuys.Text = "Продажа";
            this.tpBuys.UseVisualStyleBackColor = true;
            // 
            // tpProviders
            // 
            this.tpProviders.Controls.Add(this.btnExit2);
            this.tpProviders.Controls.Add(this.tbAddress);
            this.tpProviders.Controls.Add(this.tbCompany);
            this.tpProviders.Controls.Add(this.tbPhoneNumber);
            this.tpProviders.Controls.Add(this.tbName);
            this.tpProviders.Controls.Add(this.lbAddress);
            this.tpProviders.Controls.Add(this.lbCompany);
            this.tpProviders.Controls.Add(this.lbPhoneNumber);
            this.tpProviders.Controls.Add(this.label1);
            this.tpProviders.Controls.Add(this.gridProvider);
            this.tpProviders.Controls.Add(this.btnRemoveProvider);
            this.tpProviders.Controls.Add(this.btnCreateProvider);
            this.tpProviders.Controls.Add(this.btnSaveProvider);
            this.tpProviders.Location = new System.Drawing.Point(4, 22);
            this.tpProviders.Name = "tpProviders";
            this.tpProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tpProviders.Size = new System.Drawing.Size(1004, 625);
            this.tpProviders.TabIndex = 1;
            this.tpProviders.Text = "Поставщики";
            this.tpProviders.UseVisualStyleBackColor = true;
            // 
            // gridBuys
            // 
            this.gridBuys.AllowUserToAddRows = false;
            this.gridBuys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBuys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuys.Location = new System.Drawing.Point(14, 348);
            this.gridBuys.MultiSelect = false;
            this.gridBuys.Name = "gridBuys";
            this.gridBuys.Size = new System.Drawing.Size(979, 113);
            this.gridBuys.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(868, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(513, 12);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(109, 25);
            this.btnBuy.TabIndex = 23;
            this.btnBuy.Text = "Продать";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCreateCheck
            // 
            this.btnCreateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateCheck.Location = new System.Drawing.Point(646, 12);
            this.btnCreateCheck.Name = "btnCreateCheck";
            this.btnCreateCheck.Size = new System.Drawing.Size(110, 25);
            this.btnCreateCheck.TabIndex = 22;
            this.btnCreateCheck.Text = "Квитанция";
            this.btnCreateCheck.UseVisualStyleBackColor = true;
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(14, 87);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(979, 255);
            this.gridProducts.TabIndex = 21;
            this.gridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellDoubleClick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(10, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Name";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPosition.Location = new System.Drawing.Point(8, 51);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(65, 20);
            this.lbPosition.TabIndex = 19;
            this.lbPosition.Text = "Position";
            // 
            // tpDiscount
            // 
            this.tpDiscount.Controls.Add(this.btnExit3);
            this.tpDiscount.Controls.Add(this.btnDelete);
            this.tpDiscount.Controls.Add(this.tbSize);
            this.tpDiscount.Controls.Add(this.dtpEndTime);
            this.tpDiscount.Controls.Add(this.lbDate);
            this.tpDiscount.Controls.Add(this.lbSize);
            this.tpDiscount.Controls.Add(this.btnAddDiscount);
            this.tpDiscount.Controls.Add(this.gridDiscount);
            this.tpDiscount.Location = new System.Drawing.Point(4, 22);
            this.tpDiscount.Name = "tpDiscount";
            this.tpDiscount.Size = new System.Drawing.Size(1004, 625);
            this.tpDiscount.TabIndex = 2;
            this.tpDiscount.Text = "Скидки";
            this.tpDiscount.UseVisualStyleBackColor = true;
            // 
            // tpStaff
            // 
            this.tpStaff.Controls.Add(this.button2);
            this.tpStaff.Controls.Add(this.cbPosition);
            this.tpStaff.Controls.Add(this.textBox1);
            this.tpStaff.Controls.Add(this.textBox2);
            this.tpStaff.Controls.Add(this.tbEmail);
            this.tpStaff.Controls.Add(this.tbAccrued);
            this.tpStaff.Controls.Add(this.textBox3);
            this.tpStaff.Controls.Add(this.lbEmail);
            this.tpStaff.Controls.Add(this.label2);
            this.tpStaff.Controls.Add(this.label3);
            this.tpStaff.Controls.Add(this.lbAccrued);
            this.tpStaff.Controls.Add(this.label4);
            this.tpStaff.Controls.Add(this.label5);
            this.tpStaff.Controls.Add(this.btnAddStaff);
            this.tpStaff.Controls.Add(this.btnUpdateStaff);
            this.tpStaff.Controls.Add(this.btnRemoveStaff);
            this.tpStaff.Controls.Add(this.gridStaff);
            this.tpStaff.Location = new System.Drawing.Point(4, 22);
            this.tpStaff.Name = "tpStaff";
            this.tpStaff.Size = new System.Drawing.Size(1004, 625);
            this.tpStaff.TabIndex = 3;
            this.tpStaff.Text = "Сотрудники";
            this.tpStaff.UseVisualStyleBackColor = true;
            this.tpStaff.Click += new System.EventHandler(this.tpStaff_Click);
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.button1);
            this.tpSearch.Controls.Add(this.gridResult);
            this.tpSearch.Controls.Add(this.btnLoadSearch);
            this.tpSearch.Controls.Add(this.tbCondition);
            this.tpSearch.Controls.Add(this.cbCondition);
            this.tpSearch.Controls.Add(this.cbColumns);
            this.tpSearch.Controls.Add(this.cbTables);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(1004, 625);
            this.tpSearch.TabIndex = 4;
            this.tpSearch.Text = "Поиск";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tpReport
            // 
            this.tpReport.Location = new System.Drawing.Point(4, 22);
            this.tpReport.Name = "tpReport";
            this.tpReport.Size = new System.Drawing.Size(1004, 625);
            this.tpReport.TabIndex = 5;
            this.tpReport.Text = "Отчеты";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(1004, 625);
            this.tpSettings.TabIndex = 6;
            this.tpSettings.Text = "Настройки";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(173, 595);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(434, 20);
            this.tbAddress.TabIndex = 24;
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(173, 562);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(434, 20);
            this.tbCompany.TabIndex = 23;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(173, 528);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(434, 20);
            this.tbPhoneNumber.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(173, 494);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(434, 20);
            this.tbName.TabIndex = 21;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.Location = new System.Drawing.Point(23, 596);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(48, 16);
            this.lbAddress.TabIndex = 20;
            this.lbAddress.Text = "Адрес";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCompany.Location = new System.Drawing.Point(23, 563);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(72, 16);
            this.lbCompany.TabIndex = 19;
            this.lbCompany.Text = "Компания";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(23, 529);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(120, 16);
            this.lbPhoneNumber.TabIndex = 18;
            this.lbPhoneNumber.Text = "Номер телефона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "ФИО";
            // 
            // gridProvider
            // 
            this.gridProvider.AllowUserToAddRows = false;
            this.gridProvider.AllowUserToDeleteRows = false;
            this.gridProvider.AllowUserToResizeColumns = false;
            this.gridProvider.AllowUserToResizeRows = false;
            this.gridProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProvider.Location = new System.Drawing.Point(10, 68);
            this.gridProvider.Name = "gridProvider";
            this.gridProvider.Size = new System.Drawing.Size(983, 395);
            this.gridProvider.TabIndex = 16;
            // 
            // btnRemoveProvider
            // 
            this.btnRemoveProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveProvider.Location = new System.Drawing.Point(761, 4);
            this.btnRemoveProvider.Name = "btnRemoveProvider";
            this.btnRemoveProvider.Size = new System.Drawing.Size(96, 26);
            this.btnRemoveProvider.TabIndex = 15;
            this.btnRemoveProvider.Text = "Удалить";
            this.btnRemoveProvider.UseVisualStyleBackColor = true;
            this.btnRemoveProvider.Click += new System.EventHandler(this.btnRemoveProvider_Click);
            // 
            // btnCreateProvider
            // 
            this.btnCreateProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateProvider.Location = new System.Drawing.Point(659, 4);
            this.btnCreateProvider.Name = "btnCreateProvider";
            this.btnCreateProvider.Size = new System.Drawing.Size(96, 26);
            this.btnCreateProvider.TabIndex = 14;
            this.btnCreateProvider.Text = "Добавить";
            this.btnCreateProvider.UseVisualStyleBackColor = true;
            this.btnCreateProvider.Click += new System.EventHandler(this.btnCreateProvider_Click);
            // 
            // btnSaveProvider
            // 
            this.btnSaveProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveProvider.Location = new System.Drawing.Point(557, 4);
            this.btnSaveProvider.Name = "btnSaveProvider";
            this.btnSaveProvider.Size = new System.Drawing.Size(96, 26);
            this.btnSaveProvider.TabIndex = 13;
            this.btnSaveProvider.Text = "Сохранить";
            this.btnSaveProvider.UseVisualStyleBackColor = true;
            this.btnSaveProvider.Click += new System.EventHandler(this.btnSaveProvider_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit2.Location = new System.Drawing.Point(909, 4);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(84, 26);
            this.btnExit2.TabIndex = 26;
            this.btnExit2.Text = "Выход";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(792, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSize.Location = new System.Drawing.Point(238, 497);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(206, 22);
            this.tbSize.TabIndex = 12;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(238, 533);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(206, 22);
            this.dtpEndTime.TabIndex = 11;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(29, 539);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(113, 16);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Дата окончания";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSize.Location = new System.Drawing.Point(29, 500);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(58, 16);
            this.lbSize.TabIndex = 9;
            this.lbSize.Text = "Размер";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDiscount.Location = new System.Drawing.Point(680, 13);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(90, 26);
            this.btnAddDiscount.TabIndex = 8;
            this.btnAddDiscount.Text = "Добавить";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // gridDiscount
            // 
            this.gridDiscount.AllowUserToAddRows = false;
            this.gridDiscount.AllowUserToDeleteRows = false;
            this.gridDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiscount.Location = new System.Drawing.Point(10, 67);
            this.gridDiscount.Name = "gridDiscount";
            this.gridDiscount.Size = new System.Drawing.Size(974, 396);
            this.gridDiscount.TabIndex = 7;
            // 
            // btnExit3
            // 
            this.btnExit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit3.Location = new System.Drawing.Point(891, 13);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(84, 26);
            this.btnExit3.TabIndex = 27;
            this.btnExit3.Text = "Выход";
            this.btnExit3.UseVisualStyleBackColor = true;
            this.btnExit3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(188, 528);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(249, 21);
            this.cbPosition.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(565, 571);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(565, 527);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 22);
            this.textBox2.TabIndex = 30;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(565, 480);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(292, 22);
            this.tbEmail.TabIndex = 29;
            // 
            // tbAccrued
            // 
            this.tbAccrued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAccrued.Location = new System.Drawing.Point(188, 571);
            this.tbAccrued.Name = "tbAccrued";
            this.tbAccrued.Size = new System.Drawing.Size(249, 22);
            this.tbAccrued.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(188, 480);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 22);
            this.textBox3.TabIndex = 27;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.Location = new System.Drawing.Point(484, 483);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(49, 16);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(484, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(484, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Адрес";
            // 
            // lbAccrued
            // 
            this.lbAccrued.AutoSize = true;
            this.lbAccrued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccrued.Location = new System.Drawing.Point(103, 574);
            this.lbAccrued.Name = "lbAccrued";
            this.lbAccrued.Size = new System.Drawing.Size(57, 16);
            this.lbAccrued.TabIndex = 23;
            this.lbAccrued.Text = "Оплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(103, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(103, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "ФИО";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStaff.Location = new System.Drawing.Point(690, 15);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(93, 26);
            this.btnAddStaff.TabIndex = 20;
            this.btnAddStaff.Text = "Добавить";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(591, 15);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(93, 26);
            this.btnUpdateStaff.TabIndex = 19;
            this.btnUpdateStaff.Text = "Сохранить";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveStaff.Location = new System.Drawing.Point(789, 15);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(93, 26);
            this.btnRemoveStaff.TabIndex = 18;
            this.btnRemoveStaff.Text = "Уволить";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // gridStaff
            // 
            this.gridStaff.AllowUserToAddRows = false;
            this.gridStaff.AllowUserToDeleteRows = false;
            this.gridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStaff.Location = new System.Drawing.Point(14, 61);
            this.gridStaff.Name = "gridStaff";
            this.gridStaff.Size = new System.Drawing.Size(979, 402);
            this.gridStaff.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(888, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 26);
            this.button2.TabIndex = 33;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToAddRows = false;
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(10, 72);
            this.gridResult.Name = "gridResult";
            this.gridResult.ReadOnly = true;
            this.gridResult.Size = new System.Drawing.Size(976, 427);
            this.gridResult.TabIndex = 11;
            // 
            // btnLoadSearch
            // 
            this.btnLoadSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadSearch.Location = new System.Drawing.Point(785, 26);
            this.btnLoadSearch.Name = "btnLoadSearch";
            this.btnLoadSearch.Size = new System.Drawing.Size(92, 26);
            this.btnLoadSearch.TabIndex = 10;
            this.btnLoadSearch.Text = "Показать";
            this.btnLoadSearch.UseVisualStyleBackColor = true;
            this.btnLoadSearch.Click += new System.EventHandler(this.btnLoadSearch_Click);
            // 
            // tbCondition
            // 
            this.tbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCondition.Location = new System.Drawing.Point(525, 26);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(240, 26);
            this.tbCondition.TabIndex = 9;
            // 
            // cbCondition
            // 
            this.cbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "<",
            "<=",
            ">",
            ">=",
            "=",
            "<>",
            "between",
            "not between",
            "in",
            "not in",
            "like",
            "not like"});
            this.cbCondition.Location = new System.Drawing.Point(348, 24);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(152, 28);
            this.cbCondition.TabIndex = 8;
            // 
            // cbColumns
            // 
            this.cbColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(177, 24);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(152, 28);
            this.cbColumns.TabIndex = 7;
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(10, 24);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(152, 28);
            this.cbTables.TabIndex = 6;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(894, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 530);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС Складской учет \"У Дмитрия\"";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.tabControl.ResumeLayout(false);
            this.tpBuys.ResumeLayout(false);
            this.tpBuys.PerformLayout();
            this.tpProviders.ResumeLayout(false);
            this.tpProviders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.tpDiscount.ResumeLayout(false);
            this.tpDiscount.PerformLayout();
            this.tpStaff.ResumeLayout(false);
            this.tpStaff.PerformLayout();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpBuys;
        private System.Windows.Forms.TabPage tpProviders;
        private System.Windows.Forms.DataGridView gridBuys;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCreateCheck;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.TabPage tpDiscount;
        private System.Windows.Forms.TabPage tpStaff;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpReport;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProvider;
        private System.Windows.Forms.Button btnRemoveProvider;
        private System.Windows.Forms.Button btnCreateProvider;
        private System.Windows.Forms.Button btnSaveProvider;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.DataGridView gridDiscount;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAccrued;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAccrued;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.DataGridView gridStaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Button btnLoadSearch;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.ComboBox cbTables;
    }
}