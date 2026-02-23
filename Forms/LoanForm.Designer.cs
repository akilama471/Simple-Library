namespace SarasaviLibrary.Forms
{
    partial class LoanForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.memberNICInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bookCopyInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddBookToBorrow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Member NIC:";
            // 
            // memberNICInputField
            // 
            this.memberNICInputField.Depth = 0;
            this.memberNICInputField.Hint = "";
            this.memberNICInputField.Location = new System.Drawing.Point(113, 7);
            this.memberNICInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberNICInputField.Name = "memberNICInputField";
            this.memberNICInputField.PasswordChar = '\0';
            this.memberNICInputField.SelectedText = "";
            this.memberNICInputField.SelectionLength = 0;
            this.memberNICInputField.SelectionStart = 0;
            this.memberNICInputField.Size = new System.Drawing.Size(199, 23);
            this.memberNICInputField.TabIndex = 2;
            this.memberNICInputField.UseSystemPasswordChar = false;
            // 
            // bookCopyInputField
            // 
            this.bookCopyInputField.Depth = 0;
            this.bookCopyInputField.Hint = "";
            this.bookCopyInputField.Location = new System.Drawing.Point(432, 11);
            this.bookCopyInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookCopyInputField.Name = "bookCopyInputField";
            this.bookCopyInputField.PasswordChar = '\0';
            this.bookCopyInputField.SelectedText = "";
            this.bookCopyInputField.SelectionLength = 0;
            this.bookCopyInputField.SelectionStart = 0;
            this.bookCopyInputField.Size = new System.Drawing.Size(197, 23);
            this.bookCopyInputField.TabIndex = 4;
            this.bookCopyInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(322, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Copy Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnLoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 46);
            this.panel1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancel.Location = new System.Drawing.Point(523, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Reject";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnLoan.Location = new System.Drawing.Point(638, 5);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(100, 36);
            this.btnLoan.TabIndex = 11;
            this.btnLoan.Text = "Approve";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.BtnLoan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 351);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnAddBookToBorrow
            // 
            this.btnAddBookToBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAddBookToBorrow.Location = new System.Drawing.Point(640, 5);
            this.btnAddBookToBorrow.Name = "btnAddBookToBorrow";
            this.btnAddBookToBorrow.Size = new System.Drawing.Size(100, 36);
            this.btnAddBookToBorrow.TabIndex = 12;
            this.btnAddBookToBorrow.Text = "Add";
            this.btnAddBookToBorrow.UseVisualStyleBackColor = true;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btnAddBookToBorrow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookCopyInputField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.memberNICInputField);
            this.Controls.Add(this.materialLabel1);
            this.Name = "LoanForm";
            this.Text = "Borrow Book";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberNICInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookCopyInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddBookToBorrow;
    }
}