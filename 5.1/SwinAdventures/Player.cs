using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventures
{
    public class Player : GameObject, IHaveInventory
    {
        Inventory _inventory;
        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            } else 
                return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get { return "You are " + Name + " " + base.FullDescription + ".\nYou are carring" + _inventory.ItemList; }
        }
        
        public Inventory Invetory
        {
            get { return _inventory; }
        }
    }
}
