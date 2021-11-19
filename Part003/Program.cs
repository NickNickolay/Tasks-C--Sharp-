// 21. Программа проверяет пятизначное число на палиндромом.

bool Palindrom(int sym)
{
    string num = Convert.ToString(sym);
    int n1 = num[0];
    int n2 = num[1];
    int n4 = num[3];
    int n5 = num[4];
    if (n1 == n5 && n2 == n4) return true;
    else return false;
}

int N = new Random().Next(10000, 100000);
if (Palindrom(N)) System.Console.WriteLine($"Случайное число {N} - палиндром");
else Console.WriteLine($"Случайное число {N} - не палиндром");


// 22. Найти расстояние между точками в пространстве 2D/3D

double GetDistBetPoints(double x1, double y1, double x2, double y2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double L = Math.Sqrt(x * x + y * y);
    return L;
}
double X1 = new Random().Next(-10, 11);
double Y1 = new Random().Next(-10, 11);
double X2 = new Random().Next(-10, 11);
double Y2 = new Random().Next(-10, 11);
double L = GetDistBetPoints(X1, Y1, X2, Y2);
Console.WriteLine($"Точки A ({X1};{Y1}) и B ({X2};{Y2})");
Console.WriteLine(string.Format("имеют между собой расстояние которое равно {0:F2}", L));


double GetDistBetPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double z = z1 - z2;
    double L = Math.Sqrt(x * x + y * y + z * z);
    return L;
}
double X1 = new Random().Next(-10, 11);
double Y1 = new Random().Next(-10, 11);
double Z1 = new Random().Next(-10, 11);
double X2 = new Random().Next(-10, 11);
double Y2 = new Random().Next(-10, 11);
double Z2 = new Random().Next(-10, 11);
double L = GetDistBetPoints(X1, Y1, Z1, X2, Y2, Z2);
System.Console.Write($"Расстояние между точками A ({X1};{Y1};{Z1}) и B ({X2};{Y2};{Z2}) ");
System.Console.WriteLine(string.Format("Равно {0:F2}", L));

// Выведение алфавита 

char glif = 'a';
while (glif <= 'z')
{
    System.Console.Write($"{glif} ");
    glif++;
}
