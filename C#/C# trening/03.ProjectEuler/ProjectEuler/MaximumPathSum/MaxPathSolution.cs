using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaximumPathSum
{
    public class MaxPathSolution //: MaxPath
    {
        public  int[,] readInput(string filename)
        {
            string line;
            string[] linePieces;
            int lines = 0;

            StreamReader reader = new StreamReader(filename);

            while ((line = reader.ReadLine()) != null)
            {
                lines++;
            }

            int[,] inputTriangle = new int[lines, lines];

            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = reader.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputTriangle[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }
            reader.Close();
            return inputTriangle;
        }

        public  int Solution(string filename)
        {            
            int[,] inputTriangle = readInput(filename);
            int lines = inputTriangle.GetLength(0);

            for (int row = lines - 2; row >= 0; row--)
            {
                for (int col = 0; col <= row; col++)
                {
                    int firstNumber = inputTriangle[row + 1, col];
                    int secondNumber = inputTriangle[row + 1, col + 1];
                    inputTriangle[row, col] += Math.Max(firstNumber, secondNumber);
                }
            }
            return inputTriangle[0, 0];
        }
    }
}
