using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class MovieLink
    {
        private String link;

        private String title;

        public MovieLink(String link, String title)
        {
            this.link = link;
            this.title = title;
        }

        public String GetLink()
        {
            return link;
        }

        public String GetTitle()
        {
            return title;
        }
    }
}
