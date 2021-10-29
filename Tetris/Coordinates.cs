using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Coordinates
    {
        public int left { get; set; }
        public int top { get; set; }


        public static bool operator ==(Coordinates coordinate1, Coordinates coordinate2)
        {
            if (coordinate1.left == coordinate2.left && coordinate1.top == coordinate2.top)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Coordinates coordinate1, Coordinates coordinate2)
        {
            if (coordinate1.left == coordinate2.left && coordinate1.top == coordinate2.top)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Coordinates operator +(Coordinates coordinates,int num)
        {
            return new Coordinates { left = coordinates.left, top = coordinates.top + num };
        }

    }
}
