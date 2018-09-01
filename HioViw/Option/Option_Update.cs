using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace HioViw.Option
{
    public partial class Option_Update : UserControl
    {
        public Option_Update()
        {
            InitializeComponent();
            Panel_DB.Tag = 0.0f;
            Panel_Tag.Tag = 0.0f;
            Panel_Series.Tag = 0.0f;
            Panel_Character.Tag = 0.0f;
            Global.Panel_DB = Panel_DB;
            Global.Panel_Series = Panel_Series;
            Global.Panel_Tag = Panel_Tag;
            Global.Panel_Character = Panel_Character;
            Global.Panel_Artist = Panel_Artist;
        }



        private void Btn_DBUpdate_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.DBDownload();
            }));
            th.Start();
            
        }
        private void Btn_TagsUpdate_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.InfoDownload("tags");
            }));
            th.Start();
        }

        private void Btn_CharacterUpdate_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.InfoDownload("characters");
            }));
            th.Start();
        }

        private void Btn_SeriesUpdate_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.InfoDownload("series");
            }));
            th.Start();
        }

        private void Btn_ArtistUpdate_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(() =>
             {
                 DBDownloader.InfoDownload("artists");

             }));
            th.Start();
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
                try
                {
                    if (sender is Panel)
                    {
                        graphic.DrawLine(new Pen(Color.FromArgb(100, 200, 100), panel.Size.Height / 2),
                            0, panel.Size.Height / 2.0f,
                            // TODO : 19.0f DB Count, Search Engine 에도 나중에 수정요청
                            panel.Size.Width * (float)panel.Tag,
                            panel.Size.Height / 2.0f);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

    }
}
