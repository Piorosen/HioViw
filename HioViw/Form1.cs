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
using System.Runtime.Serialization.Formatters.Binary;

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

        private void Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            BinaryFormatter binFmt = new BinaryFormatter();
            using (FileStream fs = new FileStream(Global.ReDownloadPath, FileMode.Create))
            {
                binFmt.Serialize(fs, Global.HioDownGalleries);
            }
            Global.ProgramExit = true;
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
                            Gallerie g = new Gallerie
                            {
                                ID = data[0],
                                Type = data[1],
                                Language = data[2],
                                Series = data[3],
                                Title = data[4]
                            };
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
