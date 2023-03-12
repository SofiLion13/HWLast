// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }
    return result;
}

int SumOfNumbers(int numberM, int numberN)
{
    if (numberM == numberN)
    return numberM;
    return SumOfNumbers(numberM + 1, numberN) + numberM;
}

int numberM = GetNumber("Введите число: ");
int numberN = GetNumber("Введите число: ");
Console.WriteLine(SumOfNumbers(numberM, numberN));