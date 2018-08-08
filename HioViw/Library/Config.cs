using System.Text;
using System.Runtime.InteropServices;

namespace HioViw
{
    class Config
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string Default, StringBuilder result, int size, string path);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string path);

        public static string GetOption(string Section, string Key, string Path)
        {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(Section, Key, null, sb, 256, Path);
            return sb.ToString();
        }

        public static long SetOption(string Section, string Key, string Val, string Path)
        {
            return WritePrivateProfileString(Section, Key, Val, Path);
        }
    }
}
