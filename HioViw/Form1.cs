using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HioViw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OptionPanel.Add(new OptionTag(Panel_Language, 125));
            OptionPanel.Add(new OptionTag(Panel_Type, 110));
            OptionPanel.Add(new OptionTag(Panel_PageRange, 95));
            OptionPanel.Add(new OptionTag(Panel_DownloadPath, 95));
            OptionPanel.Add(new OptionTag(Panel_Download, 30));
            OptionPanel.Add(new OptionTag(Panel_TeamName, 30));
        }
       
            
        private void Download()
        {
            //string str = TEXT_DownloadLink.Text;

            string str = "https://hitomi.la/index-" + ChkListBox_Language.CheckedItems[0].ToString().ToLower() + "-" + Text_PageRange.Text + ".html";
            string data = str.Split('{')[1].Split('}')[0];

            string front = str.Split('{')[0];
            string back = str.Split('}')[1];
            


            int Frange;
            int Lrange;


            int.TryParse(data.Split('-')[0], out Frange);
            int.TryParse(data.Split('-')[1], out Lrange);

            for (int i = Frange; i <= Lrange; i++)
            {
                using (WebClient wc = new WebClient()) 
                {
                    // https://hitomi.la/index-all-i.html
                    string web = wc.DownloadString(front + i.ToString() + back);
                    Console.WriteLine(front + i.ToString() + back + ": 다운로드");

                    string a = Regex.Split(web, "<div class=\"gallery-content\">")[1];
                    a = Regex.Split(a, "<div class=\"page-container\">")[0];

                    List<string> list = new List<string>();
                    list.Add("dj");
                    list.Add("manga");
                    list.Add("acg");

                    for (int loop = 0; loop < 3; loop++) {
                        string[] alldata = Regex.Split(a, "<div class=\"" + list[loop].ToString() + "\">");
                        Console.WriteLine(list[loop] + ": 시작함");

                        for (int ww = 1; ww < alldata.Length; ww++)
                        {
                            try
                            {
                                Console.WriteLine(ww.ToString() + ": 번쨰 동인지 다운로드");

                                string ID = Regex.Split(alldata[ww], "<a href=\"/galleries/")[1].Split('\"')[0];
                                string Title = Regex.Split(alldata[ww], "<h1>")[1];
                                Title = Regex.Split(Title, ">")[1];
                                Title = Regex.Split(Title, "</a")[0];
                                int page;
                                //string Uploader = Regex.Split(alldata[ww], "<div class=\"artist-list\">")[1].Split('<')[0] == "N/A" ? "N/A" :
                                //    Regex.Split(alldata[ww], "<div class=\"artist-list\">")[1].Split('>')[3].Split('<')[0];

                                var p = Regex.Split(alldata[ww], "N/A");

                                string Series;
                                try
                                {
                                    Series = Regex.Split(alldata[ww], "<a href=\"/series/")[1].Split('>')[1].Split('<')[0];
                                }
                                catch (Exception)
                                {
                                    Series = "N/A";
                                }

                                string Type = Regex.Split(alldata[ww], "<a href=\"/type/")[1].Split('-')[0];
                                string Language = Regex.Split(alldata[ww], "<a href=\"/index-")[1].Split('-')[0];
                                List<string> tagList = new List<string>();
                                List<string> characterList = new List<string>();

                                using (WebClient we = new WebClient())
                                {
                                    string tags = we.DownloadString("https://hitomi.la/galleries/" + ID);
                                    string Tag = Regex.Split(tags, "<td>Tags</td>")[1];
                                    Tag = Regex.Split(Tag, "</tr>")[0];

                                    string chara = Regex.Split(tags, "<td>Characters</td>")[1];
                                    chara = Regex.Split(chara, "</tr>")[0];
                                    var ttt1 = Regex.Split(chara, "<a href=\"/character/");
                                    for (int l3 = 1; l3 < ttt1.Length; l3++)
                                    {
                                        characterList.Add(ttt1[l3].Split('>')[1].Split('<')[0]);
                                    }

                                    var ttt2 = Regex.Split(Tag, "<a href=\"/tag/");
                                    for (int l3 = 1; l3 < ttt2.Length; l3++)
                                    {
                                        tagList.Add(ttt2[l3].Split('-')[0]);
                                    }

                                }

                                Console.WriteLine("URL : https://hitomi.la/galleries/" + ID);
                                Console.WriteLine("ID : " + ID.Split('.')[0]);
                                Console.WriteLine("Title : " + Title);
                                //Console.WriteLine("Uploader : " + Uploader);
                                Console.WriteLine("Series : " + Series);
                                Console.WriteLine("Type : " + Type);
                                Console.WriteLine("Language : " + Language);
                                Console.Write("Tags : ");
                                for (int r = 0; r < tagList.Count; r++)
                                {
                                    tagList[r] = tagList[r].Replace("%3A", ":");
                                    tagList[r] = tagList[r].Replace("%20", " ");
                                    Console.Write(tagList[r] + ", ");
                                }
                                Console.WriteLine();

                                Console.Write("Character : ");
                                for (int r = 0; r < characterList.Count; r++)
                                {
                                    characterList[r] = characterList[r].Replace("%3A", ":");
                                    characterList[r] = characterList[r].Replace("%20", " ");
                                    Console.Write(characterList[r] + ", ");
                                }

                                List<string> ext = new List<string>();
                                using (WebClient wq = new WebClient())
                                {
                                    string getpage = wq.DownloadString("https://hitomi.la/reader/" + ID + "#1");
                                    var pagel = Regex.Split(getpage, "//g.hitomi.la/galleries/" + ID.Split('.')[0] + "/");
                                    for (int l2 = 1; l2 < pagel.Length; l2++)
                                    {
                                        ext.Add(pagel[l2].Split('<')[0]);
                                    }
                                    page = pagel.Length - 1;
                                    Console.WriteLine(page.ToString() + "갯수 사진 발견");
                                }

                                using (WebClient wq = new WebClient())
                                {
                                    DirectoryInfo di = new DirectoryInfo("C:\\Map\\" + ID.Split('.')[0]);
                                    if (!di.Exists)
                                    {
                                        di.Create();
                                    }

                                    for (int qww = 1; qww <= page; qww++)
                                    {
                                        try
                                        {
                                            wq.DownloadFile(new Uri("https://aa.hitomi.la/galleries/" + ID.Split('.')[0] + "/" + ext[qww - 1]),
                                                Text_DownloadPath.Text + "\\" + ID.Split('.')[0] + "\\" + qww.ToString() + ".jpg");
                                            Console.WriteLine(qww.ToString() + "번째 다운로드 완료");
                                        }
                                        catch (Exception)
                                        {
                                            try
                                            {
                                                wq.DownloadFile(new Uri("https://ba.hitomi.la/galleries/" + ID.Split('.')[0] + "/" + ext[qww - 1]),
                                                  Text_DownloadPath.Text + "\\" + ID.Split('.')[0] + "\\" + qww.ToString() + ".jpg");
                                                Console.WriteLine(qww.ToString() + "번째 다운로드 완료");
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine(ID.ToString() + "아이디 동인지 다운로드 실..패!");
                                            }

                                        }
                                    }

                                }
                                string[] da = { ID, Title, "" };
                                ListViewItem itema = new ListViewItem(da);

                                StreamWriter sw = new StreamWriter("C:\\Map\\" + ID.Split('.')[0] + "\\Info.ini", false, Encoding.UTF8);
                                sw.WriteLine("URL : https://hitomi.la/galleries/" + ID);
                                sw.WriteLine("ID : " + ID.Split('.')[0]);
                                sw.WriteLine("Title : " + Title);
                                //sw.WriteLine("Uploader : " + Uploader);
                                sw.WriteLine("Series : " + Series);
                                sw.WriteLine("Type : " + Type);
                                sw.WriteLine("Language : " + Language);
                                sw.Write("Tags : ");
                                foreach (string tag in tagList)
                                {
                                    sw.Write(tag.TrimEnd('\n') + ", ");
                                }
                                sw.WriteLine();

                                sw.Write("Character : ");
                                foreach (string tag in characterList)
                                {
                                    sw.WriteLine(tag + ", ");
                                }
                                sw.WriteLine();


                                sw.Close();

                                Console.WriteLine(ww.ToString() + "번째 동인지 다운로드 완료");
                                // LIST_Download.Items.Add(itema);
                            }
                            catch (Exception)
                            {

                            }
                        }   

                    }

                }

                    // LIST_Download.Items.Add(front + i.ToString() + back);
            }

        }



        List<OptionTag> OptionPanel = new List<OptionTag>();

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel)
            {
                var panel = (sender as Panel);
                var graphic = panel.CreateGraphics();
                graphic.Clear(this.BackColor);
                Rectangle r = new Rectangle(0,0, panel.Size.Width, panel.Size.Height);
                graphic.DrawRectangle(new Pen(Color.FromArgb(120,120,120), 2), r);
            }
        }


        private void Panel_Activate(object sender, EventArgs e)
        {
            Panel data;

            if (sender is Panel)
            {
                data = (sender as Panel);
            }
            else if (sender is Control)
            {
                data = (sender as Control).Parent as Panel;
            }
            else
            {
                data = null;
            }

            if (data != null)
            {
                if (data.Size.Height != 30)
                {
                    data.Size = new Size(data.Size.Width, 30);
                }
                else
                {
                    data.Size = new Size(data.Size.Width, OptionPanel[int.Parse(data.Tag.ToString())].Height);
                }
            }

            for (int i = 0; i < OptionPanel.Count - 3; i++)
            {
                OptionPanel[i + 1].Panel_Data.Location = new Point(OptionPanel[i + 1].Panel_Data.Location.X,
                    OptionPanel[i].Panel_Data.Location.Y + OptionPanel[i].Panel_Data.Size.Height + 6);
            }

            for (int i = OptionPanel.Count -3; i < OptionPanel.Count - 1; i++)
            {
                var p = OptionPanel[OptionPanel.Count - 3].Panel_Data;
                if (p.Location.Y + p.Size.Height + 6 >= this.Size.Height - (550 - 384))
                {
                    OptionPanel[i + 1].Panel_Data.Location = new Point(OptionPanel[i + 1].Panel_Data.Location.X,
                        OptionPanel[i].Panel_Data.Location.Y + OptionPanel[i].Panel_Data.Size.Height + 6);
                }
                else
                {
                    int length = OptionPanel.Count - i + OptionPanel.Count - 4;
                    OptionPanel[length].Panel_Data.Location =
                        new Point(6, this.Size.Height - 130 - 36 * (i - (OptionPanel.Count - 3)));

                }
            }

            foreach (var panel in OptionPanel)
            {
                Panel_Paint(panel.Panel_Data, null);
            }

        }

        private void ChkListBox_Click(object sender, EventArgs e)
        {
            var list = (sender as CheckedListBox);
            int i = list.SelectedIndex;
            for (int w = 0; w < list.Items.Count; w++)
            {
                list.SetItemCheckState(w, CheckState.Unchecked);
            }
            (sender as CheckedListBox).SelectedIndex = i;
        }

        private void Btn_DownloadPath_Click(object sender, EventArgs e)
        {
            if (FolderBrowerDialog.ShowDialog() == DialogResult.OK)
            {
                Text_DownloadPath.Text = FolderBrowerDialog.SelectedPath;
            }
        }

        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            Panel_Activate(null, null);
        }
    }

    public class OptionTag
    {
        public OptionTag(Panel p, int h)
        {
            Panel_Data = p;
            Height = h;
        }
        public Panel Panel_Data { get; set; }
        public int Height { get; set; }
    }

}
