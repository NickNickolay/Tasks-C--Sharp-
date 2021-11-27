// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру


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

//48. Показать двумерный массив размером m×n заполненный целыми числами
/*
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] array1 = GetArray(5, 7);
PrintArray(array1);
*/
// int[,] ReplaceOddElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] % 2 == 0)
//                 array[i, j] = -array[i, j];
//         }

//     }
//     return array;
// }


// 49. Показать двумерный массив размером m×n заполненный вещественными числами
/*
double[,] RealNumbers(int a, int b)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    return array;

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
double[,] array1 = RealNumbers(2, 2);
PrintArray(array1);
*/


// 50. В двумерном массиве n×k заменить четные элементы на противоположные
/*
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] array1 = GetArray(5, 7);
PrintArray(array1);

int[,] Replacement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i, j] * -1;
            }
            
        }
    }
    return array;
}


Console.WriteLine();
int[,] Array2 = Replacement(array1);
PrintArray(Array2);

*/


//52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// int[,] GetArray(int a, int b)
// {
//     int[,] array = new int[a, b];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//     }
//     return array;
// }
// int[,] GetSqrOfOddElem(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i % 2 == 0)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (j % 2 == 0)
//                 {
//                     array[i, j] = array[i, j] * array[i, j];
//                 }
//             }
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// int[,] array = GetArray(4, 6);
// PrintArray(array);
// Console.WriteLine();
// PrintArray(GetSqrOfOddElem(array));


// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

//52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// int[,] TurnTuQuarter(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] % 2 == 0)
//             {
//                 array [i, j] = array [i, j]*array [i, j];
//             }
//         }

//     }
//     return array;

// }

// int[,] array = {{1, 2, 3},{4, 5, 6}};
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// PrintArray(array);
// array = TurnTuQuarter(array);
// PrintArray(array);



// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет