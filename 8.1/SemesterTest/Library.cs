using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    class Library
    {
        private List<LibraryResource> _resources;

        public Library(string name)
        {
            _resources = new List<LibraryResource>();
            
        }

        public void AddResource(LibraryResource resource)
        {
            _resources.Add(resource);
        }

        public bool HasResource(string name)
        {
            foreach (LibraryResource r in _resources)
            {
                if ((r.Name.ToLower() == name.ToLower()) && (!r.OnLoan))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
