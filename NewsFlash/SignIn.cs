using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace NewsFlash
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            checkAutoLogin();

            SetTheme();
        }

        private void SetTheme()
        {
            ColorTheme.ChangeTheme(ColorTheme.Theme.Dark);

            this.BackColor = ColorTheme.Soft;

            lblHeader.ForeColor = ColorTheme.Text;
            lblSubTitle.ForeColor = ColorTheme.Inactive;
            lblEmail.ForeColor = ColorTheme.Text;
            lblPass.ForeColor = ColorTheme.Text;
            chkBoxRemember.ForeColor = ColorTheme.Text;
            checkBox1.ForeColor = ColorTheme.Text;

            btnLogin.ForeColor = ColorTheme.Text;
            btnLogin.BackColor = ColorTheme.Button;
            linkLblSignUp.LinkColor = ColorTheme.Button;
            linkLblSignUp.VisitedLinkColor = ColorTheme.Button;

            txtBoxEmail.BackColor = ColorTheme.Hard;
            txtBoxEmail.ForeColor = ColorTheme.Text;
            txtBoxPassword.BackColor = ColorTheme.Hard;
            txtBoxPassword.ForeColor = ColorTheme.Text;
        }

        private void checkAutoLogin()
        {
            string getEmailQuery = $"Select EMAIL from {News.AutoLoginTable}";
            DataTable dt = News.GetDataTable(getEmailQuery);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                News.AccEmail = dr["EMAIL"].ToString();

                MessageBox.Show("Auto login activated.");

                this.Hide();
                MainApp m = new MainApp();
                m.ShowDialog();
                Environment.Exit(0);

                // TODO: Exit app after when m is closed
                //this.Show();
                //Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    txtBoxPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    txtBoxPassword.UseSystemPasswordChar = true;
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text != string.Empty && txtBoxPassword.Text != string.Empty)
            {

                SqlConnection con = new SqlConnection(News.cs);
                string checkForAccountQuery = $"Select * from {News.AccountsTable} where EMAIL='{txtBoxEmail.Text}' and PASSWORD='{txtBoxPassword.Text}'";
                SqlCommand cmd = new SqlCommand(checkForAccountQuery, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    this.Hide();
                    MessageBox.Show("LOGIN SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    News.AccEmail = txtBoxEmail.Text;

                    if (chkBoxRemember.Checked)
                    {
                        string deleteLoginQuery = $"DELETE FROM {News.AutoLoginTable}";
                        if (News.ExecuteQuery(deleteLoginQuery) < 0)
                        {
                            MessageBox.Show("Unable to clear autologin table");
                        }

                        string saveLoginQuery = $"INSERT INTO {News.AutoLoginTable}(Email) Values('{News.AccEmail}')";
                        if (News.ExecuteQuery(saveLoginQuery) < 0)
                        {
                            MessageBox.Show("Failed save autologin info to database.");
                        }
                    }

                    MainApp m = new MainApp();
                    m.ShowDialog();
                    Environment.Exit(0);
                }

                else
                {
                    MessageBox.Show("LOGIN Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Username Or Password is not correct Or Empty!", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxEmail.Text) == true)
            {
                //errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.txtBoxEmail, "Please enter your email.");
            }

            else
            {
                //errorProvider1.Icon = Properties.Resources.check;
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPassword.Text) == true)
            {
                //errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.txtBoxPassword, "Please enter your password.");
            }

            else
            {
                //errorProvider2.Icon = Properties.Resources.check;
                errorProvider2.Clear();
            }

        }

        private void linkLblSignUp_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.ShowDialog();
            this.Show();
        }
    }
}
