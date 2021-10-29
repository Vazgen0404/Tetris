using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Z : Body
    {
        public Z()
        {
            coordinates = new Coordinates[16]
          {
                new Coordinates { left = 28, top = 7 },
                new Coordinates { left = 29, top = 7 },
                new Coordinates { left = 30, top = 7 },
                new Coordinates { left = 31, top = 7 },
                new Coordinates { left = 28, top = 8 },
                new Coordinates { left = 29, top = 8 },
                new Coordinates { left = 30, top = 8 },
                new Coordinates { left = 31, top = 8 },               
                new Coordinates { left = 30, top = 9 },
                new Coordinates { left = 31, top = 9 },
                new Coordinates { left = 32, top = 9 },
                new Coordinates { left = 33, top = 9 },
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 33, top = 10 }

          };
        }

        public override void ChangeStructure()
        {
            if (direction == 1)
            {          
                coordinates[0].top += 2;               
                coordinates[1].top += 2;
                coordinates[4].top += 2;
                coordinates[5].top += 2;
                coordinates[10].left -= 4;
                coordinates[10].top += 2;
                coordinates[11].left -= 4;
                coordinates[11].top += 2;
                coordinates[14].left -= 4;
                coordinates[14].top += 2;
                coordinates[15].left -= 4;
                coordinates[15].top += 2;
                direction = 2;
            }
            else
            {
                coordinates[0].top -= 2;
                coordinates[1].top -= 2;
                coordinates[4].top -= 2;
                coordinates[5].top -= 2;
                coordinates[10].left += 4;
                coordinates[10].top -= 2;
                coordinates[11].left += 4;
                coordinates[11].top -= 2;
                coordinates[14].left += 4;
                coordinates[14].top -= 2;
                coordinates[15].left += 4;
                coordinates[15].top -= 2;
                direction = 1;
            }

        }
    }
}
