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
/*
int a1 = 36;
int a2 = 6;
if (a2 * a2 == a1) Console.WriteLine("yes");
else Console.WriteLine("no");
*/
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

Console.WriteLine($"Максимальное число {max} Минимальное число {min}");
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

//5. Написать программу вычисления значения функции y=f(a)/ y=ka+m
/*
int f(int a, int k, int m)
{
    return k * a + m;
}
Console.WriteLine(f(5, 2, 8));

if (18==f(5,2,8)) Console.WriteLine("Работает верно");
else Console.WriteLine("Неверно");
*/
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
/*
int A = new Random().Next(1, 30);
for (int N = 1; N <= A; N++)
{
    if (N % 2 == 0) Console.Write($"{N} ");
}
*/
//9. Показать последнюю цифру трёхзначного числа
/*
int randnum = new Random().Next(100, 1000);
Console.WriteLine(randnum);
int thirdnum = randnum % 10;
Console.WriteLine(thirdnum);
*/

//10. Показать вторую цифру трёхзначного числа
/*
int randnum = new Random().Next(100, 1000);
Console.WriteLine(randnum);
int secnum = randnum / 10 % 10;
Console.WriteLine(secnum);
*/