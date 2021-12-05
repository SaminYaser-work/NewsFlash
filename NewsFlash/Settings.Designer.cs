namespace NewsFlash
{
    partial class Settings
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
            this.rbToggle = new RJCodeAdvance.RJControls.RJToggleButton();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblNumOfFeeds = new System.Windows.Forms.Label();
            this.cbNumOfFeeds = new CustomBox.RJControls.RJComboBox();
            this.btnSave = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // rbToggle
            // 
            this.rbToggle.AutoSize = true;
            this.rbToggle.Location = new System.Drawing.Point(171, 24);
            this.rbToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.rbToggle.Name = "rbToggle";
            this.rbToggle.OffBackColor = System.Drawing.Color.Gray;
            this.rbToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rbToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rbToggle.Size = new System.Drawing.Size(45, 22);
            this.rbToggle.TabIndex = 1;
            this.rbToggle.UseVisualStyleBackColor = true;
            this.rbToggle.CheckedChanged += new System.EventHandler(this.rbToggle_CheckedChanged);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(7, 25);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(93, 20);
            this.lblTheme.TabIndex = 2;
            this.lblTheme.Text = "Light Theme";
            // 
            // lblNumOfFeeds
            // 
            this.lblNumOfFeeds.AutoSize = true;
            this.lblNumOfFeeds.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfFeeds.Location = new System.Drawing.Point(7, 92);
            this.lblNumOfFeeds.Name = "lblNumOfFeeds";
            this.lblNumOfFeeds.Size = new System.Drawing.Size(127, 20);
            this.lblNumOfFeeds.TabIndex = 2;
            this.lblNumOfFeeds.Text = "Number of Feeds";
            // 
            // cbNumOfFeeds
            // 
            this.cbNumOfFeeds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbNumOfFeeds.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNumOfFeeds.BorderSize = 1;
            this.cbNumOfFeeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbNumOfFeeds.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumOfFeeds.ForeColor = System.Drawing.Color.DimGray;
            this.cbNumOfFeeds.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNumOfFeeds.Items.AddRange(new object[] {
            "5",
            "10"});
            this.cbNumOfFeeds.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbNumOfFeeds.ListTextColor = System.Drawing.Color.DimGray;
            this.cbNumOfFeeds.Location = new System.Drawing.Point(171, 82);
            this.cbNumOfFeeds.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbNumOfFeeds.Name = "cbNumOfFeeds";
            this.cbNumOfFeeds.Padding = new System.Windows.Forms.Padding(1);
            this.cbNumOfFeeds.Size = new System.Drawing.Size(107, 40);
            this.cbNumOfFeeds.TabIndex = 3;
            this.cbNumOfFeeds.Texts = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 9;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(169, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 9;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(25, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 215);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbNumOfFeeds);
            this.Controls.Add(this.lblNumOfFeeds);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.rbToggle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJToggleButton rbToggle;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblNumOfFeeds;
        private CustomBox.RJControls.RJComboBox cbNumOfFeeds;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
    }
}