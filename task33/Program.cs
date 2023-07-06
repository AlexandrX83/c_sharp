/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int [] getRandomArray(int length, int deviation)
{
    int [] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

void printArray (int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());

int [] randomArray = getRandomArray(5, 9);
printArray(randomArray);

bool isNumberInArray(int [] randomArray, int Number)
{
    for(int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] == Number)
        return true; 
    }
    return false;
}
if (isNumberInArray(randomArray,Num))
Console.WriteLine("Да");
else Console.WriteLine("Нет");