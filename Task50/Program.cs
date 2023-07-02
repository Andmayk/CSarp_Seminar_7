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
            System.Console.Write(AddSpace(matrixForPrint[i, j],4) + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrixElementFromRowColumn(int[,] matrixForPrint, int row, int col)
{
    if  (row < matrixForPrint.GetLength(0)&&col < matrixForPrint.GetLength(1))
    {
            System.Console.WriteLine(matrixForPrint[row, col],4);
    }
    else
    {
        System.Console.WriteLine("элемента с такими индексами в массиве нет");
    }
}



///=====================================

int row = ReadInt("Введите номер строки: ");
int col = ReadInt("Введите номер колонки: ");
double[,] matrix = FillMatrix(3, 4, 0, 10);
PrintMatrix(matrix);

PrintMatrixElementFromRowColumn(matrixForPrint, row, col);
