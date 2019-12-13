namespace Storage.Forms
{
    partial class Discount
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
            this.gridDiscount = new System.Windows.Forms.DataGridView();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDiscount
            // 
            this.gridDiscount.AllowUserToAddRows = false;
            this.gridDiscount.AllowUserToDeleteRows = false;
            this.gridDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiscount.Location = new System.Drawing.Point(12, 12);
            this.gridDiscount.Name = "gridDiscount";
            this.gridDiscount.Size = new System.Drawing.Size(437, 150);
            this.gridDiscount.TabIndex = 0;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(12, 181);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnAddDiscount.TabIndex = 1;
            this.btnAddDiscount.Text = "Добавить";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSize.Location = new System.Drawing.Point(12, 223);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(58, 16);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Размер";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(12, 262);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(113, 16);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Дата окончания";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(221, 256);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(206, 22);
            this.dtpEndTime.TabIndex = 4;
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSize.Location = new System.Drawing.Point(221, 220);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(206, 22);
            this.tbSize.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.gridDiscount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Discount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление скидками";
            this.Load += new System.EventHandler(this.Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnDelete;
    }
}