using System;
using System.IO;
using System.Net;
using System.Text;

namespace GallerieDB_Download
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            for (int i = 0; i < 20; i++)
            {
                StreamWriter sw = new StreamWriter("C:\\Map\\text" + i + ".txt");
                sw.Write(wc.DownloadString("https://ltn.hitomi.la/galleries" + i + ".json"));
                sw.Close();
            }
            wc.Dispose();
        }
    }
}
