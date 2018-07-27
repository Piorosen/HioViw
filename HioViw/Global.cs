using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HioViw
{
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

        public static string ThumbnailExt = ".tumbimage";

    }
}
