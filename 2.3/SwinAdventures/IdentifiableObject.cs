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
            for (int i = 0; i < idents.Length; i++)
                idents[i] = idents[i].ToLower();
            _identifiers.AddRange(idents);
        }

        public bool AreYou(string id)
        {
            for (int i = 0; i < _identifiers.Count; i++)
            {
                if (id.ToLower() == _identifiers[i])
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId
        {
            get 
            {
                if (_identifiers[0] == null)
                    return "";
                else
                    return _identifiers[0];
                    ; 
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
