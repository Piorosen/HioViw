using System;
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
        public event Download Downloads;
        
        private void OnDownload(Gallerie e, float f)
        {
            Downloads?.Invoke(this, e, f);
        }

        Gallerie g;
        public HioDownloader(Gallerie gallerie)
        {
            g = gallerie;
        }

        public void Download(string Download_Path = "Download\\", int StartPage = 0)
        {
            DirectoryInfo di = new DirectoryInfo(Download_Path);
       
            if (!di.Exists)
            {
                di.Create();
            }
            di = new DirectoryInfo(Download_Path + g.ID + "\\");
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
            }

            InfoFileWrite(g, page, Download_Path);
            Global.HioDownGalleries.Add(g, 0, page);

            using (WebClient wc = new WebClient())
            {
                for (int i = StartPage; i < page; i++)
                {
                    if (Global.ProgramExit == true)
                    {
                        return;
                    }

                    if (!Global.HioDownGalleries.IsData(g.ID))
                    {
                        OnDownload(g, -5.0f);
                        return;
                    }

                    try
                    {
                        wc.DownloadFile(new Uri("https://aa.hitomi.la/galleries/" + g.ID + "/" + ext[i]),
                            Download_Path + "\\" + g.ID + "\\" + (i+1).ToString() + ".jpg");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            wc.DownloadFile(new Uri("https://ba.hitomi.la/galleries/" + g.ID + "/" + ext[i]),
                              Download_Path + "\\" + g.ID + "\\" + (i+1).ToString() + ".jpg");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(g.ID.ToString() + "아이디 동인지 다운로드 실..패!");
                        }
                    }
                    Global.HioDownGalleries.Add(g, (i + 1), page);
                    OnDownload(g, (float)(i + 1) / page);
                }
                Global.HioDownGalleries.Remove(g.ID);
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
