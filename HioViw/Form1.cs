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

                viewerPage.infos.Clear();
                FileInfo fi = new FileInfo(Global.DownloadPath + Global.DownloadDBName + Global.DBExt);
                if (fi.Exists)
                {
                    using (StreamReader sr = new StreamReader(Global.DownloadPath + Global.DownloadDBName + Global.DBExt))
                    {
                        while (!sr.EndOfStream)
                        {
                            var data = sr.ReadLine().Split((char)255);
                            Gallerie g = new Gallerie();
                            g.ID = data[0];
                            g.Type = data[1];
                            g.Language = data[2];
                            g.Series = data[3];
                            g.Title = data[4];
                            viewerPage.infos.Add(g);
                        }

                        sr.Close();
                    }
                    viewerPage.Explorer_Set(new KeyEventArgs(Keys.Enter), true);
                }
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
