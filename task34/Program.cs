// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. Пример: [345, 897, 568, 234] -> 2


int[] array = CreateArray();
ShowArray(array);
Console.WriteLine($"\nКол-во четных чисел - {CalcEventNumbers(array)}");

void ShowArray(int[] array)
{
    System.Console.Write("Элементы массива - ");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] CreateArray() // метод 'создание массива'. Без параметров,т.к. необходимые данные явно объявленны внутри метода
{
    Random rnd = new Random(); //// генерация случайного числа и присвоение его переменной rnd. Random - тип данных Случайный. Оператор "new" — создает новый экземпляр типа.  
    int maxLengthArray = 100; //максимальная длина массива
    int minLengthArray = 10;  //минимальная длина массива
    int maxValueNumber = 999; //максимальное число массива
    int minValueNumber = 100; //минимальное число массива 

    int[] array = new int[rnd.Next(minLengthArray, maxLengthArray)]; // создание и заполнение массива нулями с рандомной длиной в диапазоне (minLengthArray, maxLengthArray)

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValueNumber, maxValueNumber); // заполнение массива с помощью встроенного метода Next диапазоном чисел (minValueNumber, maxValueNumber) - параметры метода Next 
    }

    return array;
}

int CalcEventNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) // условие заполнения выходного массива чётными числами - если остаток от деления на два равен 0 
            count++;
    }

    return count;
}