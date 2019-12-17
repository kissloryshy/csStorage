namespace Storage
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
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.btnUpdateCatalog = new System.Windows.Forms.Button();
            this.btnCreateCheck = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnPermissionChenging = new System.Windows.Forms.Button();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gridBuys = new System.Windows.Forms.DataGridView();
            this.btnConst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuys)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPosition.Location = new System.Drawing.Point(6, 52);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(65, 20);
            this.lbPosition.TabIndex = 0;
            this.lbPosition.Text = "Position";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(8, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(12, 97);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(979, 200);
            this.gridProducts.TabIndex = 4;
            this.gridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellDoubleClick);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProvider.Location = new System.Drawing.Point(31, 421);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(212, 25);
            this.btnAddProvider.TabIndex = 5;
            this.btnAddProvider.Text = "Управление поставщиками";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // btnUpdateCatalog
            // 
            this.btnUpdateCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateCatalog.Location = new System.Drawing.Point(519, 463);
            this.btnUpdateCatalog.Name = "btnUpdateCatalog";
            this.btnUpdateCatalog.Size = new System.Drawing.Size(472, 25);
            this.btnUpdateCatalog.TabIndex = 6;
            this.btnUpdateCatalog.Text = "Обновить товары";
            this.btnUpdateCatalog.UseVisualStyleBackColor = true;
            this.btnUpdateCatalog.Click += new System.EventHandler(this.btnUpdateCatalog_Click);
            // 
            // btnCreateCheck
            // 
            this.btnCreateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateCheck.Location = new System.Drawing.Point(519, 421);
            this.btnCreateCheck.Name = "btnCreateCheck";
            this.btnCreateCheck.Size = new System.Drawing.Size(161, 25);
            this.btnCreateCheck.TabIndex = 7;
            this.btnCreateCheck.Text = "Сформировать чек";
            this.btnCreateCheck.UseVisualStyleBackColor = true;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProducts.Location = new System.Drawing.Point(31, 463);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(212, 25);
            this.btnAddProducts.TabIndex = 8;
            this.btnAddProducts.Text = "Добавление товара";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscount.Location = new System.Drawing.Point(293, 463);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(176, 25);
            this.btnDiscount.TabIndex = 9;
            this.btnDiscount.Text = "Управление скидками";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(308, 421);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(161, 25);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Продать";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(30, 540);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(212, 25);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Отчеты";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPersonal.Location = new System.Drawing.Point(293, 540);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(161, 25);
            this.btnPersonal.TabIndex = 13;
            this.btnPersonal.Text = "Управление кадрами";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnPermissionChenging
            // 
            this.btnPermissionChenging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPermissionChenging.Location = new System.Drawing.Point(31, 587);
            this.btnPermissionChenging.Name = "btnPermissionChenging";
            this.btnPermissionChenging.Size = new System.Drawing.Size(212, 25);
            this.btnPermissionChenging.TabIndex = 15;
            this.btnPermissionChenging.Text = "Изменение прав";
            this.btnPermissionChenging.UseVisualStyleBackColor = true;
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccountSetting.Location = new System.Drawing.Point(861, 18);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Size = new System.Drawing.Size(130, 23);
            this.btnAccountSetting.TabIndex = 16;
            this.btnAccountSetting.Text = "Настройки Аккаунта";
            this.btnAccountSetting.UseVisualStyleBackColor = true;
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(861, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridBuys
            // 
            this.gridBuys.AllowUserToAddRows = false;
            this.gridBuys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBuys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuys.Location = new System.Drawing.Point(12, 303);
            this.gridBuys.MultiSelect = false;
            this.gridBuys.Name = "gridBuys";
            this.gridBuys.Size = new System.Drawing.Size(979, 95);
            this.gridBuys.TabIndex = 18;
            // 
            // btnConst
            // 
            this.btnConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConst.Location = new System.Drawing.Point(545, 555);
            this.btnConst.Name = "btnConst";
            this.btnConst.Size = new System.Drawing.Size(212, 25);
            this.btnConst.TabIndex = 19;
            this.btnConst.Text = "Конструктор";
            this.btnConst.UseVisualStyleBackColor = true;
            this.btnConst.Click += new System.EventHandler(this.btnConst_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 636);
            this.Controls.Add(this.btnConst);
            this.Controls.Add(this.gridBuys);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccountSetting);
            this.Controls.Add(this.btnPermissionChenging);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnCreateCheck);
            this.Controls.Add(this.btnUpdateCatalog);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС Складской учет \"У Дмитрия\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Button btnUpdateCatalog;
        private System.Windows.Forms.Button btnCreateCheck;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnPermissionChenging;
        private System.Windows.Forms.Button btnAccountSetting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gridBuys;
        private System.Windows.Forms.Button btnConst;
    }
}