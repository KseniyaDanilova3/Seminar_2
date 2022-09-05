// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  → да, -4, 16  →  да, 25, 5  →  да, 8, 9  →  нет

Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(num1);

Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(num2);

if (num1 * num1 == num2)
{
    Console.WriteLine($"{num2} квадрат числа {num1}");
}

else if (num2 * num2 == num1)
{
    Console.WriteLine($"{num1} квадрат числа {num2}");
}

else
{
    Console.WriteLine($"{num2} не квадрат числа {num1}");
}

