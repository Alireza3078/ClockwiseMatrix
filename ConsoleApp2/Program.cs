using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void SpiralPrint(int endRow, int endColumn, int[,] index)
        {
            int iterator;
            int startRow = 0;
            int startColumn = 0;

            while (startRow < endRow && startColumn < endColumn)
            {
                for (iterator = 0; iterator < endColumn; iterator++)
                {
                    Console.WriteLine(index[startRow, iterator] + "");
                }
                startRow++;
                for (iterator = startRow; iterator < endRow; iterator++)
                {
                    Console.WriteLine(index[iterator, endColumn - 1] + "");
                }
                endColumn--;
                if (startRow < endRow)
                {
                    for (iterator = endColumn - 1; iterator >= startColumn; --iterator)
                    {
                        Console.WriteLine(index[endRow-1,iterator]+"");
                    }
                    endRow--;
                }
                if (startColumn < endColumn)
                {
                    for (iterator = endRow - 1; iterator >= startRow; --iterator)
                    {
                        Console.WriteLine(index[iterator,startColumn]+"");
                    }
                    iterator++;
                }
            }
        }

        static void Main(string[] args)
        {
            int Row = 4;
            int Column = 4;
            int[,] index = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            SpiralPrint(Row, Column, index);

        }
    }
}
