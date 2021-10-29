using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Square : Body
    {

        public Square()
        {
            coordinates = new Coordinates[8]
            {
                new Coordinates { left = 29, top = 10 },
                new Coordinates { left = 30, top = 10 },
                new Coordinates { left = 31, top = 10 },
                new Coordinates { left = 32, top = 10 },
                new Coordinates { left = 29, top = 11 },
                new Coordinates { left = 30, top = 11 },
                new Coordinates { left = 31, top = 11 },
                new Coordinates { left = 32, top = 11 }
            };
        }

        public override void ChangeStructure()
        {
            
        }
    }
}
