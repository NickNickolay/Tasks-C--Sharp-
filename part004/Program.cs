// Почувствуй себя сеньором

// 31. Задать массив из 8 элементов и вывести их на экран 

int[] Array = new int[8];
for (int i = 0; i <= Array.Length; i++)
{
    int result = new Random().Next(10, 100);
    Console.WriteLine(result);
}

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] Array = new int[8];
for (int i = 0; i < Array.Length; i++)
{
    int result = new Random().Next(0, 2);
    Console.WriteLine(result);
}


// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

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


// 34. Написать программу замену элементов массива на противоположные

int[] Array = new int[1];
//new Random().Next(0,100);
for (int i = 0; i <= Array.Length; i++)
{
    int result = new Random().Next(0, 100);
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine(result - (2 * result));
}


