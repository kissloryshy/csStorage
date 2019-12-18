namespace Storage
{
    partial class Const
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
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gridResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(12, 12);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(152, 28);
            this.cbTables.TabIndex = 0;
            this.cbTables.SelectedValueChanged += new System.EventHandler(this.cbTables_SelectedValueChanged);
            // 
            // cbColumns
            // 
            this.cbColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(179, 12);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(152, 28);
            this.cbColumns.TabIndex = 1;
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
            this.cbCondition.Location = new System.Drawing.Point(350, 12);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(152, 28);
            this.cbCondition.TabIndex = 2;
            // 
            // tbCondition
            // 
            this.tbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCondition.Location = new System.Drawing.Point(527, 14);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(350, 26);
            this.tbCondition.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(896, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 26);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Показать";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridResult
            // 
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(12, 60);
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(976, 414);
            this.gridResult.TabIndex = 5;
            // 
            // Const
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 486);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.cbColumns);
            this.Controls.Add(this.cbTables);
            this.Name = "Const";
            this.Text = "Const";
            this.Load += new System.EventHandler(this.Const_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView gridResult;
    }
}