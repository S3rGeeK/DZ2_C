// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// 1. Ввод числа
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

// 2. Функция нахождения второй цифры в числе
int Digit2(int number)
{
    int result = ((number / 10) % 10);
    return result;
}
        
// 3. вывод решения
Console.WriteLine(Digit2(number));