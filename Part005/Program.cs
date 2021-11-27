// Почувствуй себя мидлом

// 23. Показать таблицу квадратов чисел от 1 до N 
// Первый способ
/*
void Squarenum(int n)
{
    n = 0;
    while (n < 10)
    {
        n++;
        int n1 = n * n;
        Console.WriteLine($"{n}  {n1}");
    }
}
Squarenum(10);

//Второй способ

int n = 0;
while (n < 10)
{
    int n1 = n * n;
    int n2 = n1 * n1;
    int n3 = n2 * n2;
    System.Console.WriteLine($" {n}==={n1}==={n2}==={n3}");
    n++;

}

//Третий способ

int Chislo = 1;
int N = 5;

while (Chislo <= N)
{
    int Squarenum = Chislo * Chislo;
    Console.Write(Chislo + " " + "квадрат ");
    Console.WriteLine(Squarenum);
    Chislo++;
}
*/
// 24. Найти кубы чисел от 1 до N
// Первый способ
/*
int Chislo = 1;
int N = 5;

while (Chislo <= N)
{
    int Cubenum = Chislo * Chislo * Chislo;
    Console.Write(Chislo + " " + "куб ");
    Console.WriteLine(Cubenum);
    Chislo++;
}
*/
// Второй способ 
/*
void CubeNumbers(int n)
{
    n = 0;
    while (n < 15)
    {
        n++;
        int ourNum = n * n * n;
        System.Console.WriteLine($"Число, куб которого мы выводим {n}, собственно куб этого числа {ourNum}");
    }
}
CubeNumbers(15);
*/
// 25. Найти сумму чисел от 1 до А
/*
int num = 1;
int A = 5;
int sum = 0;
while (num <= A)
{

    sum = sum + num;
    System.Console.Write($"{num} ");
    num++;
}
Console.WriteLine($" Сумма всех этих чисел {sum}");
*/
// 26. Возведите число А в натуральную степень B используя цикл
/*
int transformation(int a, int b)
{
    int res = 1;

    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

if (64 == transformation(2, 6))    Console.WriteLine("Работает");

else    Console.WriteLine("Не работает");
*/


// 27. Определить количество цифр в числе
//Пурвый способ
/*
int num = 55657657;
System.Console.Write($"Число {num}");
int Numsymbol = 0;
for (Numsymbol = 0; num != 0; Numsymbol++)
{
    num = num / 10;

}
Console.WriteLine($"состоит из {Numsymbol}  символов");
*/
//Второй способ
/*
int N = new Random().Next();
int symbol = 0;
while (symbol < N)
{
    N = N / 10;
    symbol++;
}
System.Console.WriteLine($"{N} состоит из {symbol} символов");
*/

