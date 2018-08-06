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

        public Gallerie gallerie = null;
        public float Percentage
        {
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
            try
            {
                using (var graphic = Panel_Download.CreateGraphics())
                {
                    graphic.DrawLine(new Pen(Color.Aqua, Panel_Download.Height), 0, Panel_Download.Height / 2, Panel_Download.Width * percent, Panel_Download.Height / 2);
                }
            }
            catch (Exception)
            {

            }
        }

        public DownloadLog()
        {
            InitializeComponent();
            Panel_Download.Paint += Panel_Download_Paint;
        }

        public void Panel_Download_Paint(object sender, PaintEventArgs e)
        {
            DrawPercent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control)
            {
                var panel = (sender as Control);
                e.Graphics.Clear(this.BackColor);
                Rectangle r = new Rectangle(0, 0, panel.Size.Width, panel.Size.Height);
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(120, 120, 120), 2), r);
            }
        }

        private Thread th;

        public void GetThumbnail(Gallerie g)
        {
            DirectoryInfo di = new DirectoryInfo(Global.Thumbnail);
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo fi = new FileInfo(Global.Thumbnail + g.ID + Global.ThumbnailExt);
            if (fi.Exists)
            {
                Pic_Image.Image = Image.FromFile(fi.FullName);
                return;
            }

            if (Global.DownloadedID.IndexOf(g.ID) == -1)
            {
                Global.DownloadedID.Add(g.ID);
                th = new Thread(new ParameterizedThreadStart((Gall) =>
                {
                    using (WebClient wc = new WebClient())
                    {
                        Gallerie date = Gall as Gallerie;
                        string ID = date.ID;
                        string Images = date.ThumnailImage;
                        string str = wc.DownloadString(Images);
                        string name = Regex.Split(str, "//tn.hitomi.la/bigtn/")[1].Split('\"')[0];

                        try
                        {
                            wc.DownloadFile("https://tn.hitomi.la/bigtn/" + name, Global.Thumbnail + ID + Global.ThumbnailExt);
                            if (g != null && date.ID == g.ID)
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

            th.Start(g);
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

        private void Detail_Hover(object sender, EventArgs e)
        {
            if (sender == null || gallerie == null)
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

        private void Form_DoubleClick(object sender, EventArgs e)
        {
            if (gallerie != null && Global.HioDownGalleries.IsData(gallerie.ID))
            {
                if (MessageBox.Show("다운로드를 중지 하시겠습니까?", "중지?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Global.HioDownGalleries.Remove(gallerie.ID);
                }
            }
        }
    }
}
