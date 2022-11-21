// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = number/10%10;
if (number>99 & number<1000)
{
        Console.WriteLine($"Вторая цифра числа {digit2}");
}
else if (number<-99 & number>-1000)
{
        Console.WriteLine($"Вторая цифра числа {-digit2}");
}
else
            {
                Console.Write("Это не трехзначное число!");
            }
