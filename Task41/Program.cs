// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] arrayA = GetArray(8, -1000, 1000);
int count = 0;
foreach (int el in arrayA)
{
    if (el > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0 = {count}.");
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

