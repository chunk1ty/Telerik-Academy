namespace MatrixNamespace
{
    using System;
    //Всичките интерфейси са зада се ограничи матрицата да се състой само от числа
    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        #region Fields        
        private T[,] matrix;
        private readonly int row;
        private readonly int column;
        #endregion Fields

        //Properties
        public int GetRow
        {
            get 
            {
                return this.row;
            }
            //set 
            //{
            //    if (value < 1)
            //    {
            //        throw new ArgumentException("The rows can not be a negative number!");
            //    }
            //    else
            //    {
            //        this.row = value; 
            //    }
            //}
        }
        public int GetCol
        {
            get
            {
                return this.column;
            }
            //set
            //{
            //    if (value < 1)
            //    {
            //        throw new ArgumentException("The columns can not be a negative number!");
            //    }
            //    else
            //    {
            //        this.column = value;   
            //    }
            //}
        }
        public T this[int row, int col]   //Indexer
        {
            get
            {
                return this.matrix[row,col];
            }
            set
            {
                this.matrix[row,col] = value;
            }
        }       

        //Constructors
        public Matrix(int row, int col)
        {
            //correct or not ???
            if (row < 1 || col < 1)
            {
                throw new ArgumentException("The rows or columns are negative numbers!");
            }
            else
            {
                this.row = row;
                this.column = col;
                this.matrix = new T[row, col];
            }            
        }

        #region Methods
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.GetRow != second.GetRow || first.GetCol != second.GetCol)
            {
                throw new FormatException("The matrix have difference rows or columns");
            }
            else
            {
                Matrix<T> tempMatrix = new Matrix<T>(first.GetRow, second.GetCol);

                for (int i = 0; i < first.GetRow; i++)
                {
                    for (int j = 0; j < first.GetCol; j++)
                    {
                        tempMatrix[i, j] = (dynamic)first[i, j] + (dynamic)second[i, j];
                    }
                }
                return tempMatrix;
            }
        }
        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.GetRow != second.GetRow || first.GetCol != second.GetCol)
            {
                throw new FormatException("The matrix have difference rows or columns");
            }
            else
            {
                Matrix<T> tempMatrix = new Matrix<T>(first.GetRow, second.GetCol);

                for (int i = 0; i < first.GetRow; i++)
                {
                    for (int j = 0; j < first.GetCol; j++)
                    {
                        tempMatrix[i, j] = (dynamic)first[i, j] - (dynamic)second[i, j];
                    }
                }
                return tempMatrix;
            }
        }
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.GetCol != second.GetRow)
            {
                throw new FormatException("The matrix have difference rows or columns");
            }
            else
            {
                Matrix<T> tempMatrix = new Matrix<T>(first.GetRow, second.GetCol);


                for (int i = 0; i < first.GetRow; i++)
                {
                    for (int j = 0; j < first.GetCol; j++)
                    {
                        tempMatrix[i, j] = default(T);
                        for (int k = 0; k < first.column; k++)
                        {
                            tempMatrix[i, j] += (dynamic)first[i, k] * (dynamic)second[k, j];
                        }                        
                    }
                }
                return tempMatrix;
            }
        }
        public static bool operator true(Matrix<T> m)
        {
            for (int row = 0; row < m.GetRow; row++)
            {
                for (int col = 0; col < m.GetCol; col++)
                {
                    if (m[row,col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> m)
        {
            for (int row = 0; row < m.GetRow; row++)
            {
                for (int col = 0; col < m.GetCol; col++)
                {
                    if (m[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion Methods

    }
}
