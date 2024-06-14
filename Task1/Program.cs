// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Первое решение, когда первое число всегда меньше, а второе больше
void Main()
{
    int firstNumber = ReadInt("Введите первое число: ");
    int secondNumber = ReadInt("Введите второе число: ");
    // первый вариант - простой, как в презентации. Первое число всегда меньше
    //PrintNumbers(firstNumber, secondNumber);

    // учитываем, что второе число может быть меньше
    PrintNumbers(Math.Min(firstNumber, secondNumber), Math.Max(firstNumber, secondNumber));
}

void PrintNumbers(int number, int number1)
{
    if (number1 < number) return;
    PrintNumbers(number, number1 - 1);
    Console.Write(number1 + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();