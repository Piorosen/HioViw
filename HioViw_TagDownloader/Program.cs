using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace HioViw_TagDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string data = wc.DownloadString("https://hitomi.la/alltags-123.html");

            data = Regex.Split(data, "<ul class=\"posts\">")[1];
            data = Regex.Split(data, "<div class=\"page-content\">")[0];
            string[] list = Regex.Split(data, "<li><a href=");

            StreamWriter sw = new StreamWriter("C:\\Map\\Tags.txt", false, Encoding.UTF8);
            for (int i = 1; i < list.Length; i++)
            {
                sw.WriteLine(list[i].Split('>')[1].Split('<')[0]);
            }
            
            for (int i = 'a'; i <= 'z'; i++)
            {
                data = wc.DownloadString("https://hitomi.la/alltags-" + (char)i +".html");

                data = Regex.Split(data, "<div class=\"content\">")[1];
                data = Regex.Split(data, "<div class=\"page-content\">")[0];
                string[] file = Regex.Split(data, "<li><a href=");

                for (int w = 1; w < file.Length; w++)
                {
                    sw.WriteLine(file[w].Split('>')[1].Split('<')[0]);
                }
                Console.WriteLine((char)i);
            }
           
            sw.Close();
        }
    }
}
