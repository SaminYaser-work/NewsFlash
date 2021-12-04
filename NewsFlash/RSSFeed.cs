using CodeHollow.FeedReader;

namespace NewsFlash
{
    internal class RSSFeed
    {
        private CardInfo[] cardInfo = new CardInfo[Settings.NewsLimit];

        public CardInfo[] GetCards(FeedItem feedItem)
        {

            try
            {
                // Async is hard
                var feed = FeedReader.Read(feedItem.FeedUrl);

                int i = 0;
                foreach (var item in feed.Items)
                {
                    cardInfo[i] = new CardInfo();

                    cardInfo[i].Publisher = feedItem.FeedName;
                    cardInfo[i].Title = item.Title.ToString();
                    cardInfo[i].PublishDate = item.PublishingDate.ToString();
                    cardInfo[i].Summary = item.Description;
                    cardInfo[i].Link = item.Link;
                    cardInfo[i].Category = feedItem.FeedCategory;

                    i++;
                    if (i == cardInfo.Length) break;
                }
                return cardInfo;
            }
            catch (System.Exception e)
            {
                return null;
            }

        }
    }
}
