//14. Найти третью цифру числа или сообщить, что её нет
/*
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
*/
/*int a = new Random().Next(-555, 1000);
int b = a / 100;
Console.WriteLine($"Рандомное число {a}");
Console.WriteLine(b);
if (b == 0) Console.WriteLine($"Нет третьего ");
*/
/*
int numbers (int a) {
    if (a < 0) {a = a*-1;}
    if (a > 99) {return a = a % 1000 / 100;}
    else {return a = -1;}
}
int randomNumb = new Random().Next(-100, 100);
int valueArr = numbers(randomNumb);
Console.Write($"Третья цифра числа {randomNumb}:\n {valueArr}");
*/
//Почувствуй себя джуном

//15. Дано число. Проверить кратно ли оно 7 и 23 +
/*
int a = new Random().Next(-1000, 1000);
int ab = a % 7;
int ac = a%23;
Console.WriteLine($"Остаток от деления случайного числа {a} на 7 будет {ab}");
Console.WriteLine();
Console.WriteLine($"Остаток от деления случайного числа {a} на 23 будет {ac}");
Console.WriteLine();
if(ab==0) Console.WriteLine($"Случайное число {a} Кратно 7");
else Console.WriteLine($"Случайное число {a} Не кратно 7 :(");
Console.WriteLine();
if(ac==0) Console.WriteLine($"Случайное число {a} Кратно 23");
else Console.WriteLine($"Случайное число {a} Не кратно 23 :(");
*/



//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
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

//17. По двум заданным числам проверять является ли одно квадратом другого
/*
int a = 3;
int b = 45;
if (a * a == b)
    Console.WriteLine("yes");
else Console.WriteLine("no");
*/

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