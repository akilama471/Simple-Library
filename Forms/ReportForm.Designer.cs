namespace SarasaviLibrary.Forms
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.pnlMemberSearch = new System.Windows.Forms.Panel();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.rbAllBorrow = new System.Windows.Forms.RadioButton();
            this.rbActiveBorrow = new System.Windows.Forms.RadioButton();
            this.chkDelayedBorrow = new System.Windows.Forms.CheckBox();
            this.pnlMemberSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(137, 18);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(250, 25);
            this.cmbReportType.TabIndex = 0;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(21, 21);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(110, 19);
            this.lblReportType.TabIndex = 1;
            this.lblReportType.Text = "Select Report:";
            // 
            // pnlMemberSearch
            // 
            this.pnlMemberSearch.Controls.Add(this.btnSearchMember);
            this.pnlMemberSearch.Controls.Add(this.txtMemberId);
            this.pnlMemberSearch.Controls.Add(this.lblMemberId);
            this.pnlMemberSearch.Location = new System.Drawing.Point(420, 11);
            this.pnlMemberSearch.Name = "pnlMemberSearch";
            this.pnlMemberSearch.Size = new System.Drawing.Size(350, 40);
            this.pnlMemberSearch.TabIndex = 2;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(230, 6);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(100, 27);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(100, 7);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(120, 25);
            this.txtMemberId.TabIndex = 1;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(10, 10);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(82, 19);
            this.lblMemberId.TabIndex = 0;
            this.lblMemberId.Text = "Member ID:";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 60);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.Height = 25;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(800, 390);
            this.dgvReport.TabIndex = 3;
            this.dgvReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReport_CellFormatting);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblReportType);
            this.pnlTop.Controls.Add(this.cmbReportType);
            this.pnlTop.Controls.Add(this.pnlMemberSearch);
            this.pnlTop.Controls.Add(this.pnlFilters);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 60);
            this.pnlTop.TabIndex = 4;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.chkDelayedBorrow);
            this.pnlFilters.Controls.Add(this.rbActiveBorrow);
            this.pnlFilters.Controls.Add(this.rbAllBorrow);
            this.pnlFilters.Location = new System.Drawing.Point(420, 11);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(350, 40);
            this.pnlFilters.TabIndex = 5;
            // 
            // rbAllBorrow
            // 
            this.rbAllBorrow.AutoSize = true;
            this.rbAllBorrow.Checked = true;
            this.rbAllBorrow.Location = new System.Drawing.Point(3, 11);
            this.rbAllBorrow.Name = "rbAllBorrow";
            this.rbAllBorrow.Size = new System.Drawing.Size(80, 19);
            this.rbAllBorrow.TabIndex = 0;
            this.rbAllBorrow.TabStop = true;
            this.rbAllBorrow.Text = "All Borrow";
            this.rbAllBorrow.UseVisualStyleBackColor = true;
            this.rbAllBorrow.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // rbActiveBorrow
            // 
            this.rbActiveBorrow.AutoSize = true;
            this.rbActiveBorrow.Location = new System.Drawing.Point(89, 11);
            this.rbActiveBorrow.Name = "rbActiveBorrow";
            this.rbActiveBorrow.Size = new System.Drawing.Size(98, 19);
            this.rbActiveBorrow.TabIndex = 1;
            this.rbActiveBorrow.Text = "Active Borrow";
            this.rbActiveBorrow.UseVisualStyleBackColor = true;
            this.rbActiveBorrow.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkDelayedBorrow
            // 
            this.chkDelayedBorrow.AutoSize = true;
            this.chkDelayedBorrow.Location = new System.Drawing.Point(193, 11);
            this.chkDelayedBorrow.Name = "chkDelayedBorrow";
            this.chkDelayedBorrow.Size = new System.Drawing.Size(110, 19);
            this.chkDelayedBorrow.TabIndex = 2;
            this.chkDelayedBorrow.Text = "Delayed Borrow";
            this.chkDelayedBorrow.UseVisualStyleBackColor = true;
            this.chkDelayedBorrow.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Reports";
            this.pnlMemberSearch.ResumeLayout(false);
            this.pnlMemberSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Panel pnlMemberSearch;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.RadioButton rbAllBorrow;
        private System.Windows.Forms.RadioButton rbActiveBorrow;
        private System.Windows.Forms.CheckBox chkDelayedBorrow;
    }
}
