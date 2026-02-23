namespace SarasaviLibrary.Forms
{
    partial class PublisherListForm
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
            this.publisherDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openAddPublisherButton = new System.Windows.Forms.Button();
            this.editSelectedPublisherButton = new System.Windows.Forms.Button();
            this.deleteSelectedPublisherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // publisherDataGridView
            // 
            this.publisherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.publisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisherDataGridView.Location = new System.Drawing.Point(0, 0);
            this.publisherDataGridView.Name = "publisherDataGridView";
            this.publisherDataGridView.ReadOnly = true;
            this.publisherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.publisherDataGridView.Size = new System.Drawing.Size(800, 450);
            this.publisherDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.openAddPublisherButton);
            this.panel1.Controls.Add(this.editSelectedPublisherButton);
            this.panel1.Controls.Add(this.deleteSelectedPublisherButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 2;
            // 
            // openAddPublisherButton
            // 
            this.openAddPublisherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openAddPublisherButton.Location = new System.Drawing.Point(4, 6);
            this.openAddPublisherButton.Name = "openAddPublisherButton";
            this.openAddPublisherButton.Size = new System.Drawing.Size(60, 36);
            this.openAddPublisherButton.TabIndex = 5;
            this.openAddPublisherButton.Text = "Add";
            this.openAddPublisherButton.UseVisualStyleBackColor = true;
            // 
            // editSelectedPublisherButton
            // 
            this.editSelectedPublisherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSelectedPublisherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.editSelectedPublisherButton.Location = new System.Drawing.Point(671, 7);
            this.editSelectedPublisherButton.Name = "editSelectedPublisherButton";
            this.editSelectedPublisherButton.Size = new System.Drawing.Size(60, 36);
            this.editSelectedPublisherButton.TabIndex = 4;
            this.editSelectedPublisherButton.Text = "Edit";
            this.editSelectedPublisherButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPublisherButton
            // 
            this.deleteSelectedPublisherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedPublisherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.deleteSelectedPublisherButton.Location = new System.Drawing.Point(735, 7);
            this.deleteSelectedPublisherButton.Name = "deleteSelectedPublisherButton";
            this.deleteSelectedPublisherButton.Size = new System.Drawing.Size(60, 36);
            this.deleteSelectedPublisherButton.TabIndex = 3;
            this.deleteSelectedPublisherButton.Text = "Delete";
            this.deleteSelectedPublisherButton.UseVisualStyleBackColor = true;
            // 
            // PublisherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.publisherDataGridView);
            this.Name = "PublisherListForm";
            this.Text = "Publisher List";
            this.Load += new System.EventHandler(this.PublisherListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView publisherDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openAddPublisherButton;
        private System.Windows.Forms.Button editSelectedPublisherButton;
        private System.Windows.Forms.Button deleteSelectedPublisherButton;
    }
}