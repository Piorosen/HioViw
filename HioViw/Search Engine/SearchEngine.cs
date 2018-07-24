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
using System.Drawing;

namespace HioViw
{
    public delegate void Finder(Object sender, Gallerie e);
    class SearchEngine
    {
        public event Finder Find;
        
        private void OnFind(Gallerie e)
        {
            Find?.Invoke(this, e);
        }

        private bool IsSearchData(SearchData search, JObject j)
        {
            bool Return = true;
            if (search.Title.Length != 0)
            {
                if (j["id"] == null)
                {
                    Return = false;
                }
            }
            if (search.Character.Count != 0)
            {
                if (j["c"] == null)
                {
                    Return = false;
                }
            }
            if (search.Series.Count != 0)
            {
                if (j["p"] == null)
                {
                    Return = false;
                }
            }
            if (search.Tags.Count != 0)
            {
                if (j["t"] == null)
                {
                    Return = false;
                }
            }
            if (search.Type.Count != 0)
            {
                if (j["type"] == null)
                {
                    Return = false;
                }
            }
            if (search.Language.Count != 0)
            {
                if (j["l"] == null)
                {
                    Return = false;
                }
            }
            if (!Return)
            {

            }
            return Return;
        }

        public static bool Stop = false;

        public void Find_Start(SearchData search, Panel Bar, bool IsOld = false)
        {
            if (!IsOld)
            {
                var result = new List<JToken>();

                // DB가 0부터 19까지 존재합니다.
                for (int i = 0; i < 20; i++)
                {

                    StreamReader sr = new StreamReader("Hitomi_DB\\text" + i + ".txt");
                    JArray list = JArray.Parse(sr.ReadToEnd());

                    // 검색한 자료만큼 반복을 합니다.
                    for (int w = 0; w < list.Count; w++)
                    {
                        if (Stop)
                        {
                            return;
                        }

                        JObject j = list[w].ToObject<JObject>();

                        // 이 자료가 찾은 검색에 적합한지에 조사합니다.
                        if (IsSearchData(search, j))
                        {
                            bool IsSearch = true;
                            // 찾은 검색에 적합한지에 조사한 자료에 본격적인 조사를 합니다.
                            foreach (var content in j)
                            {
                                if (search.Title.Length != 0 && content.Key == "n")
                                {
                                    if (content.Value.ToString().ToLower().IndexOf(search.Title, 0) == -1)
                                        IsSearch = false;
                                }
                                else if (search.Language.Count != 0 && content.Key == "l")
                                {
                                    bool chk = false;
                                    foreach (var lang in search.Language)
                                    {
                                        if (lang == content.Value.ToString())
                                        {
                                            chk = true;
                                        }
                                    }
                                    IsSearch = chk;
                                }
                                else if (search.Type.Count != 0 && content.Key == "type")
                                {
                                    bool chk = false;
                                    foreach (var Type in search.Type)
                                    {
                                        if (Type == content.Value.ToString())
                                        {
                                            chk = true;
                                        }
                                    }
                                    IsSearch = chk;
                                }
                                else if (search.Character.Count != 0 && content.Key == "c")
                                {
                                    int count = 0;
                                    bool chk = false;

                                    foreach (var data in search.Character)
                                    {
                                        foreach (var contentName in content.Value)
                                        {
                                            chk = false;
                                            if (contentName.ToString().ToLower() == data)
                                            {
                                                count++;
                                                chk = true;
                                            }
                                            if (chk) break;
                                        }
                                    }
                                    if (count != search.Character.Count)
                                        IsSearch = false;
                                }
                                else if (search.Series.Count != 0 && content.Key == "p")
                                {
                                    int count = 0;
                                    bool chk = false;

                                    foreach (var data in search.Series)
                                    {
                                        foreach (var contentName in content.Value)
                                        {
                                            chk = false;
                                            if (contentName.ToString().ToLower() == data)
                                            {
                                                count++;
                                                chk = true;
                                            }
                                            if (chk) break;
                                        }
                                        if (chk) break;
                                    }
                                    if (count == 0)
                                        IsSearch = false;
                                }
                                else if (search.Tags.Count != 0 && content.Key == "t")
                                {
                                    int count = 0;
                                    bool chk = false;

                                    foreach (var data in search.Tags)
                                    {
                                        foreach (var contentName in content.Value)
                                        {
                                            chk = false;
                                            if (contentName.ToString().ToLower() == data)
                                            {
                                                count++;
                                                chk = true;
                                            }
                                            if (chk) break;
                                        }
                                    }
                                    if (count != search.Tags.Count)
                                        IsSearch = false;
                                }

                                if (search.Character_Delete.Count != 0 && content.Key == "c")
                                {
                                    bool chk = true;
                                    foreach (var delete in search.Character_Delete)
                                    {
                                        if (delete == content.Value.ToString())
                                        {
                                            chk = false;
                                        }
                                    }
                                    IsSearch = chk;
                                }
                                else if (search.Series_Delete.Count != 0 && content.Key == "p")
                                {
                                    bool chk = true;
                                    foreach (var delete in search.Series_Delete)
                                    {
                                        if (delete == content.Value.ToString())
                                        {
                                            chk = false;
                                        }
                                    }
                                    IsSearch = chk;
                                }
                                else if (search.Tags_Delete.Count != 0 && content.Key == "t")
                                {
                                    bool chk = true;
                                    foreach (var delete in search.Tags_Delete)
                                    {
                                        if (delete == content.Value.ToString())
                                        {
                                            chk = false;
                                        }
                                    }
                                    IsSearch = chk;
                                }

                                if (!IsSearch)
                                {
                                    break;
                                }
                            }


                            // 검색한 결과를 OnFind 이벤트를 통해서 전달합니다.
                            if (IsSearch)
                            {
                                Gallerie g = new Gallerie
                                {
                                    Tags = new List<string>(),
                                    Character = new List<string>()
                                };

                                if (j["n"] != null)
                                    g.Title = j["n"].ToString();
                                if (j["id"] != null)
                                    g.ID = j["id"].ToString();
                                if (j["g"] != null)
                                    g.Uploader = j["g"].ToString().Split('\"')[1];
                                if (j["type"] != null)
                                    g.Type = j["type"].ToString();
                                if (j["l"] != null)
                                    g.Language = j["l"].ToString();
                                if (j["p"] != null)
                                    g.Series = j["p"].ToString().Split('\"')[1];

                                if (j["t"] != null)
                                {
                                    foreach (var value in j["t"].Values<string>())
                                    {
                                        g.Tags.Add(value);
                                    }
                                }

                                if (j["c"] != null)
                                {
                                    foreach (var value in j["c"].Values<string>())
                                    {
                                        g.Character.Add(value);
                                    }
                                }

                                g.ThumnailImage = "https://ltn.hitomi.la/galleryblock/" + g.ID + ".html";


                                OnFind(g);
                            }

                        }
                        
                    }

                    using (var draw = Bar.CreateGraphics())
                        draw.DrawLine(new Pen(Color.FromArgb(100, 200, 100), Bar.Size.Height / 2), 5, Bar.Size.Height / 2.0f, Bar.Size.Width / 19.0f * i - 5 , Bar.Size.Height / 2.0f);


                }
            }

        }
       
    }
}
