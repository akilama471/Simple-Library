namespace SarasaviLibrary.Forms
{
    partial class BookListForm
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
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openAddBookButton = new System.Windows.Forms.Button();
            this.editSelectedBookButton = new System.Windows.Forms.Button();
            this.deleteSelectedBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AllowUserToOrderColumns = true;
            this.bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 50);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGridView.Size = new System.Drawing.Size(800, 400);
            this.bookDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.openAddBookButton);
            this.panel1.Controls.Add(this.editSelectedBookButton);
            this.panel1.Controls.Add(this.deleteSelectedBookButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 4;
            // 
            // openAddBookButton
            // 
            this.openAddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openAddBookButton.Location = new System.Drawing.Point(607, 6);
            this.openAddBookButton.Name = "openAddBookButton";
            this.openAddBookButton.Size = new System.Drawing.Size(60, 36);
            this.openAddBookButton.TabIndex = 8;
            this.openAddBookButton.Text = "Add";
            this.openAddBookButton.UseVisualStyleBackColor = true;
            // 
            // editSelectedBookButton
            // 
            this.editSelectedBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSelectedBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.editSelectedBookButton.Location = new System.Drawing.Point(672, 6);
            this.editSelectedBookButton.Name = "editSelectedBookButton";
            this.editSelectedBookButton.Size = new System.Drawing.Size(60, 36);
            this.editSelectedBookButton.TabIndex = 7;
            this.editSelectedBookButton.Text = "Edit";
            this.editSelectedBookButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedBookButton
            // 
            this.deleteSelectedBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.deleteSelectedBookButton.Location = new System.Drawing.Point(736, 6);
            this.deleteSelectedBookButton.Name = "deleteSelectedBookButton";
            this.deleteSelectedBookButton.Size = new System.Drawing.Size(60, 36);
            this.deleteSelectedBookButton.TabIndex = 6;
            this.deleteSelectedBookButton.Text = "Delete";
            this.deleteSelectedBookButton.UseVisualStyleBackColor = true;
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "BookListForm";
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openAddBookButton;
        private System.Windows.Forms.Button editSelectedBookButton;
        private System.Windows.Forms.Button deleteSelectedBookButton;
    }
}