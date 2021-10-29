using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Body
    {
        public Coordinates[] coordinates;
        protected int direction = 1;


        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Coordinates coordinate in coordinates)
            {
                if (coordinate.top > 9)
                {
                    Console.SetCursorPosition(coordinate.left, coordinate.top);
                    Console.WriteLine("■");
                }              
            }
        }
        public void Clear()
        {
            foreach (Coordinates coordinate in coordinates)
            {
                if (coordinate.top > 9)
                {
                    Console.SetCursorPosition(coordinate.left, coordinate.top);
                    Console.WriteLine(" ");
                }               
            }
        }

        public void Move(string direction)
        {
            Clear();

            switch (direction)
            {
                case "Down":
                    foreach (Coordinates coordinate in coordinates)
                    {
                        coordinate.top++;
                    }
                    break;
                case "Left":
                    foreach (Coordinates coordinate in coordinates)
                    {
                        coordinate.left--;
                    }
                    break;
                case "Right":
                    foreach (Coordinates coordinate in coordinates)
                    {
                        coordinate.left++;
                    }
                    break;
                default:
                    break;
            }

            Print();
        }

      

        public abstract void ChangeStructure();
 
    }
}
