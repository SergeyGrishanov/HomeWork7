// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце
Console.Clear();

Console.Write("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, 0, 10);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);

double sum = 0;

for (int j = 0; j < col; j++)
{
    sum = Average(j); // среднее арифмитическое числовой последовательности
    Console.WriteLine();
    Console.WriteLine($"{sum:F2} ");
}

double Average(int col)
{
    double middle = 0;
    double x = 0;
    for (int i = 0; i < row; i++)
{
    middle += array[i, col];
}
x = middle / row;
return x;
}



