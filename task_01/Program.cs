// Домашнее задание №1.
//Задача №2. Написать программу, которая на вход принимает два числа и выдаёт,какое больше,какое меньше.
Console.WriteLine("Введите первое число (A) -->");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (B) -->");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b) 
   {
    Console.WriteLine($" {a} меньше {b}");
   }
  else if (a>b)
     {
      Console.WriteLine($" {b} меньше {a}");
     }   
   else 
       {
        Console.WriteLine($" {a} равно {b}");
       }
    

   
