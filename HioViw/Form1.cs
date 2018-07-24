using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HioViw
{
    public partial class HioView_Form : Form
    {
        public HioView_Form()
        {
            InitializeComponent();
            
        }


        private void HioView_Form_Resize(object sender, System.EventArgs e)
        {
        }
        
        private void Page_Change(bool IsDownloadPage)
        {
            if (IsDownloadPage)
            {
                downloadPage.Visible = false;
                viewerPage.Visible = true;
            }
            else
            {
                downloadPage.Visible = true;
                viewerPage.Visible = false;
            }
        }


    }


}
