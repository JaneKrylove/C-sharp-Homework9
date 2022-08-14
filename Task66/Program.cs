// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int a, int b)
{
    if (b > a) return b + SumNumbers(a, b - 1);
    return b;
}

Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a != b) Console.WriteLine("The sum of numbers is: " + SumNumbers(a, b));

else

    Console.WriteLine($"{a} = {b} => uncorrect result");
    

