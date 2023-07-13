/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int[,] matrix = GetRandom2DArray(3,4,10);
print2DArray(matrix);

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Enter number of row");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of column");
int n = Convert.ToInt32(Console.ReadLine());

bool IsValidPosition(int[,] matrix, int rowIndex, int columnIndex)
{
    if (rowIndex >= matrix.GetLength(0)
     columnIndex >= matrix.GetLength(1)
     rowIndex < 0
    || columnIndex < 0) 
    {
        return false;
    }
    return true;
}

if (IsValidPosition(matrix, m, n))
{
    Console.WriteLine($"Your value is {matrix[m,n]} ");
}

else {
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("No such position in the array! ");

}
Console.ResetColor();
