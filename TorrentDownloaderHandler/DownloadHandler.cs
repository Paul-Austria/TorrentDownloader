using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aria2NET;

namespace TorrentDownloaderHandler
{
    public class DownloadHandler
    {
        private static Aria2NetClient _client;

        public static void SetupClient()
        {
            _client = new Aria2NetClient("http://127.0.0.1:6800/jsonrpc");
        }
        public static async Task<string> DownloadTorrentAsync(string path, string url)
        {
            var result = await _client.AddUri(new List<string>
                {
                    url
                },
                new Dictionary<string, object>
                {
                    {"dir", path}
                });
            return result;
        }
        public static async Task<string> GetStatus(string id)
        {
            var status = _client.TellStatus(id);
            return status.Result.Status;
        }
    }
}
