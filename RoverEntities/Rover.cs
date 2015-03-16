using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Rover
    {     
        private Position position;        

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
     
        public void Explore(Movement movement)
        {
            switch (Convert.ToInt32(movement.Direction))
            {
                case (Int32)MovementEnum.M:

                    switch (Convert.ToInt32(this.position.Orientation))
                    {
                        case (Int32)CompassPointEnum.W:
                            this.Position.Coordinate.X--;
                            break;

                        case (Int32)CompassPointEnum.N:
                            this.Position.Coordinate.Y++;
                            break;

                        case (Int32)CompassPointEnum.E:
                            this.Position.Coordinate.X++;
                            break;

                        case (Int32)CompassPointEnum.S:
                            this.Position.Coordinate.Y--;
                            break;
                    }

                    break;

                // Moving counter clockwise
                case (Int32)MovementEnum.L:                   

                    if (this.position.Orientation == CompassPointEnum.N)
                    {
                        this.position.Orientation = CompassPointEnum.W;
                    }
                    else
                    {
                        this.position.Orientation--;
                    }                 

                    break;

                // Moving clockwise
                case (Int32)MovementEnum.R:

                    if (this.position.Orientation == CompassPointEnum.W)
                    {
                        this.position.Orientation = CompassPointEnum.N;
                    }
                    else
                    {
                        this.position.Orientation++;
                    }

                    break;
            }
        }
    }
}
