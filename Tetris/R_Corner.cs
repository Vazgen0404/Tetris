using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class R_Corner : Body
    {

        public R_Corner()
        {
            coordinates = new Coordinates[16]
          {
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 33, top = 10 },
                new Coordinates { left = 32, top = 11 },
                new Coordinates { left = 33, top = 11 },
                new Coordinates { left = 28, top = 12 },
                new Coordinates { left = 29, top = 12 },
                new Coordinates { left = 30, top = 12 },
                new Coordinates { left = 31, top = 12 },
                new Coordinates { left = 32, top = 12 },
                new Coordinates { left = 33, top = 12 },
                new Coordinates { left = 28, top = 13 },
                new Coordinates { left = 29, top = 13 },
                new Coordinates { left = 30, top = 13 },
                new Coordinates { left = 31, top = 13 },
                new Coordinates { left = 32, top = 13 },
                new Coordinates { left = 33, top = 13 }
          };
        }
        public override void ChangeStructure()
        {
            switch (direction)
            {
                case 1:
                    coordinates[4].left = coordinates[0].left - 2;
                    coordinates[4].top = coordinates[0].top;
                    coordinates[5].left = coordinates[0].left - 1;
                    coordinates[5].top = coordinates[0].top;
                    coordinates[6].left = coordinates[0].left - 2;
                    coordinates[6].top = coordinates[0].top + 1;
                    coordinates[7].left = coordinates[0].left - 1;
                    coordinates[7].top = coordinates[0].top + 1;
                    coordinates[12].left = coordinates[14].left;
                    coordinates[12].top = coordinates[14].top + 2;
                    coordinates[13].left = coordinates[14].left + 1;
                    coordinates[13].top = coordinates[14].top + 2;
                    coordinates[10].left = coordinates[14].left;
                    coordinates[10].top = coordinates[14].top + 1;
                    coordinates[11].left = coordinates[14].left + 1;
                    coordinates[11].top = coordinates[14].top + 1;
                    direction++;
                    break;
                case 2:
                    coordinates[8].left = coordinates[4].left - 2;
                    coordinates[8].top = coordinates[4].top;
                    coordinates[9].left = coordinates[4].left - 1;
                    coordinates[9].top = coordinates[4].top;
                    coordinates[10].left = coordinates[6].left - 2;
                    coordinates[10].top = coordinates[6].top;
                    coordinates[11].left = coordinates[6].left - 1;
                    coordinates[11].top = coordinates[6].top;
                    coordinates[12].left = coordinates[6].left - 2;
                    coordinates[12].top = coordinates[6].top + 1;
                    coordinates[13].left = coordinates[6].left - 1; 
                    coordinates[13].top = coordinates[6].top + 1;
                    coordinates[14].left = coordinates[6].left - 2;
                    coordinates[14].top = coordinates[6].top + 2;
                    coordinates[15].left = coordinates[6].left - 1;
                    coordinates[15].top = coordinates[6].top + 2;
                    direction++;
                    break;
                case 3:
                    coordinates[0].left = coordinates[14].left;
                    coordinates[0].top = coordinates[14].top + 1;
                    coordinates[1].left = coordinates[15].left;
                    coordinates[1].top = coordinates[15].top + 1;
                    coordinates[2].left = coordinates[15].left + 1;
                    coordinates[2].top = coordinates[15].top + 1;
                    coordinates[3].left = coordinates[15].left + 2;
                    coordinates[3].top = coordinates[15].top + 1;
                    coordinates[4].left = coordinates[14].left;
                    coordinates[4].top = coordinates[14].top + 2;
                    coordinates[5].left = coordinates[15].left;
                    coordinates[5].top = coordinates[15].top + 2;
                    coordinates[6].left = coordinates[15].left + 1;
                    coordinates[6].top = coordinates[15].top + 2;
                    coordinates[7].left = coordinates[15].left + 2;
                    coordinates[7].top = coordinates[15].top + 2;
                    direction++;
                    break;
                case 4:
                    coordinates[0].left = coordinates[8].left + 4;
                    coordinates[0].top = coordinates[8].top;
                    coordinates[1].left = coordinates[9].left + 4;
                    coordinates[1].top = coordinates[9].top;
                    coordinates[2].left = coordinates[10].left + 4;
                    coordinates[2].top = coordinates[10].top;
                    coordinates[3].left = coordinates[11].left + 4;
                    coordinates[3].top = coordinates[11].top;
                    coordinates[8].left = coordinates[12].left + 4;
                    coordinates[8].top = coordinates[12].top;
                    coordinates[9].left = coordinates[13].left + 4;
                    coordinates[9].top = coordinates[13].top;
                    coordinates[14].left += 4;
                    coordinates[15].left += 4;
                    coordinates[6].left = coordinates[8].left - 2;
                    coordinates[6].top = coordinates[8].top;
                    coordinates[7].left = coordinates[8].left - 1;
                    coordinates[7].top = coordinates[8].top;
                    coordinates[4].left = coordinates[8].left - 4;
                    coordinates[4].top = coordinates[8].top;
                    coordinates[5].left = coordinates[8].left - 3;
                    coordinates[5].top = coordinates[8].top;
                    coordinates[12].left = coordinates[14].left - 2;
                    coordinates[12].top = coordinates[14].top;
                    coordinates[13].left = coordinates[14].left - 1;
                    coordinates[13].top = coordinates[14].top;
                    coordinates[10].left = coordinates[14].left - 4;
                    coordinates[10].top = coordinates[14].top;
                    coordinates[11].left = coordinates[14].left - 3;
                    coordinates[11].top = coordinates[14].top;
                    direction = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
