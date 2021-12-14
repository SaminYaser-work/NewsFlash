using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data;

namespace NewsFlash
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            picChoosePic.Image = Properties.Resources.Default_Pic;

            SetTheme();
        }

        private void SetTheme()
        {
            ColorTheme.ChangeTheme(ColorTheme.Theme.Dark);

            this.BackColor = ColorTheme.Soft;
            btnContinue.BackColor = ColorTheme.Button;
            btnContinue.ForeColor = ColorTheme.Text;
            btnChoosePic.BackColor = ColorTheme.Inactive;
            btnChoosePic.ForeColor = ColorTheme.Text;

            txtEmail.BackColor = ColorTheme.Hard;
            txtEmail.ForeColor = ColorTheme.Inactive;
            txtPassword.BackColor = ColorTheme.Hard;
            txtPassword.ForeColor = ColorTheme.Inactive;
            txtConfirmPassword.BackColor = ColorTheme.Hard;
            txtConfirmPassword.ForeColor = ColorTheme.Inactive;
            txtBoxUsername.BackColor = ColorTheme.Hard;
            txtBoxUsername.ForeColor = ColorTheme.Inactive;

            lblHeader.ForeColor = ColorTheme.Text;
            lblName.ForeColor = ColorTheme.Text;
            lblPassword.ForeColor = ColorTheme.Text;
            lblRePass.ForeColor = ColorTheme.Text;
            lblEmail.ForeColor = ColorTheme.Text;
            checkBox1.ForeColor = ColorTheme.Text;
            linkLblSignIn.LinkColor = ColorTheme.Button;
            linkLblSignIn.VisitedLinkColor = ColorTheme.Button;

            picChoosePic.BorderColor = ColorTheme.Button;
            picChoosePic.BorderColor2 = ColorTheme.Button;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == String.Empty || txtPassword.Text == String.Empty || txtBoxUsername.Text == String.Empty || txtConfirmPassword.Text == string.Empty)
                MessageBox.Show("Please fill mandatory fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Password do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                // Checking for duplicate emails
                string getAccountQuery = $"SELECT * FROM {News.AccountsTable} WHERE EMAIL='{txtEmail.Text}'";
                DataTable dt = new DataTable();
                dt = News.GetDataTable(getAccountQuery);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("An account already exists with this email.", "Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Don't use News.ExecuteQuery Method
                SqlConnection con = new SqlConnection(News.cs);
                News.AccEmail = txtEmail.Text;
                string createNewAccountQuery = $"INSERT INTO {News.AccountsTable} VALUES('{txtEmail.Text}', '{txtPassword.Text}', '{txtBoxUsername.Text}', 0, @image)";
                SqlCommand cmd = new SqlCommand(createNewAccountQuery, con);
                cmd.Parameters.AddWithValue("@image", SavePhoto());
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                {
                    MessageBox.Show("Unable to sign up data to the database");
                }
                con.Close();

                this.Hide();
                TwoFA twoFA = new TwoFA();
                twoFA.ShowDialog();
                Environment.Exit(0);
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose Picture";
            openFileDialog.Filter = "PNG/JPG File (*.png;*.jpg) | *.png;*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                picChoosePic.Image = new Bitmap(openFileDialog.FileName);
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            picChoosePic.Image.Save(ms, picChoosePic.Image.RawFormat);
            return ms.GetBuffer();
        }

        void Clear()
        {
            txtBoxUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    txtConfirmPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPassword.UseSystemPasswordChar = true;
                    txtConfirmPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                txtEmail.Focus();
                //errorProvider1.Icon = Properties.Resources.Erroricon;
                errorProvider1.SetError(this.txtEmail, "Please fill the field!");
            }
            else
            {
                //errorProvider1.Icon = Properties.Resources.Checkicon;
                errorProvider1.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                txtPassword.Focus();
                //errorProvider1.Icon = Properties.Resources.Erroricon;
                errorProvider1.SetError(this.txtPassword, "Please fill the field!");
            }
            else
            {
                //errorProvider1.Icon = Properties.Resources.Checkicon;
                errorProvider1.Clear();
            }
        }

        // Goes back to previous form
        private void linkLblSignIn_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
