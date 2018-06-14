using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Download_Click(object sender, EventArgs e)
        {
            string str = TEXT_DownloadLink.Text;

            string data = str.Split('{')[1].Split('}')[0];

            string front = str.Split('{')[0];
            string back = str.Split('}')[1];

            ㅁㄴㄹㅇㅁㄴㅇ


            int Frange;
            int Lrange;


            int.TryParse(data.Split('-')[0], out Frange);
            int.TryParse(data.Split('-')[1], out Lrange);

            for (int i = Frange; i <= Lrange; i++)
            {
                LIST_Download.Items.Add(front + i.ToString() + back);
            }

        }
    }
}
