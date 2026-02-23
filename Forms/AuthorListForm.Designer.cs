namespace SarasaviLibrary.Forms
{
    partial class AuthorListForm
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
            this.authorDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openAddAuthorButton = new System.Windows.Forms.Button();
            this.editSelectedAuthorButton = new System.Windows.Forms.Button();
            this.deleteSelectedAuthorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorDataGridView
            // 
            this.authorDataGridView.AllowUserToAddRows = false;
            this.authorDataGridView.AllowUserToDeleteRows = false;
            this.authorDataGridView.AllowUserToOrderColumns = true;
            this.authorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorDataGridView.Location = new System.Drawing.Point(0, 46);
            this.authorDataGridView.Name = "authorDataGridView";
            this.authorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorDataGridView.Size = new System.Drawing.Size(800, 404);
            this.authorDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.openAddAuthorButton);
            this.panel1.Controls.Add(this.editSelectedAuthorButton);
            this.panel1.Controls.Add(this.deleteSelectedAuthorButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 2;
            // 
            // openAddAuthorButton
            // 
            this.openAddAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openAddAuthorButton.Location = new System.Drawing.Point(4, 6);
            this.openAddAuthorButton.Name = "openAddAuthorButton";
            this.openAddAuthorButton.Size = new System.Drawing.Size(60, 36);
            this.openAddAuthorButton.TabIndex = 5;
            this.openAddAuthorButton.Text = "Add";
            this.openAddAuthorButton.UseVisualStyleBackColor = true;
            this.openAddAuthorButton.Click += new System.EventHandler(this.OpenAddAuthorButton_Click);
            // 
            // editSelectedAuthorButton
            // 
            this.editSelectedAuthorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSelectedAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.editSelectedAuthorButton.Location = new System.Drawing.Point(671, 7);
            this.editSelectedAuthorButton.Name = "editSelectedAuthorButton";
            this.editSelectedAuthorButton.Size = new System.Drawing.Size(60, 36);
            this.editSelectedAuthorButton.TabIndex = 4;
            this.editSelectedAuthorButton.Text = "Edit";
            this.editSelectedAuthorButton.UseVisualStyleBackColor = true;
            this.editSelectedAuthorButton.Click += new System.EventHandler(this.EditSelectedAuthorButton_Click);
            // 
            // deleteSelectedAuthorButton
            // 
            this.deleteSelectedAuthorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.deleteSelectedAuthorButton.Location = new System.Drawing.Point(735, 7);
            this.deleteSelectedAuthorButton.Name = "deleteSelectedAuthorButton";
            this.deleteSelectedAuthorButton.Size = new System.Drawing.Size(60, 36);
            this.deleteSelectedAuthorButton.TabIndex = 3;
            this.deleteSelectedAuthorButton.Text = "Delete";
            this.deleteSelectedAuthorButton.UseVisualStyleBackColor = true;
            this.deleteSelectedAuthorButton.Click += new System.EventHandler(this.DeleteSelectedAuthorButton_Click);
            // 
            // AuthorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "AuthorListForm";
            this.Text = "Author List";
            this.Load += new System.EventHandler(this.AuthorListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView authorDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openAddAuthorButton;
        private System.Windows.Forms.Button editSelectedAuthorButton;
        private System.Windows.Forms.Button deleteSelectedAuthorButton;
    }
}