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
            return info.GetFiles();
        }
    }
}
