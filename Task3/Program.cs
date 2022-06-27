/* Задача 3: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
int CubeNumber(int a)
{
    int res = 1;
    int i = 1;
    while (i <= a)
    {
        res = i * i * i;
        i++;
    }
    return res;
}

System.Console.WriteLine("Введите число положительное число N: ");
int N = int.Parse(Console.ReadLine());
int result = 1;


if (N > 0)
{
    System.Console.WriteLine($"Перечень кубов чисел от 1 до {N} =>");
    for (int count = 1; count <= N; count++)
    {
        result = CubeNumber(count);
        System.Console.Write(result + " ");
    }
}
else
{
    System.Console.WriteLine("Ошибка! Необходимо ввести N > 0!");
}