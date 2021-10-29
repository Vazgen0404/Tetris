using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                StartGame();
                Console.Clear();
            } 

        }

        private static void StartGame()
        {
            Console.Clear();

            List<Coordinates> busyFields = new List<Coordinates>();
            AddBusyFields(busyFields);
            List<Coordinates> topRow = new List<Coordinates>();
            AddTopRow(topRow);

            PrintField();
            PrintInstruction();

            bool IsGameOver = false;
            while (!IsGameOver)
            {
                Body body = RandomBody();
                body.Print();
                Thread.Sleep(1000);
                while (!IsTheEndOfTheMovement(body,busyFields))
                {
                    if (Console.KeyAvailable)
                    {
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.LeftArrow:
                                body.Move("Left");
                                break;
                            case ConsoleKey.RightArrow:
                                body.Move("Right");
                                break;
                            case ConsoleKey.DownArrow:
                                body.Move("Down");
                                break;
                            case ConsoleKey.UpArrow:
                                body.Clear();
                                body.ChangeStructure();
                                body.Print();
                                break;
                            case ConsoleKey.Spacebar:
                                while (!IsTheEndOfTheMovement(body,busyFields))
                                {
                                    body.Move("Down");
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        body.Move("Down");
                        Thread.Sleep(1000);
                    }
                }
                IsGameOver = CheckFinish(topRow, body);
            }

        }

        private static bool CheckFinish(List<Coordinates> topRow, Body body)
        {
            foreach (Coordinates item1 in body.coordinates)
            {
                foreach (Coordinates item2 in topRow)
                {
                    if (item1 == item2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void AddTopRow(List<Coordinates> topRow)
        {
            for (int i = 16; i < 46; i++)
            {
                topRow.Add(new Coordinates { left = i, top = 9 });
            }
        }

        private static bool IsTheEndOfTheMovement(Body body, List<Coordinates> busyFields)
        {
            foreach (Coordinates item1 in body.coordinates)
            {
                foreach (Coordinates item2 in busyFields)
                {
                    if ((item1 + 1) == item2)
                    {
                        foreach (Coordinates item in body.coordinates)
                        {
                            busyFields.Add(item);
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        private static void AddBusyFields(List<Coordinates> busyFields)
        {
            for (int i = 16; i < 46; i++)
            {
                busyFields.Add(new Coordinates { left = i, top = 40 });
            }
        }

        private static Body RandomBody()
        {
            int num = new Random().Next(1, 9);
            switch (num)
            {
                case 1:
                    return new Square();
                case 2:
                    return new Rectangle();
                case 3:
                    return new Line();
                case 4:
                    return new L_Corner();
                case 5:
                    return new R_Corner();
                case 6:
                    return new T();
                case 7:
                    return new Z();
                case 8:
                    return new Z_Opposite();
                default:
                    throw new Exception();

            }
        }

        private static void PrintInstruction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("Instruction");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("Left Arrow - Move Left");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine("Right Arrow - Move Right");
            Console.SetCursorPosition(2, 46);
            Console.WriteLine("Down Arrow - Move Down");
            Console.SetCursorPosition(2, 47);
            Console.WriteLine("Up Arrow - Rotate");
            Console.SetCursorPosition(2, 48);
            Console.WriteLine("Spacebar - Drop block");
        }

        private static void PrintField()
        {
            Console.SetCursorPosition(15,9);
            Console.WriteLine('╔');
            Console.SetCursorPosition(16,9);
            Console.WriteLine(new string('═',30));
            Console.SetCursorPosition(46,9);
            Console.WriteLine('╗');
            Console.SetCursorPosition(15,40);
            Console.WriteLine('╚');
            Console.SetCursorPosition(16,40);
            Console.WriteLine(new string('═',30));
            Console.SetCursorPosition(46,40);
            Console.WriteLine('╝');

            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(15,10 + i);
                Console.WriteLine('║');
            }

            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(46,10+ i);
                Console.WriteLine('║');
            }
        }

        private static void ShowMenu()
        {
            CreateWindow();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, 2);
            Console.WriteLine(new string('=',40));
            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, 3);
            Console.WriteLine(new string('=',40));
            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.WindowHeight - 4);
            Console.WriteLine(new string('=', 40));
            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.WindowHeight - 3);
            Console.WriteLine(new string('=', 40));
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("      OOOOOOO  OOOOOO  OOOOOOO  OOOOO   OOOOO   OOOOO");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("         O     O          O     O    O    O    O");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("         O     OOOOOO     O     OOOOO     O     OOOOO");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("         O     O          O     O   O     O          O");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("         O     OOOOOO     O     O    O  OOOOO   OOOOO");

            string text = "Press Enter To Start";
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, 25);
            Console.WriteLine(text);
            
        }

        private static void CreateWindow()
        {
            Console.SetWindowSize(60, 50);
            Console.SetBufferSize(60, 50);
            Console.CursorVisible = false;
            
        }
    }
}
