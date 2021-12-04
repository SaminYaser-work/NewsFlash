using System.Xml;
using System.ServiceModel.Syndication;

namespace News_reader_mk_2
{
    public struct NewsFeed
    {
        private string title;
        private string publishDate;
        private string summary;
        private string link;
        private string image;
        private string publisher;
        private string category;


        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Link { get => link; set => link = value; }
        public string Image { get => image; set => image = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Category { get => category; set => category = value; }
    }

    class RSSreader
    {
        private string _publisher;
        private string _category;
        private string _url;

        public RSSreader(string publisher, string category, string url)
        {
            _publisher = publisher;
            _category = category;
            _url = url;
        }

        public NewsFeed[] GetContent()
        {
            //string url = "https://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml";
            //string url = "http://feeds.bbci.co.uk/news/world/rss.xml";


            XmlReader reader = XmlReader.Create(_url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();


            int limit = 10;
            int i = 0;
            NewsFeed[] newsFeed = new NewsFeed[limit];

            foreach (SyndicationItem item in feed.Items)
            {
                newsFeed[i].Title = item.Title.Text;
                newsFeed[i].PublishDate = item.PublishDate.ToLocalTime().ToString().Substring(0, 21);
                newsFeed[i].Summary = item.Summary.Text;
                newsFeed[i].Link = item.Links[0].Uri.ToString();
                newsFeed[i].Publisher = _publisher;
                newsFeed[i].Category = _category;

                if (reader.HasAttributes)
                {
                    string value = reader[i].ToString();
                    if (value.StartsWith("http://") && (value.EndsWith(".jpg") || value.EndsWith(".png") || value.EndsWith(".gif")))
                    {
                        newsFeed[i].Image = value;
                    }
                }

                i++;
                if (i == limit) break;
            }

            return newsFeed;
        }
    }
}
