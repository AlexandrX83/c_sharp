// int[] getRandArr(int length, int deviation)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rnd.Next(-deviation, deviation + 1);
    return arr;
}

void printArr(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.WriteLine(arr[i] + "]");
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[] getReverseArr(int[] arr)
{
    int[] reverseArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        reverseArr[i] = arr[i] * -1;

    return reverseArr;
}

int[] array = getRandArr(10, 100);
printArr(array);
int[] reverseArray = getReverseArr(array);
printArr(reverseArray);