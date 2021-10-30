using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Line : Body
    {
        public Line()
        {
            coordinates = new Coordinates[8]
            {
                new Coordinates { left = 27, top = 10 },
                new Coordinates { left = 28, top = 10 },
                new Coordinates { left = 29, top = 10 },
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 33, top = 10 },
                new Coordinates { left = 34, top = 10 }
            };
        }
        public override void Rotate()
        {
            if (direction == 1)
            {
                coordinates[0].left = coordinates[3].left;
                coordinates[0].top = coordinates[3].top + 1;
                coordinates[1].left = coordinates[3].left;
                coordinates[1].top = coordinates[3].top + 2;
                coordinates[2].left = coordinates[3].left;
                coordinates[2].top = coordinates[3].top + 3;
                coordinates[4].left = coordinates[3].left;
                coordinates[4].top = coordinates[3].top + 4;
                coordinates[5].left = coordinates[3].left;
                coordinates[5].top = coordinates[3].top + 5;
                coordinates[6].left = coordinates[3].left;
                coordinates[6].top = coordinates[3].top + 6;
                coordinates[7].left = coordinates[3].left;
                coordinates[7].top = coordinates[3].top + 7;
                direction = 2;
            }
            else
            {
                coordinates[0].left = coordinates[3].left - 3;
                coordinates[0].top = coordinates[3].top;
                coordinates[1].left = coordinates[3].left - 2;
                coordinates[1].top = coordinates[3].top;
                coordinates[2].left = coordinates[3].left - 1;
                coordinates[2].top = coordinates[3].top;
                coordinates[4].left = coordinates[3].left + 1;
                coordinates[4].top = coordinates[3].top;
                coordinates[5].left = coordinates[3].left + 2;
                coordinates[5].top = coordinates[3].top;
                coordinates[6].left = coordinates[3].left + 3;
                coordinates[6].top = coordinates[3].top;
                coordinates[7].left = coordinates[3].left + 4;
                coordinates[7].top = coordinates[3].top;
                direction = 1;
            }

        }


        public override Body Clone()
        {
            Line ob = (Line)this.MemberwiseClone();
            Coordinates[] tempCoordinates =
            {
                new Coordinates{left = ob.coordinates[0].left,top = ob.coordinates[0].top},
                new Coordinates{left = ob.coordinates[1].left,top = ob.coordinates[1].top},
                new Coordinates{left = ob.coordinates[2].left,top = ob.coordinates[2].top},
                new Coordinates{left = ob.coordinates[3].left,top = ob.coordinates[3].top},
                new Coordinates{left = ob.coordinates[4].left,top = ob.coordinates[4].top},
                new Coordinates{left = ob.coordinates[5].left,top = ob.coordinates[5].top},
                new Coordinates{left = ob.coordinates[6].left,top = ob.coordinates[6].top},
                new Coordinates{left = ob.coordinates[7].left,top = ob.coordinates[7].top},
            };

            ob.coordinates = tempCoordinates;
            return ob;
        }

    }
}
