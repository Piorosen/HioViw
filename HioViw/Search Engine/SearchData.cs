using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HioViw
{
    public class SearchData
    {
        public SearchData()
        {
            Title = String.Empty;
            Type = new List<string>();
            Series = new List<string>();
            Series_Delete = new List<string>();

            Character = new List<string>();
            Character_Delete = new List<string>();

            Tags = new List<string>();
            Tags_Delete = new List<string>();

            Start_Range = 0;
            End_Range = 10;

        }
        public string Title { get; set; }
        public List<string> Type { get; set; }
        public List<string> Language { get; set; }
   
        public List<string> Series { get; set; }
        public List<string> Series_Delete { get; set; }

        public List<string> Character { get; set; }
        public List<string> Character_Delete { get; set; }


        public List<string> Tags { get; set; }
        public List<string> Tags_Delete { get; set; }


        public UInt64 Start_Range { get; set; }
        public UInt64 End_Range { get; set; }
    }
}
