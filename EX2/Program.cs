/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int userNumberA = new int();
int userNumberB = new int();
int userNumberC = new int();
Console.WriteLine("Введите первое число");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
userNumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
userNumberC = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;
if (userNumberB > max)
    {
    max = userNumberB;
    }
if (userNumberC > max)
 {
    max = userNumberC;
    }
Console.WriteLine("max=");
Console.Write(max);