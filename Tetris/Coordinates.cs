using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Coordinates
    {
        public int left { get; set; }
        public int top { get; set; }
        public ConsoleColor color { get; set; }

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

        public static Coordinates operator +(Coordinates coordinates,string direction)
        {
            switch (direction)
            {
                case "down":
                    return new Coordinates { left = coordinates.left, top = coordinates.top + 1 };
                case "left":
                    return new Coordinates { left = coordinates.left - 2, top = coordinates.top };
                case "right":
                    return new Coordinates { left = coordinates.left + 2, top = coordinates.top };
                default:
                    throw new Exception();
            }
            
        }

    }
}
