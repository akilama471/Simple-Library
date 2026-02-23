namespace SarasaviLibrary.Forms
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCopyNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCheck = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReturn = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblInfo = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(157, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Copy Number:";
            // 
            // txtCopyNumber
            // 
            this.txtCopyNumber.Depth = 0;
            this.txtCopyNumber.ForeColor = System.Drawing.Color.White;
            this.txtCopyNumber.Hint = "";
            this.txtCopyNumber.Location = new System.Drawing.Point(271, 12);
            this.txtCopyNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCopyNumber.Name = "txtCopyNumber";
            this.txtCopyNumber.PasswordChar = '\0';
            this.txtCopyNumber.SelectedText = "";
            this.txtCopyNumber.SelectionLength = 0;
            this.txtCopyNumber.SelectionStart = 0;
            this.txtCopyNumber.Size = new System.Drawing.Size(273, 23);
            this.txtCopyNumber.TabIndex = 1;
            this.txtCopyNumber.UseSystemPasswordChar = false;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheck.BackColor = System.Drawing.Color.Red;
            this.btnCheck.Depth = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(344, 49);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Primary = false;
            this.btnCheck.Size = new System.Drawing.Size(56, 36);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Depth = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(408, 49);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Primary = false;
            this.btnReturn.Size = new System.Drawing.Size(64, 36);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Depth = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(480, 49);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Depth = 0;
            this.lblInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(122, 66);
            this.lblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 19);
            this.lblInfo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(556, 164);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtCopyNumber);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnForm";
            this.Text = "Return Book";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCopyNumber;
        private MaterialSkin.Controls.MaterialFlatButton btnCheck;
        private MaterialSkin.Controls.MaterialFlatButton btnReturn;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}