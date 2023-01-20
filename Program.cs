/*Задача 2.
//Напишите программу которая, на вход принимает два числа  и
//выдаёт, какое число большее, а какое меньшее.
//a = 5 ; b =  7 -> max = 7
//a = 2 ; b = 10 -> max = 10
//a = -9 ; b =-3 -> max =-3
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
   Console.WriteLine("Первое число больше второго");
}
else if (num1 < num2)
{
   Console.WriteLine("Первое число меньше второго"); 
}
else if (num1 == num2)
{
   Console.WriteLine("Оба числа равны"); 
}
*/
//Задача 4:
//Напишите программу , которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
// 2 , 3 , 7 -> 7
//44 , 5 , 78 ->78
//22 , 3 , 9 -> 22
/*
Console.WriteLine ("Введите первое число: ");
int  a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a ;
if (a > max) max= a ;
if (b > max) max = b ;
if (c > max) max = c ;
Console.Write("max = ") ;
Console.WriteLine (max) ;
*/
//Задача 6:
//Напишите программу , которая на вход принимает число и 
//выдаёт , является ли число чётным (делиться ли оно на два без остатка).
//4->да
//-3->нет
//7->нет
/*
Console.WriteLine("Введите число; ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) 
{
Console.WriteLine("Число чётное: "); 
}
else if (number % 2 > 0) 
{
Console.WriteLine("Число нечётное: ") ;
}
if (number % 2 < 0) 
{    
Console.WriteLine("Число нечётное: ");
}
*/
//Задача 8:     
//Напишите программу , которая на вход принимает
//число (N) , а на выходе показывает все чётные числа от 1 до N .
//5->2,4
//8->2,4,6,8
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Дорогой пользователь, введи N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)

            if (i % 2 == 0)
                Console.WriteLine(i);
    }
}
*/