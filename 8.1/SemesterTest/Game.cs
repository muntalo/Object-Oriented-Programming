using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    class Game : LibraryResource
    {
        private string _contentRating;

        public Game(string name, string creator, string rating) : base(name, creator)
        {
            _contentRating = rating;
        }

        public string ContentRating
        {
            get { return _contentRating; }
        }
    }
}
