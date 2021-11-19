// Почувствуй себя мидлом

// 23. Показать таблицу квадратов чисел от 1 до N 

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

int n = 0;
while (n < 10)
{
    int n1 = n * n;
    int n2 = n1 * n1;
    int n3 = n2 * n2;
    System.Console.WriteLine($" {n}==={n1}==={n2}==={n3}");
    n++;

}

int Chislo = 1;
int N = 5;

while (Chislo <= N)
{
    int Squarenum = Chislo * Chislo;
    Console.Write(Chislo + " " + "квадрат ");
    Console.WriteLine(Squarenum);
    Chislo++;
}

// 24. Найти кубы чисел от 1 до N

int Chislo = 1;
int N = 5;

while (Chislo <= N)
{
    int Squarenum = Chislo * Chislo * Chislo;
    Console.Write(Chislo + " " + "куб ");
    Console.WriteLine(Squarenum);
    Chislo++;
}

// 25. Найти сумму чисел от 1 до А

int num = 1;
int A = 5;
int sum = 0;
while (num <= A)
{

    sum = sum + num;
    System.Console.Write(num + " ");
    num++;
}
Console.WriteLine($" сумма чисел {sum}");

// 26. Возведите число А в натуральную степень B используя цикл

int transformation(int a, int b)
{
    int res = 1;

    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

if (256 == transformation(2, 8))
{
    Console.WriteLine("Работает");
}
else
{
    Console.WriteLine("Не работает");
}


// 27. Определить количество цифр в числе

int num = 543476;
int Numsymbol = 1;
for (Numsymbol = 1; Numsymbol < num; Numsymbol++)
{
    num = num / 10;

}
Console.WriteLine($"Число состоит из {Numsymbol}  символов");



