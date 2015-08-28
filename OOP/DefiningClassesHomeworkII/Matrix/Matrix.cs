using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Matrix<T> 
    where T : struct, 
          IComparable,
          IComparable<T>          

{
    private T[,] matrix;
    private int rows;
    private int columns;

    public int Rows
    {
        get
        {
            return this.rows;
        }        
    }
    public int Columns
    {
        get
        {
            return this.columns;
        }       
    }

    public T this[int row, int column]
    {
        get
        {
            ValidateRowColumn(row, column);
            return this.matrix[row, column];
        }
        set
        {
            ValidateRowColumn(row, column);
            this.matrix[row, column] = value;
        }
    }

    public Matrix(int rowsCount = 1, int columnsCount = 1)
    {
        this.rows = rowsCount;
        this.columns = columnsCount;
        this.matrix = new T[Rows, Columns];
    }

    public static Matrix<T> operator +(Matrix<T> x, Matrix<T> y)
    {
        if (x.Columns != y.Columns || x.Rows != y.Rows)
        {
            throw new Exception("Adding cannot be applied. Matrixes are with different dimensions.");
        }

        Matrix<T> result = new Matrix<T>(x.Rows, x.Columns);

        for (int i = 0; i < x.Rows; i++)
        {
            for (int j = 0; j < x.Columns; j++)
            {
                result[i, j] = (dynamic)x[i, j] + y[i, j];                
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> x, Matrix<T> y)
    {
        if (x.Columns != y.Columns || x.Rows != y.Rows)
        {
            throw new Exception("Subtracting cannot be applied. Matrixes are with different dimensions.");
        }

        Matrix<T> result = new Matrix<T>(x.Rows, x.Columns);

        for (int i = 0; i < x.Rows; i++)
        {
            for (int j = 0; j < x.Columns; j++)
            {
                result[i, j] = (dynamic)x[i, j] - y[i, j];
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> x, Matrix<T> y)
    {
        if (x.Columns != y.Rows)
        {
            throw new Exception("Multiplying cannot be applied. x matrix coulumns count have to mutch y matrix rows rount.");
        }

        Matrix<T> result = new Matrix<T>(x.Rows, y.Columns);

        T tempMult;
        for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
        {
            for (int matrixCol = 0; matrixCol < result.Columns; matrixCol++)
            {
                tempMult = default(T);
                for (int index = 0; index < result.Columns; index++)
                {
                    tempMult += (dynamic)x[matrixRow, index] * y[index, matrixCol];
                }
                result[matrixRow, matrixCol] = tempMult;
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        return CheckForNonZeroElements(matrix);
    }

    public static bool operator false(Matrix<T> matrix)
    {
        return CheckForNonZeroElements(matrix);
    }

    public static bool operator !(Matrix<T> matrix)
    {
        return !CheckForNonZeroElements(matrix);
    }

    private static bool CheckForNonZeroElements(Matrix<T> matrix)
    {
        bool result = false;

        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                if (matrix[i, j].CompareTo(default(T)) != 0)
                {
                    result = true;
                    break;
                }
            }
        }

        return result;
    }

    public override string ToString()
    {
        StringBuilder temp = new StringBuilder();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp.Append(this.matrix[i, j] + "\t");
            }

            if (i < matrix.GetLength(0) - 1)
            {
                temp.Append("\r");
                temp.Append("\n");
            }
        }

        string result = temp.ToString();
        return result;
    }

    private void ValidateRowColumn(int row, int column)
    {
        if (row < 0 || row >= Rows)
        {
            throw new IndexOutOfRangeException("Defined row is out of range.");
        }
        if (column < 0 || column >= Columns)
        {
            throw new IndexOutOfRangeException("Defined column is out of range.");
        }
    }
}

