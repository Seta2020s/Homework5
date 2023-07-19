// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу,которая покажет количество четных чисел в массиве.
// [345,897,568,234] -> 2

int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int[] array = new int[4];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
int evenCount = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел: {evenCount}");