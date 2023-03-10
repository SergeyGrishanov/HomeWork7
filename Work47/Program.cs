// Задайте двумерный массив размером m×n,заполненный случайными вещественными числами.

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble() * (10 + 10) - 10;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:F2}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
