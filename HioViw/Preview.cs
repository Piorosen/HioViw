using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace HioViw
{
    public partial class Preview : UserControl
    {
        public Preview()
        {
            InitializeComponent();
        }
        private Gallerie gallerie = null;
        private Thread th;
        public void GetThumbnail(Gallerie g)
        {
            gallerie = g;
            
            
            th = new Thread(new ThreadStart(() =>
            {
                FileInfo fi = new FileInfo("Download\\Thumbnail\\" + g.ID + ".jpg");
                if (fi.Exists)
                {
                    Pic_Image.Image = Image.FromFile(fi.FullName);
                }
                else 
                {
                    using (WebClient wc = new WebClient())
                    {
                        string str = wc.DownloadString(g.ThumnailImage);
                        string name = Regex.Split(str, "//tn.hitomi.la/bigtn/")[1].Split('\"')[0];
                        wc.DownloadFile("https://tn.hitomi.la/bigtn/" + name, "Download\\Thumbnail\\" + g.ID + ".jpg");
                        Pic_Image.Image = Image.FromFile(fi.FullName);
                    }
                }

            }));
            th.Start();
        }

        public void Clear()
        {
            gallerie = null;
            Label_Character.Text = "Character : ";
            Label_ID.Text = "ID : ";
            Label_Title.Text = "Title : ";
            Label_Series.Text = "Series : ";
            Label_Type.Text = "Type : ";
            Label_Language.Text = "Language : ";
            Label_Tags.Text = "Tags : ";
            Label_Group.Text = "Group : ";
            Label_Date.Text = "Uploaded Date : ";
            Pic_Image.Image = null;
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control)
            {
                var panel = (sender as Control);
                var graphic = panel.CreateGraphics();
                graphic.Clear(this.BackColor);
                Rectangle r = new Rectangle(0, 0, panel.Size.Width, panel.Size.Height);
                graphic.DrawRectangle(new Pen(Color.FromArgb(120, 120, 120), 2), r);
            }
        }

        private void This_DoubleClick(object sender, EventArgs e)
        {
            if (gallerie == null)
            {
                return;
            }
            Thread th = new Thread(new ThreadStart(() =>
            {
                new HioDownloader(gallerie).Download();
            }));

            th.Start();
        }
    }
}
