/* Задача 1*: Напишите программу, которая принимает на вход любое целое число и проверяет, 
является ли оно палиндромом. без массива */

System.Console.WriteLine("Введите число N > 0: ");
int number = int.Parse(Console.ReadLine());

int Rank(int n)
{
    int countR = 0;
    int b = n;
    while (b / 10 > 0)
    {
        b = b / 10;
        countR++;
    }
    return countR;
}

int RankNum(int c)
{
    int d = 10;
    while (c > 1)
    {
        d = d * 10;
        c = c - 1;
    }
    return d;
}
int r = Rank(number);
int i = RankNum(r);
int j = 10;
int res = 0;
int count = 1;

if (number < 10)
{
    if (number == 0)
    {
        res = 3;
    }
    else
    {
        res = 1;
    }
}
else
{
    int temp = number;
    while (count < (r  / 2))
    {
        if ((temp / i) == (temp % j))
        {
            res = 1;
            temp = temp % i;
            temp = temp / j;
            i = i / 100;
            count++;
        }
        else
        {
            res = 0;
            break;
        }

    }


}

if (res == 0) System.Console.WriteLine("Число не является палиндромом");
if (res == 1) System.Console.WriteLine("Число является палиндромом");
if (res == 3) System.Console.WriteLine("Ошибка! Введите число N > 0!!!");