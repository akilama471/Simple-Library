namespace SarasaviLibrary.Forms
{
    partial class BookAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.bookNameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddBookCopyButton = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.bookRefferanceInputField = new MaterialSkin.Controls.MaterialCheckBox();
            this.bookClassificationInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.bookISBNInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.isbnLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bookEditionInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.editionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bookCopyCountInputField = new System.Windows.Forms.NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.bookCopyGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyCountInputField)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Author :";
            // 
            // bookNameInputField
            // 
            this.bookNameInputField.Depth = 0;
            this.bookNameInputField.Hint = "";
            this.bookNameInputField.Location = new System.Drawing.Point(16, 140);
            this.bookNameInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookNameInputField.Name = "bookNameInputField";
            this.bookNameInputField.PasswordChar = '\0';
            this.bookNameInputField.SelectedText = "";
            this.bookNameInputField.SelectionLength = 0;
            this.bookNameInputField.SelectionStart = 0;
            this.bookNameInputField.Size = new System.Drawing.Size(509, 23);
            this.bookNameInputField.TabIndex = 17;
            this.bookNameInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Title :";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(16, 80);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(167, 23);
            this.materialSingleLineTextField1.TabIndex = 15;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Book Number :";
            // 
            // btnAddBookCopyButton
            // 
            this.btnAddBookCopyButton.BackColor = System.Drawing.Color.Aqua;
            this.btnAddBookCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBookCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAddBookCopyButton.Location = new System.Drawing.Point(424, 315);
            this.btnAddBookCopyButton.Name = "btnAddBookCopyButton";
            this.btnAddBookCopyButton.Size = new System.Drawing.Size(90, 36);
            this.btnAddBookCopyButton.TabIndex = 13;
            this.btnAddBookCopyButton.Text = "Add Copy";
            this.btnAddBookCopyButton.UseVisualStyleBackColor = false;
            this.btnAddBookCopyButton.Click += new System.EventHandler(this.btnAddBookCopyButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancel.Location = new System.Drawing.Point(5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 200);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(280, 178);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Publisher :";
            // 
            // bookRefferanceInputField
            // 
            this.bookRefferanceInputField.AutoSize = true;
            this.bookRefferanceInputField.Depth = 0;
            this.bookRefferanceInputField.Font = new System.Drawing.Font("Roboto", 10F);
            this.bookRefferanceInputField.Location = new System.Drawing.Point(296, 321);
            this.bookRefferanceInputField.Margin = new System.Windows.Forms.Padding(0);
            this.bookRefferanceInputField.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookRefferanceInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookRefferanceInputField.Name = "bookRefferanceInputField";
            this.bookRefferanceInputField.Ripple = true;
            this.bookRefferanceInputField.Size = new System.Drawing.Size(123, 30);
            this.bookRefferanceInputField.TabIndex = 24;
            this.bookRefferanceInputField.Text = "Reference Only";
            this.bookRefferanceInputField.UseVisualStyleBackColor = true;
            this.bookRefferanceInputField.CheckedChanged += new System.EventHandler(this.bookRefferanceInputField_CheckedChanged);
            // 
            // bookClassificationInputField
            // 
            this.bookClassificationInputField.Depth = 0;
            this.bookClassificationInputField.Hint = "";
            this.bookClassificationInputField.Location = new System.Drawing.Point(16, 320);
            this.bookClassificationInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookClassificationInputField.Name = "bookClassificationInputField";
            this.bookClassificationInputField.PasswordChar = '\0';
            this.bookClassificationInputField.SelectedText = "";
            this.bookClassificationInputField.SelectionLength = 0;
            this.bookClassificationInputField.SelectionStart = 0;
            this.bookClassificationInputField.Size = new System.Drawing.Size(228, 23);
            this.bookClassificationInputField.TabIndex = 29;
            this.bookClassificationInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 298);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(110, 19);
            this.materialLabel6.TabIndex = 28;
            this.materialLabel6.Text = "Classification :";
            // 
            // bookISBNInputField
            // 
            this.bookISBNInputField.Depth = 0;
            this.bookISBNInputField.Hint = "";
            this.bookISBNInputField.Location = new System.Drawing.Point(16, 260);
            this.bookISBNInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookISBNInputField.Name = "bookISBNInputField";
            this.bookISBNInputField.PasswordChar = '\0';
            this.bookISBNInputField.SelectedText = "";
            this.bookISBNInputField.SelectionLength = 0;
            this.bookISBNInputField.SelectionStart = 0;
            this.bookISBNInputField.Size = new System.Drawing.Size(228, 23);
            this.bookISBNInputField.TabIndex = 33;
            this.bookISBNInputField.UseSystemPasswordChar = false;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Depth = 0;
            this.isbnLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.isbnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.isbnLabel.Location = new System.Drawing.Point(12, 238);
            this.isbnLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(50, 19);
            this.isbnLabel.TabIndex = 32;
            this.isbnLabel.Text = "ISBN :";
            // 
            // bookEditionInputField
            // 
            this.bookEditionInputField.Depth = 0;
            this.bookEditionInputField.Hint = "";
            this.bookEditionInputField.Location = new System.Drawing.Point(284, 260);
            this.bookEditionInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookEditionInputField.Name = "bookEditionInputField";
            this.bookEditionInputField.PasswordChar = '\0';
            this.bookEditionInputField.SelectedText = "";
            this.bookEditionInputField.SelectionLength = 0;
            this.bookEditionInputField.SelectionStart = 0;
            this.bookEditionInputField.Size = new System.Drawing.Size(228, 23);
            this.bookEditionInputField.TabIndex = 35;
            this.bookEditionInputField.UseSystemPasswordChar = false;
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.Depth = 0;
            this.editionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.editionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editionLabel.Location = new System.Drawing.Point(280, 238);
            this.editionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(64, 19);
            this.editionLabel.TabIndex = 34;
            this.editionLabel.Text = "Edition :";
            // 
            // bookCopyCountInputField
            // 
            this.bookCopyCountInputField.Location = new System.Drawing.Point(426, 289);
            this.bookCopyCountInputField.Name = "bookCopyCountInputField";
            this.bookCopyCountInputField.Size = new System.Drawing.Size(86, 20);
            this.bookCopyCountInputField.TabIndex = 25;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(280, 287);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(139, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "Number of Copies :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 46);
            this.panel1.TabIndex = 36;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSubmit.Location = new System.Drawing.Point(465, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(60, 36);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bookCopyGrid
            // 
            this.bookCopyGrid.AllowUserToAddRows = false;
            this.bookCopyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookCopyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookCopyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.bookCopyGrid.Location = new System.Drawing.Point(4, 358);
            this.bookCopyGrid.Name = "bookCopyGrid";
            this.bookCopyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookCopyGrid.Size = new System.Drawing.Size(521, 257);
            this.bookCopyGrid.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book Copy";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Reference Only";
            this.Column2.Name = "Column2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add New Book";
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(529, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bookCopyGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookISBNInputField);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.bookEditionInputField);
            this.Controls.Add(this.editionLabel);
            this.Controls.Add(this.bookClassificationInputField);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.bookCopyCountInputField);
            this.Controls.Add(this.bookRefferanceInputField);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.bookNameInputField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAddBookCopyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookAddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyCountInputField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookNameInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnAddBookCopyButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckBox bookRefferanceInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookClassificationInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        // New Controls
        private MaterialSkin.Controls.MaterialSingleLineTextField bookISBNInputField;
        private MaterialSkin.Controls.MaterialLabel isbnLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookEditionInputField;
        private MaterialSkin.Controls.MaterialLabel editionLabel;
        private System.Windows.Forms.NumericUpDown bookCopyCountInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bookCopyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}