using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Hur många kast vill du göra? ");
            int numberOfThrows = int.Parse(Console.ReadLine());

            int counterThrows = 0;
            int antalEttor = 0;
            int antalTvåor = 0;
            int antalTreor = 0;
            int antalFyror = 0;
            int antalFemmor = 0;
            int antalSexor = 0;

            do
            {
                Console.Clear();

                var r = new Random();
                int slump = r.Next(1, 7);
                int positionX = r.Next(1, 7);
                int positionY = r.Next(1, 4);
                int rotation = r.Next(1, 3);

                int x = 0;
                r = new Random();
                if (positionX == 1)
                {
                    x = r.Next(5, 75);
                }
                else if (positionX == 2)
                {
                    x = r.Next(10, 55);
                }
                else if (positionX == 3)
                {
                    x = r.Next(15, 35);
                }
                else if (positionX == 4)
                {
                    x = r.Next(10, 45);
                }
                else if (positionX == 5)
                {
                    x = r.Next(5, 35);
                }
                else if (positionX == 6)
                {
                    x = r.Next(5, 65);
                }

                int y = 0;
                r = new Random();
                if (positionY == 1)
                {
                    y = r.Next(10, 24);
                }
                else if (positionY == 2)
                {
                    y = r.Next(13, 21);
                }
                else if (positionY == 3)
                {
                    y = r.Next(15, 19);
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (rotation == 1)
                {
                    if (slump == 1)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("     ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("     ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalEttor++;
                    }
                    else if (slump == 2)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalTvåor++;
                    }
                    else if (slump == 3)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O  O  O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalTreor++;
                    }
                    else if (slump == 4)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("           ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalFyror++;
                    }
                    else if (slump == 5)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalFemmor++;
                    }
                    else if (slump == 6)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O  O  O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("           ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O  O  O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalSexor++;
                    }

                }
                else
                {
                    if (slump == 1)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("     ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("     ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalEttor++;
                    }
                    else if (slump == 2)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("           ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalTvåor++;
                    }
                    else if (slump == 3)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalTreor++;
                    }
                    else if (slump == 4)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("           ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalFyror++;
                    }
                    else if (slump == 5)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("     O     ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalFemmor++;
                    }
                    else if (slump == 6)
                    {
                        Console.SetCursorPosition(x, y + 1);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 3);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 4);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  O     O  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.SetCursorPosition(x, y + 5);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        antalSexor++;
                    }

                }


                counterThrows++;

                Console.ForegroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("   Antal kast: " + counterThrows);
                Console.WriteLine(" -----------------------");
                Console.Write("  Antal ettor: "); Console.Write("{0, -3}", antalEttor); Console.WriteLine("{0, 6}", "(" + (((antalEttor * 100) / counterThrows)) + "%)");
                Console.Write("  Antal tvåor: "); Console.Write("{0, -3}", antalTvåor); Console.WriteLine("{0, 6}", "(" + (((antalTvåor * 100) / counterThrows)) + "%)");
                Console.Write("  Antal treor: "); Console.Write("{0, -3}", antalTreor); Console.WriteLine("{0, 6}", "(" + (((antalTreor * 100) / counterThrows)) + "%)");
                Console.Write("  Antal fyror: "); Console.Write("{0, -3}", antalFyror); Console.WriteLine("{0, 6}", "(" + (((antalFyror * 100) / counterThrows)) + "%)");
                Console.Write(" Antal femmor: "); Console.Write("{0, -3}", antalFemmor); Console.WriteLine("{0, 6}", "(" + (((antalFemmor * 100) / counterThrows)) + "%)");
                Console.Write("  Antal sexor: "); Console.Write("{0, -3}", antalSexor); Console.WriteLine("{0, 6}", "(" + (((antalSexor * 100) / counterThrows)) + "%)");
                Console.WriteLine(" -----------------------");

                //Console.ReadKey();
                Thread.Sleep(750);

            } while (counterThrows < numberOfThrows);

            Console.ReadKey();

        }

    }
}
