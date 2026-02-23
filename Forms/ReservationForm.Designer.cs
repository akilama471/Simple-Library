namespace SarasaviLibrary.Forms
{
    partial class ReservationForm
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
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.bookCopyInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.memberNICInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnReserveBook.Location = new System.Drawing.Point(252, 80);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(100, 36);
            this.btnReserveBook.TabIndex = 17;
            this.btnReserveBook.Text = "Reserve";
            this.btnReserveBook.UseVisualStyleBackColor = true;
            // 
            // bookCopyInputField
            // 
            this.bookCopyInputField.Depth = 0;
            this.bookCopyInputField.Hint = "";
            this.bookCopyInputField.Location = new System.Drawing.Point(155, 51);
            this.bookCopyInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookCopyInputField.Name = "bookCopyInputField";
            this.bookCopyInputField.PasswordChar = '\0';
            this.bookCopyInputField.SelectedText = "";
            this.bookCopyInputField.SelectionLength = 0;
            this.bookCopyInputField.SelectionStart = 0;
            this.bookCopyInputField.Size = new System.Drawing.Size(197, 23);
            this.bookCopyInputField.TabIndex = 16;
            this.bookCopyInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 51);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Copy Number:";
            // 
            // memberNICInputField
            // 
            this.memberNICInputField.Depth = 0;
            this.memberNICInputField.Hint = "";
            this.memberNICInputField.Location = new System.Drawing.Point(155, 16);
            this.memberNICInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberNICInputField.Name = "memberNICInputField";
            this.memberNICInputField.PasswordChar = '\0';
            this.memberNICInputField.SelectedText = "";
            this.memberNICInputField.SelectionLength = 0;
            this.memberNICInputField.SelectionStart = 0;
            this.memberNICInputField.Size = new System.Drawing.Size(199, 23);
            this.memberNICInputField.TabIndex = 14;
            this.memberNICInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Member NIC:";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.btnReserveBook);
            this.Controls.Add(this.bookCopyInputField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.memberNICInputField);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserveBook;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookCopyInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberNICInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}