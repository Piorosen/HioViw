using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HioViw
{
    public static class SearchListBox
    {
        
       public static object[] GetListBox(List<string> list, string name)
        {
            List<object> result = new List<object>();
            foreach (var data in list)
            {
                if (data.IndexOf(name) > -1)
                {
                    result.Add(data);
                }
            }
            return result.ToArray();
        }

    }
}
