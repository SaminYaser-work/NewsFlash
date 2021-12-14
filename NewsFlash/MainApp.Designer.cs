namespace NewsFlash
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pbProfilePic = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnDeleteFeed = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.pnlBtnAbout = new System.Windows.Forms.Panel();
            this.pnlBtnSett = new System.Windows.Forms.Panel();
            this.pnlBtnFav = new System.Windows.Forms.Panel();
            this.pnlBtnANF = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAboutNewsFlash = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnFavorites = new FontAwesome.Sharp.IconButton();
            this.btnAddNewFeed = new FontAwesome.Sharp.IconButton();
            this.spTreeView = new System.Windows.Forms.TreeView();
            this.fpnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlWaterMark = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMainSum = new System.Windows.Forms.Panel();
            this.lblMainSum = new System.Windows.Forms.Label();
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.btnOpenArticle = new FontAwesome.Sharp.IconButton();
            this.btnShare = new FontAwesome.Sharp.IconButton();
            this.lblMainPub = new System.Windows.Forms.Label();
            this.lblMainDate = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.pnlSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlWaterMark.SuspendLayout();
            this.pnlMainSum.SuspendLayout();
            this.pnlMainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.pnlTitleBar.Controls.Add(this.pbProfilePic);
            this.pnlTitleBar.Controls.Add(this.btnDeleteFeed);
            this.pnlTitleBar.Controls.Add(this.panel2);
            this.pnlTitleBar.Location = new System.Drawing.Point(189, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(742, 66);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfilePic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbProfilePic.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfilePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfilePic.BorderSize = 2;
            this.pbProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfilePic.GradientAngle = 50F;
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(674, 3);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(56, 56);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 0;
            this.pbProfilePic.TabStop = false;
            this.pbProfilePic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rjCircularPictureBox1_MouseClick);
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnDeleteFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFeed.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteFeed.FlatAppearance.BorderSize = 0;
            this.btnDeleteFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFeed.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFeed.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteFeed.IconColor = System.Drawing.Color.White;
            this.btnDeleteFeed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteFeed.IconSize = 30;
            this.btnDeleteFeed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteFeed.Location = new System.Drawing.Point(242, 27);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(35, 36);
            this.btnDeleteFeed.TabIndex = 2;
            this.btnDeleteFeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFeed.UseVisualStyleBackColor = false;
            this.btnDeleteFeed.Click += new System.EventHandler(this.btnDeleteFeed_Click);
            this.btnDeleteFeed.MouseEnter += new System.EventHandler(this.btnDeleteFeed_MouseEnter);
            this.btnDeleteFeed.MouseLeave += new System.EventHandler(this.btnDeleteFeed_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.Location = new System.Drawing.Point(1, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 1);
            this.panel2.TabIndex = 0;
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.pnlSidePanel.Controls.Add(this.pnlBtnAbout);
            this.pnlSidePanel.Controls.Add(this.pnlBtnSett);
            this.pnlSidePanel.Controls.Add(this.pnlBtnFav);
            this.pnlSidePanel.Controls.Add(this.pnlBtnANF);
            this.pnlSidePanel.Controls.Add(this.pbLogo);
            this.pnlSidePanel.Controls.Add(this.panel1);
            this.pnlSidePanel.Controls.Add(this.btnAboutNewsFlash);
            this.pnlSidePanel.Controls.Add(this.btnSettings);
            this.pnlSidePanel.Controls.Add(this.btnFavorites);
            this.pnlSidePanel.Controls.Add(this.btnAddNewFeed);
            this.pnlSidePanel.Controls.Add(this.spTreeView);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(189, 560);
            this.pnlSidePanel.TabIndex = 1;
            // 
            // pnlBtnAbout
            // 
            this.pnlBtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnAbout.BackColor = System.Drawing.Color.HotPink;
            this.pnlBtnAbout.Location = new System.Drawing.Point(0, 516);
            this.pnlBtnAbout.Name = "pnlBtnAbout";
            this.pnlBtnAbout.Size = new System.Drawing.Size(10, 44);
            this.pnlBtnAbout.TabIndex = 4;
            // 
            // pnlBtnSett
            // 
            this.pnlBtnSett.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnSett.BackColor = System.Drawing.Color.HotPink;
            this.pnlBtnSett.Location = new System.Drawing.Point(0, 472);
            this.pnlBtnSett.Name = "pnlBtnSett";
            this.pnlBtnSett.Size = new System.Drawing.Size(10, 44);
            this.pnlBtnSett.TabIndex = 4;
            // 
            // pnlBtnFav
            // 
            this.pnlBtnFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnFav.BackColor = System.Drawing.Color.HotPink;
            this.pnlBtnFav.Location = new System.Drawing.Point(0, 384);
            this.pnlBtnFav.Name = "pnlBtnFav";
            this.pnlBtnFav.Size = new System.Drawing.Size(10, 44);
            this.pnlBtnFav.TabIndex = 4;
            // 
            // pnlBtnANF
            // 
            this.pnlBtnANF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnANF.BackColor = System.Drawing.Color.HotPink;
            this.pnlBtnANF.Location = new System.Drawing.Point(0, 428);
            this.pnlBtnANF.Name = "pnlBtnANF";
            this.pnlBtnANF.Size = new System.Drawing.Size(10, 44);
            this.pnlBtnANF.TabIndex = 4;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::NewsFlash.Properties.Resources.logo3;
            this.pbLogo.Location = new System.Drawing.Point(14, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(157, 98);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 560);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btnAboutNewsFlash
            // 
            this.btnAboutNewsFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutNewsFlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnAboutNewsFlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutNewsFlash.FlatAppearance.BorderSize = 0;
            this.btnAboutNewsFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutNewsFlash.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutNewsFlash.ForeColor = System.Drawing.Color.White;
            this.btnAboutNewsFlash.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnAboutNewsFlash.IconColor = System.Drawing.Color.White;
            this.btnAboutNewsFlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAboutNewsFlash.IconSize = 40;
            this.btnAboutNewsFlash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutNewsFlash.Location = new System.Drawing.Point(-1, 516);
            this.btnAboutNewsFlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnAboutNewsFlash.Name = "btnAboutNewsFlash";
            this.btnAboutNewsFlash.Size = new System.Drawing.Size(190, 44);
            this.btnAboutNewsFlash.TabIndex = 1;
            this.btnAboutNewsFlash.Text = "About";
            this.btnAboutNewsFlash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutNewsFlash.UseVisualStyleBackColor = false;
            this.btnAboutNewsFlash.Click += new System.EventHandler(this.btnAboutNewsFlash_Click);
            this.btnAboutNewsFlash.MouseEnter += new System.EventHandler(this.btnAboutNewsFlash_MouseEnter);
            this.btnAboutNewsFlash.MouseLeave += new System.EventHandler(this.btnAboutNewsFlash_MouseLeave);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 40;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 472);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(190, 44);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorites.FlatAppearance.BorderSize = 0;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorites.ForeColor = System.Drawing.Color.White;
            this.btnFavorites.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnFavorites.IconColor = System.Drawing.Color.White;
            this.btnFavorites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFavorites.IconSize = 40;
            this.btnFavorites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorites.Location = new System.Drawing.Point(0, 384);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(0);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(190, 44);
            this.btnFavorites.TabIndex = 1;
            this.btnFavorites.Text = "Favorites";
            this.btnFavorites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavorites.UseVisualStyleBackColor = false;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            this.btnFavorites.MouseEnter += new System.EventHandler(this.btnFavorites_MouseEnter);
            this.btnFavorites.MouseLeave += new System.EventHandler(this.btnFavorites_MouseLeave);
            // 
            // btnAddNewFeed
            // 
            this.btnAddNewFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnAddNewFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewFeed.FlatAppearance.BorderSize = 0;
            this.btnAddNewFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFeed.ForeColor = System.Drawing.Color.White;
            this.btnAddNewFeed.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddNewFeed.IconColor = System.Drawing.Color.White;
            this.btnAddNewFeed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewFeed.IconSize = 40;
            this.btnAddNewFeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewFeed.Location = new System.Drawing.Point(0, 428);
            this.btnAddNewFeed.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewFeed.Name = "btnAddNewFeed";
            this.btnAddNewFeed.Size = new System.Drawing.Size(190, 44);
            this.btnAddNewFeed.TabIndex = 1;
            this.btnAddNewFeed.Text = "Add New Feed";
            this.btnAddNewFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewFeed.UseVisualStyleBackColor = false;
            this.btnAddNewFeed.Click += new System.EventHandler(this.btnAddNewFeed_Click);
            this.btnAddNewFeed.MouseEnter += new System.EventHandler(this.btnAddNewFeed_Enter);
            this.btnAddNewFeed.MouseLeave += new System.EventHandler(this.btnAddNewFeed_Leave);
            // 
            // spTreeView
            // 
            this.spTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.spTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spTreeView.ForeColor = System.Drawing.Color.White;
            this.spTreeView.Location = new System.Drawing.Point(0, 141);
            this.spTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.spTreeView.Name = "spTreeView";
            this.spTreeView.Size = new System.Drawing.Size(189, 246);
            this.spTreeView.TabIndex = 0;
            this.spTreeView.TabStop = false;
            this.spTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.spTreeView_AfterSelect);
            // 
            // fpnlCards
            // 
            this.fpnlCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpnlCards.AutoScroll = true;
            this.fpnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.fpnlCards.Location = new System.Drawing.Point(189, 66);
            this.fpnlCards.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlCards.Name = "fpnlCards";
            this.fpnlCards.Size = new System.Drawing.Size(277, 494);
            this.fpnlCards.TabIndex = 2;
            // 
            // pnlWaterMark
            // 
            this.pnlWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWaterMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.pnlWaterMark.Controls.Add(this.panel3);
            this.pnlWaterMark.Controls.Add(this.pnlMainSum);
            this.pnlWaterMark.Controls.Add(this.pnlMainHeader);
            this.pnlWaterMark.Controls.Add(this.iconPictureBox1);
            this.pnlWaterMark.Location = new System.Drawing.Point(466, 66);
            this.pnlWaterMark.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWaterMark.Name = "pnlWaterMark";
            this.pnlWaterMark.Size = new System.Drawing.Size(465, 494);
            this.pnlWaterMark.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 494);
            this.panel3.TabIndex = 2;
            // 
            // pnlMainSum
            // 
            this.pnlMainSum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainSum.AutoScroll = true;
            this.pnlMainSum.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlMainSum.Controls.Add(this.lblMainSum);
            this.pnlMainSum.Location = new System.Drawing.Point(20, 247);
            this.pnlMainSum.Margin = new System.Windows.Forms.Padding(20);
            this.pnlMainSum.Name = "pnlMainSum";
            this.pnlMainSum.Size = new System.Drawing.Size(425, 247);
            this.pnlMainSum.TabIndex = 4;
            // 
            // lblMainSum
            // 
            this.lblMainSum.AutoEllipsis = true;
            this.lblMainSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lblMainSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainSum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainSum.ForeColor = System.Drawing.Color.White;
            this.lblMainSum.Location = new System.Drawing.Point(0, 0);
            this.lblMainSum.Name = "lblMainSum";
            this.lblMainSum.Size = new System.Drawing.Size(425, 247);
            this.lblMainSum.TabIndex = 0;
            this.lblMainSum.Text = "Summary";
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.pnlMainHeader.Controls.Add(this.btnOpenArticle);
            this.pnlMainHeader.Controls.Add(this.btnShare);
            this.pnlMainHeader.Controls.Add(this.lblMainPub);
            this.pnlMainHeader.Controls.Add(this.lblMainDate);
            this.pnlMainHeader.Controls.Add(this.lblMainTitle);
            this.pnlMainHeader.Location = new System.Drawing.Point(20, 8);
            this.pnlMainHeader.Margin = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(425, 233);
            this.pnlMainHeader.TabIndex = 4;
            // 
            // btnOpenArticle
            // 
            this.btnOpenArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnOpenArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenArticle.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenArticle.FlatAppearance.BorderSize = 0;
            this.btnOpenArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenArticle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenArticle.ForeColor = System.Drawing.Color.White;
            this.btnOpenArticle.IconChar = FontAwesome.Sharp.IconChar.Chrome;
            this.btnOpenArticle.IconColor = System.Drawing.Color.White;
            this.btnOpenArticle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenArticle.IconSize = 30;
            this.btnOpenArticle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenArticle.Location = new System.Drawing.Point(346, 194);
            this.btnOpenArticle.Name = "btnOpenArticle";
            this.btnOpenArticle.Size = new System.Drawing.Size(35, 36);
            this.btnOpenArticle.TabIndex = 2;
            this.btnOpenArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenArticle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenArticle.UseVisualStyleBackColor = false;
            this.btnOpenArticle.Click += new System.EventHandler(this.btnOpenArticle_Click);
            this.btnOpenArticle.MouseEnter += new System.EventHandler(this.btnOpenArticle_MouseEnter);
            this.btnOpenArticle.MouseLeave += new System.EventHandler(this.btnOpenArticle_MouseLeave);
            // 
            // btnShare
            // 
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.btnShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShare.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnShare.FlatAppearance.BorderSize = 0;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.White;
            this.btnShare.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnShare.IconColor = System.Drawing.Color.White;
            this.btnShare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShare.IconSize = 30;
            this.btnShare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShare.Location = new System.Drawing.Point(387, 194);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(35, 36);
            this.btnShare.TabIndex = 2;
            this.btnShare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            this.btnShare.MouseEnter += new System.EventHandler(this.btnShare_MouseEnter);
            this.btnShare.MouseLeave += new System.EventHandler(this.btnShare_MouseLeave);
            // 
            // lblMainPub
            // 
            this.lblMainPub.AutoSize = true;
            this.lblMainPub.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMainPub.Location = new System.Drawing.Point(8, 11);
            this.lblMainPub.Name = "lblMainPub";
            this.lblMainPub.Size = new System.Drawing.Size(55, 13);
            this.lblMainPub.TabIndex = 1;
            this.lblMainPub.Text = "Publisher";
            // 
            // lblMainDate
            // 
            this.lblMainDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainDate.AutoSize = true;
            this.lblMainDate.ForeColor = System.Drawing.Color.White;
            this.lblMainDate.Location = new System.Drawing.Point(8, 210);
            this.lblMainDate.Name = "lblMainDate";
            this.lblMainDate.Size = new System.Drawing.Size(31, 13);
            this.lblMainDate.TabIndex = 1;
            this.lblMainDate.Text = "Date";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(3, 24);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(422, 167);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Title";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.iconPictureBox1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 300;
            this.iconPictureBox1.Location = new System.Drawing.Point(93, 106);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(300, 300);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 560);
            this.Controls.Add(this.fpnlCards);
            this.Controls.Add(this.pnlWaterMark);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(947, 599);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewsFlash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.pnlSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlWaterMark.ResumeLayout(false);
            this.pnlMainSum.ResumeLayout(false);
            this.pnlMainHeader.ResumeLayout(false);
            this.pnlMainHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.FlowLayoutPanel fpnlCards;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel pnlWaterMark;
        private System.Windows.Forms.TreeView spTreeView;
        private FontAwesome.Sharp.IconButton btnAddNewFeed;
        private System.Windows.Forms.Panel pnlMainSum;
        private System.Windows.Forms.Label lblMainSum;
        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Label lblMainPub;
        private System.Windows.Forms.Label lblMainDate;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlBtnANF;
        private System.Windows.Forms.Panel pnlBtnAbout;
        private System.Windows.Forms.Panel pnlBtnSett;
        private System.Windows.Forms.Panel pnlBtnFav;
        private FontAwesome.Sharp.IconButton btnAboutNewsFlash;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnFavorites;
        private FontAwesome.Sharp.IconButton btnDeleteFeed;
        private FontAwesome.Sharp.IconButton btnShare;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton btnOpenArticle;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbProfilePic;
    }
}

