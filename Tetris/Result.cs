using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Tetris
{
    [DataContract]
    class Result : IComparable
    {
        [DataMember]
        public int score { get; set; }
        [DataMember]
        public int level { get; set; }
        [DataMember]
        public int line { get; set; }
        [DataMember]
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
        public static void Print()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(24,10);
            Console.WriteLine("Best Results");

            if (File.Exists(@"..\..\..\..\Results.txt"))
            {
                Console.SetCursorPosition(14, 13);
                Console.WriteLine("Score    Level    Lines    Time");
                List<Result> results = ReadFromFile(@"..\..\..\..\Results.txt");
                for (int i = 0; i < results.Count; i++)
                {
                    Console.SetCursorPosition(12, 14 + i);
                    Console.WriteLine($"{i+1}.{results[i].score}");
                    Console.SetCursorPosition(25, 14 + i);
                    Console.WriteLine($"{results[i].level}");
                    Console.SetCursorPosition(34, 14 + i);
                    Console.WriteLine($"{results[i].line}");
                    Console.SetCursorPosition(41, 14 + i);
                    Console.WriteLine($"{results[i].time}");
                }
            }
            else
            {
                Console.SetCursorPosition(12, 13);
                Console.WriteLine("There are no registered results yet");
            }

            Console.SetCursorPosition(0, 40);
            Console.WriteLine("                  Press Enter to return Menu");


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
        }
        public static void Save(Result result)
        {
            List<Result> results;
            if (File.Exists(@"..\..\..\..\Results.txt"))
            {
                results = ReadFromFile(@"..\..\..\..\Results.txt");
            }
            else
            {
                results = new List<Result>();
            }
            results.Add(result);
            results.Sort();
            results.Reverse();
            if (results.Count == 11)
            {
                results.RemoveAt(10);
            }
            WriteInFile(results, @"..\..\..\..\Results.txt");
        }

        private static void WriteInFile(List<Result> results, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.SetLength(fs.Position);
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Result>));
                json.WriteObject(fs, results);
            }
        }

        public static List<Result> ReadFromFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Result>));
                return (List<Result>)json.ReadObject(fs);
            }

        }

        public int CompareTo(object obj)
        {
            Result temp = (Result)obj;
            if (this.score > temp.score)
            {
                return 1;
            }
            else if (this.score < temp.score)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
