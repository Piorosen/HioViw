using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    public partial class OptionList : UserControl
    {
        public OptionList()
        {
            InitializeComponent();
            Text_DBPath.Text = Global.DBPath;
            Text_DBExt.Text = Global.DBExt;
            Text_DownPath.Text = Global.DownloadPath;
            Text_ThumbPath.Text = Global.Thumbnail;
            Text_ThumbExt.Text = Global.ThumbnailExt;

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



        private void Btn_Info_Click(object sender, EventArgs e)
        {
            Global.DBPath = Text_DBPath.Text;
            Global.DBExt = Text_DBExt.Text;
            Global.DownloadPath = Text_DownPath.Text;
            Global.Thumbnail = Text_ThumbPath.Text;
            Global.ThumbnailExt = Text_ThumbExt.Text;
            Global.SpeedLimit = Radio_Up.Checked;

            string start = Application.StartupPath + "\\config.ini";
            {
                Config.SetOption("Global", "DBExt", Global.DBExt, start);
                Config.SetOption("Global", "DBPath", Global.DBPath, start);
                Config.SetOption("Global", "DownPath", Global.DownloadPath, start);
                Config.SetOption("Global", "ThumbPath", Global.Thumbnail, start);
                Config.SetOption("Global", "ThumbExt", Global.ThumbnailExt, start);
                Config.SetOption("Global", "ThumbExt", Global.ThumbnailExt, start);
                Config.SetOption("Global", "SpeedLimit", Global.SpeedLimit ? bool.TrueString : bool.FalseString, start);

            }
            MessageBox.Show("저장이 되었습니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = Application.StartupPath + "\\config.ini";

            Global.DBExt = ".db";
            Global.DBPath = "Hitomi_DB\\";
            Global.DownloadPath = "Download\\";
            Global.Thumbnail = "Download\\Thumbnail\\";
            Global.ThumbnailExt = ".tumb";

            Text_DBPath.Text = Global.DBPath;
            Text_DBExt.Text = Global.DBExt;
            Text_DownPath.Text = Global.DownloadPath;
            Text_ThumbPath.Text = Global.Thumbnail;
            Text_ThumbExt.Text = Global.ThumbnailExt;
            Radio_Down.Checked = true;

            Config.SetOption("Global", "DBExt", Global.DBExt, start);
            Config.SetOption("Global", "DBPath", Global.DBPath, start);
            Config.SetOption("Global", "DownPath", Global.DownloadPath, start);
            Config.SetOption("Global", "ThumbPath", Global.Thumbnail, start);
            Config.SetOption("Global", "ThumbExt", Global.ThumbnailExt, start);
            Config.SetOption("Global", "SpeedLimit", bool.FalseString, start);

            MessageBox.Show("초기화 되었습니다.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
