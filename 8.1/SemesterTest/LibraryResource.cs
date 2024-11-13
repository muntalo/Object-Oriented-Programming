using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    abstract class LibraryResource
    {
        private string _name;
        private string _creator;
        private bool _onLoan;

        public LibraryResource(string name, string creator)
        {
            _name = name;
            _creator = creator;
            _onLoan = false;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Creator
        {
            get { return _creator; }
        }

        public bool OnLoan
        {
            get { return _onLoan; }
            set { _onLoan = value; }
        }

    }
}
