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
            this.searchBookNumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.searchBookPublisherInput = new System.Windows.Forms.ComboBox();
            this.searchBookAuthorInput = new System.Windows.Forms.ComboBox();
            this.searchBookNameInput = new System.Windows.Forms.ComboBox();
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
            this.bookDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 56);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGridView.Size = new System.Drawing.Size(1082, 394);
            this.bookDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.searchBookNumberInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBookButton);
            this.panel1.Controls.Add(this.searchBookPublisherInput);
            this.panel1.Controls.Add(this.searchBookAuthorInput);
            this.panel1.Controls.Add(this.searchBookNameInput);
            this.panel1.Controls.Add(this.openAddBookButton);
            this.panel1.Controls.Add(this.editSelectedBookButton);
            this.panel1.Controls.Add(this.deleteSelectedBookButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 56);
            this.panel1.TabIndex = 4;
            // 
            // searchBookNumberInput
            // 
            this.searchBookNumberInput.Location = new System.Drawing.Point(6, 25);
            this.searchBookNumberInput.Name = "searchBookNumberInput";
            this.searchBookNumberInput.Size = new System.Drawing.Size(185, 20);
            this.searchBookNumberInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(577, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Book Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(386, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Book Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Book Number";
            // 
            // searchBookButton
            // 
            this.searchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.searchBookButton.Location = new System.Drawing.Point(771, 11);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(76, 36);
            this.searchBookButton.TabIndex = 13;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // searchBookPublisherInput
            // 
            this.searchBookPublisherInput.FormattingEnabled = true;
            this.searchBookPublisherInput.Location = new System.Drawing.Point(580, 24);
            this.searchBookPublisherInput.Name = "searchBookPublisherInput";
            this.searchBookPublisherInput.Size = new System.Drawing.Size(185, 21);
            this.searchBookPublisherInput.TabIndex = 12;
            // 
            // searchBookAuthorInput
            // 
            this.searchBookAuthorInput.FormattingEnabled = true;
            this.searchBookAuthorInput.Location = new System.Drawing.Point(389, 24);
            this.searchBookAuthorInput.Name = "searchBookAuthorInput";
            this.searchBookAuthorInput.Size = new System.Drawing.Size(185, 21);
            this.searchBookAuthorInput.TabIndex = 11;
            // 
            // searchBookNameInput
            // 
            this.searchBookNameInput.FormattingEnabled = true;
            this.searchBookNameInput.Location = new System.Drawing.Point(198, 24);
            this.searchBookNameInput.Name = "searchBookNameInput";
            this.searchBookNameInput.Size = new System.Drawing.Size(185, 21);
            this.searchBookNameInput.TabIndex = 10;
            // 
            // openAddBookButton
            // 
            this.openAddBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openAddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openAddBookButton.Location = new System.Drawing.Point(889, 9);
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
            this.editSelectedBookButton.Location = new System.Drawing.Point(954, 9);
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
            this.deleteSelectedBookButton.Location = new System.Drawing.Point(1018, 9);
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
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "BookListForm";
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openAddBookButton;
        private System.Windows.Forms.Button editSelectedBookButton;
        private System.Windows.Forms.Button deleteSelectedBookButton;
        private System.Windows.Forms.ComboBox searchBookAuthorInput;
        private System.Windows.Forms.ComboBox searchBookNameInput;
        private System.Windows.Forms.ComboBox searchBookPublisherInput;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBookNumberInput;
    }
}