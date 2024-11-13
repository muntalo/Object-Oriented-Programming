using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    class Book : LibraryResource
    {
        private string _isbn;

        public Book(string name, string creator, string isbn) : base(name, creator)
        {
            _isbn = isbn;
        }

        public string ISBN
        {
            get { return _isbn; }
        }

    }
}
