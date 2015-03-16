using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Coordinate
    {
        public Coordinate()
        { }
       
        private Int32 x;

        public Int32 X
        {
            get { return x; }
            set { x = value; }
        }
        private Int32 y;

        public Int32 Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
