using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace News_reader_mk_2
{

    public partial class Form1 : Form
    {
        string url = "http://feeds.bbci.co.uk/news/world/rss.xml";
        private NewsFeed[] newsFeeds;

        private Cards[] cards = new Cards[5];

        private TreeNode[] newNode = new TreeNode[5];
        private int x = 0;

        private TreeNode categories = new TreeNode("Categories");
        private TreeNode worldNews = new TreeNode("World");
        private TreeNode sportsNews = new TreeNode("Sports");
        private TreeNode lifestyleNews = new TreeNode("Lifestyle");

        //private TreeNode bbc = new TreeNode("BBC");

        private SidePanelTreeView spTreeView;
        private List<TreeNode> addNewsToSP;


        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
            label2.Text = "";
            panel1.BackColor = Color.Transparent;

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            iconPictureBox1.Left = (this.panel1.Width - iconPictureBox1.Width) / 2;
            iconPictureBox1.Top = (this.panel1.Height - iconPictureBox1.Height) / 2;


            // Treeview
            populateTreeView();
            newNode[x] = new TreeNode("BBC");

            worldNews.Nodes.Add(newNode[x]);

            addNewsToSP = new List<TreeNode>();
            addNewsToSP.Add(newNode[x]);


            RSSreader rss = new RSSreader(newNode[x].Text, "World", url);
            x++;

            newsFeeds = rss.GetContent();



        }

        protected void treeView1_AfterSelect(object sender,
        System.Windows.Forms.TreeViewEventArgs e)
        {
            //if (e.Node.Text == "BBC")
            //{
            //    label3.Text = "BBC Clicked";
            //    createCards();
            //}

            foreach (TreeNode tree in addNewsToSP)
            {
                if (e.Node.Text == tree.Text)
                {
                    label3.Text = "BBC Clicked";
                    createCards();
                }

            }
        }

        private void createCards()
        {
            int i = 0;
            foreach (NewsFeed news in newsFeeds)
            {
                cards[i] = new Cards();

                cards[i].Title = news.Title;
                cards[i].PublishDate = news.PublishDate;
                cards[i].Publisher = news.Publisher; // Change this later
                cards[i].Summary = news.Summary;

                flowLayoutPanel1.Controls.Add(cards[i]);

                // Adding click events
                cards[i].MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, news); };
                cards[i].pPanel.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, news); };
                cards[i].pPanel2.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, news); };
                cards[i].pDate.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, news); };
                cards[i].pSource.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, news); };
                cards[i].pTitle.MouseClick += delegate (object sender, MouseEventArgs e) { card_Click(sender, e, news); };

                i++;
                if (i == 5) break;
            }
        }

        private void populateTreeView()
        {
            treeView1.Nodes.Add(categories);
            categories.Nodes.Add(worldNews);
            categories.Nodes.Add(sportsNews);
            categories.Nodes.Add(lifestyleNews);
            //worldNews.Nodes.Add(bbc);
        }

        public void card_Click(object sender, EventArgs e, NewsFeed news)
        {
            label1.Text = news.Title;
            label2.Text = news.Summary;
            panel1.BackColor = Color.Gray;
            iconPictureBox1.Visible = false;
        }
    }
}
