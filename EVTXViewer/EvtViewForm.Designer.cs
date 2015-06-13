namespace EVTXViewer
{
    partial class EvtViewForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.grdEvtxData = new Telerik.WinControls.UI.RadGridView();
            this.txtFilePath = new Telerik.WinControls.UI.RadTextBox();
            this.btnFileSelect = new Telerik.WinControls.UI.RadButton();
            this.btnFileImport = new Telerik.WinControls.UI.RadButton();
            this.btnExportCSV = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvtxData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvtxData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEvtxData
            // 
            this.grdEvtxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEvtxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.grdEvtxData.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdEvtxData.EnableAnalytics = false;
            this.grdEvtxData.EnableFastScrolling = true;
            this.grdEvtxData.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdEvtxData.ForeColor = System.Drawing.Color.Black;
            this.grdEvtxData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdEvtxData.Location = new System.Drawing.Point(12, 42);
            // 
            // 
            // 
            this.grdEvtxData.MasterTemplate.AllowAddNewRow = false;
            this.grdEvtxData.MasterTemplate.AllowEditRow = false;
            this.grdEvtxData.MasterTemplate.AllowSearchRow = true;
            this.grdEvtxData.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 64;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<byte>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Version";
            gridViewDecimalColumn2.HeaderText = "Version";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Version";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 73;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Qualifiers";
            gridViewDecimalColumn3.HeaderText = "Qualifiers";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Qualifiers";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.Width = 73;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<byte>);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Level";
            gridViewDecimalColumn4.HeaderText = "Level";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Level";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewDecimalColumn4.Width = 73;
            gridViewDecimalColumn5.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Task";
            gridViewDecimalColumn5.HeaderText = "Task";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "Task";
            gridViewDecimalColumn5.ReadOnly = true;
            gridViewDecimalColumn5.Width = 73;
            gridViewDecimalColumn6.DataType = typeof(System.Nullable<short>);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "Opcode";
            gridViewDecimalColumn6.HeaderText = "Opcode";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "Opcode";
            gridViewDecimalColumn6.ReadOnly = true;
            gridViewDecimalColumn6.Width = 73;
            gridViewDecimalColumn7.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "Keywords";
            gridViewDecimalColumn7.HeaderText = "Keywords";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "Keywords";
            gridViewDecimalColumn7.ReadOnly = true;
            gridViewDecimalColumn7.Width = 73;
            gridViewDecimalColumn8.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "RecordId";
            gridViewDecimalColumn8.HeaderText = "RecordId";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "RecordId";
            gridViewDecimalColumn8.ReadOnly = true;
            gridViewDecimalColumn8.Width = 73;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ProviderName";
            gridViewTextBoxColumn1.HeaderText = "ProviderName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ProviderName";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ProviderId";
            gridViewTextBoxColumn2.HeaderText = "ProviderId";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ProviderId";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 73;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "LogName";
            gridViewTextBoxColumn3.HeaderText = "LogName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "LogName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 75;
            gridViewDecimalColumn9.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "ProcessId";
            gridViewDecimalColumn9.HeaderText = "ProcessId";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "ProcessId";
            gridViewDecimalColumn9.ReadOnly = true;
            gridViewDecimalColumn9.Width = 73;
            gridViewDecimalColumn10.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "ThreadId";
            gridViewDecimalColumn10.HeaderText = "ThreadId";
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.Name = "ThreadId";
            gridViewDecimalColumn10.ReadOnly = true;
            gridViewDecimalColumn10.Width = 73;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "MachineName";
            gridViewTextBoxColumn4.HeaderText = "MachineName";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "MachineName";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 81;
            gridViewTextBoxColumn5.DataType = typeof(System.Security.Principal.SecurityIdentifier);
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "UserId";
            gridViewTextBoxColumn5.HeaderText = "UserId";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "UserId";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 73;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "TimeCreated";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "TimeCreated";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "TimeCreated";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 73;
            gridViewTextBoxColumn6.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ActivityId";
            gridViewTextBoxColumn6.HeaderText = "ActivityId";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ActivityId";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 73;
            gridViewTextBoxColumn7.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "RelatedActivityId";
            gridViewTextBoxColumn7.HeaderText = "RelatedActivityId";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "RelatedActivityId";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 92;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ContainerLog";
            gridViewTextBoxColumn8.HeaderText = "ContainerLog";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "ContainerLog";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 75;
            gridViewTextBoxColumn9.DataType = typeof(System.Collections.Generic.IEnumerable<int>);
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "MatchedQueryIds";
            gridViewTextBoxColumn9.HeaderText = "MatchedQueryIds";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "MatchedQueryIds";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 97;
            gridViewTextBoxColumn10.DataType = typeof(System.Diagnostics.Eventing.Reader.EventBookmark);
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Bookmark";
            gridViewTextBoxColumn10.HeaderText = "Bookmark";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Bookmark";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 73;
            gridViewTextBoxColumn11.DataType = typeof(System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventProperty>);
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Properties";
            gridViewTextBoxColumn11.HeaderText = "Properties";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "Properties";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.Width = 73;
            this.grdEvtxData.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.grdEvtxData.MasterTemplate.EnableFiltering = true;
            this.grdEvtxData.Name = "grdEvtxData";
            this.grdEvtxData.ReadOnly = true;
            this.grdEvtxData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdEvtxData.Size = new System.Drawing.Size(700, 336);
            this.grdEvtxData.TabIndex = 0;
            this.grdEvtxData.Text = "radGridView1";
            this.grdEvtxData.ThemeName = "ControlDefault";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(459, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.ThemeName = "ControlDefault";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(477, 10);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(67, 24);
            this.btnFileSelect.TabIndex = 2;
            this.btnFileSelect.Text = "Browse File";
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnFileImport
            // 
            this.btnFileImport.Location = new System.Drawing.Point(550, 10);
            this.btnFileImport.Name = "btnFileImport";
            this.btnFileImport.Size = new System.Drawing.Size(67, 24);
            this.btnFileImport.TabIndex = 2;
            this.btnFileImport.Text = "Import";
            this.btnFileImport.Click += new System.EventHandler(this.btnFileImport_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(623, 10);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(67, 24);
            this.btnExportCSV.TabIndex = 2;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // EvtViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 390);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnFileImport);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.grdEvtxData);
            this.Name = "EvtViewForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EVTX Viewer";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.grdEvtxData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvtxData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdEvtxData;
        private Telerik.WinControls.UI.RadTextBox txtFilePath;
        private Telerik.WinControls.UI.RadButton btnFileSelect;
        private Telerik.WinControls.UI.RadButton btnFileImport;
        private Telerik.WinControls.UI.RadButton btnExportCSV;

    }
}