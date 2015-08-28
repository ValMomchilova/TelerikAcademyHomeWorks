using System;
using System.Collections.Generic;
using System.Linq;
class MatrixTest
{
    static void Main()
    {
        // test Matrix with int
        Console.WriteLine("Test Matrix<int>:");
        Console.WriteLine();
        Matrix<int> matrixX = new Matrix<int>(4, 4);
        /*
        1,1,1,1
        2,2,2,2
        3,3,3,3
        4,4,4,4 
        */
        matrixX[0, 0] = 1;
        matrixX[0, 1] = 1;
        matrixX[0, 2] = 1;
        matrixX[0, 3] = 1;
        matrixX[1, 0] = 2;
        matrixX[1, 1] = 2;
        matrixX[1, 2] = 2;
        matrixX[1, 3] = 2;
        matrixX[2, 0] = 3;
        matrixX[2, 1] = 3;
        matrixX[2, 2] = 3;
        matrixX[2, 3] = 3;
        matrixX[3, 0] = 4;
        matrixX[3, 1] = 4;
        matrixX[3, 2] = 4;
        matrixX[3, 3] = 4;

        Console.WriteLine("Print matrix X:");
        Console.WriteLine(matrixX.ToString());
        Console.WriteLine();

        Matrix<int> matrixY = new Matrix<int>(4, 4);
        /*
        5,5,5,5
        6,6,6,6
        7,7,7,7
        8,8,8,8 
        */
        matrixY[0, 0] = 5;
        matrixY[0, 1] = 5;
        matrixY[0, 2] = 5;
        matrixY[0, 3] = 5;
        matrixY[1, 0] = 6;
        matrixY[1, 1] = 6;
        matrixY[1, 2] = 6;
        matrixY[1, 3] = 6;
        matrixY[2, 0] = 7;
        matrixY[2, 1] = 7;
        matrixY[2, 2] = 7;
        matrixY[2, 3] = 7;
        matrixY[3, 0] = 8;
        matrixY[3, 1] = 8;
        matrixY[3, 2] = 8;
        matrixY[3, 3] = 8;

        Console.WriteLine("Print matrix Y:");
        Console.WriteLine(matrixY.ToString());
        Console.WriteLine();

        Matrix<int> matrixSum = matrixX + matrixY;
        Console.WriteLine("Print matrixes sum:");
        Console.WriteLine(matrixSum.ToString());
        Console.WriteLine();

        Matrix<int> matrixSubtle = matrixX - matrixY;
        Console.WriteLine("Print matrixes subtle:");
        Console.WriteLine(matrixSubtle.ToString());
        Console.WriteLine();

        Matrix<int> matrixProduct = matrixX * matrixY;
        Console.WriteLine("Print matrixes product:");
        Console.WriteLine(matrixProduct.ToString());
        Console.WriteLine();

        matrixX[0, 0] = 5;
        Console.WriteLine("Print matrix X (changed index[0,0]):");
        Console.WriteLine(matrixX.ToString());
        Console.WriteLine();

        // test Matrix with double
        Console.WriteLine("Test Matrix<double>:");
        Console.WriteLine();
        Matrix<double> matrixDX = new Matrix<double>(4, 4);
        /*
        1.5,1,1,1
        2,2,2,2
        3,3,3,3
        4,4,4,4.8 
        */
        matrixDX[0, 0] = 1.5;
        matrixDX[0, 1] = 1;
        matrixDX[0, 2] = 1;
        matrixDX[0, 3] = 1;
        matrixDX[1, 0] = 2;
        matrixDX[1, 1] = 2;
        matrixDX[1, 2] = 2;
        matrixDX[1, 3] = 2;
        matrixDX[2, 0] = 3;
        matrixDX[2, 1] = 3;
        matrixDX[2, 2] = 3;
        matrixDX[2, 3] = 3;
        matrixDX[3, 0] = 4;
        matrixDX[3, 1] = 4;
        matrixDX[3, 2] = 4;
        matrixDX[3, 3] = 4.8;

        Console.WriteLine("Print matrix X:");
        Console.WriteLine(matrixDX.ToString());
        Console.WriteLine();

        Matrix<double> matrixDY = new Matrix<double>(4, 4);
        /*
        5,5,5,5
        6,6,6,6
        7,7,7,7
        8,8,8,8 
        */
        matrixDY[0, 0] = 5;
        matrixDY[0, 1] = 5;
        matrixDY[0, 2] = 5;
        matrixDY[0, 3] = 5;
        matrixDY[1, 0] = 6;
        matrixDY[1, 1] = 6;
        matrixDY[1, 2] = 6;
        matrixDY[1, 3] = 6;
        matrixDY[2, 0] = 7;
        matrixDY[2, 1] = 7;
        matrixDY[2, 2] = 7;
        matrixDY[2, 3] = 7;
        matrixDY[3, 0] = 8;
        matrixDY[3, 1] = 8;
        matrixDY[3, 2] = 8;
        matrixDY[3, 3] = 8;

        Console.WriteLine("Print matrix Y:");
        Console.WriteLine(matrixDY.ToString());
        Console.WriteLine();

        Matrix<double> matrixDSum = matrixDX + matrixDY;
        Console.WriteLine("Print matrixes sum:");
        Console.WriteLine(matrixDSum.ToString());
        Console.WriteLine();

        Matrix<double> matrixDSubtle = matrixDX - matrixDY;
        Console.WriteLine("Print matrixes subtle:");
        Console.WriteLine(matrixDSubtle.ToString());
        Console.WriteLine();

        Matrix<double> matrixDProduct = matrixDX * matrixDY;
        Console.WriteLine("Print matrixes product:");
        Console.WriteLine(matrixDProduct.ToString());
        Console.WriteLine();

        // test  true  operator 
        Console.WriteLine("Test  true  operator: ");
        Console.WriteLine();

        Console.WriteLine("Check already created matrix X:");
        Console.WriteLine("Check :");

        if(matrixX)
        {
            Console.WriteLine("Matrix contains not-zero element (true)");
        }

        Console.WriteLine("Set all elements of matrix X to zero");

        for (int i = 0; i < matrixX.Rows; i++)
        {
            for (int j = 0; j < matrixX.Columns; j++)
            {
                matrixX[i, j] = 0;
            }
        }

        Console.WriteLine("Check :");

        if (!matrixX)
        {
            Console.WriteLine("All matrix element are zero (false)");
        }
    }
}

