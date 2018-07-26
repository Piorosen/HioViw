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
    public partial class DownloadLog : UserControl
    {
        Gallerie gallerie;
        public DownloadLog()
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

        public void Clear()
        {
            gallerie = null;
            Label_ID.Text = "ID : ";
            Label_Title.Text = "Title : ";
            Label_Language.Text = "Language : ";
            Pic_Image.Image = null;
        }

    }
}
