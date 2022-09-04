/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.*/

int Sum_Number(int number)
{
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Sum_Number(number));