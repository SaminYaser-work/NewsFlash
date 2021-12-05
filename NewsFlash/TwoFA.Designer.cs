namespace NewsFlash
{
    partial class TwoFA
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.btnSendCode = new RJCodeAdvance.RJControls.RJButton();
            this.btnSkip = new RJCodeAdvance.RJControls.RJButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.btnVerify = new RJCodeAdvance.RJControls.RJButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 45);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Turn on 2-step verification?";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(28, 156);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(276, 26);
            this.txtBoxEmail.TabIndex = 0;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmail.FlatAppearance.BorderSize = 0;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Location = new System.Drawing.Point(219, 189);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(99, 25);
            this.btnChangeEmail.TabIndex = 1;
            this.btnChangeEmail.Text = "Change email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(21, 71);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(319, 53);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "A code will be sent your email. Enter the code here to verify your acount.";
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.Location = new System.Drawing.Point(24, 273);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(84, 20);
            this.lblEnterCode.TabIndex = 2;
            this.lblEnterCode.Text = "Enter Code";
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendCode.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendCode.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSendCode.BorderRadius = 5;
            this.btnSendCode.BorderSize = 0;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(323, 155);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(112, 33);
            this.btnSendCode.TabIndex = 13;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.TextColor = System.Drawing.Color.White;
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSkip.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSkip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSkip.BorderRadius = 5;
            this.btnSkip.BorderSize = 0;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(323, 384);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(112, 33);
            this.btnSkip.TabIndex = 13;
            this.btnSkip.Text = "Skip";
            this.btnSkip.TextColor = System.Drawing.Color.White;
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(24, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(243, 53);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCode.Location = new System.Drawing.Point(28, 296);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(276, 26);
            this.txtBoxCode.TabIndex = 0;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVerify.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVerify.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerify.BorderRadius = 5;
            this.btnVerify.BorderSize = 0;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(323, 292);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(112, 33);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "Verify";
            this.btnVerify.TextColor = System.Drawing.Color.White;
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // TwoFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 436);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEnterCode);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.txtBoxCode);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TwoFA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwoFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEnterCode;
        private RJCodeAdvance.RJControls.RJButton btnSendCode;
        private RJCodeAdvance.RJControls.RJButton btnSkip;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtBoxCode;
        private RJCodeAdvance.RJControls.RJButton btnVerify;
        private System.Windows.Forms.Label lblEmail;
    }
}