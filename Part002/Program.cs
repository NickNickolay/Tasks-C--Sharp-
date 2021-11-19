//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// Ппервый способ

int GetMaxSec(int section)
{
    int a = section % 10;
    int b = section / 10;
    if (a < b) return b;
    else return a;
}

Console.Write("Введите число 10 до 99: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = GetMaxSec(b);
Console.WriteLine($"Наибольшее число {res}");

//Способ 2

char GetMaxNumber(int num)
{
    string ab = Convert.ToString(num);
    char a = ab[0];
    char b = ab[1];
    if (a > b) return a;
    else return b;
}
int num = new Random().Next(10, 100);
char result = GetMaxNumber(num);
Console.WriteLine($"В числе {num} наибольшая цифра - {result}");

//12. Удалить вторую цифру трёхзначного числа

//Первый способ

int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int b = a / 100;
int c = a % 10;
Console.WriteLine($"{b}{c}");


//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int NF(int a, int b)

{
    int z = a % b;
    int res = 0;
    if (z == 0) return res;
    else return z;
}
Console.WriteLine("Задайте число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое проверяете на кратность заданному: ");
int i = Convert.ToInt32(Console.ReadLine());
int j = NF(i, a);
if (j == 0)
    Console.WriteLine($"Число {a} кратно{i}");
else Console.WriteLine($"{i} Не кратно {a} остаток {j}");


int numberFirst = new Random().Next(100, 1000);
int numberSecond = new Random().Next(1, 100);

System.Console.WriteLine($"Делимое {numberFirst}");
System.Console.WriteLine($"Делитель {numberSecond}");

int withdrawRemainder(int numberFirst, int numberSecond)
{
    if (numberFirst % numberSecond == 0) System.Console.WriteLine("Кратно");

    else
    {
        int a = numberFirst % numberSecond;
        return a;
    }
}
int result = withdrawRemainder(numberFirst, numberSecond);
System.Console.WriteLine($" Остаток {result}");

//14. Найти третью цифру числа или сообщить, что её нет

int n = new Random().Next(-1090, 1000);
Console.WriteLine(n);
if (Math.Abs(n) < 100) Console.WriteLine("Нет третьей цифры");
else
{
    string num = Convert.ToString(n);
    int i = 2;
    if (n < 0) i = 3;
    char z = num[i];
    Console.WriteLine(z);
}


int a = new Random().Next(-555, 1000);
int b = a / 100;
Console.WriteLine($"Рандомное число {a}");
Console.WriteLine(b);
if (b == 0) Console.WriteLine($"Нет третьего ");


//Почувствуй себя джуном

//15. Дано число. Проверить кратно ли оно 7 и 23 


int a = new Random().Next(-1000, 1000);
int ab = a % 7;
int ac = a % 23;
Console.WriteLine($"Остаток от деления случайного числа {a} на 7 будет {ab}");
Console.WriteLine();
Console.WriteLine($"Остаток от деления случайного числа {a} на 23 будет {ac}");
Console.WriteLine();
if (ab == 0) Console.WriteLine($"Случайное число {a} Кратно 7");
else Console.WriteLine($"Случайное число {a} Не кратно 7 :(");
Console.WriteLine();
if (ac == 0) Console.WriteLine($"Случайное число {a} Кратно 23");
else Console.WriteLine($"Случайное число {a} Не кратно 23 :(");

//Решение методом! (получилось, но необходимо решать еще!)

void CardinalityCheck(int zch, int first, int second)
{
    if (zch % first == 0 && zch % second == 0) Console.WriteLine("Кратно обоим числам! :)");
    else if (zch % first == 0) Console.WriteLine($"Кратно лишь {first} ;)");
    else if (zch % second == 0) Console.WriteLine($"Кратно лишь {second} ;)");
    else Console.WriteLine("Не кратно обоим :(");
}
int Zad = new Random().Next(-1000000, 1000000);
int a = 7;
int b = 23;
Console.WriteLine($"Случайное число {Zad}");
CardinalityCheck(Zad, a, b);


//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 


bool WekDay(int Check)
{
    if (Check == 6 || Check == 7) return true;
    else return false;
}
int Day = new Random().Next(1, 8);
Console.WriteLine($"Случайное число {Day}");
if (WekDay(Day)) System.Console.WriteLine($"Выходной {Day} :)");
else System.Console.WriteLine($"Будний {Day} :(");


//17. По двум заданным числам проверять является ли одно квадратом другого
int a = 3;
int b = 45;
if (a * a == b)
    Console.WriteLine("yes");
else Console.WriteLine("no");


void sqareCheck(int a, int b)
{
    if (a * a == b) Console.WriteLine($"Число {a} является квадратом {b}");
    else Console.WriteLine($"Число {a} не является квадратом {b}");
    if (b * b == a) Console.WriteLine($"Число {b} является квадратом {a}");
    else Console.WriteLine($"Число {b} не является квадратом {a}");
}
int c = new Random().Next(1, 1000);
Console.WriteLine($"Первое случайное число {c}");
int d = new Random().Next(1, 10000);
Console.WriteLine($"Второе случайное число {d}");
sqareCheck(c, d);


//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = false;
bool y = true;
if (!(x || y) == !x && !y)
    Console.WriteLine("Верно!");
else
{
    Console.WriteLine("Не верно!");
}


bool TrueOrNot(bool x, bool y)
{
    if (!(x || y) == !x && !y) return true;
    else return false;
}
bool a = true;
bool b = false;
if (TrueOrNot(a, b)) System.Console.WriteLine("Истина!");
else System.Console.WriteLine("Ложь");


//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


void PlaneSearch(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
    if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
    if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
    if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
}
int a = new Random().Next(-10, 10);
int b = new Random().Next(-10, 10);
Console.WriteLine($"Случайная точка с координатой X {a}, Случайная точка с координатой Y {b}");
PlaneSearch(a, b);

//20. Задать номер четверти, показать диапазоны для возможных координат


void PointSearch(int area)
{
    if (area == 1) Console.WriteLine("X (0;-N); Y (0;N)");
    if (area == 2) Console.WriteLine("X (-N;0); Y (0;N)");
    if (area == 3) Console.WriteLine("X (-N;0); Y (0;-N)");
    if (area == 4) Console.WriteLine("X (0;N); Y (0;-N)");
}
int a = new Random().Next(1, 4);
Console.WriteLine(a);
PointSearch(a);
