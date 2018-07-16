using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HioViw
{
    public class SearchData
    {
        public string Title { get; set; }
        public List<string> Type { get; set; }
        public List<string> Language { get; set; }
        public List<string> Series { get; set; }
        public List<string> Character { get; set; }
        public List<string> Tags { get; set; }
        public UInt64 Start_Range { get; set; }
        public UInt64 End_Range { get; set; }
    }
}
