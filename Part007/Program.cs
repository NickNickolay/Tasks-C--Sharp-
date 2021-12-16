// 30. Показать кубы чисел, заканчивающихся на четную цифру


/*int CubeNumbers(int FirstNubers)
{
    int SecondNumbers = 0;
    if (FirstNubers % 2 == 0)
    {
        SecondNumbers = FirstNubers * FirstNubers * FirstNubers;
    }
    return SecondNumbers;
    // System.Console.WriteLine(FirstNubers);
    // System.Console.WriteLine(SecondNumbers);
}
int a = new Random().Next(1,10);
System.Console.WriteLine(a);
System.Console.WriteLine(CubeNumbers(a));
*/

//31. Задать массив из 8 элементов и вывести их на экран
/*
int[] GetArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,9);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
        
    }
    System.Console.WriteLine();
}

int[] testArray = GetArray(8);
PrintArray(testArray);
*/
//32.Задать массив из 8 элементов, заполненный 0 и 1 и вывести их на экран
/*
int[] GetArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
int[] ar = GetArray(8);
PrintArray(ar);
*/