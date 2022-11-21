// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number>100 & number<1000)
{
       Console.WriteLine($"{number%10}");
}
else if (number>=1000)
{
    while (number>=1000)
    {
        number = number/10;
    }
    Console.WriteLine($"{number%10}");    
}
else
{
    Console.WriteLine("третьей цифры нет");
}