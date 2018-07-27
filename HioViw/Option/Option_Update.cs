using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace HioViw.Option
{
    public partial class Option_Update : UserControl
    {
        public Option_Update()
        {
            InitializeComponent();
        }

        

        private void Btn_DBUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DB를 다운로드 시작합니다.");
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.DBDownload();
            }));
            th.Start();
            
        }
        private void Btn_TagsUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("태그 목록을 다운로드 시작합니다.");
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.InfoDownload("tags");
            }));
            th.Start();
        }

        private void Btn_CharacterUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("캐릭터 목록을 다운로드 시작합니다.");
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.InfoDownload("characters");
            }));
            th.Start();
        }

        private void Btn_SeriesUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("시리즈 목록을 다운로드 시작합니다.");
            Thread th = new Thread(new ThreadStart(() =>
            {
                DBDownloader.InfoDownload("series");
            }));
            th.Start();
        }
    }
}
