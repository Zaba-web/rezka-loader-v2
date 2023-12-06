using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class MoviePageData
    {
        private ArrayList translations;
        private ArrayList seasons;
        private ArrayList episodes;
        private int movieId;

        public MoviePageData(ArrayList translations, ArrayList seasons, ArrayList episodes, int movieId)
        {
            this.translations = translations;
            this.seasons = seasons;
            this.episodes = episodes;
            this.movieId = movieId;
        }

        public ArrayList Translations
        {
            get { return translations; }
            set {  }
        }

        public ArrayList Seasons
        {
            get { return seasons; }
            set { }
        }

        public ArrayList Episodes
        {
            get { return episodes; }
            set { }
        }

        public int MovieId
        {
            get { return movieId;  }
            set { }
        }
    }
}
