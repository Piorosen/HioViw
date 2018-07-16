using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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

        public void Find_Start()
        {

        }

    }
}
