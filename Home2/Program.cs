// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length = Math.Sqrt((a*a) + (b*b) + (c*c));
Console.WriteLine($"Расстояние между точками: {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
