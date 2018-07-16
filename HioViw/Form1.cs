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


            SearchEngine engine = new SearchEngine();
            engine.Find += Engine_Find;
            SearchData sd = new SearchData();

            sd.Title = string.Empty;
            sd.Tags = new List<string>();
            sd.Type = new List<string>();
            sd.Series = new List<string>();
            sd.Language = new List<string>();
            sd.Language.Add("korean".ToLower());

            sd.Character = new List<string>();
            sd.Character.Add("asuna yuuki".ToLower());
            sd.Character.Add("kazuto kirigaya".ToLower());

            engine.Find_Start(sd);
        }

        private void Engine_Find(object sender, Gallerie e)
        {
            StreamWriter sw = new StreamWriter("C:\\Map\\result.txt", true);
            sw.WriteLine(e.ID + " " + e.Title);
            sw.Close();
        }
    }


}
