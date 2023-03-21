// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool CheckMatrixDimension(int[,] matrixOne, int[,] matrixTwo)
{
    if (matrixOne.GetLength(0) == matrixTwo.GetLength(0) && 
    matrixOne.GetLength(1) == matrixTwo.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixMult = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixMult[i, j] = matrixOne[i, j] * matrixTwo[i, j]; 
        } 
    }
    return matrixMult;  
}

void Main()
{
    const int ROWS = 4;
    const int COLUMNS = 6;
    const int LEFTBORDER = 0;
    const int RIGHTBORDER = 9;
    int[,] myMatrixOne = GetRandomMatrix(ROWS, COLUMNS, LEFTBORDER, RIGHTBORDER);
    int[,] myMatrixTwo = GetRandomMatrix(ROWS, COLUMNS, LEFTBORDER, RIGHTBORDER);
    if (CheckMatrixDimension(myMatrixOne, myMatrixTwo))
    {
        PrintMatrix(myMatrixOne);
        Console.WriteLine();
        PrintMatrix(myMatrixTwo);
        Console.WriteLine();
        PrintMatrix(MatrixMultiplication(myMatrixOne, myMatrixTwo));
    }
}

Main();
