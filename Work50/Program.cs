// программa, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();

Console.WriteLine ("Введите число строк: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число стодбцов: ");
int y = int.Parse(Console.ReadLine()!);

int[,] myArray = new int [x,y];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        myArray[i,j] = new Random().Next (0, 10);
        Console.Write (myArray[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите строку элемента: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите столбец элемента: ");
int col = int.Parse(Console.ReadLine()!);

if (row < x && col < y) Console.WriteLine ("Элемент массива существует: "+ myArray[row,col]);
else Console.WriteLine ("Элемент массива не существует");

