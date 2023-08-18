namespace ManagemenDatabase
{
    partial class frmSearch
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.dgvDataSearch = new System.Windows.Forms.DataGridView();
            this.cboTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(672, 39);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lblValue);
            this.gbSearch.Controls.Add(this.lblOperator);
            this.gbSearch.Controls.Add(this.lblField);
            this.gbSearch.Controls.Add(this.cboField);
            this.gbSearch.Controls.Add(this.cboOperator);
            this.gbSearch.Controls.Add(this.txtValue);
            this.gbSearch.Location = new System.Drawing.Point(53, 39);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(414, 128);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Serach Records";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(296, 58);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "Value";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(162, 58);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Operator";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(12, 58);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(29, 13);
            this.lblField.TabIndex = 5;
            this.lblField.Text = "Field";
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Forename",
            "Surname",
            "Dept. Number"});
            this.cboField.Location = new System.Drawing.Point(15, 86);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 0;
            // 
            // cboOperator
            // 
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cboOperator.Location = new System.Drawing.Point(165, 86);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(100, 21);
            this.cboOperator.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(299, 87);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 2;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(53, 202);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(414, 207);
            this.dgvSearch.TabIndex = 7;
            // 
            // dgvDataSearch
            // 
            this.dgvDataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSearch.Location = new System.Drawing.Point(506, 202);
            this.dgvDataSearch.Name = "dgvDataSearch";
            this.dgvDataSearch.Size = new System.Drawing.Size(414, 207);
            this.dgvDataSearch.TabIndex = 11;
            // 
            // cboTables
            // 
            this.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTables.FormattingEnabled = true;
            this.cboTables.Items.AddRange(new object[] {
            "From DataBase",
            "From File"});
            this.cboTables.Location = new System.Drawing.Point(778, 39);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(100, 21);
            this.cboTables.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From Data Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "From File";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTables);
            this.Controls.Add(this.dgvDataSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvSearch);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridView dgvDataSearch;
        private System.Windows.Forms.ComboBox cboTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}