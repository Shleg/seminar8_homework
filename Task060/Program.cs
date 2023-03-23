// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] GetRandomMatrix3D(int x, int y, int z, int leftBorder, int rightBorder)
{
    int[] numbers = new int[90];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = 10 + i;
    }

    int[,,] matrix = new int[x, y, z];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int index = Random.Shared.Next(0, numbers.Length);
                matrix[i, j, k] = numbers[index];
                numbers[index] = numbers[numbers.Length - 1];
                Array.Resize(ref numbers, numbers.Length - 1);
            }   
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + $"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void Main()
{
    const int X = 2;
    const int Y = 2;
    const int Z = 2;
    const int LEFTBORDER = 10;
    const int RIGHTBORDER = 100;
    int[,,] myMatrix = GetRandomMatrix3D(X, Y, Z, LEFTBORDER, RIGHTBORDER);
    PrintMatrix3D(myMatrix);
}

Main();
