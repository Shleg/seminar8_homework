// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] GetSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int minRow = 0;
    int maxRow = matrix.GetLength(0) - 1;
    int minCol = 0;
    int maxCol = matrix.GetLength(1) - 1;
    while (count <= rows * columns)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            matrix[minRow, i] = count++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            matrix[i, maxCol] = count++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            matrix[maxRow, i] = count++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            matrix[i, minCol] = count++;
        }
        minCol++;
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


void Main()
{
    const int ROWS = 4;
    const int COLUMNS = 4;
    int[,] myMatrix = GetSpiralMatrix(ROWS, COLUMNS);
    PrintMatrix(myMatrix);
}

Main();