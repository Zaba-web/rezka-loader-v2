using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    public class VersionData
    {
        public string version { get; set; }
        public int version_sign { get; set; }
        public string new_in_release { get; set; }
        public string update_url { get; set; }
    }
}
