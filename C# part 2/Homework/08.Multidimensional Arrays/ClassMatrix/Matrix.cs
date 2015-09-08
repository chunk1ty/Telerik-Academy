using System;

class Matrix
{
    private int[,] matrix;

    //Define Constructor
    public Matrix (int rows,int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get 
        {
            return this.matrix.GetLength(0);
        }        
    }

    public int Colums
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    //Overload operator plus "+"
    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix resul = new Matrix(first.Rows,first.Colums);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Colums; col++)
            {
                resul[row, col] = first[row, col] + second[row, col];
            }
        }

        return resul;
    }

    public int this[int row,int col]
    {
        get 
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string result = null;
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Colums; col++)
            {
                result += matrix[row, col] + " ";
            }
            result +=Environment.NewLine;
        }
        return result;
    } 

}

