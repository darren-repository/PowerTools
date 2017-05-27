namespace PowerTools
{
    partial class frmPowerTools
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
            this.grpEnableOfficeStoreAddin = new System.Windows.Forms.GroupBox();
            this.lblEnableOfficeStoreAddin = new System.Windows.Forms.Label();
            this.rbEnableOfficeStoreAddinNo = new System.Windows.Forms.RadioButton();
            this.rbEnableOfficeStoreAddinYes = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMajorVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMinorVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEnableOfficeStoreAddin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEnableOfficeStoreAddin
            // 
            this.grpEnableOfficeStoreAddin.Controls.Add(this.lblEnableOfficeStoreAddin);
            this.grpEnableOfficeStoreAddin.Controls.Add(this.rbEnableOfficeStoreAddinNo);
            this.grpEnableOfficeStoreAddin.Controls.Add(this.rbEnableOfficeStoreAddinYes);
            this.grpEnableOfficeStoreAddin.Location = new System.Drawing.Point(2, 12);
            this.grpEnableOfficeStoreAddin.Name = "grpEnableOfficeStoreAddin";
            this.grpEnableOfficeStoreAddin.Size = new System.Drawing.Size(286, 36);
            this.grpEnableOfficeStoreAddin.TabIndex = 1;
            this.grpEnableOfficeStoreAddin.TabStop = false;
            // 
            // lblEnableOfficeStoreAddin
            // 
            this.lblEnableOfficeStoreAddin.AutoSize = true;
            this.lblEnableOfficeStoreAddin.Location = new System.Drawing.Point(6, 16);
            this.lblEnableOfficeStoreAddin.Name = "lblEnableOfficeStoreAddin";
            this.lblEnableOfficeStoreAddin.Size = new System.Drawing.Size(183, 13);
            this.lblEnableOfficeStoreAddin.TabIndex = 5;
            this.lblEnableOfficeStoreAddin.Text = "Enable Windows Store Add-In Office:";
            // 
            // rbEnableOfficeStoreAddinNo
            // 
            this.rbEnableOfficeStoreAddinNo.AutoSize = true;
            this.rbEnableOfficeStoreAddinNo.Location = new System.Drawing.Point(243, 14);
            this.rbEnableOfficeStoreAddinNo.Name = "rbEnableOfficeStoreAddinNo";
            this.rbEnableOfficeStoreAddinNo.Size = new System.Drawing.Size(39, 17);
            this.rbEnableOfficeStoreAddinNo.TabIndex = 4;
            this.rbEnableOfficeStoreAddinNo.TabStop = true;
            this.rbEnableOfficeStoreAddinNo.Text = "No";
            this.rbEnableOfficeStoreAddinNo.UseVisualStyleBackColor = true;
            this.rbEnableOfficeStoreAddinNo.CheckedChanged += new System.EventHandler(this.rbEnableOfficeStoreAddinNo_CheckedChanged);
            // 
            // rbEnableOfficeStoreAddinYes
            // 
            this.rbEnableOfficeStoreAddinYes.AutoSize = true;
            this.rbEnableOfficeStoreAddinYes.Location = new System.Drawing.Point(194, 14);
            this.rbEnableOfficeStoreAddinYes.Name = "rbEnableOfficeStoreAddinYes";
            this.rbEnableOfficeStoreAddinYes.Size = new System.Drawing.Size(43, 17);
            this.rbEnableOfficeStoreAddinYes.TabIndex = 3;
            this.rbEnableOfficeStoreAddinYes.TabStop = true;
            this.rbEnableOfficeStoreAddinYes.Text = "Yes";
            this.rbEnableOfficeStoreAddinYes.UseVisualStyleBackColor = true;
            this.rbEnableOfficeStoreAddinYes.CheckedChanged += new System.EventHandler(this.rbEnableOfficeStoreAddinYes_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.clnPath,
            this.clnMajorVersion,
            this.clnMinorVersion,
            this.clnGUID});
            this.dataGridView1.Location = new System.Drawing.Point(11, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(417, 248);
            this.dataGridView1.TabIndex = 3;
            // 
            // clnName
            // 
            this.clnName.HeaderText = "Name";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            // 
            // clnPath
            // 
            this.clnPath.HeaderText = "Path";
            this.clnPath.Name = "clnPath";
            this.clnPath.ReadOnly = true;
            // 
            // clnMajorVersion
            // 
            this.clnMajorVersion.HeaderText = "Major Version";
            this.clnMajorVersion.Name = "clnMajorVersion";
            this.clnMajorVersion.ReadOnly = true;
            // 
            // clnMinorVersion
            // 
            this.clnMinorVersion.HeaderText = "Minor Version";
            this.clnMinorVersion.Name = "clnMinorVersion";
            this.clnMinorVersion.ReadOnly = true;
            // 
            // clnGUID
            // 
            this.clnGUID.HeaderText = "GUID";
            this.clnGUID.Name = "clnGUID";
            this.clnGUID.ReadOnly = true;
            // 
            // frmPowerTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpEnableOfficeStoreAddin);
            this.Name = "frmPowerTools";
            this.Text = "Power Tools";
            this.Load += new System.EventHandler(this.frmPowerTools_Load);
            this.grpEnableOfficeStoreAddin.ResumeLayout(false);
            this.grpEnableOfficeStoreAddin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEnableOfficeStoreAddin;
        private System.Windows.Forms.Label lblEnableOfficeStoreAddin;
        private System.Windows.Forms.RadioButton rbEnableOfficeStoreAddinNo;
        private System.Windows.Forms.RadioButton rbEnableOfficeStoreAddinYes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMajorVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMinorVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGUID;
    }
}

