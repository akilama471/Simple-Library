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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.bookCopyInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.memberNICInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnReserveBook.Location = new System.Drawing.Point(153, 319);
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
            this.bookCopyInputField.Location = new System.Drawing.Point(23, 277);
            this.bookCopyInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookCopyInputField.Name = "bookCopyInputField";
            this.bookCopyInputField.PasswordChar = '\0';
            this.bookCopyInputField.SelectedText = "";
            this.bookCopyInputField.SelectionLength = 0;
            this.bookCopyInputField.SelectionStart = 0;
            this.bookCopyInputField.Size = new System.Drawing.Size(230, 23);
            this.bookCopyInputField.TabIndex = 16;
            this.bookCopyInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 255);
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
            this.memberNICInputField.Location = new System.Drawing.Point(23, 229);
            this.memberNICInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberNICInputField.Name = "memberNICInputField";
            this.memberNICInputField.PasswordChar = '\0';
            this.memberNICInputField.SelectedText = "";
            this.memberNICInputField.SelectionLength = 0;
            this.memberNICInputField.SelectionStart = 0;
            this.memberNICInputField.Size = new System.Drawing.Size(232, 23);
            this.memberNICInputField.TabIndex = 14;
            this.memberNICInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 196);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Member NIC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 360);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserveBook;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookCopyInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberNICInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}