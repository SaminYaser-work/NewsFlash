using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NewsFlash
{
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();

            SetTheme(Settings.colorTheme);

            ShowInfo();
            GetPicture();
            Set2FAStatus();
        }

        private void Set2FAStatus()
        {
            string get2FAStatusQuery = $"SELECT * FROM {News.AccountsTable} WHERE EMAIL='{News.AccEmail}'";
            DataTable dt = new DataTable();
            dt = News.GetDataTable(get2FAStatusQuery);
            if (dt.Rows[0]["HAS2FA"].ToString() == "0")
            {
                lbl2FA.Text = "Unverified account";
                lbl2FA.ForeColor = ColorTheme.Inactive;
            }
            else
            {
                lbl2FA.Text = "Verified account";
                lbl2FA.ForeColor = ColorTheme.Accent;
            }
        }

        private void ShowInfo()
        {
            string getAccInfoQuery = $"Select * from {News.AccountsTable} where EMAIL='{News.AccEmail}'";
            DataTable dt = new DataTable();
            dt = News.GetDataTable(getAccInfoQuery);

            lblUsername.Text = dt.Rows[0]["NAME"].ToString();
            txtBoxPass.Text = dt.Rows[0]["PASSWORD"].ToString();
            txtBoxEmail.Text = News.AccEmail;

            txtBoxEmail.ReadOnly = true;
            txtBoxPass.ReadOnly = true;
        }

        private void GetPicture()
        {
            if (News.AccEmail == "")
            {
                pbPic.Image = Properties.Resources.Default_Pic;
                return;
            }

            string getPictureQuery = $"Select PICTURE from {News.AccountsTable} where EMAIL='{News.AccEmail}'";
            DataTable dt = new DataTable();
            dt = News.GetDataTable(getPictureQuery);
            DataRow dr = dt.Rows[0];

            if (DBNull.Value.Equals(dr["PICTURE"]))
            {
                pbPic.Image = Properties.Resources.Default_Pic;
            }
            else
            {
                byte[] b = new byte[0];
                b = (byte[])(dr["PICTURE"]);
                MemoryStream ms = new MemoryStream(b);
                pbPic.Image = Image.FromStream(ms);
            }
        }

        private void SetTheme(ColorTheme.Theme theme)
        {
            ColorTheme.ChangeTheme(theme);

            this.BackColor = ColorTheme.Soft;

            lblTitle.ForeColor = ColorTheme.Text;
            lblUsername.ForeColor = ColorTheme.Text;
            lblEmail.ForeColor = ColorTheme.Text;
            lblPassword.ForeColor = ColorTheme.Text;

            pnlMain.BackColor = ColorTheme.Medium;
            pnlSecond.BackColor = ColorTheme.Soft;

            btnLogOut.BackColor = ColorTheme.Button;
            btnLogOut.ForeColor = ColorTheme.Text;

            pbPic.BorderColor = ColorTheme.Button;
            pbPic.BorderColor2 = ColorTheme.Button;

            txtBoxEmail.BackColor = ColorTheme.Medium;
            txtBoxEmail.ForeColor = ColorTheme.Text;
            txtBoxPass.BackColor = ColorTheme.Medium;
            txtBoxPass.ForeColor = ColorTheme.Text;

            btnReveal.ForeColor = ColorTheme.Button;
            btnReveal.BackColor = ColorTheme.Soft;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            string deleteLoginQuery = $"DELETE FROM {News.AutoLoginTable}";
            if (News.ExecuteQuery(deleteLoginQuery) < 0)
            {
                MessageBox.Show("Unable to clear autologin table");
            }

            Application.Restart();
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            txtBoxPass.UseSystemPasswordChar = false;
        }
    }
}
