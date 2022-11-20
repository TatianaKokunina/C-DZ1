/* 
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
int userNumberA = new int();
int userNumberB = new int();
Console.WriteLine("Введите первое число");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
userNumberB = Convert.ToInt32(Console.ReadLine());
if (userNumberA < userNumberB)
    {
    Console.WriteLine("max=");
    Console.Write(userNumberB);
    }
else {Console.WriteLine("max="); 
Console.Write(userNumberA);}