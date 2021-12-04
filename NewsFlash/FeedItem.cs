namespace NewsFlash
{
    public class FeedItem
    {
        private string feedName;
        private string feedUrl;
        private string feedCategory;

        public string FeedName { get => feedName; set => feedName = value; }
        public string FeedUrl { get => feedUrl; set => feedUrl = value; }
        public string FeedCategory { get => feedCategory; set => feedCategory = value; }
    }
}
