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

    }
    //{
    //    private void InfoFileWrite(string ID, string Title, string Uploader, string Series, string Type,
    //            string Language, List<string> tagList, List<string> characterList, string UploadDate, string Download_Path)
    //    {
    //        Console.WriteLine("URL : https://hitomi.la/galleries/" + ID);
    //        Console.WriteLine("ID : " + ID.Split('.')[0]);
    //        Console.WriteLine("Title : " + Title);
    //        Console.WriteLine("Uploader : " + Uploader);
    //        Console.WriteLine("Series : " + Series);
    //        Console.WriteLine("Type : " + Type);
    //        Console.WriteLine("Language : " + Language);
    //        Console.Write("Tags : ");
    //        for (int r = 0; r < tagList.Count; r++)
    //        {
    //            tagList[r] = tagList[r].Replace("%3A", ":");
    //            tagList[r] = tagList[r].Replace("%20", " ");
    //            Console.Write(tagList[r] + ", ");
    //        }
    //        Console.WriteLine();

    //        Console.Write("Character : ");
    //        for (int r = 0; r < characterList.Count; r++)
    //        {
    //            characterList[r] = characterList[r].Replace("%3A", ":");
    //            characterList[r] = characterList[r].Replace("%20", " ");
    //            Console.Write(characterList[r] + ", ");
    //        }




    //        StreamWriter sw = new StreamWriter(Download_Path + "\\" + ID.Split('.')[0] + "\\Info.ini", false, Encoding.UTF8);
    //        sw.WriteLine("URL : https://hitomi.la/galleries/" + ID);
    //        sw.WriteLine("ID : " + ID.Split('.')[0]);
    //        sw.WriteLine("Title : " + Title);
    //        sw.WriteLine("Group : " + Uploader);
    //        sw.WriteLine("Series : " + Series);
    //        sw.WriteLine("Type : " + Type);
    //        sw.WriteLine("Language : " + Language);
    //        sw.Write("Tags : ");
    //        foreach (string tag in tagList)
    //        {
    //            sw.Write(tag + ", ");
    //        }
    //        sw.WriteLine();

    //        sw.Write("Character : ");
    //        foreach (string character in characterList)
    //        {
    //            sw.Write(character + ", ");
    //        }
    //        sw.WriteLine();
    //        sw.Write("UploadDate : " + UploadDate);
    //        sw.Close();

    //    }

    //    private void Download()
    //    {
    //        string Download_Path = Panel_Download_Option.Text_DownloadPath.Text;


    //        if (Download_Path == "")
    //        {
    //            MessageBox.Show("Not Found Download Path");
    //            return;
    //        }
    //        if (!new DirectoryInfo(Download_Path + "\\").Exists)
    //        {
    //            MessageBox.Show("Not Found Download Path");
    //            return;
    //        }




    //        string str = "https://hitomi.la/index-" + Panel_Download_Option.ChkListBox_Language.SelectedItems[0].ToString().ToLower() +
    //            "-{" + Panel_Download_Option.Text_PageRange.Text + "}.html";
    //        string data = str.Split('{')[1].Split('}')[0];
    //        string front = str.Split('{')[0];
    //        string back = str.Split('}')[1];
    //        int Frange;
    //        int Lrange;
    //        int.TryParse(data.Split('-')[0], out Frange);
    //        int.TryParse(data.Split('-')[1], out Lrange);

    //        for (int i = Frange; i <= Lrange; i++)
    //        {
    //            using (WebClient wc = new WebClient())
    //            {
    //                wc.Encoding = Encoding.UTF8;
    //                // https://hitomi.la/index-all-i.html
    //                string web = wc.DownloadString(front + i.ToString() + back);
    //                Console.WriteLine(front + i.ToString() + back + ": 다운로드");

    //                string a = Regex.Split(web, "<div class=\"gallery-content\">")[1];
    //                a = Regex.Split(a, "<div class=\"page-container\">")[0];

    //                List<string> list = new List<string>();
    //                list.Add("dj");
    //                list.Add("manga");
    //                list.Add("acg");
    //                list.Add("cg");

    //                for (int loop = -1; loop < list.Count; loop++)
    //                {
    //                    var type = Panel_Download_Option.ChkListBox_Type.CheckedItems[0].ToString().ToLower();

    //                    if (type == "doujinshi")
    //                    {
    //                        if (loop == 0)
    //                        {
    //                            break;
    //                        }
    //                        loop = 0;
    //                    }
    //                    else if (type == "manga")
    //                    {
    //                        if (loop == 1)
    //                        {
    //                            break;
    //                        }
    //                        loop = 1;
    //                    }
    //                    else if (type == "artist cg")
    //                    {
    //                        if (loop == 2)
    //                        {
    //                            break;
    //                        }
    //                        loop = 2;
    //                    }
    //                    else if (type == "game cg")
    //                    {
    //                        if (loop == 3)
    //                        {
    //                            break;
    //                        }
    //                        loop = 3;
    //                    }
    //                    else
    //                    {
    //                        if (loop == -1)
    //                        {
    //                            loop = 0;
    //                        }
    //                    }


    //                    string[] alldata = Regex.Split(a, "<div class=\"" + list[loop].ToString() + "\">");
    //                    Console.WriteLine(list[loop] + ": 시작함");

    //                    for (int ww = 1; ww < alldata.Length; ww++)
    //                    {
    //                        try
    //                        {
    //                            Console.WriteLine(ww.ToString() + ": 번쨰 동인지 다운로드");

    //                            string ID = Regex.Split(alldata[ww], "<a href=\"/galleries/")[1].Split('\"')[0];
    //                            string Title = Regex.Split(alldata[ww], "<h1>")[1];
    //                            Title = Regex.Split(Title, ">")[1];
    //                            Title = Regex.Split(Title, "</a")[0];
    //                            int page;
    //                            string Uploader = Regex.Split(alldata[ww], "<div class=\"artist-list\">")[1];
    //                            Uploader = Uploader.Split('<')[0].Split('\n')[0];
    //                            Uploader = Uploader == "N/A" ? "N/A" :
    //                                Regex.Split(alldata[ww], "<div class=\"artist-list\">")[1].Split('>')[3].Split('<')[0];

    //                            string UploadDate = Regex.Split(alldata[ww], "<p class=\"" + list[loop] + "-date date\">")[1];
    //                            UploadDate = UploadDate.Split('<')[0];

    //                            string Series;
    //                            try
    //                            {
    //                                Series = Regex.Split(alldata[ww], "<a href=\"/series/")[1].Split('>')[1].Split('<')[0];
    //                            }
    //                            catch (Exception)
    //                            {
    //                                Series = "N/A";
    //                            }

    //                            string Type = Regex.Split(alldata[ww], "<a href=\"/type/")[1].Split('-')[0];

    //                            string Language;
    //                            try
    //                            {
    //                                Language = Regex.Split(alldata[ww], "<a href=\"/index-")[1].Split('-')[0];

    //                            }
    //                            catch (Exception)
    //                            {
    //                                Language = "N/A";
    //                            }
    //                            List<string> tagList = new List<string>();
    //                            List<string> characterList = new List<string>();
    //                            using (WebClient we = new WebClient())
    //                            {
    //                                string tags = we.DownloadString("https://hitomi.la/galleries/" + ID);
    //                                string Tag = Regex.Split(tags, "<td>Tags</td>")[1];
    //                                Tag = Regex.Split(Tag, "</tr>")[0];

    //                                string chara = Regex.Split(tags, "<td>Characters</td>")[1];
    //                                chara = Regex.Split(chara, "</tr>")[0];
    //                                var ttt1 = Regex.Split(chara, "<a href=\"/character/");
    //                                for (int l3 = 1; l3 < ttt1.Length; l3++)
    //                                {
    //                                    characterList.Add(ttt1[l3].Split('>')[1].Split('<')[0].TrimEnd('\n'));
    //                                }

    //                                var ttt2 = Regex.Split(Tag, "<a href=\"/tag/");
    //                                for (int l3 = 1; l3 < ttt2.Length; l3++)
    //                                {
    //                                    tagList.Add(ttt2[l3].Split('-')[0]);
    //                                }

    //                            }
    //                            for (int r = 0; r < tagList.Count; r++)
    //                            {
    //                                tagList[r] = tagList[r].Replace("%3A", ":");
    //                                tagList[r] = tagList[r].Replace("%20", " ");
    //                                Console.Write(tagList[r] + ", ");
    //                            }
    //                            for (int r = 0; r < characterList.Count; r++)
    //                            {
    //                                characterList[r] = characterList[r].Replace("%3A", ":");
    //                                characterList[r] = characterList[r].Replace("%20", " ");
    //                                Console.Write(characterList[r] + ", ");
    //                            }

    //                            if (tagList.Count == 0)
    //                            {
    //                                tagList.Add("N/A");
    //                            }
    //                            if (characterList.Count == 0)
    //                            {
    //                                characterList.Add("N/A");
    //                            }

    //                            DirectoryInfo di = new DirectoryInfo(Download_Path + "\\" + ID.Split('.')[0]);
    //                            if (!di.Exists)
    //                            {
    //                                di.Create();
    //                            }
    //                            InfoFileWrite(ID, Title, Uploader, Series, Type, Language, tagList, characterList, UploadDate, Download_Path);


    //                            List<string> ext = new List<string>();
    //                            using (WebClient wq = new WebClient())
    //                            {
    //                                string getpage = wq.DownloadString("https://hitomi.la/reader/" + ID + "#1");
    //                                var pagel = Regex.Split(getpage, "//g.hitomi.la/galleries/" + ID.Split('.')[0] + "/");
    //                                for (int l2 = 1; l2 < pagel.Length; l2++)
    //                                {
    //                                    ext.Add(pagel[l2].Split('<')[0]);
    //                                }
    //                                page = pagel.Length - 1;
    //                                Console.WriteLine(page.ToString() + "갯수 사진 발견");
    //                            }


    //                            var graphic = Panel_DownloadBar.CreateGraphics();
    //                            graphic.DrawLine(new Pen(BackColor, 18), 1, 10, Panel_DownloadBar.Size.Width - 1, 10);

    //                            using (WebClient wq = new WebClient())
    //                            {
    //                                for (int qww = 1; qww <= page; qww++)
    //                                {
    //                                    try
    //                                    {
    //                                        wq.DownloadFile(new Uri("https://aa.hitomi.la/galleries/" + ID.Split('.')[0] + "/" + ext[qww - 1]),
    //                                            Download_Path + "\\" + ID.Split('.')[0] + "\\" + qww.ToString() + ".jpg");
    //                                        Console.WriteLine(qww.ToString() + "번째 다운로드 완료");
    //                                    }
    //                                    catch (Exception)
    //                                    {
    //                                        try
    //                                        {
    //                                            wq.DownloadFile(new Uri("https://ba.hitomi.la/galleries/" + ID.Split('.')[0] + "/" + ext[qww - 1]),
    //                                              Download_Path + "\\" + ID.Split('.')[0] + "\\" + qww.ToString() + ".jpg");
    //                                            Console.WriteLine(qww.ToString() + "번째 다운로드 완료");
    //                                        }
    //                                        catch (Exception)
    //                                        {
    //                                            Console.WriteLine(ID.ToString() + "아이디 동인지 다운로드 실..패!");
    //                                        }
    //                                    }

    //                                    if (qww == 1)
    //                                    {
    //                                        Preview_Add(Download_Path + "\\" + ID.Split('.')[0] + "\\1.jpg", ID, Title, Uploader, Series,
    //                                            Type, Language, tagList, characterList, UploadDate);
    //                                    }


    //                                    graphic.DrawLine(new Pen(Color.LightSkyBlue, 18), 1, 10, (Panel_DownloadBar.Size.Width - 1) * ((float)qww / (float)page), 10);
    //                                }

    //                            }

    //                            Console.WriteLine(ww.ToString() + "번째 동인지 다운로드 완료");
    //                            // LIST_Download.Items.Add(itema);
    //                        }
    //                        catch (Exception)
    //                        {

    //                        }
    //                    }

    //                }

    //            }

    //            // LIST_Download.Items.Add(front + i.ToString() + back);
    //        }
    //        Console.WriteLine("끝났습니다.");
    //    }

    //    BackgroundWorker worker = new BackgroundWorker();

}