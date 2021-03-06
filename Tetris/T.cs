using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class T : Body
    {
        public T()
        {
            coordinates = new Coordinates[16]
          {
                new Coordinates { left = 30, top = 7 },
                new Coordinates { left = 31, top = 7 },
                new Coordinates { left = 30, top = 8 },
                new Coordinates { left = 31, top = 8 },
                new Coordinates { left = 28, top = 9 },
                new Coordinates { left = 29, top = 9 },
                new Coordinates { left = 30, top = 9 },
                new Coordinates { left = 31, top = 9 },
                new Coordinates { left = 32, top = 9 },
                new Coordinates { left = 33, top = 9 },
                new Coordinates { left = 28, top = 10 },
                new Coordinates { left = 29, top = 10 },
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 33, top = 10 }
          };
            color = ConsoleColor.Cyan;
        }
        public override void Rotate()
        {
            switch (direction)
            {
                case 1:
                    coordinates[4].left = coordinates[12].left;
                    coordinates[4].top = coordinates[12].top + 1;
                    coordinates[5].left = coordinates[13].left;
                    coordinates[5].top = coordinates[13].top + 1;
                    coordinates[10].left = coordinates[12].left;
                    coordinates[10].top = coordinates[12].top + 2;
                    coordinates[11].left = coordinates[12].left + 1;
                    coordinates[11].top = coordinates[12].top + 2;
                    direction++;
                    break;
                case 2:
                    coordinates[0].left = coordinates[6].left - 2;
                    coordinates[0].top = coordinates[6].top;
                    coordinates[1].left = coordinates[6].left - 1;
                    coordinates[1].top = coordinates[6].top;
                    coordinates[2].left = coordinates[12].left - 2;
                    coordinates[2].top = coordinates[12].top;
                    coordinates[3].left = coordinates[12].left - 1;
                    coordinates[3].top = coordinates[12].top;
                    direction++;
                    break;
                case 3:
                    coordinates[8].left = coordinates[0].left;
                    coordinates[8].top = coordinates[0].top;
                    coordinates[9].left = coordinates[1].left;
                    coordinates[9].top = coordinates[1].top;
                    coordinates[14].left = coordinates[2].left;
                    coordinates[14].top = coordinates[2].top;
                    coordinates[15].left = coordinates[3].left;
                    coordinates[15].top = coordinates[3].top;
                    coordinates[0].left = coordinates[6].left;
                    coordinates[0].top = coordinates[6].top - 2;
                    coordinates[1].left = coordinates[7].left;
                    coordinates[1].top = coordinates[7].top - 2;
                    coordinates[2].left = coordinates[6].left;
                    coordinates[2].top = coordinates[6].top - 1;
                    coordinates[3].left = coordinates[7].left;
                    coordinates[3].top = coordinates[7].top - 1;                  
                    direction++;
                    break;
                case 4:
                    coordinates[4].left = coordinates[8].left;
                    coordinates[4].top = coordinates[8].top;
                    coordinates[5].left = coordinates[9].left;
                    coordinates[5].top = coordinates[9].top;
                    coordinates[10].left = coordinates[14].left;
                    coordinates[10].top = coordinates[14].top;
                    coordinates[11].left = coordinates[15].left;
                    coordinates[11].top = coordinates[15].top;
                    coordinates[8].left = coordinates[7].left + 1;
                    coordinates[8].top = coordinates[7].top;
                    coordinates[9].left = coordinates[7].left + 2;
                    coordinates[9].top = coordinates[7].top;
                    coordinates[14].left = coordinates[13].left + 1;
                    coordinates[14].top = coordinates[13].top;
                    coordinates[15].left = coordinates[13].left + 2;
                    coordinates[15].top = coordinates[13].top;
                    direction = 1;
                    break;
                default:
                    break;
            }
        }

        public override Body Clone()
        {
            T ob = (T)this.MemberwiseClone();
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
