using EASendMail;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewsFlash
{
    public partial class TwoFA : Form
    {

        private static Random rnd = new Random(Guid.NewGuid().GetHashCode());
        private int currentCode;
        private const string nfEmail = "noreply@newsflash.com";
        private const string nfSubject = "Two factor authentication code.";

        public TwoFA()
        {
            InitializeComponent();

            lblStatus.Text = "";
            txtBoxEmail.Text = News.AccEmail;

            txtBoxEmail.Enabled = false;
            txtBoxCode.Enabled = false;
            btnVerify.Enabled = false;

            SetTheme();
        }

        private void SetTheme()
        {
            ColorTheme.ChangeTheme(ColorTheme.Theme.Dark);

            this.BackColor = ColorTheme.Soft;

            lblTitle.ForeColor = ColorTheme.Text;
            lblSubtitle.ForeColor = ColorTheme.Inactive;

            lblEmail.ForeColor = ColorTheme.Text;
            lblEnterCode.ForeColor = ColorTheme.Text;

            txtBoxEmail.BackColor = ColorTheme.Hard;
            txtBoxEmail.ForeColor = ColorTheme.Text;
            txtBoxCode.BackColor = ColorTheme.Hard;
            txtBoxCode.ForeColor = ColorTheme.Text;

            btnChangeEmail.ForeColor = ColorTheme.Button;
            btnSendCode.BackColor = ColorTheme.Button;
            btnSendCode.ForeColor = ColorTheme.Text;
            btnVerify.BackColor = ColorTheme.Accent;
            btnVerify.ForeColor = ColorTheme.Text;
            btnSkip.BackColor = ColorTheme.Inactive;
            btnSkip.ForeColor = ColorTheme.Text;

            lblStatus.ForeColor = ColorTheme.Text;
        }

        private int GetCode()
        {
            return rnd.Next(111111, 999999);
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            currentCode = GetCode();

            if (txtBoxEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter your email.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                SmtpMail mail = new SmtpMail("TryIt"); // must be "TryIt" to use it for free
                mail.From = nfEmail;
                mail.Subject = nfSubject;
                mail.To = txtBoxEmail.Text;
                mail.TextBody = "Your verification code is " + currentCode; // TODO: Add username here

                SmtpServer server = new SmtpServer(""); // no smtp server because I am poor

                EASendMail.SmtpClient smtp = new EASendMail.SmtpClient();
                smtp.SendMail(server, mail);

                lblStatus.Text = "A code has been sent to your email.";
                lblStatus.ForeColor = ColorTheme.Accent;
                lblStatus.Visible = true;

                btnVerify.Enabled = true;
                txtBoxCode.Enabled = true;
            }

            catch (Exception ep)
            {
                lblStatus.Text = "Failed to send the code to given email address.";
                lblStatus.ForeColor = Color.Red;
                lblStatus.Visible = true;
                MessageBox.Show(Properties.Resources.emailErrorMessage, "Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            txtBoxEmail.Enabled = true;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtBoxCode.Text == Convert.ToString(currentCode))
            {
                string oldEmail = News.AccEmail;
                News.AccEmail = txtBoxEmail.Text;

                string changeEmailQuery = $"UPDATE {News.AccountsTable} SET EMAIL='{News.AccEmail}' WHERE EMAIL='{oldEmail}'";
                if (News.ExecuteQuery(changeEmailQuery) < 0)
                {
                    MessageBox.Show("Unable to change email.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string change2FAStatusQuery = $"UPDATE {News.AccountsTable} SET HAS2FA=1 WHERE EMAIL='{News.AccEmail}'";
                if (News.ExecuteQuery(change2FAStatusQuery) < 0)
                {
                    MessageBox.Show("Unable to change status of 2FA.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Your account is now secured with 2-Step Authentication!", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Interests i = new Interests();
                i.ShowDialog();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Code did not match.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interests i = new Interests();
            i.ShowDialog();
            this.Close();
        }
    }
}
