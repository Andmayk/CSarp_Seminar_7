// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//  1 7 -> такого числа в массиве нет

int ReadInt(string message) // запрос целого числа с выводом сообщения
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrixElementFromRowColumn(int[,] matrixForPrint, int row, int col)
{
    if (row < matrixForPrint.GetLength(0) && col < matrixForPrint.GetLength(1))
    {
        System.Console.Write($"элемента с и ндексами {row}, {col} -> ");
        System.Console.WriteLine(matrixForPrint[row, col]);
    }
    else
    {
        System.Console.WriteLine("элемента с такими индексами в массиве нет");
    }
}

///=====================================

int row = ReadInt("Введите ндекс строки: ");
int col = ReadInt("Введите ндекс колонки: ");
int[,] matrix = FillMatrix(4, 5, 0, 9);
PrintMatrix(matrix);

PrintMatrixElementFromRowColumn(matrix, row, col);
