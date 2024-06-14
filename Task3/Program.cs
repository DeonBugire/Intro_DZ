// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    int size = ReadInt("Задайте размер массива: ");
    int[] array = CreateArray(size);
    PrintArrayFromEnd(array);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();

//Создаем массив
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new();
    FillArray(array, rand, 0);
    return array;
}
//Делаем функцию для рекурсивного заполнения
void FillArray(int[] array, Random rand, int index)
{
    if (index >= array.Length)
        return;

    array[index] = rand.Next(1, 11);
    FillArray(array, rand, index + 1);
}

//выводим массив задом наперед с рекурсией
void PrintArrayFromEnd(int[] array)
{
    if (array.Length == 0)
        return;
    int[] array2 = array[1..];
    PrintArrayFromEnd(array2);
    Console.Write($"{array[0]} ");
}