using System;
using System.Threading;

namespace MaXXX.HelloWorld
{
    class Program
    {
        static readonly int SpeedOfSpelling = 100;
        static readonly int SpeedOfEnter = 2000;
        static readonly char Razdelitel = ';';
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            WriteMatrix("Wake up, Neo...;The Matrix has you...;Follow the white rabbit.;Knock, knock, Neo.");

            void WriteMatrix(string str)
            {

                for (int i = 0; i < str.Length; i++)
                {                    
                    if (str[i] == Razdelitel)
                    {
                        NewString();
                    }
                    else
                    {
                        Console.Write(str.ToCharArray(i, 1));
                        Thread.Sleep(SpeedOfSpelling);
                    }
                   
                }

                NewString();
            }

            void NewString()
            {
                Thread.Sleep(SpeedOfEnter);
                Console.Clear();
            }
        }
    }
}
