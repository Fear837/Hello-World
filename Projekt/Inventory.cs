using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Inventory
    {
        public List<Item> Items { get; }

        public Int32 MaxSlots { get; set; }

        private Scene scene;

        public Inventory(Scene scene, Int32 MaxSlots) // Todo: Inventar-Klasse
        {
            this.scene = scene;
            this.MaxSlots = MaxSlots;
        }

        public bool addItem(Item item)
        {
            if (Items.Count < MaxSlots || MaxSlots == 0)
            {
                Items.Add(item);
                return true;
            }
            else { return false; }
        }
        public bool removeItem(Item item)
        {
            if (Items.Remove(item))
            { 
                return true; 
            }
            else { return false; }
        }

        public Item getItem(String Itemname)
        {
            Item returnItem = null;
            foreach (var item in Items)
            {
                if (item.Itemname == Itemname)
                { returnItem = item; }
            }

            return returnItem;
        }
        public Item getItem(Int32 Itemid)
        {
            Item returnItem = null;
            foreach (var item in Items)
            {
                if (item.getItemid() == Itemid)
                { returnItem = item; }
            }

            return returnItem;
        }
    }
}
