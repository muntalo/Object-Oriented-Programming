using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventures
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look", "at" })
        {

        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Count() != 3 && text.Count() != 5)
                return "I don't know how to look at that.";
            else if (text[0].ToLower() != "look")
                return "Error in look input.";
            else if (text[1].ToLower() != "at")
                return "What do you want to look at?";
            else if ((text.Count() == 5) && (text[3].ToLower() != "in"))
                return "What do you want to look in?";
            else if (text.Count() == 3)
            {
                return LookAtIn(text[2], p);
            }
            else
            {
                
                IHaveInventory container = FetchContainer(p, text[4]);
                if (container == null)
                    return "Cant find \"" + text[4] + "\".";
                else
                    return LookAtIn(text[2], container);
            }
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            return (IHaveInventory)p.Locate(containerId);
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            try
            {
                return container.Locate(thingId).FullDescription;
            }
            catch
            {
                return "Cant find \"" + thingId + "\".";
            }
        }
    }
}
