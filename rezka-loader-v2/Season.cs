using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class Season
    {
        private String seasonTitle;
        private int seasionId;

        public Season(String seasonTitle, int seasionId)
        {
            this.seasonTitle = seasonTitle;
            this.seasionId = seasionId;
        }

        public String GetSeasonTitle()
        {
            return seasonTitle;
        }

        public int GetSeasonId()
        {
            return seasionId;
        }
    }
}
