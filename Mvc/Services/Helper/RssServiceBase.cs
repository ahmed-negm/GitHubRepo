using RadarcOnline.App.Presentation.Mvc.Extensions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;
using System.Configuration;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Xml;

namespace RadarcOnline.App.Services
{
    public abstract class RssServiceBase<T>
    {

        protected string url = "";
		private const string Urlpattern = @"(www.+|http.+)([\s]|$)";
        private const string Imgpattern = @"<(?<Tag_Name>(a)|img)\b[^>]*?\b(?<URL_Type>(?(1)href|src))\s*=\s*(?:""(?<URL>(?:\\""|[^""])*)""|'(?<URL>(?:\\'|[^'])*)')";
       
        public virtual T Find(string id)
        {
			var feed = this.GetSyndicationFeed();

			if(feed.Items.Any() == true)
			{
				var item = feed.Items.FirstOrDefault(i=>i.Id == id);
				if(null != item)
				{
					return this.MappItem(item);
				}
			}

			return default(T);
        }

        public virtual List<T> FindAll()
        {
			 var feed = this.GetSyndicationFeed();

            return GetRssMappedItems(feed.Items);			
        }
		
		public virtual List<T> Search(string searchValue)
        {
            return Search(searchValue, "ID", true, 0, 0);
        }

        public virtual List<T> Search(string searchValue, int pageIndex, int pageSize)
        {
            return Search(searchValue, "ID", true, pageIndex, pageSize);
        }

        public virtual List<T> Search(string searchValue, string orderBy)
        {
            return Search(searchValue, orderBy, true, 0, 0);
        }

        public virtual List<T> Search(string searchValue, string orderBy, int pageIndex, int pageSize)
        {
            return Search(searchValue, orderBy, true, pageIndex, pageSize);
        }

        public virtual List<T> Search(string searchValue, string orderBy = "", bool ascending = true, int pageIndex = 0, int pageSize = 10)
        {
			var feed = this.GetSyndicationFeed();
		    var items = 0 < pageSize ? feed.Items.Skip(pageIndex * pageSize).Take(pageSize) : feed.Items;
            return this.GetRssMappedItems(items);
        }

		public virtual List<T> Search(string searchValue, out int searchCount, string orderBy = "", bool ascending = true, int pageIndex = 0, int pageSize = 10)
		{
			var feed = this.GetSyndicationFeed();
			searchCount = feed.Items.Count();
		    var items = 0 < pageSize ? feed.Items.Skip(pageIndex * pageSize).Take(pageSize) : feed.Items;
            return this.GetRssMappedItems(items);
		}

        public virtual int SearchCount(string searchValue)
        {
           var feed = this.GetSyndicationFeed();
            return feed.Items.Count();
        }

		protected virtual List<T> GetRssMappedItems(IEnumerable<SyndicationItem> items)
	    {
	        var feedItems = from item in items
	                        select
	                            this.MappItem(item);

	        return feedItems.ToList();
	    }

        protected abstract T MappItem(SyndicationItem item);
        

		protected virtual SyndicationFeed GetSyndicationFeed(string feedUrl = "")
		{
		    feedUrl = false == string.IsNullOrEmpty(feedUrl) ? feedUrl : this.url;
            XmlReader reader = XmlReader.Create(feedUrl);

            SyndicationFeed feed = SyndicationFeed.Load(reader);
            return feed;
        }

		protected virtual IEnumerable<string> GetImagesInHTMLString(string htmlString)
        {
            var images = new List<string>();
            const string pattern = Imgpattern;
            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(htmlString);

            for (int i = 0, l = matches.Count; i < l; i++)
            {
                if (matches[i].Value.Contains(".jpg") || matches[i].Value.Contains(".png"))
                {
                    var ms = Regex.Matches(matches[i].Value, Urlpattern);
                    if (!string.IsNullOrEmpty(ms[0].Value))
                        images.Add(ms[0].Value.Replace("\"", string.Empty));
                }
            }

            return images;
        }
		
        protected virtual string GetSummary(string summary)
        {
            string resultSummary = summary;
            resultSummary = Utility.DecodeHtml(resultSummary).Trim().Truncate(500, true);
            resultSummary = Utility.SanitizeString(resultSummary);
            return resultSummary;
        }
    }
}
