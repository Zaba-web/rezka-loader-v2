using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class DownloadHistory
    {
        private const String FILE_NAME = "\\history.json";

        public static void Save(Dictionary<String, List<String>> fileList)
        {
            try
            {
                String json = JsonConvert.SerializeObject(fileList);

                string path = (Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + FILE_NAME).Replace("file:\\", "");

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                File.WriteAllText(path, json);
            } catch
            {
                return;
            }
        }

        public static Dictionary<String, List<String>> Read()
        {
            string path = (Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + FILE_NAME).Replace("file:\\", "");

            if (File.Exists(path))
            {
                String json = File.ReadAllText(path);
                var history = JsonConvert.DeserializeObject<Dictionary<String, List<String>>>(json);

                foreach (var file in history)
                {
                    file.Value[1] = "History";
                }

                return history;
            }

            return null;
        }
    }
}
