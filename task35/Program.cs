/* 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int fillNumberArray (int [] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] >= start && array[i] <= end)
        {
            count = count + 1;
        }
    }
    return count; 
}

int [] getRandomArray(int length, int deviation)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    int []result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);
    }
    return result;
}

int [] myArray = getRandomArray (123, 1000);
printArray (myArray);

int result = fillNumberArray (myArray, 10, 99);
Console.WriteLine($"Количество двухзначных чисел в массиве - {result} ");