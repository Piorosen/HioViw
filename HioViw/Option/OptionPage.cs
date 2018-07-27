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
    public partial class OptionPage : UserControl
    {
        public event Change Change;

        private void OnChange(int page)
        {
            Change?.Invoke(page);
        }

        public OptionPage()
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

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            OnChange(0);
        }

        private void Btn_Viewer_Click(object sender, EventArgs e)
        {
            OnChange(1);
        }

        bool ch = true;
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                Panel_Option.Size = new Size(0, Panel_Option.Size.Height);

                Panel_Setting.Size = new Size(Panel_Setting.Width + 150, Panel_Setting.Height);
                Panel_Setting.Location = new Point(Panel_Setting.Location.X - 150, Panel_Setting.Location.Y);
                ch = !ch;
            }
            else
            {
                Panel_Option.Size = new Size(150, Panel_Option.Size.Height);

                Panel_Setting.Size = new Size(Panel_Setting.Width - 150, Panel_Setting.Height);
                Panel_Setting.Location = new Point(Panel_Setting.Location.X + 150, Panel_Setting.Location.Y);
                ch = !ch;
            }
        }

        private void Panel_Setting_Resize(object sender, EventArgs e)
        {
            Panel_Update.Size = Panel_Setting.Size;
            Panel_Update.Location = new Point(Panel_Setting.Location.X - 153, 0);
        }
    }
}
