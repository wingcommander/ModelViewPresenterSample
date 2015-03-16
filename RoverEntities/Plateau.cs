using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Plateau
    {
        private Coordinate size;

        public Coordinate Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
