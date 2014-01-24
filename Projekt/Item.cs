using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Item
    {
        public static List<Item> AllItems = new List<Item>();
        public String Itemname { get; set; }
        public String Itemtype { get; set; }
        public String Extra { get; set; }
        private Int32 _Itemid;
        


        public Item(String Itemname, String Itemtype, String Extra) // Todo: Item-Klasse
        {
            this.Itemname = Itemname;
            this.Itemtype = Itemtype;
            this.Extra = Extra;

            Item.AllItems.Add(this);

            this._Itemid = Item.AllItems.Count;
        }

        public Int32 getItemid()
        { return _Itemid; }
    }
}
