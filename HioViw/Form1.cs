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

namespace HioViw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Download_Click(object sender, EventArgs e)
        {
            string str = TEXT_DownloadLink.Text;

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

                    string a = Regex.Split(web, "<div class=\"gallery-content\">")[1];
                    a = Regex.Split(a, "<div class=\"page-container\">")[0];

                    List<string> list = new List<string>();
                    list.Add("dj");
                    list.Add("manga");
                    list.Add("acg");

                    for (int loop = 0; loop < 3; loop++) {
                            string[] alldata = Regex.Split(a, "<div class=\"" + list[loop].ToString() + "\">");

                        for (int ww = 1; ww < alldata.Length; ww++)
                        {
                            string ID = Regex.Split(alldata[ww], "<a href=\"/galleries/")[1].Split('\"')[0];
                            string Title = Regex.Split(alldata[ww], "<h1>")[1];
                            Title = Regex.Split(Title, ">")[1];
                            Title = Regex.Split(Title, "</a")[0];
                            int page;
                            string Uploader = Regex.Split(alldata[ww], "<div class=\"artist-list\">")[1].Split('>')[3].Split('<')[0];
                            var p = Regex.Split(alldata[ww], "N/A");
                            string Series = p.Length == 0 ? "N/A" : Regex.Split(alldata[ww], "<a href=\"/series/")[1].Split('>')[1].Split('<')[0];
                            string Type = Regex.Split(alldata[ww], "<a href=\"/type/")[1].Split('-')[0];
                            string Language = Regex.Split(alldata[ww], "<a href=\"/index-")[1].Split('-')[0];
                            List<string> tagList = new List<string>();
                            using (WebClient we = new WebClient())
                            {
                                string tags = we.DownloadString("https://hitomi.la/galleries/" + ID);
                                string Tag = Regex.Split(alldata[ww], "<td>Tags</td>")[1];
                                Tag = Regex.Split(Tag, "</tr>")[0];


                                var ttt = Regex.Split(Tag, "<a href=\"/tag/");
                                foreach (string o in ttt)
                                {
                                    tagList.Add(o.Split('-')[0]);
                                }

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
                                            "C:\\Map\\" + ID.Split('.')[0] + "\\" + qww.ToString() + ".jpg");
                                    }catch(Exception)
                                    {
                                         wq.DownloadFile(new Uri("https://ba.hitomi.la/galleries/" + ID.Split('.')[0] + "/" + ext[qww - 1]),
                                           "C:\\Map\\" + ID.Split('.')[0] + "\\" + qww.ToString() + ".jpg");
                                    }
                                }
                            }
                            string[] da = { ID, Title, "" };
                            ListViewItem itema = new ListViewItem(da);

                            LIST_Download.Items.Add(itema);
                        }   

                    }

                }

                    LIST_Download.Items.Add(front + i.ToString() + back);
            }

        }
    }
}
