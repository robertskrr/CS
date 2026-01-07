using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DownloadService
    {
        public byte[] Download(string songName)
        {
            Thread.Sleep(1000);
            return new byte[] { };
        }

        public Task<byte[]> DownloadAsync(string songName)
        {
            Thread.Sleep(1000);
            return Task.FromResult(new byte[] { });
        }
    }
}