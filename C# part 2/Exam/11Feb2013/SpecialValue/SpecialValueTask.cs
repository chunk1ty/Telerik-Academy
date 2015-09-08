using System;

namespace SpecialValue
{
    class SpecialValueTask
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] field = new int[n][];
            ReadData(field);
            bool[][] used = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                used[i] = new bool[field[i].Length];   
            }

            long max = long.MinValue;
            for (int i = 0; i < field[0].Length; i++)
            {
                long currentValue = FindCurrentSpecialValue(field, i, used);
                if (max < currentValue)
                {
                    max = currentValue;
                }
            }
            Console.WriteLine(max);
        }
        static int[][] ReadData(int[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currentLine = Console.ReadLine().Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries);
                field[i] = new int[currentLine.Length];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    field[i][j] = int.Parse(currentLine[j].ToString());
                }
            }
            return field;
        }

        static long FindCurrentSpecialValue (int[][] field,int column, bool[][] used)
        {
            long result = 0;
            int currenrRow = 0;

            while (true)
            {
                result++;

                if (used[currenrRow][column])
                {
                    return long.MinValue;   
                }
                if (field[currenrRow][column] < 0) 
                {
                    result -= field[currenrRow][column];
                    return result;
                }
                int nextColumn = field[currenrRow][column];
                used[currenrRow][column] = true;
                column = nextColumn;

                currenrRow++;
                if (currenrRow== field.GetLength(0))
                {
                    currenrRow = 0;
                }
            }

            return result;
        }
    }
}
