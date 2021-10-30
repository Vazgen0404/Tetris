using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Z_Opposite : Body
    {
        public Z_Opposite()
        {
            coordinates = new Coordinates[16]
         {
                
                new Coordinates { left = 30, top = 7 },
                new Coordinates { left = 31, top = 7 },
                new Coordinates { left = 32, top = 7 },
                new Coordinates { left = 33, top = 7 },           
                new Coordinates { left = 30, top = 8 },
                new Coordinates { left = 31, top = 8 },
                new Coordinates { left = 32, top = 8 },
                new Coordinates { left = 33, top = 8 },
                new Coordinates { left = 28, top = 9 },
                new Coordinates { left = 29, top = 9 },
                new Coordinates { left = 30, top = 9 },
                new Coordinates { left = 31, top = 9 },
                new Coordinates { left = 28, top = 10 },
                new Coordinates { left = 29, top = 10 },
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                

         };
        }

        public override void Rotate()
        {
            if (direction == 1)
            {
                coordinates[2].top += 2;
                coordinates[3].top += 2;
                coordinates[6].top += 2;
                coordinates[7].top += 2;
                coordinates[8].left += 4;
                coordinates[8].top += 2;
                coordinates[9].left += 4;
                coordinates[9].top += 2;
                coordinates[12].left += 4;
                coordinates[12].top += 2;
                coordinates[13].left += 4;
                coordinates[13].top += 2;
                direction = 2;
            }
            else
            {
                coordinates[2].top -= 2;
                coordinates[3].top -= 2;
                coordinates[6].top -= 2;
                coordinates[7].top -= 2;
                coordinates[8].left -= 4;
                coordinates[8].top -= 2;
                coordinates[9].left -= 4;
                coordinates[9].top -= 2;
                coordinates[12].left -= 4;
                coordinates[12].top -= 2;
                coordinates[13].left -= 4;
                coordinates[13].top -= 2;
                direction = 1;
            }

        }

        public override Body Clone()
        {
            Z_Opposite ob = (Z_Opposite)this.MemberwiseClone();
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
                new Coordinates{left = ob.coordinates[9].left,top = ob.coordinates[9].top},
                new Coordinates{left = ob.coordinates[10].left,top = ob.coordinates[10].top},
                new Coordinates{left = ob.coordinates[11].left,top = ob.coordinates[11].top},
                new Coordinates{left = ob.coordinates[12].left,top = ob.coordinates[12].top},
                new Coordinates{left = ob.coordinates[13].left,top = ob.coordinates[13].top},
                new Coordinates{left = ob.coordinates[14].left,top = ob.coordinates[14].top},
                new Coordinates{left = ob.coordinates[15].left,top = ob.coordinates[15].top}
            };

            ob.coordinates = tempCoordinates;
            return ob;
        }
    }
}
