using System.Windows.Forms;

namespace NewsFlash
{
    public partial class Cards : UserControl
    {
        private bool isFav = false;

        public bool IsFav { get => isFav; set { isFav = value; SetIcon(); } }

        public Cards()
        {
            InitializeComponent();

            lblTitle.AutoEllipsis = true;

            SetTheme(ColorTheme.Theme.Dark);

        }

        public void SetCardTheme(ColorTheme.Theme theme)
        {
            SetTheme(theme);
        }

        private void SetTheme(ColorTheme.Theme theme)
        {
            ColorTheme.ChangeTheme(theme);

            this.BackColor = ColorTheme.Highlight;
            lblTitle.BackColor = ColorTheme.Highlight;
            lblTitle.ForeColor = ColorTheme.Text;
            faPbCardIcon.BackColor = ColorTheme.Highlight;
            faPbCardIcon.ForeColor = ColorTheme.Text;
            lblDate.ForeColor = ColorTheme.Inactive;
            lblPublisher.ForeColor = ColorTheme.Inactive;
        }

        // Focus events (when the card is clicked)
        private void Cards_Enter(object sender, System.EventArgs e)
        {
            this.BackColor = ColorTheme.Soft;
            lblTitle.BackColor = ColorTheme.Soft;
            faPbCardIcon.BackColor = ColorTheme.Soft;
            faPbCardIcon.ForeColor = ColorTheme.Accent;
        }
        private void Cards_Leave(object sender, System.EventArgs e)
        {
            this.BackColor = ColorTheme.Highlight;
            lblTitle.BackColor = ColorTheme.Highlight;
            faPbCardIcon.BackColor = ColorTheme.Highlight;
            faPbCardIcon.ForeColor = ColorTheme.Inactive;
        }

        private void lblTitle_Click(object sender, System.EventArgs e)
        {
            this.Focus();
        }

        private void btnFav_Click(object sender, System.EventArgs e)
        {
            SetFavStatus();
        }

        private void SwitchFavStatus() { isFav = isFav ? false : true; }

        private void SetFavStatus()
        {
            //lblTitle.Focus();
            SwitchFavStatus();
            SetIcon();
        }

        private void SetIcon()
        {
            if (isFav)
                btnFav.IconFont = FontAwesome.Sharp.IconFont.Solid;
            else
                btnFav.IconFont = FontAwesome.Sharp.IconFont.Auto;
        }
    }
}
