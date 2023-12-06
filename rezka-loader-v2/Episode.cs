using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class Episode
    {
        private string episodeTitle;
        private int episodeId;

        public Episode(string episodeTitle, int episodeId)
        {
            this.episodeTitle = episodeTitle;
            this.episodeId = episodeId;
        }

        public string GetEpisodeTitle()
        {
            return episodeTitle;
        }

        public int GetEpisodeId()
        {
            return episodeId;
        }
    }
}
