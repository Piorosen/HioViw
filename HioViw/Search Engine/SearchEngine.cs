using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HioViw
{


    public delegate void Finder(Object sender, Gallerie e);
    class SearchEngine
    {
        public event Finder Find;
        
        private void Finded(Gallerie e)
        {
            Find?.Invoke(this, e);
        }

        public void Find_Start(SearchData search, bool IsOld = false)
        {
            if (!IsOld)
            {
                var result = new List<JToken>();
                for (int i = 8; i < 20; i++)
                {
                   
                    var serializer = new JsonSerializer();
                    StreamReader sr = new StreamReader("Hitomi_DB\\text" + i + ".txt");

                    JArray list = JArray.Parse(sr.ReadToEnd());
                    for (int w = 0; w < list.Count; w++)
                    {
                        JObject j = list[w].ToObject<JObject>();
                        
                        foreach (var content in j)
                        {
                            if (search.Title.Length != 0 && content.Key == "n")
                            {

                            }
                            else if (search.Language.Count != 0 && content.Key == "l")
                            {

                            }
                            else if (search.Type.Count != 0 && content.Key == "type")
                            {

                            }
                            else if (search.Character.Count != 0 && content.Key == "c")
                            {

                            }
                            else if (search.Series.Count != 0 && content.Key == "p")
                            {

                            }else if (search.Tags.Count != 0 && content.Key == "t")
                            {

                            }
                        }
                    }


                }
            }

        }

    }
}
