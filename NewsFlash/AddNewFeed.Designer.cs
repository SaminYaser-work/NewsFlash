namespace NewsFlash
{
    partial class AddNewFeedForm
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cbFeedCategory = new CustomBox.RJControls.RJComboBox();
            this.btnAddNewFeed = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.txtBoxNFName = new System.Windows.Forms.TextBox();
            this.txtBoxNFLink = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cbFeedCategory
            // 
            this.cbFeedCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFeedCategory.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbFeedCategory.BorderSize = 1;
            this.cbFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFeedCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFeedCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cbFeedCategory.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbFeedCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbFeedCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.cbFeedCategory.Location = new System.Drawing.Point(78, 176);
            this.cbFeedCategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFeedCategory.Name = "cbFeedCategory";
            this.cbFeedCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cbFeedCategory.Size = new System.Drawing.Size(250, 30);
            this.cbFeedCategory.TabIndex = 5;
            this.cbFeedCategory.TabStop = false;
            this.cbFeedCategory.Texts = "Select a Category";
            // 
            // btnAddNewFeed
            // 
            this.btnAddNewFeed.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewFeed.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewFeed.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNewFeed.BorderRadius = 10;
            this.btnAddNewFeed.BorderSize = 0;
            this.btnAddNewFeed.FlatAppearance.BorderSize = 0;
            this.btnAddNewFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFeed.ForeColor = System.Drawing.Color.White;
            this.btnAddNewFeed.Location = new System.Drawing.Point(226, 231);
            this.btnAddNewFeed.Name = "btnAddNewFeed";
            this.btnAddNewFeed.Size = new System.Drawing.Size(102, 40);
            this.btnAddNewFeed.TabIndex = 7;
            this.btnAddNewFeed.Text = "Add";
            this.btnAddNewFeed.TextColor = System.Drawing.Color.White;
            this.btnAddNewFeed.UseVisualStyleBackColor = false;
            this.btnAddNewFeed.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(78, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxNFName
            // 
            this.txtBoxNFName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNFName.Location = new System.Drawing.Point(78, 44);
            this.txtBoxNFName.Name = "txtBoxNFName";
            this.txtBoxNFName.Size = new System.Drawing.Size(250, 27);
            this.txtBoxNFName.TabIndex = 8;
            // 
            // txtBoxNFLink
            // 
            this.txtBoxNFLink.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNFLink.Location = new System.Drawing.Point(78, 113);
            this.txtBoxNFLink.Name = "txtBoxNFLink";
            this.txtBoxNFLink.Size = new System.Drawing.Size(250, 27);
            this.txtBoxNFLink.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(76, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name of the Feed";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(76, 90);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(66, 20);
            this.lblLink.TabIndex = 9;
            this.lblLink.Text = "RSS Link";
            // 
            // AddNewFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 308);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxNFLink);
            this.Controls.Add(this.txtBoxNFName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNewFeed);
            this.Controls.Add(this.cbFeedCategory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(425, 347);
            this.MinimumSize = new System.Drawing.Size(425, 347);
            this.Name = "AddNewFeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Feed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private CustomBox.RJControls.RJComboBox cbFeedCategory;
        private RJCodeAdvance.RJControls.RJButton btnAddNewFeed;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
        private System.Windows.Forms.TextBox txtBoxNFName;
        private System.Windows.Forms.TextBox txtBoxNFLink;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLink;
    }
}