using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    internal class NewBunCoordinatesToSkip
    {
        public NewBunCoordinatesToSkip(int r, int c)
        {
            Row = r;
            Col = c;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var lair = new char[size[0], size[1]];

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    lair[row, col] = input[col];
                }
            }

            char[] command = Console.ReadLine().ToCharArray();
            int lastRow = 0;
            int lastCol = 0;
            bool won = false;
            bool dead = false;

            var newBunCoordinatesToSkip = new List<NewBunCoordinatesToSkip>();

            for (int i = 0; i < command.Length; i++)
            {
                bool moveCheck = false;

                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'P')
                        {
                            switch (command[i])
                            {
                                case 'U':
                                    if (row - 1 >= 0)
                                    {
                                        if (lair[row - 1, col] == '.')
                                        {
                                            lair[row - 1, col] = lair[row, col];
                                            lair[row, col] = '.';
                                        }
                                        else if (lair[row - 1, col] == 'B')
                                        {
                                            lair[row, col] = '.';
                                            lastRow = row - 1;
                                            lastCol = col;
                                            dead = true;
                                        }
                                    }
                                    else if (row - 1 < 0)

                                    {
                                        lair[row, col] = '.';
                                        lastRow = row;
                                        lastCol = col;
                                        won = true;
                                    }
                                    break;

                                case 'R':
                                    if (col + 1 < lair.GetLength(1))
                                    {
                                        if (lair[row, col + 1] == '.')
                                        {
                                            lair[row, col + 1] = lair[row, col];
                                            lair[row, col] = '.';
                                        }
                                        else if (lair[row, col + 1] == 'B')
                                        {
                                            lair[row, col] = '.';
                                            lastRow = row;
                                            lastCol = col + 1;
                                            dead = true;
                                        }
                                    }
                                    else if (col + 1 >= lair.GetLength(1))
                                    {
                                        lair[row, col] = '.';
                                        lastRow = row;
                                        lastCol = col;
                                        won = true;
                                    }
                                    break;

                                case 'D':
                                    if (row + 1 < lair.GetLength(0))
                                    {
                                        if (lair[row + 1, col] == '.')
                                        {
                                            lair[row + 1, col] = lair[row, col];
                                            lair[row, col] = '.';
                                        }
                                        else if (lair[row, col + 1] == 'B')
                                        {
                                            lair[row, col] = '.';
                                            lastRow = row + 1;
                                            lastCol = col;
                                            dead = true;
                                        }
                                    }
                                    else if (row + 1 >= lair.GetLength(0))
                                    {
                                        lair[row, col] = '.';
                                        lastRow = row;
                                        lastCol = col;
                                        won = true;
                                    }
                                    break;

                                case 'L':
                                    if (col - 1 >= 0)
                                    {
                                        if (lair[row, col - 1] == '.')
                                        {
                                            lair[row, col - 1] = lair[row, col];
                                            lair[row, col] = '.';
                                        }
                                        else if (lair[row, col - 1] == 'B')
                                        {
                                            lair[row, col] = '.';
                                            lastRow = row;
                                            lastCol = col - 1;
                                            dead = true;
                                        }
                                    }
                                    else if (col - 1 < 0)
                                    {
                                        lair[row, col] = '.';
                                        lastRow = row;
                                        lastCol = col;
                                        won = true;
                                    }
                                    break;
                            }

                            for (int r = 0; r < lair.GetLength(0); r++)
                            {
                                for (int c = 0; c < lair.GetLength(1); c++)
                                {
                                    if (lair[r, c] == 'B' && !newBunCoordinatesToSkip.Any(x => x.Row == r && x.Col == c))
                                    {
                                        if (r - 1 >= 0)
                                        {
                                            if (lair[r - 1, c] == '.')
                                            {
                                                lair[r - 1, c] = 'B';
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(row - 1, c));
                                            }
                                            else if (lair[r - 1, c] == 'P')
                                            {
                                                lair[r - 1, c] = 'B';
                                                lastRow = r - 1;
                                                lastCol = c;
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(row - 1, c));
                                                dead = true;
                                            }
                                        }

                                        if (c + 1 < lair.GetLength(1))
                                        {
                                            if (lair[r, c + 1] == '.')
                                            {
                                                lair[r, c + 1] = 'B';
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(r, c + 1));
                                            }
                                            else if (lair[r, c + 1] == 'P')
                                            {
                                                lair[r, c + 1] = 'B';
                                                lastRow = r;
                                                lastCol = c + 1;
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(r, c + 1));
                                                dead = true;
                                            }
                                        }

                                        if (r + 1 < lair.GetLength(0))
                                        {
                                            if (lair[r + 1, c] == '.')
                                            {
                                                lair[r + 1, c] = 'B';
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(r + 1, c));
                                            }
                                            else if (lair[r + 1, c] == 'P')
                                            {
                                                lair[r + 1, c] = 'B';
                                                lastRow = r + 1;
                                                lastCol = c;
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(r + 1, c));
                                                dead = true;
                                            }
                                        }

                                        if (c - 1 >= 0)
                                        {
                                            if (lair[r, c - 1] == '.')
                                            {
                                                lair[r, c - 1] = 'B';
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(r, c - 1));

                                            }
                                            else if (lair[r, c - 1] == 'P')
                                            {
                                                lair[r, c - 1] = 'B';
                                                lastRow = r;
                                                lastCol = c - 1;
                                                newBunCoordinatesToSkip.Add(new NewBunCoordinatesToSkip(r, c - 1));
                                                dead = true;
                                            }
                                        }
                                    }
                                }
                            }

                            moveCheck = true;
                            newBunCoordinatesToSkip.Clear();
                        }

                        if (moveCheck)
                        {
                            break;
                        }
                    }

                    if (moveCheck)
                    {
                        break;
                    }
                }

                if (dead || won)
                {
                    goto END;
                }
            }

        END:
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }

            if (won)
            {
                Console.WriteLine("won: {0} {1}", lastRow, lastCol);
            }
            else if (dead)
            {
                Console.WriteLine("dead: {0} {1}", lastRow, lastCol);
            }
        }
    }
}