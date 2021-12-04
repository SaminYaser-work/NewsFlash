using System.Diagnostics;
using System.Windows.Forms;

namespace NewsFlash
{
    public partial class About : Form
    {
        private const string githubLink = "https://github.com/SaminYaser-work/NewsFlash";
        public About()
        {
            InitializeComponent();

            lblDescription.Text = Properties.Resources.aboutDescription;

            SetTheme(Settings.colorTheme);
        }

        private void SetTheme(ColorTheme.Theme theme)
        {
            ColorTheme.ChangeTheme(theme);

            this.BackColor = ColorTheme.Soft;
            lblDescription.ForeColor = ColorTheme.Text;
            linkLabel1.LinkColor = ColorTheme.Button;
            linkLabel1.VisitedLinkColor = ColorTheme.Button;
            label1.ForeColor = ColorTheme.Text;
            pbGithub.IconColor = ColorTheme.Text;

            materialDivider1.BackColor = ColorTheme.Divider;
        }

        // Opens github link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo openLink = new ProcessStartInfo
            {
                FileName = githubLink,
                UseShellExecute = true
            };
            Process.Start(openLink);
        }
    }
}
