// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message) // запрос целого числа с выводом сообщения
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int rangLeft, int rangRight)
{
    double[,] tempMatrix = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = Math.Round(rand.Next(rangLeft, rangRight) + rand.NextDouble(), 2);
        }
    }
    return tempMatrix;
}

string AddSpace(double number, int wide)  //добавим пробелы для выравнивания чисел в колонках по правому краю
{
    string resul = Convert.ToString(number);
    if (number == Math.Round(number, 0)) // если число целое
    {
        resul = resul + ",00";          // добавим дав ноля после запятой
    }
    else if (number == Math.Round(number, 1)) // если число с 1 знаком после запятой
    {
        resul = resul + "0";                // добавим ноль
    }
    while (resul.Length < wide)
    {
        resul = " " + resul;         // добавим пробел в начало строки 
    }
    return resul;
}

void PrintMatrix(double[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(AddSpace(matrixForPrint[i, j], 5) + "\t");
        }
        System.Console.WriteLine();
    }
}
///=========================================================
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество стобцов: ");
double[,] matrix = FillMatrix(rows, cols, -10, 10);
PrintMatrix(matrix);