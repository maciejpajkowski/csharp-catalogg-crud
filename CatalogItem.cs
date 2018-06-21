using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogg
{
    public class CatalogItem
    {
        public CatalogItem()
        {
            id = int.MinValue;
            title = "Name not specified";
            genre = "No genre specified";
            developer = "Unknown developer";
        }
        public int id;
        public string title;
        public string genre;
        public string developer;

    }
}
