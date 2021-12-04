using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace NewsFlash
{
    public partial class MainApp : Form
    {
        private RSSFeed feed;
        private Cards[] cards;
        private string feedLinkThatMightGetDeleted;
        private string feedLinkThatMightGetShared;
        private readonly string GetAllFeedsQuery = $"select FEEDNAME, FEEDLINK, FEEDCATEGORY from {News.FeedTable} where EMAIL='{News.AccEmail}'";
        private readonly string getSettingsQuery = $"SELECT * FROM {News.SettingsTable} WHERE EMAIL='{News.AccEmail}'";

        public MainApp()
        {
            InitializeComponent();
            GetSettings();

            // Initilization
            feed = new RSSFeed();
            cards = new Cards[Settings.NewsLimit];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Cards();
            }

            // Style
            pnlMainHeader.Visible = false;
            pnlMainSum.Visible = false;
            btnDeleteFeed.Enabled = false;
            pnlMainSum.AutoScroll = true;
            //notifyIcon1.Visible = false;
            pnlBtnANF.Visible = false;
            pnlBtnFav.Visible = false;
            pnlBtnSett.Visible = false;
            pnlBtnAbout.Visible = false;



            // Database related
            AddCategoryNodes();
            UpdateSidePanel(News.GetDataTable(GetAllFeedsQuery));

            // FIXME: Takes to much time to load
            //FetchFeedsFromDB();

            // Setting the theme
            SetTheme(Settings.colorTheme);
        }

        // Loads the profile picture
        private void MainApp_Load(object sender, EventArgs e)
        {
            GetPicture();
        }

        // Gets the settings for the user from DB
        private void GetSettings()
        {
            DataTable dt = News.GetDataTable(getSettingsQuery);

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];

                if (Convert.ToBoolean(dr["LIGHTTHEME"]))
                    Settings.colorTheme = ColorTheme.Theme.Light;
                else
                    Settings.colorTheme = ColorTheme.Theme.Dark;

                Settings.NewsLimit = Convert.ToInt32(dr["NUMOFFEEDS"]);
            }
            else if (dt.Rows.Count == 0)
            {
                // New user
                string setDefSettingsQuery = $"INSERT INTO {News.SettingsTable} VALUES('{News.AccEmail}', 0, 5)";
                int result = News.ExecuteQuery(setDefSettingsQuery);
                if (result < 0)
                {
                    MessageBox.Show("Failed to set default settings");
                }
            }
            else
            {
                MessageBox.Show("Database error. Duplicate information.");
            }

        }

        // Sets the color theme
        private void SetTheme(ColorTheme.Theme theme)
        {
            ColorTheme.ChangeTheme(theme);

            // Panel
            pnlSidePanel.BackColor = ColorTheme.Hard;
            pnlTitleBar.BackColor = ColorTheme.Hard;
            fpnlCards.BackColor = ColorTheme.Medium;
            pnlWaterMark.BackColor = ColorTheme.Soft;
            pnlMainHeader.BackColor = ColorTheme.Medium;
            pnlMainSum.BackColor = ColorTheme.Medium;

            // Treeview
            spTreeView.BackColor = ColorTheme.Hard;
            spTreeView.LineColor = ColorTheme.Button;

            // Text (label, etc...)
            spTreeView.ForeColor = ColorTheme.Text;
            lblMainTitle.BackColor = ColorTheme.Medium;
            lblMainSum.BackColor = ColorTheme.Medium;
            lblMainTitle.ForeColor = ColorTheme.Text;
            lblMainSum.ForeColor = ColorTheme.Text;

            // Buttons
            btnAboutNewsFlash.BackColor = ColorTheme.Hard;
            btnAboutNewsFlash.ForeColor = ColorTheme.Text;
            btnAddNewFeed.BackColor = ColorTheme.Hard;
            btnAddNewFeed.ForeColor = ColorTheme.Text;
            btnFavorites.BackColor = ColorTheme.Hard;
            btnFavorites.ForeColor = ColorTheme.Text;
            btnSettings.BackColor = ColorTheme.Hard;
            btnSettings.ForeColor = ColorTheme.Text;
            pnlBtnAbout.BackColor = ColorTheme.Button;
            pnlBtnANF.BackColor = ColorTheme.Button;
            pnlBtnFav.BackColor = ColorTheme.Button;
            pnlBtnSett.BackColor = ColorTheme.Button;
            btnDeleteFeed.BackColor = ColorTheme.Hard;
            btnOpenArticle.BackColor = ColorTheme.Medium;
            btnShare.BackColor = ColorTheme.Medium;

            // Dividers (Panel)
            panel1.BackColor = ColorTheme.Divider;
            panel2.BackColor = ColorTheme.Divider;
            panel3.BackColor = ColorTheme.Divider;

            // Misc
            iconPictureBox1.ForeColor = ColorTheme.Divider;
            btnDeleteFeed.IconColor = ColorTheme.Text;
            btnShare.IconColor = ColorTheme.Text;
            btnOpenArticle.IconColor = ColorTheme.Text;
            btnFavorites.IconColor = ColorTheme.Text;
            btnAddNewFeed.IconColor = ColorTheme.Text;
            btnSettings.IconColor = ColorTheme.Text;
            btnAboutNewsFlash.IconColor = ColorTheme.Text;
            //pbLogo.Image = ColorTheme.Logo;
        }

        private void AddCategoryNodes()
        {
            foreach (string category in Enum.GetNames(typeof(News.NewsCategories)))
            {
                spTreeView.Nodes.Add(category);
            }
        }

        private void AddNewFeed(FeedItem feedItem)
        {
            CardInfo[] cardInfo = new CardInfo[Settings.NewsLimit];

            for (int i = 0; i < cardInfo.Length; i++)
            {
                cardInfo[i] = new CardInfo();
            }

            cardInfo = feed.GetCards(feedItem);

            if (cardInfo == null)
            {
                MessageBox.Show("Unable to load feed. Link is invalid or check your internet connection.", "Failed to load feed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            addCards(cardInfo);
        }

        private void GetPicture()
        {
            if (News.AccEmail == "")
            {
                pbProfilePic.Image = Properties.Resources.Default_Pic;
                return;
            }

            string getPictureQuery = $"Select PICTURE from {News.AccountsTable} where EMAIL='{News.AccEmail}'";
            DataTable dt = new DataTable();
            dt = News.GetDataTable(getPictureQuery);
            DataRow dr = dt.Rows[0];

            if (DBNull.Value.Equals(dr["PICTURE"]))
            {
                pbProfilePic.Image = Properties.Resources.Default_Pic;
            }
            else
            {
                byte[] b = new byte[0];
                b = (byte[])(dr["PICTURE"]);
                MemoryStream ms = new MemoryStream(b);
                pbProfilePic.Image = Image.FromStream(ms);
            }
        }

        private void addCards(CardInfo[] cardInfo)
        {
            int i = 0;
            Cursor.Current = Cursors.Default;

            Cards[] cards = new Cards[cardInfo.Length];

            foreach (var info in cardInfo)
            {
                cards[i] = new Cards();

                // Setting the information
                cards[i].CardTitle = info.Title;
                cards[i].CardDate = info.PublishDate;
                cards[i].CardPublisher = info.Publisher;
                cards[i].faPbCardIcon.IconChar = News.GetIcon(info.Category);


                // Set the status of favorite button style
                cards[i].IsFav = CheckFavourite(info.Link);

                // Setting the theme
                cards[i].SetCardTheme(Settings.colorTheme);

                // Adding click events
                cards[i].MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, info); };
                cards[i].lblTitle.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, info); };
                cards[i].lblPublisher.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, info); };
                cards[i].lblDate.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, info); };
                cards[i].faPbCardIcon.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, info); };
                cards[i].btnFav.MouseClick += delegate (object sender, MouseEventArgs e) { MakeFavourite(sender, e, info); };


                // Adding it to the flowlayout panel
                fpnlCards.Controls.Add(cards[i]);

                i++;
                if (i == cards.Length) break;
            }
        }

        private bool CheckFavourite(string url)
        {
            string checkFavQuery = $"SELECT * FROM {News.FavTable} WHERE EMAIL='{News.AccEmail}' AND LINK='{url}'";

            DataTable dt = new DataTable();
            dt = News.GetDataTable(checkFavQuery);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        // Shows all favourited feeds
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            GetFavourites();
        }

        private void GetFavourites()
        {
            string GetFavQuery = $"SELECT * FROM {News.FavTable} WHERE EMAIL='{News.AccEmail}'";
            DataTable dt = new DataTable();
            dt = News.GetDataTable(GetFavQuery);

            if (dt.Rows.Count > 0)
            {
                CardInfo[] cardInfo = new CardInfo[dt.Rows.Count];
                for (int j = 0; j < cardInfo.Length; j++)
                {
                    cardInfo[j] = new CardInfo();
                }

                fpnlCards.Controls.Clear();
                pnlMainHeader.Visible = false;
                pnlMainSum.Visible = false;

                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    cardInfo[i].Title = dr["TITLE"].ToString();
                    cardInfo[i].Summary = dr["SUMMARY"].ToString();
                    cardInfo[i].Publisher = dr["PUBLISHER"].ToString();
                    cardInfo[i].PublishDate = dr["PDATE"].ToString();
                    cardInfo[i].Link = dr["LINK"].ToString();
                    cardInfo[i].Category = dr["CATEGORY"].ToString();

                    i++;
                    if (i == dt.Rows.Count) break;
                }
                addCards(cardInfo);
            }
            else
            {
                MessageBox.Show("Your favourite list is empty. Favourite some feed to get started!", "Favourites", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MakeFavourite(object sender, MouseEventArgs e, CardInfo info)
        {
            if (CheckFavourite(info.Link))
            {
                RemoveFromFav(info.Link);
                GetFavourites();
                MessageBox.Show("Removed from favourites.");
                return;
            }

            string makeFavQuery = $"INSERT INTO {News.FavTable}(EMAIL, TITLE, SUMMARY, PUBLISHER, PDATE, LINK, CATEGORY) VALUES('{News.AccEmail}', '{info.Title.Replace("\'", string.Empty)}', '{info.Summary.Replace("\'", string.Empty)}', '{info.Publisher.Replace("\'", string.Empty)}', '{info.PublishDate}', '{info.Link}', '{info.Category}');";

            int result = News.ExecuteQuery(makeFavQuery);
            if (result < 0)
            {
                MessageBox.Show("Unable to save to database.");
            }
        }

        private void RemoveFromFav(string url)
        {
            string deleteFromFavQuery = $"DELETE FROM {News.FavTable} WHERE ACCNAME='{News.AccEmail}' AND LINK='{url}'";
            //SqlConnection con = new SqlConnection(News.cs);
            //SqlCommand cmd = new SqlCommand(deleteFromFavQuery, con);
            int result = News.ExecuteQuery(deleteFromFavQuery);
            //con.Open();
            //int result = cmd.ExecuteNonQuery();
            if (result < 0)
            {
                MessageBox.Show("Unable to delete the feed.");
            }
            //con.Close();
        }

        private void card_Click(object sender, EventArgs e, CardInfo cardInfo)
        {
            iconPictureBox1.Visible = false;

            pnlMainHeader.Visible = true;
            pnlMainSum.Visible = true;

            lblMainTitle.Text = cardInfo.Title;
            lblMainDate.Text = "Date Published: " + cardInfo.PublishDate;
            lblMainPub.Text = cardInfo.Publisher;
            lblMainSum.Text = cardInfo.Summary;

            feedLinkThatMightGetShared = cardInfo.Link;
        }

        // Other Forms
        private void btnAddNewFeed_Click(object sender, EventArgs e)
        {
            AddNewFeedForm addNewFeedForm = new AddNewFeedForm();
            addNewFeedForm.ShowDialog();

            UpdateSidePanel(News.GetDataTable(GetAllFeedsQuery));

            // No need of this method - maybe for a refresh feed fucntion?
            //FetchFeedsFromDB();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }


        private void UpdateSidePanel(DataTable dt)
        {
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (TreeNode tree in spTreeView.Nodes)
                {
                    // Searching for correct category to add
                    if (dataRow["FEEDCATEGORY"].ToString() == tree.Text)
                    {
                        bool isPresent = false;
                        // Don't add it if its already there, no duplication
                        foreach (TreeNode subNodes in tree.Nodes)
                        {
                            if (subNodes.Text == dataRow["FEEDNAME"].ToString())
                            {
                                isPresent = true;
                                break;
                            }
                        }
                        if (!isPresent)
                            tree.Nodes.Add(dataRow["FEEDNAME"].ToString());
                    }
                }
            }
        }

        private void FetchFeedsFromDB()
        {
            DataTable dt = News.GetDataTable(GetAllFeedsQuery);
            foreach (DataRow dr in dt.Rows)
            {
                FeedItem feedItem = new FeedItem();

                feedItem.FeedName = dr["FEEDNAME"].ToString();
                feedItem.FeedUrl = dr["FEEDLINK"].ToString();
                feedItem.FeedCategory = dr["FEEDCATEGORY"].ToString();

                AddNewFeed(feedItem);
            }
        }

        private void spTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = News.GetDataTable(GetAllFeedsQuery);

            // Changing mouse cursor
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["FEEDNAME"].ToString() == e.Node.Text)
                {
                    fpnlCards.Controls.Clear();
                    pnlMainHeader.Visible = false;
                    pnlMainSum.Visible = false;

                    FeedItem feedItem = new FeedItem();
                    feedItem.FeedName = dr["FEEDNAME"].ToString();
                    feedItem.FeedUrl = dr["FEEDLINK"].ToString();
                    feedItem.FeedCategory = dr["FEEDCATEGORY"].ToString();

                    btnDeleteFeed.Enabled = true;
                    feedLinkThatMightGetDeleted = feedItem.FeedUrl;


                    AddNewFeed(feedItem);

                    break;
                }
            }

        }

        // Delete Feed
        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure you want to delete the feed?", "Delete Feed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (feedLinkThatMightGetDeleted == "")
                    MessageBox.Show("Unable to delete the feed.");

                fpnlCards.Controls.Clear();

                string deleteFeedQUery = $"DELETE FROM FEED_TABLE WHERE FEEDLINK='{feedLinkThatMightGetDeleted}'";
                int result = News.ExecuteQuery(deleteFeedQUery);

                if (result < 0)
                {
                    MessageBox.Show("Unable to delete the feed.");
                }
                else
                {
                    spTreeView.Nodes.Clear();
                    AddCategoryNodes();
                    UpdateSidePanel(News.GetDataTable(GetAllFeedsQuery));
                }
            }
        }

        // Share button
        private void btnShare_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(feedLinkThatMightGetShared);

            notifyIcon1.Icon = Properties.Resources.share_this;
            notifyIcon1.Text = "NewsFlash";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "NewsFlash Share";
            notifyIcon1.BalloonTipText = "Link has been copied to the clipboard.";
            notifyIcon1.ShowBalloonTip(100);
        }

        // Read full article or open in browser button
        private void btnOpenArticle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(feedLinkThatMightGetShared)) return;

            ProcessStartInfo openLink = new ProcessStartInfo
            {
                FileName = feedLinkThatMightGetShared,
                UseShellExecute = true
            };
            Process.Start(openLink);
        }


        // Button effects
        private void btnAddNewFeed_Enter(object sender, EventArgs e)
        {
            btnAddNewFeed.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAddNewFeed.Padding = new Padding(20, 0, 0, 0);
            pnlBtnANF.Visible = true;
            btnAddNewFeed.BackColor = ColorTheme.Highlight;
        }
        private void btnAddNewFeed_Leave(object sender, EventArgs e)
        {
            btnAddNewFeed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNewFeed.Padding = new Padding(0, 0, 0, 0);
            pnlBtnANF.Visible = false;
            btnAddNewFeed.BackColor = ColorTheme.Hard;
        }
        private void btnFavorites_MouseEnter(object sender, EventArgs e)
        {
            btnFavorites.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnFavorites.Padding = new Padding(20, 0, 0, 0);
            pnlBtnFav.Visible = true;
            btnFavorites.BackColor = ColorTheme.Highlight;
        }
        private void btnFavorites_MouseLeave(object sender, EventArgs e)
        {
            btnFavorites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFavorites.Padding = new Padding(0, 0, 0, 0);
            pnlBtnFav.Visible = false;
            btnFavorites.BackColor = ColorTheme.Hard;
        }
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSettings.Padding = new Padding(20, 0, 0, 0);
            pnlBtnSett.Visible = true;
            btnSettings.BackColor = ColorTheme.Highlight;
        }
        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.Padding = new Padding(0, 0, 0, 0);
            pnlBtnSett.Visible = false;
            btnSettings.BackColor = ColorTheme.Hard;
        }

        private void btnAboutNewsFlash_MouseEnter(object sender, EventArgs e)
        {
            btnAboutNewsFlash.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAboutNewsFlash.Padding = new Padding(20, 0, 0, 0);
            pnlBtnAbout.Visible = true;
            btnAboutNewsFlash.BackColor = ColorTheme.Highlight;
        }

        private void btnAboutNewsFlash_MouseLeave(object sender, EventArgs e)
        {
            btnAboutNewsFlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAboutNewsFlash.Padding = new Padding(0, 0, 0, 0);
            pnlBtnAbout.Visible = false;
            btnAboutNewsFlash.BackColor = ColorTheme.Hard;
        }
        private void btnDeleteFeed_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteFeed.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnDeleteFeed.BackColor = System.Drawing.Color.FromArgb(202, 2, 1);
        }
        private void btnDeleteFeed_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteFeed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteFeed.BackColor = ColorTheme.Hard;
        }

        private void btnShare_MouseEnter(object sender, EventArgs e)
        {
            btnShare.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnShare.BackColor = ColorTheme.Button;
        }

        private void btnShare_MouseLeave(object sender, EventArgs e)
        {
            btnShare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShare.BackColor = ColorTheme.Medium;
        }

        private void btnOpenArticle_MouseEnter(object sender, EventArgs e)
        {
            btnOpenArticle.BackColor = ColorTheme.Button;
        }

        private void btnOpenArticle_MouseLeave(object sender, EventArgs e)
        {
            btnOpenArticle.BackColor = ColorTheme.Medium;
        }

        private void rjCircularPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //SignUp s = new SignUp();
            //s.Show();
            AccountInfo ai = new AccountInfo();
            ai.ShowDialog();
        }

    }
}
