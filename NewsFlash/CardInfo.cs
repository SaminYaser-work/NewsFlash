namespace NewsFlash
{
    internal class CardInfo
    {
        private string title;
        private string publishDate;
        private string summary;
        private string link;
        private string publisher;
        private string category;

        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Link { get => link; set => link = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Category { get => category; set => category = value; }
    }
}
