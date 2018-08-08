using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    class CheckProgram
    {
        
        
        public bool CheckVersion()
        {
            WebClient wc = new WebClient();
            string str = wc.DownloadString("https://drive.google.com/uc?authuser=0&id=133eR7CUUhL9FkPLKpWrNSCeCi15BJLSt&export=download");
            string Version = "1.4.7";

            if (Version == str)
            {
                return true;
            }
            else
            {
                wc.DownloadFile("https://drive.google.com/uc?authuser=0&id=1h8qjWpMOt7aS4XZuDp9dB6047BNTL8Z_&export=download", Application.StartupPath + "\\Hioviw " + str + ".exe");
                return false;
            }
        }

    }
}
