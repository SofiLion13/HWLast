// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа numberM и numberN.
// numberM = 2, numberN = 3 -> A(numberM,numberN) = 9
// numberM = 3, numberN = 2 -> A(numberM,numberN) = 29

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

int Akkerman(int numberM, int numberN)
{
  if (numberM == 0) return numberN + 1;
  if (numberM > 0 && numberN == 0) return Akkerman(numberM - 1, 1);
  else return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
}

int numberM = GetNumber("Введите число: ");
int numberN = GetNumber("Введите число: ");
Console.WriteLine($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");

