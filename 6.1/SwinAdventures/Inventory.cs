using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventures
{
    public class Inventory
    {
        List<Item> _items;
        
        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    Item placeholder = i;
                    _items.Remove(i);
                    return placeholder;
                }
            }
            return null;

            //return _items.Remove(this.Fetch(id));
        }

        public Item Fetch(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    return i;
                }
            }
            return null;
        }

        public string ItemList
        {
            get 
            {
                string itemlist = "";
                foreach (Item i in _items)
                {
                    itemlist += "\t" + i.ShortDescription + "\n";
                }
                return itemlist;  
            }
        }
    }
}
