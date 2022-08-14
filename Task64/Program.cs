// Задача 64: 
// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

int CountDigits(int number)
{
    if (number / 10 != 0) return 1 + CountDigits(number / 10);

    else return 1;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of digits in number: " + CountDigits(num));