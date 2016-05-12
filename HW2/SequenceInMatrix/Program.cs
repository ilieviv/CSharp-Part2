using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] sizes = input
                            .Trim(' ')
                            .Split(' ');

            int inputRows = int.Parse(sizes[0]);
            int inputCols = int.Parse(sizes[1]);

            string[][] toSearch = new string[inputRows][];

            for (int i = 0; i < inputRows; i++)
            {
                toSearch[i] = Console.ReadLine()
                                     .Trim(' ')
                                     .Split(' ');
            }

            int maxSeq = 0;
            int curSeq = 1;

            for (int row = 0; row < inputRows; row++)
            {
                curSeq = 1;

                for (int col = 1; col < inputCols; col++)
                {
                    if (toSearch[row][col] ==
                        toSearch[row][col - 1])
                    {
                        curSeq++;
                    }
                    else
                    {
                        if (curSeq > maxSeq)
                        {
                            maxSeq = curSeq;
                        }
                        curSeq = 1;
                    }
                }

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                }
            }

            for (int col = 0; col < inputCols; col++)
            {
                curSeq = 1;

                for (int row = 1; row < inputRows; row++)
                {
                    if (toSearch[row][col] ==
                        toSearch[row - 1][col])
                    {
                        curSeq++;
                    }
                    else
                    {
                        if (curSeq > maxSeq)
                        {
                            maxSeq = curSeq;
                        }
                        curSeq = 1;
                    }
                }

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                }
            }

            for (int Col = 1; Col < inputCols; Col++)
            {
                curSeq = 1;

                for (int curMod = 1;
                         curMod <= Math.Min(Col, inputRows - 1);
                         curMod++)
                {
                    if (toSearch[0 + curMod][Col - curMod] ==
                        toSearch[0 + (curMod - 1)][Col - (curMod - 1)])
                    {
                        curSeq++;
                    }
                }

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                }
            }

            for (int Row = 1; Row < inputRows; Row++)
            {
                curSeq = 1;

                for (int curMod = 1;
                         curMod <= Math.Min(inputRows - 1 - Row - 1, inputCols - 2);
                         curMod++)
                {
                    if (toSearch[Row + curMod][(inputCols - 1) - curMod] ==
                        toSearch[Row + (curMod + 1)][(inputCols - 1) - (curMod + 1)])
                    {
                        curSeq++;
                    }
                }

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                }
            }

            for (int Row = inputRows - 2;
                     Row >= 0;
                     Row--)
            {
                curSeq = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(inputRows - Row - 1, inputCols - 1);
                    curMod++)
                {
                    if (toSearch[Row + curMod][0 + curMod] ==
                        toSearch[Row + (curMod - 1)][0 + (curMod - 1)])
                    {
                        curSeq++;
                    }
                }

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                }
            }

            for (int Row = 1;
                     Row < inputRows - 1;
                     Row++)
            {
                curSeq = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(Row - 1, inputCols - 1);
                    curMod++)
                {
                    if (toSearch[Row - curMod][(inputCols - 1) - curMod] ==
                        toSearch[Row - (curMod - 1)][(inputCols - 1) - (curMod - 1)])
                    {
                        curSeq++;
                    }
                }

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                }
            }

            Console.WriteLine(maxSeq);
        }
    }
}
