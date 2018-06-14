using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                            using (WebClient wq = new WebClient())
                            {
                                wq.DownloadString(TEXT_URL.Text + "/galleries/" + ID);

                            }

                        }

                    }

                }

                    LIST_Download.Items.Add(front + i.ToString() + back);
            }

        }
    }
}
