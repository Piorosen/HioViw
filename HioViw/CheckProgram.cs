using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HioViw
{
    class CheckProgram
    {
        
        
        public bool CheckVersion()
        {
            WebClient wc = new WebClient();
            string str = wc.DownloadString("https://drive.google.com/uc?authuser=0&id=133eR7CUUhL9FkPLKpWrNSCeCi15BJLSt&export=download");

            if (str == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
            



        }

    }
}
