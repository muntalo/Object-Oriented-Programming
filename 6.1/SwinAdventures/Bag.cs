using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventures
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else
                return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get { return "In the " + Name + " you can see: \n" + _inventory.ItemList; }
        }
        public Inventory Inventory
        {
            get { return _inventory;  }
        }
    }
}
