using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsFlash
{
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
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
    }
}
