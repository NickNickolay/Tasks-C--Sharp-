//0. Вывести квадрат числа 

//Метод 1
/*
int SquareNumber(int i)
{
    return i * i;
}
int b = SquareNumber(3);
Console.WriteLine(b);
//Метод 2 - не актуальный!
int a = 2;
int b = a * a;
Console.WriteLine(b);
*/
//1. По двум заданным числам проверять является ли первое квадратом второго

//2. Даны два числа. Показать большее и меньшее число 
/*
void Comparison(int a, int b)
{
    if (a < b)
    {
        Console.WriteLine($"{b} max {a} min");
    }
    else
    {
        Console.WriteLine($"{a} max {b} min");
    }
}
Comparison(23,44);
*/
//Примитивный метод
/*int a = 23;
int b = 3;
int max = a;
int min = b;
if (a < b)
{
    max = b;
    min = a;
}
else
{
    max = a;
    min = b;
}

Console.WriteLine($"max{max} min {min}");
*/
//3. По заданному номеру дня недели вывести его название
/*
Console.WriteLine("Введите номер деня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Console.WriteLine("Monday");
    }
    if (a == 2)
    {
        Console.WriteLine("Tuesday");
    }
    if (a == 3)
    {
        Console.WriteLine("Wednesday");
    }
    if (a == 4)
    {
        Console.WriteLine("Thursday");
    }
    if (a == 5)
    {
        Console.WriteLine("Friday");
    }
    if (a == 6)
    {
        Console.WriteLine("Saturday");
    }
    if (a == 7)
    {
        Console.WriteLine("Sunday");
    }
    */
//4. Найти максимальное из трех чисел
/*
//int a = 3;
//int b = 4;
//int c = 7;
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
Console.Write("Введите число 1: ");
int MaximumOfThree(int a, int b, int c)
{
    int result = a;
    if (a < b && c < b) result = b;
    if (b < c && c > a) result = c;
    if (c < a && a > b) result = a;
    return result;
}
int result = MaximumOfThree(a, b, c);
Console.WriteLine($"Максимальное число {result}");
*/
//5. Написать программу вычисления значения функции y=f(a) 

//6. Выяснить является ли число чётным
/* 
bool ParityCheck(int i)
{
    if (i % 2 == 0) return true;
    else return false;
}
Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
if(ParityCheck(i) == true)
Console.WriteLine("Четное!");
else
Console.WriteLine("Нечетное!");
*/
/*int a = 22;
if(a%2==0)
{
    Console.WriteLine($"Четное: {a}");
}
if(a%2!=0)
{
    Console.WriteLine($"Нечетное: {a}");
}
*/
//7. Показать числа от -N до N
/*
int VseChila(int n)
{
    for (int i = -n; i <= n; i++)
        Console.WriteLine(i);
    return n;
}
VseChila(3);
*/
/*int n = 5;
for(int i = -n; i<=n; i++)
Console.WriteLine(i);
*/
//8. Показать четные числа от 1 до N 

//9. Показать последнюю цифру трёхзначного числа

//10. Показать вторую цифру трёхзначного числа

//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

/* Ппервый способ
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
*/
//Способ 2
/*char GetMaxNumber(int num)
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
*/
//12. Удалить вторую цифру трёхзначного числа
//Первый способ
/*int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int b = a / 100;
int c = a % 10;
Console.WriteLine($"{b}{c}");
*/

//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
/*
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
*/
/*int numberFirst=new Random().Next(100,1000);
int numberSecond=new Random().Next(1,100);

System.Console.WriteLine($"Делимое {numberFirst}");
System.Console.WriteLine($"Делитель {numberSecond}");

int withdrawRemainder( int numberFirst, int numberSecond)
{
if (numberFirst%numberSecond==0) System.Console.WriteLine("Кратно");

else 
{
    int a= numberFirst%numberSecond;
    return a;
}
}
int result=withdrawRemainder ( numberFirst, numberSecond);
System.Console.WriteLine($" Остаток {result}");*/

//14. Найти третью цифру числа или сообщить, что её нет
int n = new Random().Next(-1090,1000);
Console.WriteLine(n);
if(Math.Abs(n)<100) Console.WriteLine("Нет третьей цифры");
else
{
    string num = Convert.ToString(n);
    int i = 2;
    if(n<0) i =3;
    char z = num[i];
    Console.WriteLine(z);
}
/*int a = new Random().Next(-555, 1000);
int b = a / 100;
Console.WriteLine($"Рандомное число {a}");
Console.WriteLine(b);
if (b == 0) Console.WriteLine($"Нет третьего ");
*/

//Почувствуй себя джуном

//15. Дано число. Проверить кратно ли оно 7 и 23 +

//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным (Сделанно)

//17. По двум заданным числам проверять является ли одно квадратом другого

//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
/*
bool x = false;
bool y = true;
if(!(x || y) == !x && !y)
Console.WriteLine("Верно!");
else
{
    Console.WriteLine("Не верно!");
}
*/
//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

//20. Задать номер четверти, показать диапазоны для возможных координат

//21. Программа проверяет пятизначное число на палиндромом.

//22. Найти расстояние между точками в пространстве 2D/3D