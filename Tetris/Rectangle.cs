using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Rectangle : Body
    {
        public Rectangle()
        {
            coordinates = new Coordinates[16]
           {
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
                new Coordinates { left = 29, top = 13 },
                new Coordinates { left = 30, top = 13 },
                new Coordinates { left = 31, top = 13 },
                new Coordinates { left = 32, top = 13 }
           };
        }
        public override void ChangeStructure()
        {
            if (direction == 1)
            {
                coordinates[8].left = coordinates[0].left - 1;
                coordinates[8].top = coordinates[0].top;
                coordinates[9].left = coordinates[0].left - 2;
                coordinates[9].top = coordinates[0].top;
                coordinates[10].left = coordinates[3].left + 1;
                coordinates[10].top = coordinates[3].top;
                coordinates[11].left = coordinates[3].left + 2;
                coordinates[11].top = coordinates[3].top;
                coordinates[12].left = coordinates[4].left - 1;
                coordinates[12].top = coordinates[4].top;
                coordinates[13].left = coordinates[4].left - 2;
                coordinates[13].top = coordinates[4].top;
                coordinates[14].left = coordinates[7].left + 1;
                coordinates[14].top = coordinates[7].top;
                coordinates[15].left = coordinates[7].left + 2;
                coordinates[15].top = coordinates[7].top;
                direction = 2;
            }
            else
            {
                coordinates[8].left = coordinates[0].left;
                coordinates[8].top = coordinates[0].top + 2;
                coordinates[9].left = coordinates[0].left + 1;
                coordinates[9].top = coordinates[0].top + 2;
                coordinates[10].left = coordinates[0].left + 2;
                coordinates[10].top = coordinates[0].top + 2;
                coordinates[11].left = coordinates[0].left + 3;
                coordinates[11].top = coordinates[0].top + 2;
                coordinates[12].left = coordinates[4].left;
                coordinates[12].top = coordinates[4].top + 2;
                coordinates[13].left = coordinates[4].left + 1 ;
                coordinates[13].top = coordinates[4].top + 2;
                coordinates[14].left = coordinates[4].left + 2;
                coordinates[14].top = coordinates[4].top + 2;
                coordinates[15].left = coordinates[4].left + 3;
                coordinates[15].top = coordinates[4].top + 2;
                direction = 1;
            }
            
        }
    }
}
