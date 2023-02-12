// Задача 2(21).  Напишите программу, которая принимает на вход 
// координаты двух точек,и находит расстояние между ними в 3D-пространстве
// А(3,6,8); B(2,1,-7), -> 15.84
// А(7,-5,0); B(1,-1,9), -> 11.53


System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;

    double distAB = Math.Round(Math.Sqrt(deltaX *deltaX + deltaY * deltaY + deltaZ * deltaZ),2);                                                                                                                                                                            
    return distAB;

}

Console.Write("Input X coordinate of A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Z coordinate of A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Z coordinate of B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);


Console.WriteLine($"Distance between A&B is {distanceAB:f2}");