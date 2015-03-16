using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Position
    {
        private Coordinate coordinate;
        private CompassPointEnum orientation;

        public Coordinate Coordinate
        {
            get
            {
                if (this.coordinate == null)
                {
                    this.Coordinate = new Coordinate();                    
                }

                return this.coordinate;
            }
            set { coordinate = value; }
        }

        public CompassPointEnum Orientation
        {
            get { return orientation; }
            set { orientation = value; }
        }
    }
}
