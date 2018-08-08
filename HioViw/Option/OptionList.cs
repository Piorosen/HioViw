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

        }
    }
}
