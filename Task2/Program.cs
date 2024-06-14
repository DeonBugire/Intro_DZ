// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void Main()
{
    int firstNumber = ReadInt("Задайте первое число: ");
    int secondNumber = ReadInt("Задайте второе число: ");
    Console.WriteLine(AckermannFunction(firstNumber, secondNumber));
}

int AckermannFunction(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if (number2 == 0)
    {
        return AckermannFunction(number1 - 1, 1);
    }
    else
    {
        return AckermannFunction(number1 - 1, AckermannFunction(number1, number2 - 1));
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();