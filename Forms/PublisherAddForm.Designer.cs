namespace SarasaviLibrary.Forms
{
    partial class PublisherAddForm
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
            this.publisherNameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.submitPublisherFromButton = new System.Windows.Forms.Button();
            this.dismissPublisherFromButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // publisherNameInputField
            // 
            this.publisherNameInputField.Depth = 0;
            this.publisherNameInputField.Hint = "";
            this.publisherNameInputField.Location = new System.Drawing.Point(120, 27);
            this.publisherNameInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.publisherNameInputField.Name = "publisherNameInputField";
            this.publisherNameInputField.PasswordChar = '\0';
            this.publisherNameInputField.SelectedText = "";
            this.publisherNameInputField.SelectionLength = 0;
            this.publisherNameInputField.SelectionStart = 0;
            this.publisherNameInputField.Size = new System.Drawing.Size(396, 23);
            this.publisherNameInputField.TabIndex = 19;
            this.publisherNameInputField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(116, 5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Name :";
            // 
            // submitPublisherFromButton
            // 
            this.submitPublisherFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPublisherFromButton.Location = new System.Drawing.Point(396, 56);
            this.submitPublisherFromButton.Name = "submitPublisherFromButton";
            this.submitPublisherFromButton.Size = new System.Drawing.Size(120, 46);
            this.submitPublisherFromButton.TabIndex = 17;
            this.submitPublisherFromButton.Text = "Add";
            this.submitPublisherFromButton.UseVisualStyleBackColor = true;
            this.submitPublisherFromButton.Click += new System.EventHandler(this.submitPublisherFromButton_Click);
            // 
            // dismissPublisherFromButton
            // 
            this.dismissPublisherFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissPublisherFromButton.Location = new System.Drawing.Point(270, 56);
            this.dismissPublisherFromButton.Name = "dismissPublisherFromButton";
            this.dismissPublisherFromButton.Size = new System.Drawing.Size(120, 46);
            this.dismissPublisherFromButton.TabIndex = 16;
            this.dismissPublisherFromButton.Text = "Cancel";
            this.dismissPublisherFromButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 162);
            this.panel1.TabIndex = 20;
            // 
            // PublisherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.publisherNameInputField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.submitPublisherFromButton);
            this.Controls.Add(this.dismissPublisherFromButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublisherAddForm";
            this.Text = "Add Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField publisherNameInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button submitPublisherFromButton;
        private System.Windows.Forms.Button dismissPublisherFromButton;
        private System.Windows.Forms.Panel panel1;
    }
}