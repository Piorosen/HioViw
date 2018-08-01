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
    public delegate void DetailHover(string data);
    public delegate void Download(object sender, Gallerie e, float Percentage);
    public delegate void DetailLeave();

    public partial class Preview : UserControl
    {
        public event DetailHover DetailHover;
        public event DetailLeave DetailLeave;

        private void OnDetailHover(string data)
        {
            DetailHover?.Invoke(data);
        }
        private void OnDetailLeave()
        {
            DetailLeave?.Invoke();
        }

        public event Download Download;

        private void OnDownload(Gallerie e, float f)
        {
            Download?.Invoke(this, e, f);
        }

        public Preview()
        {
            InitializeComponent();
        }

        public Gallerie gallerie = null;
        private Thread th;

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
            Label_Character.Text = "Character : ";
            Label_ID.Text = "ID : ";
            Label_Title.Text = "Title : ";
            Label_Series.Text = "Series : ";
            Label_Type.Text = "Type : ";
            Label_Language.Text = "Language : ";
            Label_Tags.Text = "Tags : ";
            Label_Group.Text = "Group : ";
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

        public void This_DoubleClick(object sender, EventArgs e)
        {
            if (gallerie == null)
            {
                return;
            }
            
            if (Global.CheckDownloadID.IndexOf(gallerie.ID) == -1)
            {
                Global.CheckDownloadID.Add(gallerie.ID);
                MessageBox.Show("다운로드를 시작합니다.");
                Thread th = new Thread(new ThreadStart(() =>
                {
                    OnDownload(gallerie, 0);
                    HioDownloader hio = new HioDownloader(gallerie);
                    hio.Downloads += Hio_Downloads;
                    int startPage = 0;

                    if (sender is int)
                    {
                        startPage = (int)sender != 0 ? (int)sender : 0;
                    }
                    hio.Download(Global.DownloadPath, startPage);
                    Global.CheckDownloadID.Remove(gallerie.ID);
                }));
                th.Start();
            }
            else
            {
                MessageBox.Show("이미 다운로드 중입니다.");
            }
           

            
        }

        private void Hio_Downloads(object sender, Gallerie e, float Percentage)
        {
            OnDownload(e, Percentage);
        }

        private void Detail_Hover(object sender, EventArgs e)
        {
            if (sender == null || gallerie == null || gallerie.ID == null)
            {
                return;
            }

            if (sender is Label)
            {
                DetailHover((sender as Label).Text);
            }
            else
            {
                DetailHover("pic " + gallerie.ID);
            }
            
        }

        private void Detail_Leave(object sender, EventArgs e)
        {
            OnDetailLeave();
        }
    }
}
