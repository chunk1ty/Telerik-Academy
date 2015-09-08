namespace MatrixNamespace
{
    using System;
    public class MatrixTest
    {
        static void Main()
        {
            Matrix<double> mt = new Matrix<double>(2, 2);
            Matrix<double> mt2 = new Matrix<double>(2, 2);

            int someIdiotsValue = 0;

            for (int row = 0; row < mt.GetRow; row++)
            {
                for (int col = 0; col < mt.GetCol; col++)
                {
                    mt[row, col] = someIdiotsValue;
                    someIdiotsValue++;
                }
            }

            someIdiotsValue = 2;
            for (int row = 0; row < mt2.GetRow; row++)
            {
                for (int col = 0; col < mt2.GetCol; col++)
                {
                    mt2[row, col] = someIdiotsValue;
                    someIdiotsValue++;
                }
            }
            //True and False
            if (mt)
            {
                Console.WriteLine("Not cantain zero element!");
            }
            else
            {
                Console.WriteLine("Contain zero element");
            }
            Matrix<double> result = mt * mt2;            
        }
    }
}
