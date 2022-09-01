/*Задача №19
Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number.Length == 5)
{

    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");*/

/* Задача №21

System.Console.WriteLine("Введите координату x первой точки");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);

System.Console.WriteLine("Введите координату y первой точки");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);

System.Console.WriteLine("Введите координату x второй точки");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);

System.Console.WriteLine("Введите координату y второй точки");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);

System.Console.WriteLine("Введите координату z третьей точки");
bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);

System.Console.WriteLine("Введите координату z третьей точки");
bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);

if(!isNumberX_1 || !isNumberX_2 || !isNumberY_1 || !isNumberY_2 || !isNumberZ_1 || !isNumberZ_2 )
{
    Console.WriteLine("Числа введены неправильно ");
}
else{
System.Console.Write($"Расстояние {GetLenght(x1,y1,x2,y2,z1,z2)}");
}
double GetLenght(int x1,int y1,int x2,int y2,int z1,int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
}

/*

Задача №23

Console.WriteLine("Введите положительное N");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if (!isNumberN)
{
    Console.WriteLine("Не число");
    return;
}

PrintSqares (GetSqares(N));
int[] GetSqares(int n)
{
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i-1] = (int) Math.Pow (i,3);
        i++;
    }
    return results;
}

void PrintSqares(int[] sqares) 
{
    int i = 0;
    int len = sqares.Length;
    while (i < len)
    {
        Console.WriteLine(sqares[i]);
        i++;
    }
}
/*
