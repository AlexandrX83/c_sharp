/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8]; // объявление двумерного массива с явным указанием числа строк и столбцов
FillArray2D(numbers); // Заполнение массива 
PrintArray2D(numbers); // Вывод массива

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
   Console.WriteLine($"В ячейке таблицы с индексом {rows}{colums} находится число {numbers[rows, colums]}");
  
 //если индекс строки введённый пользователем меньше колличества строк массива И 
//индекс столбца введённый пользователем меньше колличества столбцов массива  

else Console.WriteLine($"{rows}{colums} -> числа с таким индексом в массиве нет");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //array.GetLength(0) функция получения количества строк
    // двумерного массива. На это указывает параметр (0)
    {
        for (int j = 0; j < array.GetLength(1); j++)  //array.GetLength(1) - (1) количество столбцов
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}