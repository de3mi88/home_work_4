
//Задача 2
Console.WriteLine("Введите число a");
int a = Int32.Parse(Console.ReadLine());


Console.WriteLine("Введите число b");
int b = Int32.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Число " + a + " больше");
}
else
{
    Console.WriteLine("Число " + b + " больше");
}

//Задача 4

int max = 0;

Console.WriteLine("Введите число a");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число c");
int c = Int32.Parse(Console.ReadLine());

max = a;

if (b > a)
    max = b;
if (c > max)
{
    max = c;

}
Console.WriteLine("Число " + max + " больше");

//Задача 6

Console.WriteLine("Введите число ");
double a = Int32.Parse(Console.ReadLine());
if (a % 2! < 1)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}


//Задача 8

Console.WriteLine("Введите число ");
int a = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    if (i % 2! < 1)
    {
        Console.WriteLine(i + " Число четное");
    }
}