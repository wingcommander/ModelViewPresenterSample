using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Movement : EventArgs
    {
        private MovementEnum direction;

        public Movement(char movement)
        {
            this.Direction = (MovementEnum)Enum.Parse(typeof(MovementEnum), movement.ToString().Substring(0)).GetHashCode();
        }

        public Movement()
        {
           
        }

        public MovementEnum Direction
        {
            get { return direction; }
            set { direction = value; }
        }
    }
}
