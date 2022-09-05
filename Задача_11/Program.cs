// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random ().Next (100, 1000);
    Console.WriteLine(number);

    Console.Write($"{number / 100}{number % 10}");
