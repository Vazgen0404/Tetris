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
                
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 33, top = 10 },           
                new Coordinates { left = 30, top = 11 },
                new Coordinates { left = 31, top = 11 },
                new Coordinates { left = 32, top = 11 },
                new Coordinates { left = 33, top = 11 },
                new Coordinates { left = 28, top = 12 },
                new Coordinates { left = 29, top = 12 },
                new Coordinates { left = 30, top = 12 },
                new Coordinates { left = 31, top = 12 },
                new Coordinates { left = 28, top = 13 },
                new Coordinates { left = 29, top = 13 },
                new Coordinates { left = 30, top = 13 },
                new Coordinates { left = 31, top = 13 },
                

         };
        }

        public override void ChangeStructure()
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
    }
}
