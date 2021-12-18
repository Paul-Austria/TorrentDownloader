using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aria2NET;
using Aria2NET.Apis;
namespace TorrentDownloaderHandler
{
    public class FileStructureHandler
    {
        public static List<string> GetSubPaths(string path)
        {
            return Directory.GetDirectories(path).ToList();
        }

        public static List<string> AddNewFolder(string path, string folderName)
        {
            Directory.CreateDirectory(path +"/" + folderName);
            return GetSubPaths(path);
        }

        public static List<string> GetFiles(string path)
        {
            return Directory.GetFiles(path).ToList();
        }
    }
}
