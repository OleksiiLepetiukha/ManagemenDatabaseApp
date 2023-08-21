namespace ManagemenDatabase
{
    partial class DataFromFile
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
            this.components = new System.ComponentModel.Container();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnSearcFile = new System.Windows.Forms.Button();
            this.ttButton = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(150, 97);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(443, 199);
            this.dgvData.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Red;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Location = new System.Drawing.Point(670, 310);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "&Close";
            this.ttButton.SetToolTip(this.btnCloseForm, "Click to close this window");
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(367, 54);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 2;
            // 
            // btnSearcFile
            // 
            this.btnSearcFile.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearcFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearcFile.Location = new System.Drawing.Point(670, 54);
            this.btnSearcFile.Name = "btnSearcFile";
            this.btnSearcFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearcFile.TabIndex = 3;
            this.btnSearcFile.Text = "&Search";
            this.ttButton.SetToolTip(this.btnSearcFile, "click to open search form");
            this.btnSearcFile.UseVisualStyleBackColor = false;
            this.btnSearcFile.Click += new System.EventHandler(this.btnSearcFile_Click);
            // 
            // DataFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnSearcFile);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.dgvData);
            this.Name = "DataFromFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataFromFile";
            this.Load += new System.EventHandler(this.DataFromFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnSearcFile;
        private System.Windows.Forms.ToolTip ttButton;
    }
}