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
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLoan = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 38);
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
            this.memberNICInputField.Location = new System.Drawing.Point(126, 38);
            this.memberNICInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberNICInputField.Name = "memberNICInputField";
            this.memberNICInputField.PasswordChar = '\0';
            this.memberNICInputField.SelectedText = "";
            this.memberNICInputField.SelectionLength = 0;
            this.memberNICInputField.SelectionStart = 0;
            this.memberNICInputField.Size = new System.Drawing.Size(422, 23);
            this.memberNICInputField.TabIndex = 2;
            this.memberNICInputField.UseSystemPasswordChar = false;
            // 
            // bookCopyInputField
            // 
            this.bookCopyInputField.Depth = 0;
            this.bookCopyInputField.Hint = "";
            this.bookCopyInputField.Location = new System.Drawing.Point(126, 89);
            this.bookCopyInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookCopyInputField.Name = "bookCopyInputField";
            this.bookCopyInputField.PasswordChar = '\0';
            this.bookCopyInputField.SelectedText = "";
            this.bookCopyInputField.SelectionLength = 0;
            this.bookCopyInputField.SelectionStart = 0;
            this.bookCopyInputField.Size = new System.Drawing.Size(422, 23);
            this.bookCopyInputField.TabIndex = 4;
            this.bookCopyInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 89);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Copy Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(323, 157);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.AutoSize = true;
            this.btnLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoan.Depth = 0;
            this.btnLoan.Location = new System.Drawing.Point(500, 157);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Primary = false;
            this.btnLoan.Size = new System.Drawing.Size(48, 36);
            this.btnLoan.TabIndex = 7;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.BtnLoan_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bookCopyInputField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.memberNICInputField);
            this.Controls.Add(this.materialLabel1);
            this.Name = "LoanForm";
            this.Text = "Borrow Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberNICInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookCopyInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnLoan;
    }
}