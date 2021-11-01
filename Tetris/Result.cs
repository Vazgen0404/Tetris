using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Result
    {
        public int score { get; set; }
        public int level { get; set; }
        public int line { get; set; }
        public string time { get; set; }

        public Result()
        {
            score = 0;
            level = 1;
            line = 0;
        }
        public void AddScore(int points)
        {
            score += points * level;

            CheckLevel();
            Show();

        }

        private void CheckLevel()
        {
            if (score >= 1000 && score < 2000)
            {
                level = 2;
            }
            else if (score >= 2000 && score < 3500)
            {
                level = 3;
            }
            else if (score >= 3500 && score < 5000)
            {
                level = 4;
            }
            else if (score >= 5000 && score < 8000)
            {
                level = 5;
            }
            else if (score >= 8000 && score < 15000)
            {
                level = 6;
            }
            else if (score >= 15000)
            {
                level = 7;
            }
        }
        public void LineControls(int count)
        {
            line += count;

            switch (count)
            {
                case 1:
                    AddScore(100);
                    break;
                case 2:
                    AddScore(300);
                    break;
                case 3:
                    AddScore(500);
                    break;
                case 4:
                    AddScore(800);
                    break;
                default:
                    AddScore(2000);
                    break;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Lines: {line}");
            Console.SetCursorPosition(27, 1);
            Console.WriteLine($"Score: {score}");
            Console.SetCursorPosition(50, 1);
            Console.WriteLine($"Level: {level}");
        }

        public void Save()
        {

        }
    }
}
