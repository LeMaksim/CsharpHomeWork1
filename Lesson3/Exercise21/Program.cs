/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    Console.Write($"Distance between A({x1}, {y1}, {z1}) and B({x2}, {y2}, {z2}) is ");
    double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
    Console.WriteLine(dist);
    return dist;
    
}

double xa1 = 3, ya1 = 6, za1 = 8, xb1 = 2, yb1 = 1, zb1 = -7, xa2 = 7, ya2 = -5, za2 = 0, xb2 = 1, yb2 = -1, zb2 = 9;

Distance(xa1, ya1, za1, xb1, yb1, zb1);

Distance(xa2, ya2, za2, xb2, yb2, zb2);