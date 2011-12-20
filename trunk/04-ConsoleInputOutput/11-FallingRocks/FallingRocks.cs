using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _11_FallingRocks
{
    class FallingRocks
    {
        // X, Y Coordinate
        struct Position
        {
            public int X, Y;
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        static void Main(string[] args)
        {
            List<char> rocks = new List<char>();
            rocks.Add('^');
            rocks.Add('@');
            rocks.Add('*');
            rocks.Add('&');
            rocks.Add('+');
            rocks.Add('%');
            rocks.Add('$');
            rocks.Add('#');
            rocks.Add('!');
            rocks.Add('.');
            rocks.Add(';');

            Random randomNumberGenerator = new Random();
            // Position of the dwarf
            Position dwarfPosition = new Position(39, Console.WindowHeight - 1);
            // Position of the rock
            Position rockPosition = new Position(randomNumberGenerator.Next(0, Console.WindowWidth - 3), 0);
            string dwarf = "(0)";
            bool gameOver = false;

            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            //_-----------------------------------------------------------------------------------Not work correclty !!!!!!
            //char rock = rocks.ElementAt(randomNumberGenerator.Next(0, rocks.Count));

            while (!gameOver)
            {
                //------------------------------------------------------------------------------------------
                char rock = rocks.ElementAt(randomNumberGenerator.Next(0, rocks.Count));
                
                if (rockPosition.Y == Console.WindowHeight - 1)
                {
                    rockPosition.Y = 0;
                    rockPosition.X = randomNumberGenerator.Next(0, Console.WindowWidth - 1);
                    rock = rocks.ElementAt(randomNumberGenerator.Next(0, rocks.Count));
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        dwarfPosition.X += 1;
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        dwarfPosition.X -= 1;
                    }
                }

                if ((dwarfPosition.X >= Console.WindowWidth - 3) ||
                    (dwarfPosition.X < 1))
                {
                    gameOver = true;
                }

                //_Print the rock's
                Console.SetCursorPosition(rockPosition.X, rockPosition.Y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(rock);
                rockPosition.Y++;

                //_________________________________
                Console.MoveBufferArea(0, 0, Console.WindowWidth, Console.WindowHeight - 1, 0, 1);
                byte[] newRow = new byte[5];
                for (byte i = 0; i < 5; i++)
                {
                    newRow[i] = (byte)randomNumberGenerator.Next(0, Console.WindowWidth - 1);
                    byte nextSymbol = (byte)randomNumberGenerator.Next(0, randomNumberGenerator.Next(0, 8));
                    Console.Write(rocks.ElementAt(i));
                }

                DrawRocks();

                //char[] kamani = new char[randomNumberGenerator.Next(1, 11)];
                //for (int i = 0; i < kamani.Length; i++)
                //{
                //    rockPosition.X = randomNumberGenerator.Next(1, 70);
                //    rockPosition.Y = 0;
                //    Console.SetCursorPosition(rockPosition.X, rockPosition.Y);
                //}

                //Console.MoveBufferArea(0, 0, 70, 2, 0, 20);
                //Console.SetCursorPosition(0, 20);

                if (rockPosition.Y == Console.WindowHeight - 1)
                {
                    rockPosition.Y = 0;
                    rockPosition.X = randomNumberGenerator.Next(0, Console.WindowWidth - 1);
                    rock = rocks.ElementAt(randomNumberGenerator.Next(0, rocks.Count));
                }

                Console.SetCursorPosition(dwarfPosition.X, dwarfPosition.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(dwarf);

                Thread.Sleep(150);
                Console.Clear();

                //----------------------------------------------------WORK-----------------------------------
                char[] array = new char[] { 'a', 'b', 'c', 'd' };
                //
                // Write the entire char array on a new line.
                //
                Console.SetCursorPosition(10, rockPosition.Y);
                Console.Write(array);
                Console.SetCursorPosition(20, rockPosition.Y);
                Console.Write("@#$");
                //
                // Write the middle 2 characters on a new line.
                //
                Console.SetCursorPosition(0, rockPosition.Y);
                Console.Write(array, 1, 2);
                rockPosition.Y++;
            }
        }

        static void DrawRocks()
        {
            Random randomNumberGenerator = new Random();
            Position rockPosition = new Position(randomNumberGenerator.Next(0, Console.WindowWidth - 3), 0);
            Console.Clear();

            char[] kamani = new char[randomNumberGenerator.Next(1, 11)];
            for (int i = 0; i < kamani.Length; i++)
            {
                rockPosition.X = randomNumberGenerator.Next(1, 70);
                rockPosition.Y = 0;
                Console.SetCursorPosition(rockPosition.X, rockPosition.Y);
            }

            Console.SetCursorPosition(0, randomNumberGenerator.Next(1, Console.WindowWidth - 3));
            Console.Write(kamani[randomNumberGenerator.Next(0, 11)]);
        }
    }
}