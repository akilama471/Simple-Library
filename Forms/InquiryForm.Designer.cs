namespace SarasaviLibrary.Forms
{
    partial class InquiryForm
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
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.rdoTitle = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoAuthor = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoCopy = new MaterialSkin.Controls.MaterialRadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(12, 19);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(264, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(283, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(64, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // rdoTitle
            // 
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.Depth = 0;
            this.rdoTitle.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoTitle.Location = new System.Drawing.Point(28, 45);
            this.rdoTitle.Margin = new System.Windows.Forms.Padding(0);
            this.rdoTitle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.Ripple = true;
            this.rdoTitle.Size = new System.Drawing.Size(75, 30);
            this.rdoTitle.TabIndex = 2;
            this.rdoTitle.TabStop = true;
            this.rdoTitle.Text = "By Title";
            this.rdoTitle.UseVisualStyleBackColor = true;
            // 
            // rdoAuthor
            // 
            this.rdoAuthor.AutoSize = true;
            this.rdoAuthor.Depth = 0;
            this.rdoAuthor.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoAuthor.Location = new System.Drawing.Point(201, 45);
            this.rdoAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.rdoAuthor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoAuthor.Name = "rdoAuthor";
            this.rdoAuthor.Ripple = true;
            this.rdoAuthor.Size = new System.Drawing.Size(89, 30);
            this.rdoAuthor.TabIndex = 3;
            this.rdoAuthor.TabStop = true;
            this.rdoAuthor.Text = "By Author";
            this.rdoAuthor.UseVisualStyleBackColor = true;
            // 
            // rdoCopy
            // 
            this.rdoCopy.AutoSize = true;
            this.rdoCopy.Depth = 0;
            this.rdoCopy.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoCopy.Location = new System.Drawing.Point(377, 45);
            this.rdoCopy.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCopy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoCopy.Name = "rdoCopy";
            this.rdoCopy.Ripple = true;
            this.rdoCopy.Size = new System.Drawing.Size(79, 30);
            this.rdoCopy.TabIndex = 4;
            this.rdoCopy.TabStop = true;
            this.rdoCopy.Text = "By Copy";
            this.rdoCopy.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 364);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoCopy);
            this.panel2.Controls.Add(this.rdoAuthor);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.rdoTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 86);
            this.panel2.TabIndex = 7;
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "InquiryForm";
            this.Text = "Book Inquiry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private MaterialSkin.Controls.MaterialRadioButton rdoTitle;
        private MaterialSkin.Controls.MaterialRadioButton rdoAuthor;
        private MaterialSkin.Controls.MaterialRadioButton rdoCopy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}
