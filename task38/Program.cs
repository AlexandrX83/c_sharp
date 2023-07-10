// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] createRandDoubleArr(int size, int min, int max) // метод. Возвращаемый тип данных - массив типа Дабл. 
                            //Параметры -размер,минимальное значение,максимальное значение
{
    Random rnd = new Random();
    double[] randArr = new double[size];

    for(int i = 0; i < size; i++)
        randArr[i] = (rnd.NextDouble() * (max - min) + min);
    return randArr; // метод createRandDoubleArr возращает заполненный вещ числами массив randArr. При этом при имени переменной 
                    // типа массив не указывается не тип возращаеммых данных,ни спец символы [], это указанно при объявлении метода   
}

System.Console.Write("Массив вещественных чисел--> ");
void printArr(double[] arr) // процедура печати массива для работы будет принимать в себя массив вещественных чисел,при этом именование 
{                           // принято массива не имеет связи с именами того же массива в других методах.
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
    //double diff = max - min;
    //return diff;               
   return max - min; // return передаёт значение, это можно делать без использования переменной.Две строчки выше-более явная логика.
}

double[] array = createRandDoubleArr(10, 5, 15); // array - глобальная переменная которая сначала получает значения из метода 
printArr(array); // глобальная переменная передаётся в процедуру(void) для вывода массива созданного в методе
double diff = findMaxMinDiff(array); // метод которому параметром передаём глобальную переменную типа массив выдаёт результат типа double 
System.Console.Write("Разница между максимальным и минимальным вещественным числом массива--> ");
Console.WriteLine(Math.Round(diff, 2));