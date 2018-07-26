using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Text.RegularExpressions;

namespace HioViw
{
    public partial class DownloadLog : UserControl
    {
        public Gallerie gallerie = null;
        public float Percentage {
            get
            {
                return percent;
            }
            set
            {
                percent = value;
                DrawPercent();
            }
        }
        private float percent = 0;

        public void DrawPercent()
        {
            using (var graphic = Panel_Download.CreateGraphics())
            {
                graphic.DrawLine(new Pen(Color.Aqua, Panel_Download.Height), 0, Panel_Download.Height / 2, Panel_Download.Width * percent, Panel_Download.Height / 2);
            }
        }

        public DownloadLog()
        {
            InitializeComponent();
            Panel_Download.Paint += Panel_Download_Paint;
        }

        private void Panel_Download_Paint(object sender, PaintEventArgs e)
        {
            DrawPercent();
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

        private Thread th;
        private static List<string> DownloadedID = new List<string>();

        public void GetThumbnail(Gallerie g)
        {
            gallerie = g;
            FileInfo fi = new FileInfo("Download\\Thumbnail\\" + g.ID + ".jpg");
            if (fi.Exists)
            {
                Pic_Image.Image = Image.FromFile(fi.FullName);
                return;
            }

            if (DownloadedID.IndexOf(g.ID) == -1)
            {
                DownloadedID.Add(g.ID);
                th = new Thread(new ThreadStart(() =>
                {
                    using (WebClient wc = new WebClient())
                    {
                        string ID = gallerie.ID;
                        string Images = gallerie.ThumnailImage;
                        string str = wc.DownloadString(Images);
                        string name = Regex.Split(str, "//tn.hitomi.la/bigtn/")[1].Split('\"')[0];



                        try
                        {
                            wc.DownloadFile("https://tn.hitomi.la/bigtn/" + name, "Download\\Thumbnail\\" + ID + ".jpg");
                            if (gallerie.ID == ID)
                            {
                                Pic_Image?.Invoke(new MethodInvoker(() =>
                                {
                                    Pic_Image.Image = Image.FromFile(fi.FullName);
                                }));
                            }
                        }
                        catch (Exception e1)
                        {
                            if (e1.HResult != -2147467261)
                            {
                                MessageBox.Show(e1.ToString());
                            }
                        }

                    }
                    DownloadedID.Remove(g.ID);
                }));

            }

            th.Start();
        }


        public void Clear()
        {
            gallerie = null;
            Percentage = 0;
            Label_ID.Text = "ID : ";
            Label_Title.Text = "Title : ";
            Label_Language.Text = "Language : ";
            Label_Type.Text = "Type : ";
            Label_Series.Text = "Series : ";
            Pic_Image.Image = null;
        }

    }
}
