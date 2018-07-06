using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HashtagManager
{
    public static class DataLoader
    {
        public static FileInfo[] LoadFilesFromDirectory(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            return info.GetFiles("*.txt");
        }

        public static List<string> LoadTagsFromFile(string fileName)
        {
            List<string> HashTags = new List<string>();
            StreamReader reader = new StreamReader(fileName);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                HashTags.Add(line);
            }

            return HashTags;
        }
    }
}
