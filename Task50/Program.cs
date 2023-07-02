// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//  1 7 -> такого числа в массиве нет

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
    System.Console.Write("    ");
    for (int j = 0; j < matrixForPrint.GetLength(1); j++) System.Console.Write("[" + j + "]");
    System.Console.WriteLine();
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        System.Console.Write("[" + i + "] ");
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(" "+matrixForPrint[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrixElementFromRowColumn(int[,] matrixForSearch, int row, int col)
{
    if (row < matrixForSearch.GetLength(0) && col < matrixForSearch.GetLength(1))
    {
        System.Console.Write($"элемент с индексами {row}, {col} -> ");
        System.Console.WriteLine(matrixForSearch[row, col]);
    }
    else
    {
        System.Console.WriteLine("элемента с такими индексами в массиве нет");
    }
}
int[] InputArray(string message, int size)
{
    Console.Write(message);
    int[] inputArr = Array.ConvertAll(Console.ReadLine()!.Split(" ", size), int.Parse);
    return inputArr;
}

///=====================================

int[] elementRowCol = InputArray("Введите индексы элемента массива через пробел - строка колонка: ", 2);

int rows = 4;
int cols = 5;
int minLeftRange = 0;
int maxRightRange = 9;

int[,] matrix = FillMatrix(rows, cols, minLeftRange, maxRightRange);
PrintMatrix(matrix);
PrintMatrixElementFromRowColumn(matrix, elementRowCol[0], elementRowCol[1]);
