﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    class HioDownloader
    {
        Gallerie g;
        public HioDownloader(Gallerie gallerie)
        {
            g = gallerie;

        }

        public void Download(string Download_Path = "Download\\")
        {

            DirectoryInfo di = new DirectoryInfo(Download_Path + g.ID + "\\");
            if (!di.Exists)
            {
                di.Create();
            }

            int page = 0;

            List<string> ext = new List<string>();
            using (WebClient wc = new WebClient())
            {
                string getpage = wc.DownloadString("https://hitomi.la/reader/" + g.ID + ".html#1");
                var pagel = Regex.Split(getpage, "//g.hitomi.la/galleries/" + g.ID + "/");
                for (int i = 1; i < pagel.Length; i++)
                {
                    ext.Add(pagel[i].Split('<')[0]);
                }
                page = ext.Count;
                Console.WriteLine(page.ToString() + " 갯수 사진 발견");
            }

            InfoFileWrite(g, page, Download_Path);

            using (WebClient wc = new WebClient())
            {
                for (int i = 0; i < page; i++)
                {
                    try
                    {
                        wc.DownloadFile(new Uri("https://aa.hitomi.la/galleries/" + g.ID + "/" + ext[i]),
                            Download_Path + "\\" + g.ID + "\\" + (i+1).ToString() + ".jpg");
                        Console.WriteLine(i.ToString() + "번째 다운로드 완료");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            wc.DownloadFile(new Uri("https://ba.hitomi.la/galleries/" + g.ID + "/" + ext[i]),
                              Download_Path + "\\" + g.ID + "\\" + (i+1).ToString() + ".jpg");
                            Console.WriteLine(i.ToString() + "번째 다운로드 완료");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(g.ID.ToString() + "아이디 동인지 다운로드 실..패!");
                        }
                    }
                }
            }
        }

        


        private void InfoFileWrite(Gallerie g, int page, string Download_Path)
        {
            StreamWriter sw = new StreamWriter(Download_Path + "\\" + g.ID + "\\Info.ini", false, Encoding.UTF8);
            sw.WriteLine("URL : https://hitomi.la/galleries/" + g.ID);
            sw.WriteLine("ID : " + g.ID);
            sw.WriteLine("Title : " + g.Title);
            sw.WriteLine("Group : " + g.Uploader);
            sw.WriteLine("Series : " + g.Series);
            sw.WriteLine("Type : " + g.Type);
            sw.WriteLine("Language : " + g.Language);
            sw.WriteLine("Page : " + page);

            sw.Write("Tags : ");
            for (int i = 0; i < g.Tags.Count; i++)
            {
                if (i == g.Tags.Count - 1)
                    sw.Write(g.Tags[i]);
                else
                    sw.Write(g.Tags[i] + ", ");
            }
            sw.WriteLine();


            sw.Write("Character : ");
            for (int i = 0; i < g.Character.Count; i++)
            {
                if (i == g.Character.Count - 1)
                    sw.Write(g.Character[i]);
                else
                    sw.Write(g.Character[i] + ", ");
            }
            sw.WriteLine();
            
            sw.Close();
        }
    }
}
    //{
    

