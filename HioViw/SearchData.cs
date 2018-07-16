using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HioViw
{
    class SearchData
    {
            public string Title { get; set; }
            public string Type { get; set; }
            public string Language { get; set; }
            public string Series { get; set; }
            public List<string> Character { get; set; }
            public List<string> Tags { get; set; }
            public string ID { get; set; }
            public string PictureNum { get; set; }
            public string URL { get; set; }
            public string ImagePath { get; set; }
            public string ThumnailImage { get; set; }
            public string Uploader { get; set; }
            public string UploadDate { get; set; }
    }
}
