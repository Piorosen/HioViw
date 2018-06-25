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
