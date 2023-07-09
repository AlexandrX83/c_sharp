// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateRandomArray();
ShowArray(array);
int sum = OddIndexSum(array);
System.Console.Write("Сумма чисел нечётных позиций массива --> ");
Console.WriteLine(sum);

void ShowArray(int[] array)
{
    System.Console.Write("Массив чисел - ");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] CreateRandomArray()
{
    int minSizeArray = 0;
    int maxSizeArray = 100;
    Random rnd = new Random();
    int[] rndArr = new int [8];
    for (int i = 0; i < rndArr.Length; i++)
    {
        rndArr[i] = rnd.Next(minSizeArray, maxSizeArray);
    }
    return rndArr;
}

int OddIndexSum(int[] array)
{
    int sum = 0;
    for ( int i = 1; i < array.Length; i+=2) //i=i+2
    {
        sum = sum + array[i]; 
    }
    return sum;
}