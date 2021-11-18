// 21. Программа проверяет пятизначное число на палиндромом.
/*
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

int N = new Random().Next(10000,100000);
if (Palindrom(N)) System.Console.WriteLine($"Случайное число {N} - палиндром");
else Console.WriteLine($"Случайное число {N} - не палиндром");
*/

// 22. Найти расстояние между точками в пространстве 2D/3D
/*
double GetDistBetPoints(double x1, double y1, double x2, double y2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double L = Math.Sqrt(x * x + y * y);
    return L;
}
double X1 = new Random().Next(-10,11);
double Y1 = new Random().Next(-10,11);
double X2 = new Random().Next(-10,11);
double Y2 = new Random().Next(-10,11);
double L = GetDistBetPoints(X1, Y1, X2, Y2);
Console.WriteLine($"Точки A ({X1};{Y1}) и B ({X2};{Y2})");
Console.WriteLine(string.Format("имеют между собой расстояние которое равно {0:F2}", L));
*/
/*
double GetDistBetPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double z = z1 - z2;
    double L = Math.Sqrt(x * x + y * y + z * z);
    return L;
}
double X1 = new Random().Next(-10,11);
double Y1 = new Random().Next(-10,11);
double Z1 = new Random().Next(-10,11);
double X2 = new Random().Next(-10,11);
double Y2 = new Random().Next(-10,11);
double Z2 = new Random().Next(-10,11);
double L = GetDistBetPoints(X1, Y1, Z1, X2, Y2, Z2);
System.Console.Write($"Расстояние между точками A ({X1};{Y1};{Z1}) и B ({X2};{Y2};{Z2}) ");
System.Console.WriteLine(string.Format("Равно {0:F2}", L));
*/
// Почувствуй себя мидлом

// 23. Показать таблицу квадратов чисел от 1 до N 

// 24. Найти кубы чисел от 1 до N

// 25. Найти сумму чисел от 1 до А

// 26. Возведите число А в натуральную степень B используя цикл

// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
/*
int[] Array = new  int [8];
for(int i=0; i<=Array.Length; i++)
{
    int result = new Random().Next(10, 100);
    Console.WriteLine(result);
}
*/
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
/*int [] Array = new int [8];
for(int i = 0; i<Array.Length; i++)
{
    int result = new Random().Next(0,2);
    Console.WriteLine(result);
}
*/

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
/*
int[] array = new int[12];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    int result = new Random().Next(0, 10);
    Console.Write(result + " ");



    if (result > 0)
    {
        j = result + j;
        // result++;
    }

    Console.WriteLine(j);
}
*/

// 34. Написать программу замену элементов массива на противоположные
/*int[] Array = new int [1];
//new Random().Next(0,100);
for(int i =0; i<=Array.Length;i++)
{
    int result = new Random().Next(0,100); 
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine(result - (2*result));
}
*/
 
// 35. Определить, присутствует ли в заданном массиве, некоторое число



// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива

