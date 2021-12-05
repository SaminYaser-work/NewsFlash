namespace NewsFlash
{
    partial class Cards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.faPbCardIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnFav = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.faPbCardIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(229)))));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(28, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.Enter += new System.EventHandler(this.Cards_Enter);
            this.lblTitle.Leave += new System.EventHandler(this.Cards_Leave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(126, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ForeColor = System.Drawing.Color.Silver;
            this.lblPublisher.Location = new System.Drawing.Point(29, 2);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(55, 13);
            this.lblPublisher.TabIndex = 1;
            this.lblPublisher.Text = "Publisher";
            this.lblPublisher.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // faPbCardIcon
            // 
            this.faPbCardIcon.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.faPbCardIcon.IconColor = System.Drawing.Color.White;
            this.faPbCardIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faPbCardIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(229)))));
            this.faPbCardIcon.IconSize = 20;
            this.faPbCardIcon.Location = new System.Drawing.Point(7, 12);
            this.faPbCardIcon.Name = "faPbCardIcon";
            this.faPbCardIcon.Size = new System.Drawing.Size(20, 20);
            this.faPbCardIcon.TabIndex = 2;
            this.faPbCardIcon.TabStop = false;
            this.faPbCardIcon.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnFav
            // 
            this.btnFav.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnFav.IconColor = System.Drawing.Color.Orange;
            this.btnFav.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFav.FlatAppearance.BorderSize = 0;
            this.btnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFav.IconSize = 20;
            this.btnFav.Location = new System.Drawing.Point(7, 37);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(20, 20);
            this.btnFav.TabIndex = 3;
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(248, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 77);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Location = new System.Drawing.Point(-56, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 75);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(1, -76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 77);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.faPbCardIcon);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblDate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.Name = "Cards";
            this.Size = new System.Drawing.Size(250, 77);
            this.Enter += new System.EventHandler(this.Cards_Enter);
            this.Leave += new System.EventHandler(this.Cards_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.faPbCardIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string cardTitle;
        private string cardDate;
        private string cardPublisher;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblPublisher;
        public FontAwesome.Sharp.IconPictureBox faPbCardIcon;
        public FontAwesome.Sharp.IconButton btnFav;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;

        public string CardTitle { get => cardTitle; set { cardTitle = value; lblTitle.Text = cardTitle; } }
        public string CardDate { get => cardDate; set { cardDate = value; lblDate.Text = cardDate; } }
        public string CardPublisher { get => cardPublisher; set { cardPublisher = value; lblPublisher.Text = cardPublisher; } }
    }
}
