using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
            static int x = 3;
            static int y = 5;
            static int fallSpeedMS = 50;
            static void Main(string[] args)
            {
                string player = "q#p";
                bool run = true;
                do
                {

                    if (y == 23)
                    {
                    run = false;
                    }

                    y = y + 1;
                    Console.SetCursorPosition(x, y);
                    Console.Write(player);
                    DrawFloor();
                DrawFloorX2();
                    Thread.Sleep(fallSpeedMS);
                    Console.Clear();
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            y = y - 5;
                            Thread.Sleep(fallSpeedMS);
                        }
                    }

                } while (run);
            }

        static void DrawFloor()
        {
            int floorX = 0;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 24);
            Console.Write("#");
            floorX = floorX + 2;

        }
        static void DrawFloorX2()
        {
            int floorX = 1;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;
            Console.SetCursorPosition(floorX, 25);
            Console.Write("#");
            floorX = floorX + 2;

        }


    }
}
