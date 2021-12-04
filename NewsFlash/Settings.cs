using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsFlash
{
    public partial class Settings : Form
    {
        // News card limit
        private static int limit = 5;

        // Database test - remove later
        //public static string accountName = "user1";

        // Color theme variable
        public static ColorTheme.Theme colorTheme = ColorTheme.Theme.Dark;


        private bool isLightTheme = false;
        //private int numOfFeeds = 5;
        private string updateSettingsQuery;
        //private string getSettingsQuery;


        public Settings()
        {
            // Initilization
            InitializeComponent();

            DisplaySavedSettings();

            SetTheme(colorTheme);
        }

        // Accessors
        public static int NewsLimit
        {
            set => limit = value;
            get => limit;
        }

        //public void DecideColorTheme()
        //{
        //    if (colorTheme == ColorTheme.Theme.Light)
        //        isLightTheme = true;
        //    else
        //        isLightTheme = false;
        //}

        // Sets the theme
        private void SetTheme(ColorTheme.Theme theme)
        {
            ColorTheme.ChangeTheme(theme);

            btnCancel.ForeColor = ColorTheme.Text;
            btnCancel.BackColor = ColorTheme.Accent;
            btnSave.ForeColor = ColorTheme.Text;
            btnSave.BackColor = ColorTheme.Accent;

            this.BackColor = ColorTheme.Soft;
            lblTheme.ForeColor = ColorTheme.Text;
            lblNumOfFeeds.ForeColor = ColorTheme.Text;

            rbToggle.OnBackColor = ColorTheme.Button;
            cbNumOfFeeds.ListBackColor = ColorTheme.Highlight;
            cbNumOfFeeds.BackColor = ColorTheme.Inactive;
            cbNumOfFeeds.ForeColor = ColorTheme.Text;
            cbNumOfFeeds.BorderColor = ColorTheme.Divider;
            cbNumOfFeeds.ListTextColor = ColorTheme.Text;
            cbNumOfFeeds.IconColor = ColorTheme.Accent;
        }


        // Display the currently applied settings
        private void DisplaySavedSettings()
        {
            // Visual Change of radio button
            if (colorTheme == ColorTheme.Theme.Light)
                rbToggle.Checked = true;
            else
                rbToggle.Checked = false;

            // Visual Change of combo box
            switch (NewsLimit)
            {
                case 5:
                    cbNumOfFeeds.SelectedIndex = 0;
                    break;
                case 10:
                    cbNumOfFeeds.SelectedIndex = 1;
                    break;
                default:
                    cbNumOfFeeds.SelectedIndex = 0;
                    break;
            }
        }

        // Button click events

        // Cancel button, kills window, changes are not saved to DB
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Saves settings to database and restarts the application
        private void btnSave_Click(object sender, EventArgs e)
        {
            NewsLimit = cbNumOfFeeds.SelectedIndex == 0 ? 5 : 10;

            //SqlConnection con = new SqlConnection(News.cs);
            updateSettingsQuery = $"UPDATE {News.SettingsTable} SET LIGHTTHEME={Convert.ToInt32(isLightTheme)}, NUMOFFEEDS={NewsLimit} WHERE EMAIL='{News.AccEmail}'";
            //SqlCommand cmd = new SqlCommand(updateSettingsQuery, con);

            if (News.ExecuteQuery(updateSettingsQuery) < 0)
            {
                MessageBox.Show("Unable to save the settings.");
            }
            else
            {
                DialogResult d = MessageBox.Show("Application need to be restarted for changes to take effect.\n Restart NewsFlash?", "Setting Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }



            //con.Open();
            //int result = cmd.ExecuteNonQuery();
            //if (result < 0)
            //{
            //    MessageBox.Show("Unable to save the settings.");
            //}
            //else
            //{
            //    DialogResult d = MessageBox.Show("Application need to be restarted for changes to take effect.\n Restart NewsFlash?", "Setting Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (d == DialogResult.Yes)
            //    {
            //        Application.Restart();
            //    }
            //}
            //con.Close();
        }

        private void rbToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToggle.Checked)
                isLightTheme = true;
            else
                isLightTheme = false;
        }
    }
}
