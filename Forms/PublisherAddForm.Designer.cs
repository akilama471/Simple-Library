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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherAddForm));
            this.publisherNameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.submitPublisherFromButton = new System.Windows.Forms.Button();
            this.dismissPublisherFromButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // publisherNameInputField
            // 
            this.publisherNameInputField.Depth = 0;
            this.publisherNameInputField.Hint = "";
            this.publisherNameInputField.Location = new System.Drawing.Point(145, 27);
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
            this.materialLabel1.Location = new System.Drawing.Point(141, 5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Name :";
            // 
            // submitPublisherFromButton
            // 
            this.submitPublisherFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dismissPublisherFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissPublisherFromButton.Location = new System.Drawing.Point(270, 56);
            this.dismissPublisherFromButton.Name = "dismissPublisherFromButton";
            this.dismissPublisherFromButton.Size = new System.Drawing.Size(120, 46);
            this.dismissPublisherFromButton.TabIndex = 16;
            this.dismissPublisherFromButton.Text = "Cancel";
            this.dismissPublisherFromButton.UseVisualStyleBackColor = true;
            this.dismissPublisherFromButton.Click += new System.EventHandler(this.dismissPublisherFromButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // PublisherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(530, 134);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.publisherNameInputField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.submitPublisherFromButton);
            this.Controls.Add(this.dismissPublisherFromButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublisherAddForm";
            this.Text = "Add Publisher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField publisherNameInputField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button submitPublisherFromButton;
        private System.Windows.Forms.Button dismissPublisherFromButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}