namespace SarasaviLibrary.Forms
{
    partial class MemberListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.editSelectedMemberButton = new System.Windows.Forms.Button();
            this.openAddMemberButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.openAddMemberButton);
            this.panel1.Controls.Add(this.editSelectedMemberButton);
            this.panel1.Controls.Add(this.deleteSelectedMemberButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.memberDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 404);
            this.panel2.TabIndex = 2;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDataGridView.Location = new System.Drawing.Point(0, 0);
            this.memberDataGridView.MultiSelect = false;
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberDataGridView.Size = new System.Drawing.Size(800, 404);
            this.memberDataGridView.TabIndex = 1;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(735, 7);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(60, 36);
            this.deleteSelectedMemberButton.TabIndex = 3;
            this.deleteSelectedMemberButton.Text = "Delete";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            this.deleteSelectedMemberButton.Click += new System.EventHandler(this.DeleteSelectedMemberButton_Click);
            // 
            // editSelectedMemberButton
            // 
            this.editSelectedMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSelectedMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.editSelectedMemberButton.Location = new System.Drawing.Point(671, 7);
            this.editSelectedMemberButton.Name = "editSelectedMemberButton";
            this.editSelectedMemberButton.Size = new System.Drawing.Size(60, 36);
            this.editSelectedMemberButton.TabIndex = 4;
            this.editSelectedMemberButton.Text = "Edit";
            this.editSelectedMemberButton.UseVisualStyleBackColor = true;
            this.editSelectedMemberButton.Click += new System.EventHandler(this.EditSelectedMemberButton_Click);
            // 
            // openAddMemberButton
            // 
            this.openAddMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.openAddMemberButton.Location = new System.Drawing.Point(4, 6);
            this.openAddMemberButton.Name = "openAddMemberButton";
            this.openAddMemberButton.Size = new System.Drawing.Size(60, 36);
            this.openAddMemberButton.TabIndex = 5;
            this.openAddMemberButton.Text = "Add";
            this.openAddMemberButton.UseVisualStyleBackColor = true;
            this.openAddMemberButton.Click += new System.EventHandler(this.OpenAddMemberButton_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MemberListForm";
            this.Text = "MemberList";
            this.Load += new System.EventHandler(this.MemberListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.Button editSelectedMemberButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button openAddMemberButton;
    }
}