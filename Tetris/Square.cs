using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Square : Body
    {

        public Square()
        {
            coordinates = new Coordinates[16]
            {
                new Coordinates { left = 29, top = 9 },
                new Coordinates { left = 30, top = 9 },
                new Coordinates { left = 31, top = 9 },
                new Coordinates { left = 32, top = 9 },
                new Coordinates { left = 29, top = 10 },
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 29, top = 11 },
                new Coordinates { left = 30, top = 11 },
                new Coordinates { left = 31, top = 11 },
                new Coordinates { left = 32, top = 11 },
                new Coordinates { left = 29, top = 12 },
                new Coordinates { left = 30, top = 12 },
                new Coordinates { left = 31, top = 12 },
                new Coordinates { left = 32, top = 12 },
            };
            color = ConsoleColor.Red;
        }

        public override void Rotate()
        {

        }

        public override Body Clone()
        {
            Square ob = (Square)this.MemberwiseClone();
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
                new Coordinates{left = ob.coordinates[8].left,top = ob.coordinates[8].top},
                new Coordinates{left = ob.coordinates[10].left,top = ob.coordinates[10].top},
                new Coordinates{left = ob.coordinates[11].left,top = ob.coordinates[11].top},
                new Coordinates{left = ob.coordinates[12].left,top = ob.coordinates[12].top},
                new Coordinates{left = ob.coordinates[13].left,top = ob.coordinates[13].top},
                new Coordinates{left = ob.coordinates[14].left,top = ob.coordinates[14].top},
                new Coordinates{left = ob.coordinates[15].left,top = ob.coordinates[15].top},
                new Coordinates{left = ob.coordinates[9].left,top = ob.coordinates[9].top},
            };

            ob.coordinates = tempCoordinates;
            return ob;
        }
    }
}
