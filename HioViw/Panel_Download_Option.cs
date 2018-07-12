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
    public partial class Panel_Download_Option : UserControl
    {
        public Panel_Download_Option()
        {
            InitializeComponent();
        }

        private void Btn_DownloadPath_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Lang_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Lang_Up(object sender, MouseEventArgs e)
        {
            if ((sender as Control).Focused)
                Panel_Language.Tag = (sender as Control).Text.ToLower();
        }

        private void Btn_Lang_Down(object sender, MouseEventArgs e)
        {
            
        }
    }



    public class OptionTag
    {
        public OptionTag(Panel p, int h)
        {
            Panel_Data = p;
            Height = h;
        }
        public Panel Panel_Data { get; set; }
        public int Height { get; set; }
    }

}
