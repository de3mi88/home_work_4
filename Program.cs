
/*Задача 10

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();

Console.WriteLine(number[1]);*/

//Задача 13

/*Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (number.Length > 2)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}*/

//Задача 13



Console.WriteLine("Введите число обозначающее день недели");
Console.WriteLine("1 - Понедельник");
Console.WriteLine("2 - Вторник");
Console.WriteLine("3 - Среда");
Console.WriteLine("4 - Четверг");
Console.WriteLine("5 - Пятница");
Console.WriteLine("6 - Суббота");
Console.WriteLine("7 - Воскресение");
Console.WriteLine("8 - Выход");

int userInput = Convert.ToInt32(Console.ReadLine());

switch (userInput)
{
    case 1:
        Console.WriteLine("Это не выходной");
        break;
    case 2:
        Console.WriteLine("Это не выходной");
        break;
    case 3:
        Console.WriteLine("Это не выходной");
        break;
    case 4:
        Console.WriteLine("Это не выходной");
        break;
    case 5:
        Console.WriteLine("Это не выходной");
        break;
    case 6:
        Console.WriteLine("Это выходной");
        break;
    case 7:
        Console.WriteLine("Это выходной");
        break;
    case 8:
        break;
}
Console.WriteLine("Нажмите ENTER для выхода");
Console.ReadKey();
Console.Clear();
