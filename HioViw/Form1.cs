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
       
        //
        // 0 : downloadPage
        // 1 : viewPage
        // 2 : optionPage
        //
        //
        private void Page_Change(int page)
        {
            if (page == 0)
            {
                downloadPage.Visible = true;
                viewerPage.Visible = false;
                optionPage.Visible = false; 
            }
            else if (page == 1)
            {
                downloadPage.Visible = false;
                viewerPage.Visible = true;
                optionPage.Visible = false;
            }
            else
            {
                downloadPage.Visible = false;
                viewerPage.Visible = false;
                optionPage.Visible = true;
            }
        }


    }


}
