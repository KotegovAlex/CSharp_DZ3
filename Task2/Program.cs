/* Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double inputCoord(string message)
{
    System.Console.WriteLine(message);
    double a = double.Parse(Console.ReadLine());
    return a;
}

double x1 = inputCoord("Введите координату X1: ");

double y1 = inputCoord("Введите координату Y1: ");

double z1 = inputCoord("Введите координату Z1: ");

double x2 = inputCoord("Введите координату X2: ");

double y2 = inputCoord("Введите координату Y2: ");

double z2 = inputCoord("Введите координату Z2: ");

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (x2 - x1) * (x2 - x1) + (y2 - y1) * (z2 - z1));

System.Console.WriteLine($"Расстояние между двумя точками равно: {distance}");