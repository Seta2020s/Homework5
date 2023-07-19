// Задайте одномерный массив,заполненный случайными числами.
// Найдите сумму элементов ,стоящих на нечётных позициях
// [3,7,23,12] -> 19
// [-4,-6,89,6] -> 0

int SumOddPositionElements(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int[] GenerateRandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(-100, 100);
    }

    return array;
}

int[] array = GenerateRandomArray(4);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
int sumOddPositions = SumOddPositionElements(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumOddPositions}");
