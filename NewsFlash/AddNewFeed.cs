using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewsFlash
{
    public partial class AddNewFeedForm : Form
    {

        public AddNewFeedForm()
        {
            InitializeComponent();

            AddCategoriesToCB();

            SetTheme();
        }

        private void SetTheme()
        {
            this.BackColor = ColorTheme.Medium;
            btnAddNewFeed.BackColor = ColorTheme.Button;
            btnAddNewFeed.ForeColor = ColorTheme.Text;
            btnCancel.BackColor = ColorTheme.Button;
            btnCancel.ForeColor = ColorTheme.Text;

            txtBoxNFLink.BackColor = ColorTheme.Hard;
            txtBoxNFLink.ForeColor = ColorTheme.Inactive;
            txtBoxNFName.BackColor = ColorTheme.Hard;
            txtBoxNFName.ForeColor = ColorTheme.Inactive;
            lblLink.ForeColor = ColorTheme.Text;
            lblName.ForeColor = ColorTheme.Text;
            lblCategory.ForeColor = ColorTheme.Text;

            cbFeedCategory.BackColor = ColorTheme.Hard;
            cbFeedCategory.ForeColor = ColorTheme.Inactive;
            cbFeedCategory.BorderColor = ColorTheme.Button;
        }

        private void AddCategoriesToCB()
        {
            foreach (string category in Enum.GetNames(typeof(News.NewsCategories)))
            {
                cbFeedCategory.Items.Add(category);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtBoxNFLink.Text != String.Empty && txtBoxNFName.Text != String.Empty && cbFeedCategory.SelectedIndex > -1)
            {

                // Inserting into database
                string addNewFeedQuery = $"INSERT INTO {News.FeedTable}(EMAIL, FEEDNAME, FEEDLINK, FEEDCATEGORY)" +
                              $"values('{News.AccEmail}', '{txtBoxNFName.Text}', '{txtBoxNFLink.Text}', '{cbFeedCategory.SelectedItem.ToString()}')";

                int result = News.ExecuteQuery(addNewFeedQuery);

                if (result < 0)
                {
                    MessageBox.Show("Data insertion failed.");
                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please fill out the all the fields.");
            }
        }

        // Disable typing in the combo box
        private void cbFeedCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Disables ugly highlighting after combo box is closed
        private void cbFeedCategory_DropDownClosed(object sender, EventArgs e)
        {
            btnAddNewFeed.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
