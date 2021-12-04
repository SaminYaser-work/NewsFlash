using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NewsFlash
{
    // Utility class for various purposes
    internal class News
    {
        // Database tables
        private static string accountsTable = "ACCOUNTINFO_TABLE";
        private static string favTable = "FAV_TABLE";
        private static string settingsTable = "SETTINGS_TABLE";
        private static string feedTable = "FEED_TABLE";
        private static string autoLoginTable = "AUTOLOGIN_TABLE";


        // Current user info
        private static string accEmail = "";

        public static string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

        // Fetch datatable from DB
        private static SqlConnection con;
        public static DataTable GetDataTable(string query)
        {
            con = new SqlConnection(News.cs);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            return dt;
        }

        // Execute a query
        public static int ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(News.cs);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public enum NewsCategories
        {
            World,
            Sports,
            Business,
            Health,
            Lifestyle,
            Other
        }

        // Icons for different categories
        private static FontAwesome.Sharp.IconChar iconWorld = FontAwesome.Sharp.IconChar.Globe;
        private static FontAwesome.Sharp.IconChar iconSports = FontAwesome.Sharp.IconChar.Futbol;
        private static FontAwesome.Sharp.IconChar iconBusiness = FontAwesome.Sharp.IconChar.Briefcase;
        private static FontAwesome.Sharp.IconChar iconHealth = FontAwesome.Sharp.IconChar.Heartbeat;
        private static FontAwesome.Sharp.IconChar iconLifestyle = FontAwesome.Sharp.IconChar.Hiking;
        private static FontAwesome.Sharp.IconChar iconOther = FontAwesome.Sharp.IconChar.RssSquare;
        private static FontAwesome.Sharp.IconChar iconUnknown = FontAwesome.Sharp.IconChar.QuestionCircle;

        public static string AccountsTable { get => accountsTable; }
        public static string FavTable { get => favTable; }
        public static string SettingsTable { get => settingsTable; }
        public static string FeedTable { get => feedTable; }
        public static string AutoLoginTable { get => autoLoginTable; }
        public static string AccEmail { get => accEmail; set => accEmail = value; }


        // Gets icon for appropiate category
        public static FontAwesome.Sharp.IconChar GetIcon(string category)
        {
            switch (category)
            {
                case "World":
                    return iconWorld;
                case "Sports":
                    return iconSports;
                case "Business":
                    return iconBusiness;
                case "Health":
                    return iconHealth;
                case "Lifestyle":
                    return iconLifestyle;
                case "Other":
                    return iconOther;
                default:
                    return iconUnknown;
            }
        }
    }
}
