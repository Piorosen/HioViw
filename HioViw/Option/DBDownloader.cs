﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    public static class DBDownloader
    {

        private static bool Tag = false;
        private static bool Seires = false;
        private static bool Character = false;
        private static bool Artist = false;

 
        /// <summary>
        /// Tags Series Character 를 다운로드 합니다.
        /// </summary>
        /// <param name="info">tags, series, characters 중 입력을 하셔야 합니다.</param>
        public static void InfoDownload(string info)
        {
            MessageBox.Show(info + " 다운로드 시작");
            DirectoryInfo fi = new DirectoryInfo(Global.DBPath);
            if (!fi.Exists)
            {
                fi.Create();
            }


            int iSize = 'z' - 'a' + 2;
            
            string DownloadLink = "https://hitomi.la/all" + info + "-";

            WebClient wc = new WebClient();
            string data = wc.DownloadString(DownloadLink + "123.html");

            data = Regex.Split(data, "<ul class=\"posts\">")[1];
            data = Regex.Split(data, "<div class=\"page-content\">")[0];
            string[] list = Regex.Split(data, "<li><a href=");

            StreamWriter sw;
            
            Panel panel;
            if (info == "tags")
            {
                if (Tag == true)
                {
                    return;
                }
                Tag = true;
                sw = new StreamWriter(Global.DBPath + Global.DBTags + Global.DBExt, false, Encoding.UTF8);
                panel = Global.Panel_Tag;
                {

                    for (int i = 1; i < list.Length; i++)
                    {
                        sw.WriteLine(list[i].Split('>')[1].Split('<')[0]);
                    }
                    panel.Tag = 1 / iSize;

                    for (int i = 'a'; i <= 'z'; i++)
                    {
                        data = wc.DownloadString(DownloadLink + (char)i + ".html");

                        data = Regex.Split(data, "<div class=\"content\">")[1];
                        data = Regex.Split(data, "<div class=\"page-content\">")[0];
                        string[] file = Regex.Split(data, "<li><a href=");

                        for (int w = 1; w < file.Length; w++)
                        {
                            sw.WriteLine(file[w].Split('>')[1].Split('<')[0]);
                        }
                        panel?.Invoke(new MethodInvoker(() =>
                        {
                            panel.Tag = (i - 'a' + 2) / (float)iSize;
                            panel.Refresh();
                        }));

                        Console.WriteLine((char)i);
                    }
                    sw.Close();
                }

                StreamReader sr = new StreamReader(Global.DBPath + Global.DBTags + Global.DBExt, Encoding.UTF8);
                Global.Tags.Clear();
                while (!sr.EndOfStream)
                {
                    Global.Tags.Add(sr.ReadLine());
                }
                sr.Close();

                Tag = false;
            }
            else if (info == "series")
            {
                if (Seires == true)
                {
                    return;
                }
                Seires = true;
                sw = new StreamWriter(Global.DBPath + Global.DBSeries + Global.DBExt, false, Encoding.UTF8);
                panel = Global.Panel_Series;
                {
                    for (int i = 1; i < list.Length; i++)
                    {
                        sw.WriteLine(list[i].Split('>')[1].Split('<')[0]);
                    }
                    panel.Tag = 1 / iSize;

                    for (int i = 'a'; i <= 'z'; i++)
                    {
                        data = wc.DownloadString(DownloadLink + (char)i + ".html");

                        data = Regex.Split(data, "<div class=\"content\">")[1];
                        data = Regex.Split(data, "<div class=\"page-content\">")[0];
                        string[] file = Regex.Split(data, "<li><a href=");

                        for (int w = 1; w < file.Length; w++)
                        {
                            sw.WriteLine(file[w].Split('>')[1].Split('<')[0]);
                        }
                        panel?.Invoke(new MethodInvoker(() =>
                        {
                            panel.Tag = (i - 'a' + 2) / (float)iSize;
                            panel.Refresh();
                        }));

                        Console.WriteLine((char)i);
                    }
                    sw.Close();

                }
                StreamReader sr = new StreamReader(Global.DBPath + Global.DBSeries + Global.DBExt, Encoding.UTF8);
                Global.Series.Clear();
                while (!sr.EndOfStream)
                {
                    Global.Series.Add(sr.ReadLine());
                }
                sr.Close();
                Seires = false;


            }
            else if (info == "characters")
            {
                if (Character == true)
                {
                    return;
                }
                Character = true;
                sw = new StreamWriter(Global.DBPath + Global.DBCharcter + Global.DBExt, false, Encoding.UTF8);
                panel = Global.Panel_Character;
                {
                    for (int i = 1; i < list.Length; i++)
                    {
                        sw.WriteLine(list[i].Split('>')[1].Split('<')[0]);
                    }
                    panel.Tag = 1 / iSize;

                    for (int i = 'a'; i <= 'z'; i++)
                    {
                        data = wc.DownloadString(DownloadLink + (char)i + ".html");

                        data = Regex.Split(data, "<div class=\"content\">")[1];
                        data = Regex.Split(data, "<div class=\"page-content\">")[0];
                        string[] file = Regex.Split(data, "<li><a href=");

                        for (int w = 1; w < file.Length; w++)
                        {
                            sw.WriteLine(file[w].Split('>')[1].Split('<')[0]);
                        }
                        panel?.Invoke(new MethodInvoker(() =>
                        {
                            panel.Tag = (i - 'a' + 2) / (float)iSize;
                            panel.Refresh();
                        }));

                        Console.WriteLine((char)i);
                    }
                    sw.Close();
                }
                StreamReader sr = new StreamReader(Global.DBPath + Global.DBCharcter + Global.DBExt, Encoding.UTF8);
                Global.Character.Clear();
                while (!sr.EndOfStream)
                {
                    Global.Character.Add(sr.ReadLine());
                }
                sr.Close();
                Character = false;
            }
            else
            {
                if (Artist == true)
                {
                    return;
                }
                Artist = true;
                sw = new StreamWriter(Global.DBPath + Global.DBArtist + Global.DBExt, false, Encoding.UTF8);
                panel = Global.Panel_Artist;
                {
                    for (int i = 1; i < list.Length; i++)
                    {
                        sw.WriteLine(list[i].Split('>')[1].Split('<')[0]);
                    }
                    panel.Tag = 1 / iSize;

                    for (int i = 'a'; i <= 'z'; i++)
                    {
                        data = wc.DownloadString(DownloadLink + (char)i + ".html");

                        data = Regex.Split(data, "<div class=\"content\">")[1];
                        data = Regex.Split(data, "<div class=\"page-content\">")[0];
                        string[] file = Regex.Split(data, "<li><a href=");

                        for (int w = 1; w < file.Length; w++)
                        {
                            sw.WriteLine(file[w].Split('>')[1].Split('<')[0]);
                        }
                        panel?.Invoke(new MethodInvoker(() =>
                        {
                            panel.Tag = (i - 'a' + 2) / (float)iSize;
                            panel.Refresh();
                        }));

                        Console.WriteLine((char)i);
                    }
                    sw.Close();
                }
                StreamReader sr = new StreamReader(Global.DBPath + Global.DBArtist + Global.DBExt, Encoding.UTF8);
                Global.Artist.Clear();
                while (!sr.EndOfStream)
                {
                    Global.Artist.Add(sr.ReadLine());
                }
                sr.Close();
                Artist = false;
            }
            MessageBox.Show(info + " 다운로드 완료");
        }

        private static bool DBRun = false;
        public static void DBDownload()
        {
            if (DBRun)
            {
                return;
            }
            DBRun = true;

            MessageBox.Show("DB파일을 다운로드 중입니다.");
            DirectoryInfo fi = new DirectoryInfo(Global.DBPath);
            if (!fi.Exists)
            {
                fi.Create();
            }

            Thread th = new Thread(new ThreadStart(() =>
            {

                WebClient wc = new WebClient
                {
                    Encoding = Encoding.UTF8
                };

                try
                {
                    for (int i = 0; i < 30; i++)
                    {
                        if (Global.ProgramExit)
                        {
                            return;
                        }
                        string DB = wc.DownloadString("https://ltn.hitomi.la/galleries" + i + ".json");

                        StreamWriter sw = new StreamWriter(Global.DBPath + Global.DBName + i + Global.DBExt);
                        sw.Write(DB);
                        sw.Close();

                        Global.Panel_DB?.Invoke(new MethodInvoker(() =>
                        {
                            Global.Panel_DB.Tag = (i + 1) / 19.0f;
                            Global.Panel_DB.Refresh();
                        }));
                        
                    }
                }
                catch (Exception)
                {
                    DBRun = false;
                }
                wc.Dispose();
                MessageBox.Show("DB파일을 전부다 다운로드 하였습니다.");
                
            }));
            th.Start();
        }


    }
}
