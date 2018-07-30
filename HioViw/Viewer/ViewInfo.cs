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
    public delegate void ViewEvent(object sender, Gallerie e);
    public partial class ViewInfo : UserControl
    {
        public ViewInfo()
        {
            InitializeComponent();
        }

        public event ViewEvent ViewEvent;

        private void OnViewEvent(Gallerie e)
        {
            ViewEvent?.Invoke(this, e);
        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {

        }


        private Thread th;
        public Gallerie gallerie = null;

        public void GetThumbnail(Gallerie g)
        {
            DirectoryInfo di = new DirectoryInfo(Global.Thumbnail);
            if (!di.Exists)
            {
                di.Create();
            }

            gallerie = g;
            FileInfo fi = new FileInfo(Global.Thumbnail + g.ID + Global.ThumbnailExt);
            if (fi.Exists)
            {
                Pic_Image.Image = Image.FromFile(fi.FullName);
                return;
            }

            if (Global.DownloadedID.IndexOf(g.ID) == -1)
            {
                Global.DownloadedID.Add(g.ID);
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
                            wc.DownloadFile("https://tn.hitomi.la/bigtn/" + name, Global.Thumbnail + ID + Global.ThumbnailExt);
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
                    Global.DownloadedID.Remove(g.ID);
                }));

            }

            th.Start();
        }

        public void Clear()
        {
            gallerie = null;
            Label_Title.Text = "Title : ";
            Label_Lang.Text = "Language : ";
            Label_Type.Text = "Type : ";
            Label_Series.Text = "Series : ";

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


        private void EventDoubleClick(object sender, EventArgs e)
        {
            OnViewEvent(gallerie);
        }
    }
}
