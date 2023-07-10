// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] createRandDoubleArr(int size, int min, int max)
{
    Random rnd = new Random();
    double[] randArr = new double[size];

    for(int i = 0; i < size; i++)
        randArr[i] = (rnd.NextDouble() * (max - min) + min);
    return randArr;
}

System.Console.Write("Массив вещественных чисел--> ");
void printArr(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
            Console.Write(Math.Round(arr[i], 2) + ", ");
        else
            Console.WriteLine(Math.Round(arr[i], 2) + "]");
    }
    Console.ForegroundColor = ConsoleColor.White;
}


double findMaxMinDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    return max - min;
}


double[] array = createRandDoubleArr(10, 5, 15);
printArr(array);
double diff = findMaxMinDiff(array);
System.Console.Write("Разница между максимальным и минимальным вещественным числом массива--> ");
Console.WriteLine(Math.Round(diff, 2));