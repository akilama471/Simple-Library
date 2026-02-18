namespace SarasaviLibrary.Forms
{
    partial class AuthorAddForm
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
            this.authorNameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.submitAuthorFromButton = new System.Windows.Forms.Button();
            this.dismissAuthorFromButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorNameInputField
            // 
            this.authorNameInputField.Depth = 0;
            this.authorNameInputField.Hint = "";
            this.authorNameInputField.Location = new System.Drawing.Point(12, 34);
            this.authorNameInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorNameInputField.Name = "authorNameInputField";
            this.authorNameInputField.PasswordChar = '\0';
            this.authorNameInputField.SelectedText = "";
            this.authorNameInputField.SelectionLength = 0;
            this.authorNameInputField.SelectionStart = 0;
            this.authorNameInputField.Size = new System.Drawing.Size(504, 23);
            this.authorNameInputField.TabIndex = 15;
            this.authorNameInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Name :";
            // 
            // submitAuthorFromButton
            // 
            this.submitAuthorFromButton.Location = new System.Drawing.Point(396, 63);
            this.submitAuthorFromButton.Name = "submitAuthorFromButton";
            this.submitAuthorFromButton.Size = new System.Drawing.Size(120, 46);
            this.submitAuthorFromButton.TabIndex = 13;
            this.submitAuthorFromButton.Text = "Add";
            this.submitAuthorFromButton.UseVisualStyleBackColor = true;
            this.submitAuthorFromButton.Click += new System.EventHandler(this.submitAuthorFromButton_Click);
            // 
            // dismissAuthorFromButton
            // 
            this.dismissAuthorFromButton.Location = new System.Drawing.Point(235, 63);
            this.dismissAuthorFromButton.Name = "dismissAuthorFromButton";
            this.dismissAuthorFromButton.Size = new System.Drawing.Size(120, 46);
            this.dismissAuthorFromButton.TabIndex = 12;
            this.dismissAuthorFromButton.Text = "Cancel";
            this.dismissAuthorFromButton.UseVisualStyleBackColor = true;
            // 
            // AuthorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 125);
            this.Controls.Add(this.authorNameInputField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.submitAuthorFromButton);
            this.Controls.Add(this.dismissAuthorFromButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorAddForm";
            this.Text = "Add Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField authorNameInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button submitAuthorFromButton;
        private System.Windows.Forms.Button dismissAuthorFromButton;
    }
}