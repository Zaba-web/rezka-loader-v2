using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class DownloadStatus
    {
        public const int NATIVE = 1;

        public const int ALTO = 2;

        public static int DownloadClient = 1;

        private Dictionary<String, List<String>> fileList = new Dictionary<String, List<String>>();

        private static DownloadStatus self;
        private DownloadStatus()
        {

        }

        public void InitFromHistory()
        {
            Dictionary<String, List<String>> history = DownloadHistory.Read();

            if (history != null)
            {
                fileList = history;
            }
        }

        public static DownloadStatus Get()
        {
            if (self == null)
            {
                self = new DownloadStatus();
            }

            return self;
        }

        public void AddFile(string fullPath, string status)
        {
            var name = GetName(fullPath);
            fileList.Add(name, new List<string> { fullPath, status });
            DownloadHistory.Save(fileList);
        }

        public Dictionary<String, List<String>> GetFiles()
        {
            return fileList;
        }

        public void UpdateStatus(String filename, String newStatus)
        {
            GetFiles()[filename][1] = newStatus;
        }

        private String GetName(String fullPath)
        {
            return fullPath.Split('\\').Last();
        }

        public void ClearHistory()
        {
            fileList = new Dictionary<String, List<String>>();
            DownloadHistory.Save(fileList);
        }
    }
}
