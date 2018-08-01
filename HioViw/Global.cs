using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
    [Serializable]
    public class DownloadGallerie
    {
        public void Add(Gallerie mID, int mDownloadPage, int mTotalPage)
        {
            int num = ID.IndexOf(mID.ID);
            if (num == -1)
            {
                if (mDownloadPage == 0)
                {
                    Galleries.Add(mID);
                    ID.Add(mID.ID);
                    DownloadPage.Add(mDownloadPage);
                    TotalPage.Add(mTotalPage);
                }
            }
            else
            {
                DownloadPage[num] = mDownloadPage;
                TotalPage[num] = mTotalPage;
            }
        }

        public void Remove(string mID)
        {
            int num = ID.IndexOf(mID);
            if (num != -1)
            {
                Galleries.RemoveAt(num);
                ID.RemoveAt(num);
                DownloadPage.RemoveAt(num);
                TotalPage.RemoveAt(num);
            }
        }

        public bool IsData(string mID)
        {
            return ID.IndexOf(mID) == -1 ? false : true;
        }

        public List<Gallerie> Galleries { get; private set; } = new List<Gallerie>();
        public List<string> ID { get; private set; } = new List<string>();

        public List<int> DownloadPage { get; private set; } = new List<int>();
        public List<int> TotalPage { get; private set; } = new List<int>();
    }


    public static class Global
    {
        public static string DBPath = Application.StartupPath + "\\Hitomi_DB\\";
        public readonly static string DBName = "DB_";
        public readonly static string DBArtist = "_Artist";
        public readonly static string DBCharcter = "_Character";
        public readonly static string DBSeries = "_Series";
        public readonly static string DBTags = "_Tags";
        public readonly static string DBExt = ".db";
        public static string DownloadPath = Application.StartupPath + "\\Download\\";
        public static string Thumbnail = DownloadPath + "Thumbnail\\";

        /// <summary>
        ///  Thumbnail
        /// </summary>
        public static List<string> DownloadedID = new List<string>();
        /// <summary>
        /// DownloadImage List
        /// </summary>
        public static List<string> CheckDownloadID = new List<string>();

        public static string ThumbnailExt = ".tmp";

        public readonly static string DownloadDBName = "DL";

        public static bool ProgramExit = false;

        public readonly static string ReDownloadPath = DBPath + "redown" + DBExt;

        public static DownloadGallerie HioDownGalleries = new DownloadGallerie();
    }
}
