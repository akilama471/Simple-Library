namespace SarasaviLibrary.Forms
{
    partial class MemberAddForm
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
            this.dismissMemberFromButton = new System.Windows.Forms.Button();
            this.submitMemberFromButton = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.memberNameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.memberNICInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.memberAddressInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.memberSexInputField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dismissMemberFromButton
            // 
            this.dismissMemberFromButton.BackColor = System.Drawing.Color.Red;
            this.dismissMemberFromButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dismissMemberFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissMemberFromButton.Location = new System.Drawing.Point(270, 202);
            this.dismissMemberFromButton.Name = "dismissMemberFromButton";
            this.dismissMemberFromButton.Size = new System.Drawing.Size(120, 46);
            this.dismissMemberFromButton.TabIndex = 1;
            this.dismissMemberFromButton.Text = "Cancel";
            this.dismissMemberFromButton.UseVisualStyleBackColor = false;
            // 
            // submitMemberFromButton
            // 
            this.submitMemberFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMemberFromButton.Location = new System.Drawing.Point(396, 201);
            this.submitMemberFromButton.Name = "submitMemberFromButton";
            this.submitMemberFromButton.Size = new System.Drawing.Size(120, 46);
            this.submitMemberFromButton.TabIndex = 2;
            this.submitMemberFromButton.Text = "Add";
            this.submitMemberFromButton.UseVisualStyleBackColor = true;
            this.submitMemberFromButton.Click += new System.EventHandler(this.submitMemberFromButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Name :";
            // 
            // memberNameInputField
            // 
            this.memberNameInputField.Depth = 0;
            this.memberNameInputField.Hint = "";
            this.memberNameInputField.Location = new System.Drawing.Point(12, 46);
            this.memberNameInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberNameInputField.Name = "memberNameInputField";
            this.memberNameInputField.PasswordChar = '\0';
            this.memberNameInputField.SelectedText = "";
            this.memberNameInputField.SelectionLength = 0;
            this.memberNameInputField.SelectionStart = 0;
            this.memberNameInputField.Size = new System.Drawing.Size(504, 23);
            this.memberNameInputField.TabIndex = 5;
            this.memberNameInputField.UseSystemPasswordChar = false;
            // 
            // memberNICInputField
            // 
            this.memberNICInputField.Depth = 0;
            this.memberNICInputField.Hint = "";
            this.memberNICInputField.Location = new System.Drawing.Point(12, 109);
            this.memberNICInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberNICInputField.Name = "memberNICInputField";
            this.memberNICInputField.PasswordChar = '\0';
            this.memberNICInputField.SelectedText = "";
            this.memberNICInputField.SelectionLength = 0;
            this.memberNICInputField.SelectionStart = 0;
            this.memberNICInputField.Size = new System.Drawing.Size(320, 23);
            this.memberNICInputField.TabIndex = 7;
            this.memberNICInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 87);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "NIC :";
            // 
            // memberAddressInputField
            // 
            this.memberAddressInputField.Depth = 0;
            this.memberAddressInputField.Hint = "";
            this.memberAddressInputField.Location = new System.Drawing.Point(12, 172);
            this.memberAddressInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberAddressInputField.Name = "memberAddressInputField";
            this.memberAddressInputField.PasswordChar = '\0';
            this.memberAddressInputField.SelectedText = "";
            this.memberAddressInputField.SelectionLength = 0;
            this.memberAddressInputField.SelectionStart = 0;
            this.memberAddressInputField.Size = new System.Drawing.Size(504, 23);
            this.memberAddressInputField.TabIndex = 9;
            this.memberAddressInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 150);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Address :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(334, 87);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Sex :";
            // 
            // memberSexInputField
            // 
            this.memberSexInputField.FormattingEnabled = true;
            this.memberSexInputField.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.memberSexInputField.Location = new System.Drawing.Point(338, 109);
            this.memberSexInputField.Name = "memberSexInputField";
            this.memberSexInputField.Size = new System.Drawing.Size(178, 21);
            this.memberSexInputField.TabIndex = 11;
            // 
            // MemberAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 256);
            this.Controls.Add(this.memberSexInputField);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.memberAddressInputField);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.memberNICInputField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.memberNameInputField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.submitMemberFromButton);
            this.Controls.Add(this.dismissMemberFromButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Member";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dismissMemberFromButton;
        private System.Windows.Forms.Button submitMemberFromButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberNameInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberNICInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField memberAddressInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox memberSexInputField;
    }
}