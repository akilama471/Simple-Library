namespace SarasaviLibrary.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.InquiryRibbonButton = new System.Windows.Forms.RibbonButton();
            this.loanRibbonButton = new System.Windows.Forms.RibbonButton();
            this.returnRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.addBookRibbonButton = new System.Windows.Forms.RibbonButton();
            this.findBookRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.addAuthorRibbonButton = new System.Windows.Forms.RibbonButton();
            this.findAuthorRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.addPublisherRibbonButton = new System.Windows.Forms.RibbonButton();
            this.findPublisherRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.addMemberRibbonButton = new System.Windows.Forms.RibbonButton();
            this.findMemberRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(800, 133);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "General";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.InquiryRibbonButton);
            this.ribbonPanel1.Items.Add(this.loanRibbonButton);
            this.ribbonPanel1.Items.Add(this.returnRibbonButton);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // InquiryRibbonButton
            // 
            this.InquiryRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("InquiryRibbonButton.Image")));
            this.InquiryRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("InquiryRibbonButton.LargeImage")));
            this.InquiryRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.InquiryRibbonButton.Name = "InquiryRibbonButton";
            this.InquiryRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("InquiryRibbonButton.SmallImage")));
            this.InquiryRibbonButton.Text = "Inquiry";
            this.InquiryRibbonButton.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.InquiryRibbonButton.Click += new System.EventHandler(this.InquiryRibbonButton_Click);
            // 
            // loanRibbonButton
            // 
            this.loanRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("loanRibbonButton.Image")));
            this.loanRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("loanRibbonButton.LargeImage")));
            this.loanRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.loanRibbonButton.Name = "loanRibbonButton";
            this.loanRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("loanRibbonButton.SmallImage")));
            this.loanRibbonButton.Text = "Loan";
            this.loanRibbonButton.Click += new System.EventHandler(this.loanRibbonButton_Click);
            // 
            // returnRibbonButton
            // 
            this.returnRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("returnRibbonButton.Image")));
            this.returnRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("returnRibbonButton.LargeImage")));
            this.returnRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.returnRibbonButton.Name = "returnRibbonButton";
            this.returnRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("returnRibbonButton.SmallImage")));
            this.returnRibbonButton.Text = "Return";
            this.returnRibbonButton.Click += new System.EventHandler(this.returnRibbonButton_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Panels.Add(this.ribbonPanel5);
            this.ribbonTab2.Text = "Books and Authors";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.addBookRibbonButton);
            this.ribbonPanel2.Items.Add(this.findBookRibbonButton);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Books";
            // 
            // addBookRibbonButton
            // 
            this.addBookRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("addBookRibbonButton.Image")));
            this.addBookRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("addBookRibbonButton.LargeImage")));
            this.addBookRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.addBookRibbonButton.Name = "addBookRibbonButton";
            this.addBookRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addBookRibbonButton.SmallImage")));
            this.addBookRibbonButton.Text = "Add";
            this.addBookRibbonButton.Click += new System.EventHandler(this.addBookRibbonButton_Click);
            // 
            // findBookRibbonButton
            // 
            this.findBookRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("findBookRibbonButton.Image")));
            this.findBookRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("findBookRibbonButton.LargeImage")));
            this.findBookRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.findBookRibbonButton.Name = "findBookRibbonButton";
            this.findBookRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("findBookRibbonButton.SmallImage")));
            this.findBookRibbonButton.Text = "Find";
            this.findBookRibbonButton.Click += new System.EventHandler(this.findBookRibbonButton_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.addAuthorRibbonButton);
            this.ribbonPanel3.Items.Add(this.findAuthorRibbonButton);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Authors";
            // 
            // addAuthorRibbonButton
            // 
            this.addAuthorRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("addAuthorRibbonButton.Image")));
            this.addAuthorRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("addAuthorRibbonButton.LargeImage")));
            this.addAuthorRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.addAuthorRibbonButton.Name = "addAuthorRibbonButton";
            this.addAuthorRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addAuthorRibbonButton.SmallImage")));
            this.addAuthorRibbonButton.Text = "Add";
            this.addAuthorRibbonButton.Click += new System.EventHandler(this.addAuthorRibbonButton_Click);
            // 
            // findAuthorRibbonButton
            // 
            this.findAuthorRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("findAuthorRibbonButton.Image")));
            this.findAuthorRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("findAuthorRibbonButton.LargeImage")));
            this.findAuthorRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.findAuthorRibbonButton.Name = "findAuthorRibbonButton";
            this.findAuthorRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("findAuthorRibbonButton.SmallImage")));
            this.findAuthorRibbonButton.Text = "Find";
            this.findAuthorRibbonButton.Click += new System.EventHandler(this.findAuthorRibbonButton_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.addPublisherRibbonButton);
            this.ribbonPanel5.Items.Add(this.findPublisherRibbonButton);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Publisher";
            // 
            // addPublisherRibbonButton
            // 
            this.addPublisherRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("addPublisherRibbonButton.Image")));
            this.addPublisherRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("addPublisherRibbonButton.LargeImage")));
            this.addPublisherRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.addPublisherRibbonButton.Name = "addPublisherRibbonButton";
            this.addPublisherRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addPublisherRibbonButton.SmallImage")));
            this.addPublisherRibbonButton.Text = "Add";
            this.addPublisherRibbonButton.Click += new System.EventHandler(this.addPublisherRibbonButton_Click);
            // 
            // findPublisherRibbonButton
            // 
            this.findPublisherRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("findPublisherRibbonButton.Image")));
            this.findPublisherRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("findPublisherRibbonButton.LargeImage")));
            this.findPublisherRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.findPublisherRibbonButton.Name = "findPublisherRibbonButton";
            this.findPublisherRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("findPublisherRibbonButton.SmallImage")));
            this.findPublisherRibbonButton.Text = "Find";
            this.findPublisherRibbonButton.Click += new System.EventHandler(this.findPublisherRibbonButton_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel4);
            this.ribbonTab3.Text = "Members";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.addMemberRibbonButton);
            this.ribbonPanel4.Items.Add(this.findMemberRibbonButton);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Members";
            // 
            // addMemberRibbonButton
            // 
            this.addMemberRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("addMemberRibbonButton.Image")));
            this.addMemberRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("addMemberRibbonButton.LargeImage")));
            this.addMemberRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.addMemberRibbonButton.Name = "addMemberRibbonButton";
            this.addMemberRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addMemberRibbonButton.SmallImage")));
            this.addMemberRibbonButton.Text = "Add";
            this.addMemberRibbonButton.Click += new System.EventHandler(this.addMemberRibbonButton_Click);
            // 
            // findMemberRibbonButton
            // 
            this.findMemberRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("findMemberRibbonButton.Image")));
            this.findMemberRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("findMemberRibbonButton.LargeImage")));
            this.findMemberRibbonButton.MinimumSize = new System.Drawing.Size(64, 0);
            this.findMemberRibbonButton.Name = "findMemberRibbonButton";
            this.findMemberRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("findMemberRibbonButton.SmallImage")));
            this.findMemberRibbonButton.Text = "Find Member";
            this.findMemberRibbonButton.Click += new System.EventHandler(this.findMemberRibbonButton_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Reports";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton addMemberRibbonButton;
        private System.Windows.Forms.RibbonButton findMemberRibbonButton;
        private System.Windows.Forms.RibbonButton addBookRibbonButton;
        private System.Windows.Forms.RibbonButton findBookRibbonButton;
        private System.Windows.Forms.RibbonButton addAuthorRibbonButton;
        private System.Windows.Forms.RibbonButton findAuthorRibbonButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton addPublisherRibbonButton;
        private System.Windows.Forms.RibbonButton findPublisherRibbonButton;
        private System.Windows.Forms.RibbonButton InquiryRibbonButton;
        private System.Windows.Forms.RibbonButton loanRibbonButton;
        private System.Windows.Forms.RibbonButton returnRibbonButton;
    }
}