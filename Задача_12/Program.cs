// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine(numberA);

Console.Write("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine(numberB);

if (numberA % numberB == 0)
    Console.WriteLine("Числа кратны");

else
{
    int a = (numberA % numberB);
    Console.WriteLine($"Числа не кратны, остаток {a}");
}