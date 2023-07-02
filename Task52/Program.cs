// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            System.Console.Write(" " + matrixForPrint[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

double[] FillArraySumCol(int[,] matrixForCalc)
{
    double[] tempMatrix = new double[matrixForCalc.GetLength(1)];
    double sumCol;

    for (int i = 0; i < matrixForCalc.GetLength(1); i++)
    {
        sumCol = 0;
        for (int j = 0; j < matrixForCalc.GetLength(0); j++)
        {
            sumCol += matrixForCalc[j, i];
        }
        tempMatrix[i] = sumCol / matrixForCalc.GetLength(0);
    }
    return tempMatrix;
}


///====================================
int rows = 4;
int cols = 5;
int minLeftRange = 0;
int maxRightRange = 9;

int[,] matrix = FillMatrix(rows, cols, minLeftRange, maxRightRange);

PrintMatrix(matrix);
System.Console.WriteLine();

double[] arraySumCol = FillArraySumCol(matrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
System.Console.WriteLine(string.Join(" ", arraySumCol));