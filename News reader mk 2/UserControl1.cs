using System.Drawing;
using System.Windows.Forms;

namespace News_reader_mk_2
{
    public partial class Cards : UserControl
    {
        private string title;
        private string sourceName;
        private string publishDate;
        private string summary;
        private Image thumbnail;
        private bool isFav;


        public Cards()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => title;

            set
            {
                title = value;
                lblTitle.Text = title;

            }
        }

        public string Publisher { get => sourceName; set { sourceName = value; lblSource.Text = sourceName; } }
        public string PublishDate { get => publishDate; set { publishDate = value; lblDate.Text = publishDate; } }
        public Image Thumbnail
        {
            get => thumbnail;

            set
            {
                thumbnail = value;
            }
        }

        public string Summary { get => summary; set => summary = value; }

        private void Cards_MouseEnter(object sender, System.EventArgs e)
        {
            panel2.BackColor = Color.Gray;
            lblTitle.BackColor = Color.Gray;
            lblDate.BackColor = Color.Gray;
            lblSource.BackColor = Color.Gray;
            this.Cursor = Cursors.Hand;
        }

        private void Cards_MouseLeave(object sender, System.EventArgs e)
        {
            panel2.BackColor = Color.White;
            lblTitle.BackColor = Color.White;
            lblDate.BackColor = Color.White;
            lblSource.BackColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void iconButton1_Click(object sender, System.EventArgs e)
        {
            isFav = isFav ? false : true;

            if (isFav)
                iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            else
                iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
        }

        private void iconButton1_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void iconButton1_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
