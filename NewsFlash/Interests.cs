using System;
using System.Windows.Forms;

namespace NewsFlash
{
    public partial class Interests : Form
    {
        public Interests()
        {
            InitializeComponent();

            SetTheme();
        }

        private void SetTheme()
        {
            ColorTheme.ChangeTheme(ColorTheme.Theme.Dark);

            this.BackColor = ColorTheme.Soft;

            btnNext.BackColor = ColorTheme.Button;
            btnNext.ForeColor = ColorTheme.Text;

            lblBusiness.ForeColor = ColorTheme.Text;
            lblHealth.ForeColor = ColorTheme.Text;
            lblLifestyle.ForeColor = ColorTheme.Text;
            lblSports.ForeColor = ColorTheme.Text;
            lblTitle.ForeColor = ColorTheme.Text;
            lblWorld.ForeColor = ColorTheme.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (chkWorld.Checked)
            {
                AddFeed(Properties.Resources.world1Name, Properties.Resources.world1Link, lblWorld.Text);
                AddFeed(Properties.Resources.world2Name, Properties.Resources.world2Link, lblWorld.Text);
            }
            if (chkBusiness.Checked)
            {
                AddFeed(Properties.Resources.bus1Name, Properties.Resources.bus1Link, lblBusiness.Text);
                AddFeed(Properties.Resources.bus2Name, Properties.Resources.bus2Link, lblBusiness.Text);
            }
            if (chkLifestyle.Checked)
            {
                AddFeed(Properties.Resources.lifestyle1Name, Properties.Resources.lifestyle1Link, lblLifestyle.Text);
                AddFeed(Properties.Resources.lifestyle2Name, Properties.Resources.lifestyle2Link, lblLifestyle.Text);
            }
            if (chkSports.Checked)
            {
                AddFeed(Properties.Resources.sports1Name, Properties.Resources.sports1Link, lblSports.Text);
                AddFeed(Properties.Resources.sports2Name, Properties.Resources.sports2Link, lblSports.Text);
            }
            if (chkHealth.Checked)
            {
                AddFeed(Properties.Resources.health1Name, Properties.Resources.health1Link, lblHealth.Text);
                AddFeed(Properties.Resources.health2Name, Properties.Resources.health2Link, lblHealth.Text);
            }


            this.Hide();
            //System.Threading.Thread.Sleep(1000); // May fix a bug

            MainApp m = new MainApp();
            //System.Threading.Thread.Sleep(1000); // May fix a bug
            m.ShowDialog();

            Environment.Exit(0);
        }

        private void AddFeed(string name, string link, string category)
        {
            string addFeedQuery = $"Insert Into {News.FeedTable} VALUES('{News.AccEmail}', '{name}', '{link}', '{category}')";
            News.ExecuteQuery(addFeedQuery);
        }
    }
}
