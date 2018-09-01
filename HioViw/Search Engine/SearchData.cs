using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HioViw
{
    public class SearchData
    {
        public string Title { get; set; } = string.Empty;
        public List<string> Type { get; set; } = new List<string>();
        public List<string> Language { get; set; } = new List<string>();

        public List<string> Series { get; set; } = new List<string>();
        public List<string> Series_Delete { get; set; } = new List<string>();

        public List<string> Character { get; set; } = new List<string>();
        public List<string> Character_Delete { get; set; } = new List<string>();

        public List<string> Artist { get; set; } = new List<string>();

        public List<string> Tags { get; set; } = new List<string>();
        public List<string> Tags_Delete { get; set; } = new List<string>();


        public UInt64 Start_Range { get; set; } = 0;
        public UInt64 End_Range { get; set; } = 10;
    }
}
