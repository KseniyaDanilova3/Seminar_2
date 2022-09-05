// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 → нет , 46 → нет , 161 → да

Console.Write("Введите число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine(numberA);

int a = 0; a = numberA;

if (a % 7 == 0) {
    if (a % 23 == 0) Console.WriteLine($"Число {a} кратно числу 7 и 23.");
    else Console.WriteLine($"Число {a} кратно 7, но не 23.");
}
else {
    if (a % 23 == 0) Console.WriteLine($"Число {a} кратно числу 23, но не 7.");
    else Console.WriteLine($"Число {a} не кратно ни 7, ни 23.");
}