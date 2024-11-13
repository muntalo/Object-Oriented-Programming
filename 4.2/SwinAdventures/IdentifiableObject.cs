using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventures
{
    public class IdentifiableObject
    {
        private List<String> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            _identifiers.AddRange(idents);
        }

        public bool AreYou(string id)
        {
            foreach (String s in _identifiers)
            {
                if (id.ToLower() == s)
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId
        {
            get { return _identifiers[0]; }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
