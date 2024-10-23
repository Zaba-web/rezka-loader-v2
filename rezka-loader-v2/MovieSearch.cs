using System;
using System.Collections;
using HtmlAgilityPack;
using System.Linq;

namespace rezka_loader_v2
{
    internal class MovieSearch
    {
        private RezkaClient rezkaClient;

        public MovieSearch()
        {
            rezkaClient = new RezkaClient();
        }

        public ArrayList PerformSearch(String request)
        {
            ArrayList foundMovies = new ArrayList();
            String resultPage = rezkaClient.search(request);

            if (resultPage == null)
            {
                return null;
            }

            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(resultPage);

            HtmlNodeCollection movieNodes = html.DocumentNode.SelectNodes("//div[contains(@class, 'b-content__inline_item-link')]");

            if (movieNodes == null)
            {
                return null;
            }

            foreach (HtmlNode movieNode in movieNodes)
            {
                var link = movieNode.ChildNodes["a"];
                String name = link.InnerText;
                String pageLink = link.GetAttributeValue("href", "");
                foundMovies.Add(new MovieLink(pageLink, name));

            }

            return foundMovies;
        }

        public string getNameFromUrl(String url)
        {
            String page = rezkaClient.GetMoviePage(url);

            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(page);

            HtmlNodeCollection title = html.DocumentNode.SelectNodes("//div[contains(@class, 'b-post__title')]");

            if (title.Count > 0)
            {
                return title[0].InnerText;
            }

            return "";
        }
    }
}
