/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }

    return result;
}

Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(number_1, number_2);
Console.WriteLine("Ответ: " + exponentiation);