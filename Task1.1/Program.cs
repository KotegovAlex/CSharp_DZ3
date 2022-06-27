/* Задача 1*: Напишите программу, которая принимает на вход любое целое число и проверяет, 
является ли оно палиндромом. */

System.Console.WriteLine("Введите число N > 0: ");
int[] numbers = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();

int i = 0;
int j = numbers.Length - 1;
int res = 0;


if (numbers.Length < 2)
{
    if (numbers[0] == 0)
    {
        res = 0;
        System.Console.WriteLine("Ошибка! Введите число N > 0!!!");
    }
    else
    {
        res = 1;
    }
}
else
{
    while (i < j)
    {
        if (numbers[i] == numbers[j])
        {
            res = 1;
            i++;
            j = j - 1;
        }
        else
        {
            res = 0;
            break;
        }

    }
}


if (res == 0)
{
    System.Console.WriteLine("Число не является палиндромом");
}
else
{
    System.Console.WriteLine("Число является палиндромом");
}